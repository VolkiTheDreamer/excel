Imports System.Windows.Forms
Module bolmekodlar
    'TODO:çok sayfalıda PDF seçildiğinde exportwb olcak
    'TODO:açık sayfa yoksa veya boş bir wb varsa hiçbieşy yapmasın, veya msgbox
    'TODO:özel işaret neye çevirilsin kısmı da ayrı sub olsun
    'TODO:özel işaret neye çevilrisine ? girmesinler, üerine gelince de özel işaretleri çıkarsın
    'TODO KLASÖR YOKSA YARATSIN
    Sub Standart_Bol()
        'BİLGİ:Dim abc As Workbook '.....tools...'ta bir interface
        'BİLGİ:Dim abc2 As Excel.Workbook '...interop...'ta bir interface, biz bunu kullanıyoruz, neden?
        'BİLGİ:Neden New kullamıyoruz--->Çünkü innterfacelerde New kullanılmaz
        Dim enUsttekiHucre, enAlttekiHucre, blokunIlkHucresi, blokunSonHucresi, ilkSatirinSecimi, sonSatirinSecimi As Excel.Range
        Dim anaDosya, yeniDosya As Excel.Workbook
        Dim yeniBlokMu As Boolean
        Dim kacKolonVar, enUstSatir, enAltSatir As Integer
        Dim dosyaGenelAdi, boluneninAdi As String
        Dim sortlayimmi As MsgBoxResult


        'İlk olarak ayarlar formu çıkar
        Dim fb As New frmBolme
        fb.lblKacKolonaGore.Visible = False
        fb.cbKacKolonaGore.Visible = False
        fb.grpKaynak.Visible = False
        fb.ShowDialog()


        If fb.devammi = False Then Exit Sub 'formda iptale basıldıysa

        Try
            Dim Foldername As String = fb.klasor
            Dim baslangicSatirNo As Byte = CByte(1 + fb.satirAdet)

            app_aksiyon(app, "Giriş")

            'ÖNCE GENEL HAZIRLIK
            'sıralı değildir diye sıralayalım, burda hata çıkabilr, çıkarsa catch'de siraamadangece yönledirem seçneği var
            app.Range("A1").CurrentRegion.Sort(Key1:=app.Range("A1"), Order1:=Excel.XlSortOrder.xlAscending, _
            Header:=Excel.XlYesNoGuess.xlGuess, OrderCustom:=1, MatchCase _
            :=False, Orientation:=Excel.XlSortOrientation.xlSortColumns, DataOption1:=Excel.XlSortDataOption.xlSortNormal)

