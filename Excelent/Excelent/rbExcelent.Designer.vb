Partial Class rbExcelent
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rbExcelent))
        Dim RibbonDialogLauncherImpl1 As Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher = Me.Factory.CreateRibbonDialogLauncher
        Dim RibbonDropDownItemImpl1 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl2 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl3 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl4 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl5 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl6 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl7 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl8 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl9 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl10 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl11 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl12 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl13 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl14 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl15 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl16 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl17 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl18 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl19 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl20 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl21 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl22 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl23 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl24 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl25 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl26 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl27 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl28 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl29 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl30 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl31 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl32 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl33 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl34 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl35 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl36 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDropDownItemImpl37 As Microsoft.Office.Tools.Ribbon.RibbonDropDownItem = Me.Factory.CreateRibbonDropDownItem
        Dim RibbonDialogLauncherImpl2 As Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher = Me.Factory.CreateRibbonDialogLauncher
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.btnStandartBol = Me.Factory.CreateRibbonButton
        Me.btnCokSutunluBol = Me.Factory.CreateRibbonButton
        Me.Button4 = Me.Factory.CreateRibbonButton
        Me.Separator1 = Me.Factory.CreateRibbonSeparator
        Me.Button8 = Me.Factory.CreateRibbonButton
        Me.btnSayfaBirlestir = Me.Factory.CreateRibbonButton
        Me.grpMail = Me.Factory.CreateRibbonGroup
        Me.Button11 = Me.Factory.CreateRibbonButton
        Me.grpHazirLookup = Me.Factory.CreateRibbonGroup
        Me.mnAdetYaz = Me.Factory.CreateRibbonMenu
        Me.btnFiiliYaz = Me.Factory.CreateRibbonButton
        Me.btnNormVarYok = Me.Factory.CreateRibbonButton
        Me.Separator6 = Me.Factory.CreateRibbonSeparator
        Me.DropDown2 = Me.Factory.CreateRibbonDropDown
        Me.DropDown1 = Me.Factory.CreateRibbonDropDown
        Me.DropDown3 = Me.Factory.CreateRibbonDropDown
        Me.Group6 = Me.Factory.CreateRibbonGroup
        Me.mnWB = Me.Factory.CreateRibbonMenu
        Me.btnWBsaveall = Me.Factory.CreateRibbonButton
        Me.btnCloseall = Me.Factory.CreateRibbonButton
        Me.btnWBtumuPrint = Me.Factory.CreateRibbonButton
        Me.Separator2 = Me.Factory.CreateRibbonSeparator
        Me.btnWBrefreshall = Me.Factory.CreateRibbonButton
        Me.btnWBsifreDegis = Me.Factory.CreateRibbonButton
        Me.mnWS = Me.Factory.CreateRibbonMenu
        Me.btnWsPrintnames = Me.Factory.CreateRibbonButton
        Me.btnWsSortalpha = Me.Factory.CreateRibbonButton
        Me.Separator4 = Me.Factory.CreateRibbonSeparator
        Me.btnWsProtectall = Me.Factory.CreateRibbonButton
        Me.btnWsUnprotectall = Me.Factory.CreateRibbonButton
        Me.Separator5 = Me.Factory.CreateRibbonSeparator
        Me.btnWsilkharicHide = Me.Factory.CreateRibbonButton
        Me.btnShowallhiddens = Me.Factory.CreateRibbonButton
        Me.Group4 = Me.Factory.CreateRibbonGroup
        Me.Box1 = Me.Factory.CreateRibbonBox
        Me.btnPivotOtodoldur = Me.Factory.CreateRibbonButton
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Button3 = Me.Factory.CreateRibbonButton
        Me.Separator3 = Me.Factory.CreateRibbonSeparator
        Me.Box2 = Me.Factory.CreateRibbonBox
        Me.Button5 = Me.Factory.CreateRibbonButton
        Me.Button6 = Me.Factory.CreateRibbonButton
        Me.Button7 = Me.Factory.CreateRibbonButton
        Me.Group5 = Me.Factory.CreateRibbonGroup
        Me.Gallery1 = Me.Factory.CreateRibbonGallery
        Me.grpFrequentFile = Me.Factory.CreateRibbonGroup
        Me.mnFrequentFile = Me.Factory.CreateRibbonMenu
        Me.btnFreqDosya1 = Me.Factory.CreateRibbonButton
        Me.btnFreqDosya2 = Me.Factory.CreateRibbonButton
        Me.btnFreqDosya3 = Me.Factory.CreateRibbonButton
        Me.btnFreqDosya4 = Me.Factory.CreateRibbonButton
        Me.btnFreqDosya5 = Me.Factory.CreateRibbonButton
        Me.Group3 = Me.Factory.CreateRibbonGroup
        Me.Menu1 = Me.Factory.CreateRibbonMenu
        Me.Button12 = Me.Factory.CreateRibbonButton
        Me.Button13 = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.grpMail.SuspendLayout()
        Me.grpHazirLookup.SuspendLayout()
        Me.Group6.SuspendLayout()
        Me.Group4.SuspendLayout()
        Me.Box1.SuspendLayout()
        Me.Box2.SuspendLayout()
        Me.Group5.SuspendLayout()
        Me.grpFrequentFile.SuspendLayout()
        Me.Group3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.grpMail)
        Me.Tab1.Groups.Add(Me.grpHazirLookup)
        Me.Tab1.Groups.Add(Me.Group6)
        Me.Tab1.Groups.Add(Me.Group4)
        Me.Tab1.Groups.Add(Me.Group5)
        Me.Tab1.Groups.Add(Me.grpFrequentFile)
        Me.Tab1.Groups.Add(Me.Group3)
        Me.Tab1.Label = "Excelent"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.btnStandartBol)
        Me.Group1.Items.Add(Me.btnCokSutunluBol)
        Me.Group1.Items.Add(Me.Button4)
        Me.Group1.Items.Add(Me.Separator1)
        Me.Group1.Items.Add(Me.Button8)
        Me.Group1.Items.Add(Me.btnSayfaBirlestir)
        Me.Group1.Label = "Bölme ve Birleştirme"
        Me.Group1.Name = "Group1"
        '
        'btnStandartBol
        '
        Me.btnStandartBol.Label = "Standart Bölme"
        Me.btnStandartBol.Name = "btnStandartBol"
        Me.btnStandartBol.OfficeImageId = "SplitTable"
        Me.btnStandartBol.ScreenTip = "Standart Bölme"
        Me.btnStandartBol.ShowImage = True
        Me.btnStandartBol.SuperTip = "Bir çalışma sayfasındaki datayı A kolonuna göre bölüp, önceden ayarlanmış klasör " &
    "içine ayrı dosyalar halinde kopyalar"
        '
        'btnCokSutunluBol
        '
        Me.btnCokSutunluBol.Label = "Çok Sütunlu Bölme"
        Me.btnCokSutunluBol.Name = "btnCokSutunluBol"
        Me.btnCokSutunluBol.OfficeImageId = "ColumnsGroup"
        Me.btnCokSutunluBol.ScreenTip = "Çok Sütunlu Bölme"
        Me.btnCokSutunluBol.ShowImage = True
        Me.btnCokSutunluBol.SuperTip = "Birden fazla sütuna göre  bölme işlemi yapar"
        '
        'Button4
        '
        Me.Button4.Label = "Çok Sayfalı Bölme"
        Me.Button4.Name = "Button4"
        Me.Button4.OfficeImageId = "PageVersionSplitButton"
        Me.Button4.ScreenTip = "Çok Sayfalı Bölme"
        Me.Button4.ShowImage = True
        Me.Button4.SuperTip = "Bir dosyadaki tüm sayfaları bölme işlemine tabi tutar. Bölme işlemi sonunda oluşa" &
    "n tüm dosyalarda ana doysadaki sayfaların aynısı bulunur."
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        '
        'Button8
        '
        Me.Button8.Label = "Dosya Birleştir"
        Me.Button8.Name = "Button8"
        Me.Button8.OfficeImageId = "ReviewCombineRevisions"
        Me.Button8.ScreenTip = "Dosya Birleştirme"
        Me.Button8.ShowImage = True
        Me.Button8.SuperTip = "Seçilen klasördeki tüm dosyaları tek bir  dosyada birleştirir. Tüm dosyların aynı" &
    " formatta olması gerekmektedir. Sayfa sayılarının da aynı olması gerekir, aksi h" &
    "alde hata alınacaktır."
        '
        'btnSayfaBirlestir
        '
        Me.btnSayfaBirlestir.Label = "Sayfa Birleştir"
        Me.btnSayfaBirlestir.Name = "btnSayfaBirlestir"
        Me.btnSayfaBirlestir.OfficeImageId = "CompareAndCombine"
        Me.btnSayfaBirlestir.ScreenTip = "Sayfa Birleştirme"
        Me.btnSayfaBirlestir.ShowImage = True
        Me.btnSayfaBirlestir.SuperTip = "Bir dosyadaki tüm sayfaları, tek bir sayfada altalta gelecek şekilde birleştirir." &
    " Her sayfanın adını, ilk kolona yani A kolonuna yazar."
        '
        'grpMail
        '
        Me.grpMail.Items.Add(Me.Button11)
        Me.grpMail.Label = "Toplu Mail"
        Me.grpMail.Name = "grpMail"
        '
        'Button11
        '
        Me.Button11.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button11.Label = "Toplu Mail Gönderimi"
        Me.Button11.Name = "Button11"
        Me.Button11.OfficeImageId = "MailMergeStartMailMergeMenu"
        Me.Button11.ScreenTip = "Toplu Mail"
        Me.Button11.ShowImage = True
        Me.Button11.SuperTip = resources.GetString("Button11.SuperTip")
        '
        'grpHazirLookup
        '
        Me.grpHazirLookup.DialogLauncher = RibbonDialogLauncherImpl1
        Me.grpHazirLookup.Items.Add(Me.mnAdetYaz)
        Me.grpHazirLookup.Items.Add(Me.Separator6)
        Me.grpHazirLookup.Items.Add(Me.DropDown2)
        Me.grpHazirLookup.Items.Add(Me.DropDown1)
        Me.grpHazirLookup.Items.Add(Me.DropDown3)
        Me.grpHazirLookup.Label = "Hazır Lookuplar"
        Me.grpHazirLookup.Name = "grpHazirLookup"
        '
        'mnAdetYaz
        '
        Me.mnAdetYaz.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.mnAdetYaz.Items.Add(Me.btnFiiliYaz)
        Me.mnAdetYaz.Items.Add(Me.btnNormVarYok)
        Me.mnAdetYaz.Label = "Personel Adet"
        Me.mnAdetYaz.Name = "mnAdetYaz"
        Me.mnAdetYaz.OfficeImageId = "CoauthorCount"
        Me.mnAdetYaz.ScreenTip = "Personel Adet"
        Me.mnAdetYaz.ShowImage = True
        Me.mnAdetYaz.SuperTip = resources.GetString("mnAdetYaz.SuperTip")
        '
        'btnFiiliYaz
        '
        Me.btnFiiliYaz.Label = "Fiili Yaz"
        Me.btnFiiliYaz.Name = "btnFiiliYaz"
        Me.btnFiiliYaz.ShowImage = True
        Me.btnFiiliYaz.SuperTip = "Bir kolonda bulunan şubelerin yanına, kullanıcıya sorulan personel tipindeki fiil" &
    "i adedi yazdırılır."
        '
        'btnNormVarYok
        '
        Me.btnNormVarYok.Label = "Norm Var/Yok"
        Me.btnNormVarYok.Name = "btnNormVarYok"
        Me.btnNormVarYok.ShowImage = True
        Me.btnNormVarYok.SuperTip = "Bir kolonda bulunan şubelerin yanına, kullanıcıya sorulan personel tipindeki norm" &
    " adedi yazdırılır."
        '
        'Separator6
        '
        Me.Separator6.Name = "Separator6"
        '
        'DropDown2
        '
        RibbonDropDownItemImpl1.Label = "Sicilden"
        RibbonDropDownItemImpl2.Label = "Ad Soyad"
        RibbonDropDownItemImpl3.Label = "Çalıştığı Birim Kodu"
        RibbonDropDownItemImpl4.Label = "Çalıştığı Birim Adı"
        RibbonDropDownItemImpl5.Label = "Görevi"
        RibbonDropDownItemImpl6.Label = "Bankaya Giriş Tarihi"
        RibbonDropDownItemImpl7.Label = "Birime Giriş Tarihi"
        Me.DropDown2.Items.Add(RibbonDropDownItemImpl1)
        Me.DropDown2.Items.Add(RibbonDropDownItemImpl2)
        Me.DropDown2.Items.Add(RibbonDropDownItemImpl3)
        Me.DropDown2.Items.Add(RibbonDropDownItemImpl4)
        Me.DropDown2.Items.Add(RibbonDropDownItemImpl5)
        Me.DropDown2.Items.Add(RibbonDropDownItemImpl6)
        Me.DropDown2.Items.Add(RibbonDropDownItemImpl7)
        Me.DropDown2.Label = " "
        Me.DropDown2.Name = "DropDown2"
        Me.DropDown2.ScreenTip = "Sicilden lookup"
        Me.DropDown2.SuperTip = "Bir kolonda bulunan sicillerin yanına seçilen değerler getirilir.(Personel dosyas" &
    "ının konumunu bir seferliğine tanıtmak için bu grubun sağ alt köşesindeki küçük " &
    "oka tıklayınız)"
        '
        'DropDown1
        '
        RibbonDropDownItemImpl8.Label = "Şubeden"
        RibbonDropDownItemImpl9.Label = "Şube Adı"
        RibbonDropDownItemImpl10.Label = "Bölge Kodu"
        RibbonDropDownItemImpl11.Label = "Bölge Adı"
        RibbonDropDownItemImpl12.Label = "Açılış Tarihi"
        RibbonDropDownItemImpl13.Label = "Açık/Kapalı"
        RibbonDropDownItemImpl14.Label = "Kapanış Tarihi"
        RibbonDropDownItemImpl15.Label = "Türü"
        RibbonDropDownItemImpl16.Label = "Sınıfı"
        RibbonDropDownItemImpl17.Label = "Tipi"
        RibbonDropDownItemImpl18.Label = "İl Kodu"
        RibbonDropDownItemImpl19.Label = "Müdür Sicili"
        RibbonDropDownItemImpl20.Label = "Müdür Adı"
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl8)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl9)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl10)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl11)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl12)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl13)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl14)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl15)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl16)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl17)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl18)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl19)
        Me.DropDown1.Items.Add(RibbonDropDownItemImpl20)
        Me.DropDown1.Label = " "
        Me.DropDown1.Name = "DropDown1"
        Me.DropDown1.ScreenTip = "Şube kodundan lookup"
        Me.DropDown1.SuperTip = "Bir kolonda bulunan şubelerin yanına seçilen değerler getirilir.(Şube dosyasının " &
    "konumunu bir seferliğine tanıtmak için bu grubun sağ alt köşesindeki küçük oka t" &
    "ıklayınız)"
        '
        'DropDown3
        '
        RibbonDropDownItemImpl21.Label = "Bölgeden"
        RibbonDropDownItemImpl22.Label = "Bölge Adı"
        RibbonDropDownItemImpl23.Label = "Bölge Müdürü"
        RibbonDropDownItemImpl24.Label = "Bireysel Satış Ekibi"
        RibbonDropDownItemImpl25.Label = "Birebir Satış Ekibi"
        RibbonDropDownItemImpl26.Label = "Bireysel+Birebir Satış Ekibi"
        RibbonDropDownItemImpl27.Label = "Bölge Müdürü+Bireysel+Birebir"
        RibbonDropDownItemImpl28.Label = "KOBİ Satış Ekibi"
        RibbonDropDownItemImpl29.Label = "Ticari Satış Ekibi"
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl21)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl22)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl23)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl24)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl25)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl26)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl27)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl28)
        Me.DropDown3.Items.Add(RibbonDropDownItemImpl29)
        Me.DropDown3.Label = " "
        Me.DropDown3.Name = "DropDown3"
        Me.DropDown3.ScreenTip = "Bölge kodundan lookup"
        Me.DropDown3.SuperTip = "Bir kolonda bulunan bölgelerin yanına seçilen değerler getirilir.(Şube dosyasının" &
    " konumunu bir seferliğine tanıtmak için bu grubun sağ alt köşesindeki küçük oka " &
    "tıklayınız)"
        '
        'Group6
        '
        Me.Group6.Items.Add(Me.mnWB)
        Me.Group6.Items.Add(Me.mnWS)
        Me.Group6.Label = "Workbook ve Worksheet"
        Me.Group6.Name = "Group6"
        '
        'mnWB
        '
        Me.mnWB.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.mnWB.Items.Add(Me.btnWBsaveall)
        Me.mnWB.Items.Add(Me.btnCloseall)
        Me.mnWB.Items.Add(Me.btnWBtumuPrint)
        Me.mnWB.Items.Add(Me.Separator2)
        Me.mnWB.Items.Add(Me.btnWBrefreshall)
        Me.mnWB.Items.Add(Me.btnWBsifreDegis)
        Me.mnWB.Label = "WorkBook İşlemleri"
        Me.mnWB.Name = "mnWB"
        Me.mnWB.OfficeImageId = "SaveWorkbookTask"
        Me.mnWB.ScreenTip = "WorkBook İşlemleri"
        Me.mnWB.ShowImage = True
        '
        'btnWBsaveall
        '
        Me.btnWBsaveall.Label = "Tümünü kaydet"
        Me.btnWBsaveall.Name = "btnWBsaveall"
        Me.btnWBsaveall.ScreenTip = "Tümü Kaydet"
        Me.btnWBsaveall.ShowImage = True
        Me.btnWBsaveall.SuperTip = "Gizli dosyalar dışındaki tüm dosyaları kaydeder."
        '
        'btnCloseall
        '
        Me.btnCloseall.Label = "Tümünü kapat"
        Me.btnCloseall.Name = "btnCloseall"
        Me.btnCloseall.ScreenTip = "Tümünü kapat"
        Me.btnCloseall.ShowImage = True
        Me.btnCloseall.SuperTip = "Gizli dosyalar dışındaki tüm dosyaları kapatır. Kapatırken dosyaları kaydedip kay" &
    "detmeyeceği kullanıcıya sorulur."
        '
        'btnWBtumuPrint
        '
        Me.btnWBtumuPrint.Label = "Tümünü bas"
        Me.btnWBtumuPrint.Name = "btnWBtumuPrint"
        Me.btnWBtumuPrint.ScreenTip = "Tümünü bas"
        Me.btnWBtumuPrint.ShowImage = True
        Me.btnWBtumuPrint.SuperTip = "Gizli dosyalar dışındaki tüm açık dosyalar printerdan bastırılır."
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        '
        'btnWBrefreshall
        '
        Me.btnWBrefreshall.Label = "Tümünü refresh et"
        Me.btnWBrefreshall.Name = "btnWBrefreshall"
        Me.btnWBrefreshall.ScreenTip = "Tümüm refresh et"
        Me.btnWBrefreshall.ShowImage = True
        Me.btnWBrefreshall.SuperTip = "Açık olan tüm dosyalardaki ODBC bağlantıları refresh edilir."
        '
        'btnWBsifreDegis
        '
        Me.btnWBsifreDegis.Label = "Tümünüde odbc connection şifre değiş"
        Me.btnWBsifreDegis.Name = "btnWBsifreDegis"
        Me.btnWBsifreDegis.ScreenTip = "Connection şifresi değiştir"
        Me.btnWBsifreDegis.ShowImage = True
        Me.btnWBsifreDegis.SuperTip = resources.GetString("btnWBsifreDegis.SuperTip")
        '
        'mnWS
        '
        Me.mnWS.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.mnWS.Items.Add(Me.btnWsPrintnames)
        Me.mnWS.Items.Add(Me.btnWsSortalpha)
        Me.mnWS.Items.Add(Me.Separator4)
        Me.mnWS.Items.Add(Me.btnWsProtectall)
        Me.mnWS.Items.Add(Me.btnWsUnprotectall)
        Me.mnWS.Items.Add(Me.Separator5)
        Me.mnWS.Items.Add(Me.btnWsilkharicHide)
        Me.mnWS.Items.Add(Me.btnShowallhiddens)
        Me.mnWS.Label = "WorkSheet İşlemleri"
        Me.mnWS.Name = "mnWS"
        Me.mnWS.OfficeImageId = "ExcelSpreadsheetInsert"
        Me.mnWS.ScreenTip = "WorkSheet İşlemleri"
        Me.mnWS.ShowImage = True
        '
        'btnWsPrintnames
        '
        Me.btnWsPrintnames.Label = "Sayfa isimlerin yazdır"
        Me.btnWsPrintnames.Name = "btnWsPrintnames"
        Me.btnWsPrintnames.ScreenTip = "İsimleri yazdır"
        Me.btnWsPrintnames.ShowImage = True
        Me.btnWsPrintnames.SuperTip = "Aktif dosyadaki sayfaların isimleri yeni aılan bir sayfaya yazdırılır"
        '
        'btnWsSortalpha
        '
        Me.btnWsSortalpha.Label = "Sayfaları alfabetik sırala"
        Me.btnWsSortalpha.Name = "btnWsSortalpha"
        Me.btnWsSortalpha.ScreenTip = "Sırala"
        Me.btnWsSortalpha.ShowImage = True
        Me.btnWsSortalpha.SuperTip = "Aktif dosyadaki sayfalar alfabetik olarak sıralanır"
        '
        'Separator4
        '
        Me.Separator4.Name = "Separator4"
        '
        'btnWsProtectall
        '
        Me.btnWsProtectall.Label = "Tümüne protect koy"
        Me.btnWsProtectall.Name = "btnWsProtectall"
        Me.btnWsProtectall.ScreenTip = "Protection koy"
        Me.btnWsProtectall.ShowImage = True
        Me.btnWsProtectall.SuperTip = "Aktif dosyadaki tüm sayfalara eş zamanlı olarak aynı şifre konulur"
        '
        'btnWsUnprotectall
        '
        Me.btnWsUnprotectall.Label = "Tümünü unprotect"
        Me.btnWsUnprotectall.Name = "btnWsUnprotectall"
        Me.btnWsUnprotectall.ScreenTip = "Protection kaldır"
        Me.btnWsUnprotectall.ShowImage = True
        Me.btnWsUnprotectall.SuperTip = "Aktif dosyadaki tüm sayfaların protectionı kaldırlır"
        '
        'Separator5
        '
        Me.Separator5.Name = "Separator5"
        '
        'btnWsilkharicHide
        '
        Me.btnWsilkharicHide.Label = "İlk sayfa hariç gizle"
        Me.btnWsilkharicHide.Name = "btnWsilkharicHide"
        Me.btnWsilkharicHide.ScreenTip = "Tümünü gizle"
        Me.btnWsilkharicHide.ShowImage = True
        Me.btnWsilkharicHide.SuperTip = "İlk sayfa dışındaki tüm sayfalar gizlenir"
        '
        'btnShowallhiddens
        '
        Me.btnShowallhiddens.Label = "Tüm gizli sayfaları göster"
        Me.btnShowallhiddens.Name = "btnShowallhiddens"
        Me.btnShowallhiddens.ScreenTip = "Sayfaları göster"
        Me.btnShowallhiddens.ShowImage = True
        Me.btnShowallhiddens.SuperTip = "Aktif dosyadaki tüm gizli sayfaları göster"
        '
        'Group4
        '
        Me.Group4.Items.Add(Me.Box1)
        Me.Group4.Items.Add(Me.Separator3)
        Me.Group4.Items.Add(Me.Box2)
        Me.Group4.Label = "Pivot ve Liste İşlemleri"
        Me.Group4.Name = "Group4"
        '
        'Box1
        '
        Me.Box1.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.Box1.Items.Add(Me.btnPivotOtodoldur)
        Me.Box1.Items.Add(Me.Button2)
        Me.Box1.Items.Add(Me.Button3)
        Me.Box1.Name = "Box1"
        '
        'btnPivotOtodoldur
        '
        Me.btnPivotOtodoldur.Label = "Pivot Boş Satır Doldur"
        Me.btnPivotOtodoldur.Name = "btnPivotOtodoldur"
        Me.btnPivotOtodoldur.OfficeImageId = "PivotTableRepeatItemLabels"
        Me.btnPivotOtodoldur.ScreenTip = "Pivot Boş Satır Doldurma"
        Me.btnPivotOtodoldur.ShowImage = True
        Me.btnPivotOtodoldur.SuperTip = "Pivot Tablo yaptıktan sonra, fieldların alt tarafı boş bırakılır. Bu buton ile bu" &
    " boşluklar ilgili field ile doldurulur."
        '
        'Button2
        '
        Me.Button2.Label = "Ters Pivot Al"
        Me.Button2.Name = "Button2"
        Me.Button2.OfficeImageId = "TableSummarizeWithPivot"
        Me.Button2.ScreenTip = "Ters Pivot Alma"
        Me.Button2.ShowImage = True
        Me.Button2.SuperTip = "Pivot tablo şeklindeki tabloyu tabular forma getirir. Böylece tablo sanki pivot y" &
    "apılmamış önceki haline geri döner."
        '
        'Button3
        '
        Me.Button3.Label = "Listeyi Parçala"
        Me.Button3.Name = "Button3"
        Me.Button3.OfficeImageId = "PivotTableMove"
        Me.Button3.ScreenTip = "Liste Parçalama"
        Me.Button3.ShowImage = True
        Me.Button3.SuperTip = "Bir listeyi belli miktardaki parçalara böler. Ör:5000 satırlık bir müşteri numara" &
    "sından oluşan listesini 1000er adetlik 5 parçaya bölmek isterseniz bu düğmeyi ku" &
    "llanabilirsinz."
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        '
        'Box2
        '
        Me.Box2.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.Box2.Items.Add(Me.Button5)
        Me.Box2.Items.Add(Me.Button6)
        Me.Box2.Items.Add(Me.Button7)
        Me.Box2.Name = "Box2"
        '
        'Button5
        '
        Me.Button5.Label = "Listeyi yan yana yaz"
        Me.Button5.Name = "Button5"
        Me.Button5.OfficeImageId = "SharePointListsWorkOffline"
        Me.Button5.ScreenTip = "Listeyi yan yana yazma"
        Me.Button5.ShowImage = True
        Me.Button5.SuperTip = resources.GetString("Button5.SuperTip")
        '
        'Button6
        '
        Me.Button6.Label = "Listeyi altalta yaz"
        Me.Button6.Name = "Button6"
        Me.Button6.OfficeImageId = "ListToolView"
        Me.Button6.ScreenTip = "Listeyi altalta yazma"
        Me.Button6.ShowImage = True
        Me.Button6.SuperTip = resources.GetString("Button6.SuperTip")
        '
        'Button7
        '
        Me.Button7.Label = "Çoklu Rank"
        Me.Button7.Name = "Button7"
        Me.Button7.OfficeImageId = "SortByDate"
        Me.Button7.ScreenTip = "Çoklu rank"
        Me.Button7.ShowImage = True
        Me.Button7.SuperTip = "2 kritere göre sıralama yapar. Excelde varolmayan ama olsaydı RANKIF adını alacak" &
    " olan fonksiyon mantığıyla çalışır. (Ör: Bir bölgedeki şubelerin belli bir üründ" &
    "eki hacmine göre sıralaması gibi.)"
        '
        'Group5
        '
        Me.Group5.Items.Add(Me.Gallery1)
        Me.Group5.Label = "Hızlı İşlem"
        Me.Group5.Name = "Group5"
        '
        'Gallery1
        '
        Me.Gallery1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Gallery1.Image = Global.Excelent.My.Resources.Resources._4islem2
        RibbonDropDownItemImpl30.Label = "x1.000.000"
        RibbonDropDownItemImpl31.Label = "x1.000"
        RibbonDropDownItemImpl32.Label = "x?"
        RibbonDropDownItemImpl33.Label = "/1.000.000"
        RibbonDropDownItemImpl34.Label = "/1.000"
        RibbonDropDownItemImpl35.Label = "/?"
        RibbonDropDownItemImpl36.Label = "+?"
        RibbonDropDownItemImpl37.Label = "-?"
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl30)
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl31)
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl32)
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl33)
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl34)
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl35)
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl36)
        Me.Gallery1.Items.Add(RibbonDropDownItemImpl37)
        Me.Gallery1.Label = "Hızlı İşlem"
        Me.Gallery1.Name = "Gallery1"
        Me.Gallery1.ScreenTip = "Hızlı İşlem"
        Me.Gallery1.ShowImage = True
        Me.Gallery1.SuperTip = "Seçilen bölgedeki tüm rakamları belli bir sayıyla çarpmanızı/bölmenizi/toplamanız" &
    "ı veya çıkarmanızı sağlar. Ör:Seçilen bölgedeki tüm rakamları 1000 ile tek sefer" &
    "de çarpabilirsinz."
        '
        'grpFrequentFile
        '
        Me.grpFrequentFile.DialogLauncher = RibbonDialogLauncherImpl2
        Me.grpFrequentFile.Items.Add(Me.mnFrequentFile)
        Me.grpFrequentFile.Label = "Sık Kullanım"
        Me.grpFrequentFile.Name = "grpFrequentFile"
        '
        'mnFrequentFile
        '
        Me.mnFrequentFile.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.mnFrequentFile.Items.Add(Me.btnFreqDosya1)
        Me.mnFrequentFile.Items.Add(Me.btnFreqDosya2)
        Me.mnFrequentFile.Items.Add(Me.btnFreqDosya3)
        Me.mnFrequentFile.Items.Add(Me.btnFreqDosya4)
        Me.mnFrequentFile.Items.Add(Me.btnFreqDosya5)
        Me.mnFrequentFile.Label = "Sık Kullanılan Dosyalar"
        Me.mnFrequentFile.Name = "mnFrequentFile"
        Me.mnFrequentFile.OfficeImageId = "OpenSpecificFile"
        Me.mnFrequentFile.ScreenTip = "Sık Kullanılan Dosyalar"
        Me.mnFrequentFile.ShowImage = True
        Me.mnFrequentFile.SuperTip = "Sık kullandığınız dosyaları buraya ekleyerek onlara erişiminizi hızlandırabilirsi" &
    "niz. (5 adete kadar dosyayı tanımlamak için bu grubun sağ alt köşesindeki küçük " &
    "oka tıklayınız)"
        '
        'btnFreqDosya1
        '
        Me.btnFreqDosya1.Label = ""
        Me.btnFreqDosya1.Name = "btnFreqDosya1"
        Me.btnFreqDosya1.ShowImage = True
        '
        'btnFreqDosya2
        '
        Me.btnFreqDosya2.Label = ""
        Me.btnFreqDosya2.Name = "btnFreqDosya2"
        Me.btnFreqDosya2.ShowImage = True
        '
        'btnFreqDosya3
        '
        Me.btnFreqDosya3.Label = ""
        Me.btnFreqDosya3.Name = "btnFreqDosya3"
        Me.btnFreqDosya3.ShowImage = True
        '
        'btnFreqDosya4
        '
        Me.btnFreqDosya4.Label = ""
        Me.btnFreqDosya4.Name = "btnFreqDosya4"
        Me.btnFreqDosya4.ShowImage = True
        '
        'btnFreqDosya5
        '
        Me.btnFreqDosya5.Label = ""
        Me.btnFreqDosya5.Name = "btnFreqDosya5"
        Me.btnFreqDosya5.ShowImage = True
        '
        'Group3
        '
        Me.Group3.Items.Add(Me.Menu1)
        Me.Group3.Label = "Yardım"
        Me.Group3.Name = "Group3"
        '
        'Menu1
        '
        Me.Menu1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Menu1.Items.Add(Me.Button12)
        Me.Menu1.Items.Add(Me.Button13)
        Me.Menu1.Label = "Yardım"
        Me.Menu1.Name = "Menu1"
        Me.Menu1.OfficeImageId = "HelpLaunch"
        Me.Menu1.ShowImage = True
        '
        'Button12
        '
        Me.Button12.Label = "Hakkında"
        Me.Button12.Name = "Button12"
        Me.Button12.ShowImage = True
        '
        'Button13
        '
        Me.Button13.Label = "KullanımKılavuzu"
        Me.Button13.Name = "Button13"
        Me.Button13.ShowImage = True
        '
        'rbExcelent
        '
        Me.Name = "rbExcelent"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.grpMail.ResumeLayout(False)
        Me.grpMail.PerformLayout()
        Me.grpHazirLookup.ResumeLayout(False)
        Me.grpHazirLookup.PerformLayout()
        Me.Group6.ResumeLayout(False)
        Me.Group6.PerformLayout()
        Me.Group4.ResumeLayout(False)
        Me.Group4.PerformLayout()
        Me.Box1.ResumeLayout(False)
        Me.Box1.PerformLayout()
        Me.Box2.ResumeLayout(False)
        Me.Box2.PerformLayout()
        Me.Group5.ResumeLayout(False)
        Me.Group5.PerformLayout()
        Me.grpFrequentFile.ResumeLayout(False)
        Me.grpFrequentFile.PerformLayout()
        Me.Group3.ResumeLayout(False)
        Me.Group3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btnStandartBol As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnCokSutunluBol As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpHazirLookup As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Group3 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Group4 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents DropDown1 As Microsoft.Office.Tools.Ribbon.RibbonDropDown
    Friend WithEvents DropDown2 As Microsoft.Office.Tools.Ribbon.RibbonDropDown
    Friend WithEvents DropDown3 As Microsoft.Office.Tools.Ribbon.RibbonDropDown
    Friend WithEvents Box1 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents btnPivotOtodoldur As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button3 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Separator3 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents Box2 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents Button5 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button6 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button7 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents grpFrequentFile As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents mnFrequentFile As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents btnFreqDosya1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnFreqDosya2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnFreqDosya3 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnFreqDosya4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnFreqDosya5 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnSayfaBirlestir As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button8 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents mnAdetYaz As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents btnFiiliYaz As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnNormVarYok As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Separator6 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents grpMail As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button11 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents mnWB As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents mnWS As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents Group6 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Separator1 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents btnWBsaveall As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnCloseall As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnWBtumuPrint As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnWBrefreshall As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnWBsifreDegis As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnWsPrintnames As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnWsSortalpha As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnWsProtectall As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Menu1 As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents Button12 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button13 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group5 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Gallery1 As Microsoft.Office.Tools.Ribbon.RibbonGallery
    Friend WithEvents btnWsUnprotectall As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnWsilkharicHide As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnShowallhiddens As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Separator2 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents Separator4 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents Separator5 As Microsoft.Office.Tools.Ribbon.RibbonSeparator

End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property rbExcelent() As rbExcelent
        Get
            Return Me.GetRibbon(Of rbExcelent)()
        End Get
    End Property
End Class