siralamadangec:
            'özel karekterleri dönüştürme
            Dim ozelKarakterler() As String = {"/", "\", ":", "<", ">", """", "~?", "~*"}
            For Each a As String In ozelKarakterler
                CType(app.Columns("A:A"), Excel.Range).Select()
                CType(app.Selection, Excel.Range).Replace(What:=a, Replacement:=fb.ozelKarakterSubsitute, LookAt:=Excel.XlLookAt.xlPart, _
                    SearchOrder:=Excel.XlSearchOrder.xlByRows, MatchCase:=False, SearchFormat:=False, _
                    ReplaceFormat:=False)
            Next

            'başlık sonrasında boş hücreleri dönüşütüryurz
            CType(app.Rows(baslangicSatirNo), Excel.Range).Select()
            CType(app.Selection, Excel.Range).Replace(What:="", Replacement:=fb.boslukSubstitue, LookAt:=Excel.XlLookAt.xlPart, _
                    SearchOrder:=Excel.XlSearchOrder.xlByRows, MatchCase:=False, SearchFormat:=False, _
                    ReplaceFormat:=False)

            If Not My.Computer.FileSystem.DirectoryExists(Foldername) Then My.Computer.FileSystem.CreateDirectory(Foldername) 'burda Mkdir("C:\böl") de diyebilridik, hatta ilk başta öyle demiştim ama Mkdir üzerine gelice çıkan açıklamada My feature daha iyidir dedi

            anaDosya = app.ActiveWorkbook
            dosyaGenelAdi = Left(anaDosya.Name, Len(anaDosya.Name) - Len(DosyaExtension(app, anaDosya)))

            enUsttekiHucre = CType(app.Cells(baslangicSatirNo, 1), Excel.Range)
            enAlttekiHucre = enUsttekiHucre.End(Excel.XlDirection.xlDown)

            enUstSatir = enUsttekiHucre.Row
            enAltSatir = enAlttekiHucre.Row

            'ilk hücreye konuyoruz ve başlıyoruz
            CType(app.Cells(baslangicSatirNo, 1), Excel.Range).Select()
            ilkSatirinSecimi = Nothing 'warning veriyor diye bunu ekledim, çok krtik değil sonucta error değil ama 0 sorun olsun die ekledim
            yeniBlokMu = True
            kacKolonVar = enUsttekiHucre.End(Excel.XlDirection.xlToRight).Column

            For i As Integer = enUstSatir To enAltSatir
                If yeniBlokMu = False Then GoTo ATLA

                blokunIlkHucresi = app.ActiveCell
                ilkSatirinSecimi = app.Range(blokunIlkHucresi, blokunIlkHucresi.Offset(0, kacKolonVar - 1))
ATLA:
                'BİLGİ:VBA'da value2 variant döndürü, doğal olarak VB.nette object. çünkü variant artık yok, onun yerine
                'BİLGİ:object var. objecti de ya Cstr ile değiştirip = ile karşılaştırısın
                'BİLGİ:ya da olduğ gibi bırakıp Is operatör ile karşılaştırırın.
                If CStr(CType(app.Cells(i, 1), Excel.Range).Value2) = CStr(CType(app.Cells(i + 1, 1), Excel.Range).Value2) Then
                    app.ActiveCell.Offset(1, 0).Select()
                    yeniBlokMu = False
                Else
                    blokunSonHucresi = app.ActiveCell
                    sonSatirinSecimi = app.Range(blokunSonHucresi, blokunSonHucresi.Offset(0, kacKolonVar - 1))
                    boluneninAdi = Trim(CStr(app.ActiveCell.Text))
                    app.Range(app.Cells(1, 1), app.Cells(baslangicSatirNo - 1, 1)).EntireRow.Copy()
                    yeniDosya = app.Workbooks.Add()
                    CType(app.ActiveSheet, Excel.Worksheet).Paste()
                    anaDosya.Activate()
                    app.Range(ilkSatirinSecimi, sonSatirinSecimi).Select()
                    CType(app.Selection, Excel.Range).Copy()
                    yeniDosya.Activate()
                    CType(app.Cells(baslangicSatirNo, 1), Excel.Range).Select()
                    CType(app.ActiveSheet, Excel.Worksheet).Paste()
                    CType(app.Cells, Excel.Range).Select()
                    CType(app.Cells, Excel.Range).EntireColumn.AutoFit()

                    'print layout ayarı
                    With CType(app.ActiveSheet, Excel.Worksheet).PageSetup
                        If Not fb.layoutSecenek = Nothing Then
                            If fb.layoutSecenek = True Then
                                .Orientation = Excel.XlPageOrientation.xlPortrait
                                .Zoom = False
                                .FitToPagesWide = 1
                                .FitToPagesTall = 1
                            Else
                                .Orientation = Excel.XlPageOrientation.xlLandscape
                                .Zoom = False
                                .FitToPagesWide = 1
                                .FitToPagesTall = 1
                            End If
                        End If
                    End With

                    'save formatı
                    If fb.dosyaBolmeFormati = True Then
                        yeniDosya.SaveAs(Filename:=Foldername & "\" & boluneninAdi & fb.dosyaAyirmaIsareti & dosyaGenelAdi & DosyaExtension(app, anaDosya), FileFormat:=anaDosya.FileFormat)

                    Else
                        yeniDosya.ExportAsFixedFormat(Type:=Excel.XlFixedFormatType.xlTypePDF, _
                                Filename:=Foldername & "\" & boluneninAdi & fb.dosyaAyirmaIsareti & dosyaGenelAdi & "pdf" _
                                , IncludeDocProperties:=True, IgnorePrintAreas _
                                :=False, OpenAfterPublish:=False)
                    End If

                    yeniDosya.Close()
                    blokunSonHucresi.Offset(1, 0).Select()
                    yeniBlokMu = True
                End If
            Next i

            'klasörde göster
            Shell("explorer.exe " & Foldername, vbNormalFocus)

        Catch e As Exception
            If e.Message = "To do this, all the merged cells need to be the same size." Then
                sortlayimmi = MsgBox("Başlıklarınızda merge cell var, o yüzden A sütununda göre sıralamadan devam edilecek. Zaten sıralıysa Evet'i tıklayın ve devam edilsin. Sıralamayı kendiniz yapacaksanız Hayır'ı tıklayın?", vbYesNo)
                If sortlayimmi = MsgBoxResult.Yes Then
                    GoTo siralamadangec
                Else
                    MsgBox("Kendiniz sıralamayı seçtiniz, sıralayıp makroyu tekrar çalıştırın")
                    Exit Sub 'displayalert ve screenupdating nolcak
                End If
            Else
                MsgBox(e.Message)
            End If
        Finally
            app_aksiyon(app, "Çıkış")
        End Try
    End Sub
    Sub cok_kolonlu_bolme()
        Dim enUsttekiHucre, enAlttekiHucre, blokunIlkHucresi, blokunSonHucresi, ilkSatirinSecimi, sonSatirinSecimi As Excel.Range
        Dim anaDosya, yeniDosya As Excel.Workbook
        Dim yeniBlokMu As Boolean
        Dim kacKolonVar, enUstSatir, enAltSatir As Integer
        Dim kacKolonaGoreBolcez As Byte
        Dim dosyaGenelAdi, boluneninAdi As String
        Dim sortlayimmi As MsgBoxResult



        'İlk olarak ayarlar formu çıkar
        Dim fb As New frmBolme
        'fb.lblKacKolonaGore.Visible = False
        'fb.cbKacKolonaGore.Visible = False
        fb.grpKaynak.Visible = False
        fb.ShowDialog()


        If fb.devammi = False Then Exit Sub

        Try
            Dim Foldername As String = fb.klasor
            Dim baslangicSatirNo As Byte = CByte(1 + fb.satirAdet)

            app_aksiyon(app, "Giriş")

            kacKolonaGoreBolcez = fb.kacKolonBolme

            'ÖNCE GENEL HAZIRLIK
            'TODO:FOR NEXT YAP, CELL(İ,2) ŞEKLİNDE
            'burdaki sıralama 3 kolon önreği üzeirnden önce a sonra b sonra c kolonuna göre olsun
            'çünkü her zaman uniq değerler olayabilir. ör: bankada böge-şube-miy şekklinde sıraladıgımda
            'sorun yok çünkü siciller uniq. ama  bir başkası şöyle bi sıralama yatırabilir
            'bölge-şube-iisim :bu durumda isim uniq olmuyor, bi isim birden fazla bölge-şubede varolaiblir
            'o yüzden sıralalmayı C kolonuna göre yaparsak tüm volkanlar altlatala gelir, halbuki A bölgeisinin
            'x şubesinin volkanlar alt alta olcak v.s

            'sıralı değildir diye sıralayalım, burda hata çıkabilr, çıkarsa catch'de siraamadangece yönledirem seçneği var
            'satır başlığı çok olunca a2'leri falan deiştir
            CType(app.ActiveSheet, Excel.Worksheet).Sort.SortFields.Clear()
            CType(app.ActiveSheet, Excel.Worksheet).Sort.SortFields.Add(Key:=app.Range(app.Range("a2"), app.Range("a2").End(Excel.XlDirection.xlDown)), _
                SortOn:=Excel.XlSortOn.xlSortOnValues, Order:=Excel.XlSortOrder.xlAscending, DataOption:=Excel.XlSortDataOption.xlSortNormal)
            CType(app.ActiveSheet, Excel.Worksheet).Sort.SortFields.Add(Key:=app.Range(app.Range("b2"), app.Range("b2").End(Excel.XlDirection.xlDown)), _
                SortOn:=Excel.XlSortOn.xlSortOnValues, Order:=Excel.XlSortOrder.xlAscending, DataOption:=Excel.XlSortDataOption.xlSortNormal)
            CType(app.ActiveSheet, Excel.Worksheet).Sort.SortFields.Add(Key:=app.Range(app.Range("c2"), app.Range("c2").End(Excel.XlDirection.xlDown)), _
                SortOn:=Excel.XlSortOn.xlSortOnValues, Order:=Excel.XlSortOrder.xlAscending, DataOption:=Excel.XlSortDataOption.xlSortNormal)
            With CType(app.ActiveSheet, Excel.Worksheet).Sort
                .SetRange(app.Range("A1").CurrentRegion)
                .Header = Excel.XlYesNoGuess.xlYes
                .MatchCase = False
                .Orientation = Excel.XlSortOrientation.xlSortColumns
                .SortMethod = Excel.XlSortMethod.xlPinYin
                .Apply()
            End With

siralamadangec:
            'özel karekterleri dönüştürme
            Dim ozelKarakterler() As String = {"/", "\", ":", "<", ">", """", "~?", "~*"}
            For Each a As String In ozelKarakterler
                'kaç kolon varsa ona da for next yap
                CType(app.Columns("A:A"), Excel.Range).Select()
                CType(app.Selection, Excel.Range).Replace(What:=a, Replacement:=fb.ozelKarakterSubsitute, LookAt:=Excel.XlLookAt.xlPart, _
                    SearchOrder:=Excel.XlSearchOrder.xlByRows, MatchCase:=False, SearchFormat:=False, _
                    ReplaceFormat:=False)
            Next

            'başlık sonrasında boş hücreleri dönüşütüryurz
            CType(app.Rows(baslangicSatirNo), Excel.Range).Select()
            CType(app.Selection, Excel.Range).Replace(What:="", Replacement:=fb.boslukSubstitue, LookAt:=Excel.XlLookAt.xlPart, _
                    SearchOrder:=Excel.XlSearchOrder.xlByRows, MatchCase:=False, SearchFormat:=False, _
                    ReplaceFormat:=False)

            If Not My.Computer.FileSystem.DirectoryExists(Foldername) Then My.Computer.FileSystem.CreateDirectory(Foldername) 'burda Mkdir("C:\böl") de diyebilridik, hatta ilk başta öyle demiştim ama Mkdir üzerine gelice çıkan açıklamada My feature daha iyidir dedi

            anaDosya = app.ActiveWorkbook

            'bu kısmı da geçicez
            Select Case anaDosya.FileFormat
                Case Excel.XlFileFormat.xlExcel8
                    'Case "-4143", "-4158", 6, 56 'normal xls, txt, csv veya Excel2007deki 97-2003 xls'i mi
                    dosyaGenelAdi = Left(anaDosya.Name, Len(anaDosya.Name) - 3)
                Case Excel.XlFileFormat.xlWorkbookDefault
                    'Case 50, 51, 52 'xlsx, xlsb veya xlsm ise
                    dosyaGenelAdi = Left(anaDosya.Name, Len(anaDosya.Name) - 4)
                Case Else
                    MsgBox("Bu dosya formatı bu makronun çalışması için uygun değil. xls, xlsx, xlsb, xlsm, txt veya csv dosyalarıyla çalışmalısınız")
                    Exit Sub
            End Select

            enUsttekiHucre = CType(app.Cells(baslangicSatirNo, 1), Excel.Range)
            enAlttekiHucre = enUsttekiHucre.End(Excel.XlDirection.xlDown)

            enUstSatir = enUsttekiHucre.Row
            enAltSatir = enAlttekiHucre.Row

            CType(app.Cells(baslangicSatirNo, 1), Excel.Range).Select()
            ilkSatirinSecimi = Nothing 'warning veriyor diye bunu ekledim, çok krtik değil sonucta error değil ama 0 sorun olsun die ekledim
            yeniBlokMu = True
            kacKolonVar = enUsttekiHucre.End(Excel.XlDirection.xlToRight).Column

            For i As Integer = enUstSatir To enAltSatir
                If yeniBlokMu = False Then GoTo ATLA

                blokunIlkHucresi = CType(app.ActiveCell, Excel.Range)
                ilkSatirinSecimi = app.Range(blokunIlkHucresi, blokunIlkHucresi.Offset(0, kacKolonVar - 1))
ATLA:
                If CStr(CType(app.Cells(i, kacKolonaGoreBolcez), Excel.Range).Value2) = CStr(CType(app.Cells(i + 1, kacKolonaGoreBolcez), Excel.Range).Value2) Then
                    app.ActiveCell.Offset(1, 0).Select()
                    yeniBlokMu = False
                Else
                    blokunSonHucresi = app.ActiveCell
                    sonSatirinSecimi = app.Range(blokunSonHucresi, blokunSonHucresi.Offset(0, kacKolonVar - 1))

                    boluneninAdi = "" 'her yeni bloğa girişte sıfırlıyoruz
                    For m As Integer = 0 To CByte(kacKolonaGoreBolcez) - 1
                        'bu kısımdaki ayraç için ayrı bir dğeişken tanımalyalımmı, otomail yapısına göre değiştir
                        boluneninAdi = String.Concat(boluneninAdi, IIf(m = 0, "", fb.dosyaAyirmaIsareti), Trim(CStr(CType(app.ActiveCell, Excel.Range).Offset(0, m).Value)))
                    Next m

                    app.Range(app.Cells(1, 1), app.Cells(baslangicSatirNo - 1, 1)).EntireRow.Copy()
                    yeniDosya = app.Workbooks.Add()
                    CType(app.ActiveSheet, Excel.Worksheet).Paste()
                    anaDosya.Activate()
                    app.Range(ilkSatirinSecimi, sonSatirinSecimi).Select()
                    CType(app.Selection, Excel.Range).Copy()
                    yeniDosya.Activate()
                    CType(app.Cells(baslangicSatirNo, 1), Excel.Range).Select()
                    CType(app.ActiveSheet, Excel.Worksheet).Paste()
                    CType(app.Cells, Excel.Range).Select()
                    CType(app.Cells, Excel.Range).EntireColumn.AutoFit()


                    'save formatı
                    If fb.dosyaBolmeFormati = True Then
                        yeniDosya.SaveAs(Filename:=Foldername & "\" & boluneninAdi & fb.dosyaAyirmaIsareti & dosyaGenelAdi & DosyaExtension(app, anaDosya), FileFormat:=anaDosya.FileFormat)
                    Else
                        yeniDosya.ExportAsFixedFormat(Type:=Excel.XlFixedFormatType.xlTypePDF, _
                                Filename:=Foldername & "\" & boluneninAdi & fb.dosyaAyirmaIsareti & dosyaGenelAdi & "pdf" _
                                , IncludeDocProperties:=True, IgnorePrintAreas _
                                :=False, OpenAfterPublish:=False)
                    End If

                    yeniDosya.Close()
                    blokunSonHucresi.Offset(1, 0).Select()
                    yeniBlokMu = True
                End If

            Next i

            Shell("explorer.exe " & Foldername, vbNormalFocus)

        Catch e As Exception
            If e.Message = "To do this, all the merged cells need to be the same size." Then
                sortlayimmi = MsgBox("Başlıklarınızda merge cell var, o yüzden A sütununda göre sıralamadan devam edeceğim. Zaten sıralıysa Evet'i tıklayın ve devam edeyim,  veya kendiniz sıralıacyaksanız Hayır'ı tıklayın?", vbYesNo)
                If sortlayimmi = MsgBoxResult.Yes Then
                    GoTo siralamadangec
                Else
                    MsgBox("Kendiniz sıralamayı seçtiniz, sıralayıp makroyu tekrar çalıştırın")
                    Exit Sub
                End If
            Else
                MsgBox(e.Message)
            End If
        Finally
            app_aksiyon(app, "Çıkış")
        End Try
    End Sub
    Sub coksayfali_bolme()
        'TODO:şimdilik tek kolon üzerinden bölüyor, ilerde çok kolonlu da yap(talep gelmezse yapmasak da olur, genelde tek kolon yeterli olacaktır)
        'TODO:inputbox ile, array de kabul edebiliyorsun, type:=64, dene bakalım
        'TODO:ikinci seçeneğimizde dirkt kolondaon aldırıyodu ya, bunun yerine sçetirsin, type:8 veya 64

        Dim degisken() As String 'ilk kolonun rakam olması durumunda bile string işe yarar, ama integer tanımlasaydık ilk kolon string olsa patlardı
        Dim kacItem, sayfaCount As Integer
        Dim anaDosya, baslikDosya, yeniDosya As Excel.Workbook
        Dim uzanti, dosyaGenelAdi, anaDosyaAd, boluneninAdi As String
        Dim dosyaFormat As Excel.XlFileFormat


formgoster:
        'İlk olarak ayarlar formu çıkar
        Dim fb As New frmBolme
        fb.lblKacKolonaGore.Visible = False
        fb.cbKacKolonaGore.Visible = False
        fb.lblBoslukConvert.Visible = False
        fb.txtBoslukConvert.Visible = False
        fb.ShowDialog()

        If fb.devammi = False Then Exit Sub

        'Dim z As Integer
        'For Each rButton In fb.grpKaynak.Controls.OfType(Of RadioButton)()
        '    If rButton.Checked Then
        '        z += 1
        '    End If
        'Next
        'MsgBox(z)

        If fb.grpKaynak.Controls.OfType(Of RadioButton).Any(Function(rb) rb.Checked) = False Then
            MsgBox("Bi kaynak türü seçin!" _
                   & vbCrLf & "Neye göre bölme yapılacaksa onun kaynağı seçilir." _
                   & vbCrLf & "Aktif(şuan açık olan) sayfanın A kolonu " _
                    & vbCrLf & "tüm benzersiz(unique) değerleri içeriyorsa " _
                   & vbCrLf & "Aktif sayfa seçeneğini seçebilirsiniz. " _
                   & vbCrLf & "Eğer hiçbir sayfanız tüm değerleri tamaman " _
                    & vbCrLf & "içermiyorsa, yeni bir workbook açın ve " _
                    & vbCrLf & "başlık olmadan hepsini A kolonuna girin," _
                    & vbCrLf & "sonra da bu dosya açıkken ikinci seçeneği seçin.")
            GoTo formgoster
        End If

        Try
            Dim Foldername As String = fb.klasor

            app_aksiyon(app, "Giriş")

            'açık dsyadan tüm uniqleri içerenden mi, yoksa sen mi biwrokbbok tanımalyıp onu mu acık bırakcan
            If fb.rbKaynakActiveSheet.Checked = True Then
                'ilk bşata hiçbiri seçil değil, 
                'yukarda zaten bişey seçilpi seçilmediğini kontrol ettiğmize göre buraya gelmiştir
                've Else durumunda diğer düğme seçilimiş demktir

                CType(app.Columns(1), Excel.Range).Copy()
                app.Workbooks.Add()
                CType(app.ActiveSheet, Excel.Worksheet).Paste()
                CType(app.Selection, Excel.Range).RemoveDuplicates(Columns:=1, Header:=Excel.XlYesNoGuess.xlNo)
                CType(app.Rows("1:" & fb.satirAdet), Excel.Range).Delete()
                kacItem = app.Range("a1").End(Excel.XlDirection.xlDown).Row

                ReDim degisken(0 To kacItem - 1)

                For x = 0 To kacItem - 1
                    degisken(x) = CStr(CType(app.ActiveCell, Excel.Range).Value)
                    CType(app.ActiveCell, Excel.Range).Offset(1, 0).Select()
                Next x
                CType(app.ActiveWorkbook, Excel.Workbook).Close(SaveChanges:=False)
            Else 'ayrı wb üzerinden uniqe değerler alınacak
                'fomrda uyarı mesajı çıkarıyoruz ama biz ekstra bi güvenlik noktası daha koyalım
                'gizli dosyalar(personl.xlsb gibi) hariç aık dosya sayısı=1 ise
                'uni    e değerler dosyayısı açık dğeildir demek, devam etmesin
                Dim aw As Integer
                Dim q As Excel.Window
                For Each q In app.Windows
                    If q.Visible = True Then aw += 1
                Next
                If aw = 1 Then
                    MsgBox("Şuan sadece 1 dosya açık, lütfen ana dosyanızdan sonra uniqe değerleri içeren dosyayı açık bırakın")
                    Exit Sub
                End If
                app.Range("a1").Select()
                kacItem = app.Range("a1").End(Excel.XlDirection.xlDown).Row

                ReDim degisken(0 To kacItem - 1)

                For x = 0 To kacItem - 1
                    degisken(x) = CStr(CType(app.ActiveCell, Excel.Range).Value)
                    CType(app.ActiveCell, Excel.Range).Offset(1, 0).Select()
                Next x
                CType(app.ActiveWorkbook, Excel.Workbook).Close(SaveChanges:=False)
            End If

            anaDosya = app.ActiveWorkbook

            anaDosyaAd = anaDosya.FullName
            uzanti = DosyaExtension(app, anaDosya)
            dosyaFormat = anaDosya.FileFormat
            dosyaGenelAdi = Left(anaDosya.Name, Len(anaDosya.Name) - Len(DosyaExtension(app, anaDosya)))
            sayfaCount = app.Worksheets.Count 'doğru oldu mu emin olamadım

            anaDosya.Close(SaveChanges:=True) 'az sonra tekrar açılıyo zaten

            app.Workbooks.Add()
            baslikDosya = app.ActiveWorkbook
            If app.Worksheets.Count < sayfaCount Then 'yeni dosyadai sayfa sayısı, orjinaldekinden az mı
                For q = 1 To sayfaCount - app.Worksheets.Count 'Q'yu nedne tanımlatmaya zorlamadı
                    app.Worksheets.Add()
                Next q
            End If

            For k = 0 To kacItem - 1
                boluneninAdi = degisken(k)

                app.Workbooks.Open(Filename:=anaDosyaAd)
                yeniDosya = app.ActiveWorkbook

                'başlık işine devam
                For y = 1 To sayfaCount
                    CType(app.Sheets(y), Excel.Worksheet).Select()
                    CType(app.Rows("1:" & fb.satirAdet), Excel.Range).Select()
                    CType(app.Selection, Excel.Range).Copy()
                    baslikDosya.Activate()
                    CType(app.Sheets(y), Excel.Worksheet).Select()
                    CType(app.ActiveSheet, Excel.Worksheet).Paste()
                    yeniDosya.Activate()
                Next y

                For i = 1 To sayfaCount
                    CType(app.Sheets(i), Excel.Worksheet).Select() 'burdan eminmiyiz, aktifwb mi yapsak
                    app.Range("A1").Select()
                    'CType(app.Selection, Excel.Range).AutoFilter()
                    app.Range("$A$1").CurrentRegion.AutoFilter(Field:=1, Criteria1:="<>" & boluneninAdi & "", _
                        Operator:=Excel.XlAutoFilterOperator.xlAnd)
                    CType(app.Rows("1:1"), Excel.Range).Select()
                    app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlDown)).Select()
                    CType(app.Selection, Excel.Range).SpecialCells(Excel.XlCellType.xlCellTypeVisible).Select()
                    CType(app.Selection, Excel.Range).Delete(Excel.XlDeleteShiftDirection.xlShiftUp)
                Next i


                For i = 1 To app.Worksheets.Count
                    baslikDosya.Activate()
                    CType(app.Sheets(i), Excel.Worksheet).Select()
                    'app.Range("a1").Select()
                    'app.Range(CType(app.Selection, Excel.Range), CType(app.Selection, Excel.Range).End(Excel.XlDirection.xlToRight)).Select()
                    CType(app.Rows("1:" & fb.satirAdet), Excel.Range).Select()
                    CType(app.Selection, Excel.Range).Copy()

                    yeniDosya.Activate()
                    CType(app.Sheets(i), Excel.Worksheet).Select()
                    app.Range("a1").Select()
                    CType(app.Selection, Excel.Range).Insert(Shift:=Excel.XlInsertShiftDirection.xlShiftDown)


                    'print layout ayarı
                    With CType(app.ActiveSheet, Excel.Worksheet).PageSetup
                        If Not fb.layoutSecenek = Nothing Then
                            If fb.layoutSecenek = True Then
                                .Orientation = Excel.XlPageOrientation.xlPortrait
                                .Zoom = False
                                .FitToPagesWide = 1
                                .FitToPagesTall = 1
                            Else
                                .Orientation = Excel.XlPageOrientation.xlLandscape
                                .Zoom = False
                                .FitToPagesWide = 1
                                .FitToPagesTall = 1
                            End If
                        End If
                    End With

                Next i

                'MsgBox(anaDosya.Name)

                'save formatı
                If fb.dosyaBolmeFormati = True Then
                    yeniDosya.SaveAs(Filename:=Foldername & "\" & boluneninAdi & fb.dosyaAyirmaIsareti & dosyaGenelAdi & uzanti, FileFormat:=dosyaFormat)

                Else
                    yeniDosya.ExportAsFixedFormat(Type:=Excel.XlFixedFormatType.xlTypePDF, _
                            Filename:=Foldername & "\" & boluneninAdi & fb.dosyaAyirmaIsareti & dosyaGenelAdi & "pdf" _
                            , IncludeDocProperties:=True, IgnorePrintAreas _
                            :=False, OpenAfterPublish:=False)
                End If

                yeniDosya.Close()
            Next k

            baslikDosya.Close(SaveChanges:=False)
            'klasörde göster
            Shell("explorer.exe " & Foldername, vbNormalFocus)

        Catch e As Exception
            MsgBox(e.Message)
        Finally
            app_aksiyon(app, "Çıkış")
        End Try

    End Sub
    
   
End Module