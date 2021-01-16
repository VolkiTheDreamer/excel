Partial Class Ribbon1
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
        Dim RibbonDialogLauncherImpl1 As Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher = Me.Factory.CreateRibbonDialogLauncher
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Button1 = Me.Factory.CreateRibbonButton
        Me.Group8 = Me.Factory.CreateRibbonGroup
        Me.menu1 = Me.Factory.CreateRibbonMenu
        Me.button13 = Me.Factory.CreateRibbonButton
        Me.button14 = Me.Factory.CreateRibbonButton
        Me.menu2 = Me.Factory.CreateRibbonMenu
        Me.menu3 = Me.Factory.CreateRibbonMenu
        Me.button23 = Me.Factory.CreateRibbonButton
        Me.button24 = Me.Factory.CreateRibbonButton
        Me.button25 = Me.Factory.CreateRibbonButton
        Me.button16 = Me.Factory.CreateRibbonButton
        Me.button17 = Me.Factory.CreateRibbonButton
        Me.button18 = Me.Factory.CreateRibbonButton
        Me.button19 = Me.Factory.CreateRibbonButton
        Me.button20 = Me.Factory.CreateRibbonButton
        Me.group6 = Me.Factory.CreateRibbonGroup
        Me.buttonGroup2 = Me.Factory.CreateRibbonButtonGroup
        Me.gallery1 = Me.Factory.CreateRibbonGallery
        Me.gallery2 = Me.Factory.CreateRibbonGallery
        Me.gallery4 = Me.Factory.CreateRibbonGallery
        Me.gallery3 = Me.Factory.CreateRibbonGallery
        Me.group4 = Me.Factory.CreateRibbonGroup
        Me.comboBox1 = Me.Factory.CreateRibbonComboBox
        Me.dropDown1 = Me.Factory.CreateRibbonDropDown
        Me.button15 = Me.Factory.CreateRibbonButton
        Me.button21 = Me.Factory.CreateRibbonButton
        Me.button22 = Me.Factory.CreateRibbonButton
        Me.group7 = Me.Factory.CreateRibbonGroup
        Me.splitButton1 = Me.Factory.CreateRibbonSplitButton
        Me.button26 = Me.Factory.CreateRibbonButton
        Me.button27 = Me.Factory.CreateRibbonButton
        Me.splitButton2 = Me.Factory.CreateRibbonSplitButton
        Me.button28 = Me.Factory.CreateRibbonButton
        Me.button29 = Me.Factory.CreateRibbonButton
        Me.toggleButton1 = Me.Factory.CreateRibbonToggleButton
        Me.Group3 = Me.Factory.CreateRibbonGroup
        Me.button30 = Me.Factory.CreateRibbonButton
        Me.Tab2 = Me.Factory.CreateRibbonTab
        Me.group2 = Me.Factory.CreateRibbonGroup
        Me.button2 = Me.Factory.CreateRibbonButton
        Me.button4 = Me.Factory.CreateRibbonButton
        Me.button5 = Me.Factory.CreateRibbonButton
        Me.separator1 = Me.Factory.CreateRibbonSeparator
        Me.button6 = Me.Factory.CreateRibbonButton
        Me.Group5 = Me.Factory.CreateRibbonGroup
        Me.buttonGroup1 = Me.Factory.CreateRibbonButtonGroup
        Me.button7 = Me.Factory.CreateRibbonButton
        Me.button8 = Me.Factory.CreateRibbonButton
        Me.button9 = Me.Factory.CreateRibbonButton
        Me.box2 = Me.Factory.CreateRibbonBox
        Me.editBox1 = Me.Factory.CreateRibbonEditBox
        Me.checkBox1 = Me.Factory.CreateRibbonCheckBox
        Me.box1 = Me.Factory.CreateRibbonBox
        Me.button10 = Me.Factory.CreateRibbonButton
        Me.button11 = Me.Factory.CreateRibbonButton
        Me.button12 = Me.Factory.CreateRibbonButton
        Me.Tab3 = Me.Factory.CreateRibbonTab
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.Group8.SuspendLayout()
        Me.group6.SuspendLayout()
        Me.buttonGroup2.SuspendLayout()
        Me.group4.SuspendLayout()
        Me.group7.SuspendLayout()
        Me.Group3.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.group2.SuspendLayout()
        Me.Group5.SuspendLayout()
        Me.buttonGroup1.SuspendLayout()
        Me.box2.SuspendLayout()
        Me.box1.SuspendLayout()
        Me.Tab3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.Group8)
        Me.Tab1.Groups.Add(Me.group6)
        Me.Tab1.Groups.Add(Me.group4)
        Me.Tab1.Groups.Add(Me.group7)
        Me.Tab1.Groups.Add(Me.Group3)
        Me.Tab1.Label = "VBNet_Tab1"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.Button1)
        Me.Group1.Label = "Group1"
        Me.Group1.Name = "Group1"
        '
        'Button1
        '
        Me.Button1.Label = "Button1"
        Me.Button1.Name = "Button1"
        '
        'Group8
        '
        Me.Group8.Items.Add(Me.menu1)
        Me.Group8.Items.Add(Me.menu2)
        Me.Group8.Label = "Dosyalar"
        Me.Group8.Name = "Group8"
        '
        'menu1
        '
        Me.menu1.Items.Add(Me.button13)
        Me.menu1.Items.Add(Me.button14)
        Me.menu1.Label = "küçük itemlı menü"
        Me.menu1.Name = "menu1"
        '
        'button13
        '
        Me.button13.Label = "Bütçem"
        Me.button13.Name = "button13"
        Me.button13.ShowImage = True
        '
        'button14
        '
        Me.button14.Label = "Filmler"
        Me.button14.Name = "button14"
        Me.button14.ShowImage = True
        '
        'menu2
        '
        Me.menu2.Items.Add(Me.menu3)
        Me.menu2.Items.Add(Me.button16)
        Me.menu2.Items.Add(Me.button17)
        Me.menu2.Items.Add(Me.button18)
        Me.menu2.Items.Add(Me.button19)
        Me.menu2.Items.Add(Me.button20)
        Me.menu2.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.menu2.Label = "büyük itemlı menü"
        Me.menu2.Name = "menu2"
        '
        'menu3
        '
        Me.menu3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.menu3.Items.Add(Me.button23)
        Me.menu3.Items.Add(Me.button24)
        Me.menu3.Items.Add(Me.button25)
        Me.menu3.Label = "altmenü"
        Me.menu3.Name = "menu3"
        Me.menu3.ShowImage = True
        '
        'button23
        '
        Me.button23.Label = "button23"
        Me.button23.Name = "button23"
        Me.button23.ShowImage = True
        '
        'button24
        '
        Me.button24.Label = "button24"
        Me.button24.Name = "button24"
        Me.button24.ShowImage = True
        '
        'button25
        '
        Me.button25.Label = "button25"
        Me.button25.Name = "button25"
        Me.button25.ShowImage = True
        '
        'button16
        '
        Me.button16.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.button16.Label = "resimsiz"
        Me.button16.Name = "button16"
        Me.button16.ShowImage = True
        '
        'button17
        '
        Me.button17.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.button17.Label = "ofisidli"
        Me.button17.Name = "button17"
        Me.button17.OfficeImageId = "AccessFormDatasheet"
        Me.button17.ShowImage = True
        '
        'button18
        '
        Me.button18.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.button18.Label = "büyük imaj"
        Me.button18.Name = "button18"
        Me.button18.ShowImage = True
        '
        'button19
        '
        Me.button19.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.button19.Label = "küçük imaj"
        Me.button19.Name = "button19"
        Me.button19.ShowImage = True
        '
        'button20
        '
        Me.button20.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.button20.Label = "ico file"
        Me.button20.Name = "button20"
        Me.button20.ShowImage = True
        '
        'group6
        '
        Me.group6.Items.Add(Me.buttonGroup2)
        Me.group6.Items.Add(Me.gallery4)
        Me.group6.Items.Add(Me.gallery3)
        Me.group6.Label = "Galeriler"
        Me.group6.Name = "group6"
        '
        'buttonGroup2
        '
        Me.buttonGroup2.Items.Add(Me.gallery1)
        Me.buttonGroup2.Items.Add(Me.gallery2)
        Me.buttonGroup2.Name = "buttonGroup2"
        '
        'gallery1
        '
        Me.gallery1.ImageName = "Test"
        Me.gallery1.ItemImageSize = New System.Drawing.Size(80, 80)
        RibbonDropDownItemImpl1.Label = "Seçim1_ico"
        RibbonDropDownItemImpl1.OfficeImageId = "_3DSurfacePlasticClassic"
        RibbonDropDownItemImpl2.Label = "Seçim2_icoveimg"
        RibbonDropDownItemImpl2.OfficeImageId = "_3DTiltDownClassic"
        RibbonDropDownItemImpl3.Label = "Seçim3_img"
        Me.gallery1.Items.Add(RibbonDropDownItemImpl1)
        Me.gallery1.Items.Add(RibbonDropDownItemImpl2)
        Me.gallery1.Items.Add(RibbonDropDownItemImpl3)
        Me.gallery1.Label = "gallery1"
        Me.gallery1.Name = "gallery1"
        Me.gallery1.ScreenTip = "ben bir screentipim, aslında bir başlık satırıyım"
        Me.gallery1.ShowImage = True
        Me.gallery1.SuperTip = "ben bir supertip'im, birden fazla satıra yayılırım"
        '
        'gallery2
        '
        Me.gallery2.ImageName = "Zuzu"
        Me.gallery2.ItemImageSize = New System.Drawing.Size(25, 25)
        RibbonDropDownItemImpl4.Label = "Galeri1"
        RibbonDropDownItemImpl4.OfficeImageId = "AccessOnlineLists"
        RibbonDropDownItemImpl5.Label = "Galeri2"
        RibbonDropDownItemImpl5.OfficeImageId = "AddReminder"
        Me.gallery2.Items.Add(RibbonDropDownItemImpl4)
        Me.gallery2.Items.Add(RibbonDropDownItemImpl5)
        Me.gallery2.Label = "gallery2"
        Me.gallery2.Name = "gallery2"
        Me.gallery2.ShowImage = True
        Me.gallery2.ShowItemLabel = False
        Me.gallery2.ShowItemSelection = True
        Me.gallery2.ShowLabel = False
        '
        'gallery4
        '
        RibbonDropDownItemImpl6.Label = "Item0"
        RibbonDropDownItemImpl7.Label = "Item1"
        Me.gallery4.Items.Add(RibbonDropDownItemImpl6)
        Me.gallery4.Items.Add(RibbonDropDownItemImpl7)
        Me.gallery4.Label = "Resimsiz"
        Me.gallery4.Name = "gallery4"
        '
        'gallery3
        '
        Me.gallery3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.gallery3.Label = "gallery3"
        Me.gallery3.Name = "gallery3"
        Me.gallery3.OfficeImageId = "AccessTableContacts"
        Me.gallery3.ShowImage = True
        '
        'group4
        '
        Me.group4.Items.Add(Me.comboBox1)
        Me.group4.Items.Add(Me.dropDown1)
        Me.group4.Label = "combo ve drop"
        Me.group4.Name = "group4"
        '
        'comboBox1
        '
        RibbonDropDownItemImpl8.Label = "Item0"
        RibbonDropDownItemImpl9.Label = "Item1"
        Me.comboBox1.Items.Add(RibbonDropDownItemImpl8)
        Me.comboBox1.Items.Add(RibbonDropDownItemImpl9)
        Me.comboBox1.Label = "comboBox1"
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.OfficeImageId = "AddAccount"
        Me.comboBox1.ShowImage = True
        Me.comboBox1.Text = Nothing
        '
        'dropDown1
        '
        Me.dropDown1.Buttons.Add(Me.button15)
        Me.dropDown1.Buttons.Add(Me.button21)
        Me.dropDown1.Buttons.Add(Me.button22)
        RibbonDropDownItemImpl10.Label = "Item0"
        RibbonDropDownItemImpl10.OfficeImageId = "_3DPerspectiveIncrease"
        RibbonDropDownItemImpl11.Label = "Item1"
        RibbonDropDownItemImpl11.OfficeImageId = "_3DSurfaceWireFrameClassic"
        Me.dropDown1.Items.Add(RibbonDropDownItemImpl10)
        Me.dropDown1.Items.Add(RibbonDropDownItemImpl11)
        Me.dropDown1.Label = "dropDown1"
        Me.dropDown1.Name = "dropDown1"
        Me.dropDown1.ShowImage = True
        '
        'button15
        '
        Me.button15.Label = "button15"
        Me.button15.Name = "button15"
        '
        'button21
        '
        Me.button21.Label = "button21"
        Me.button21.Name = "button21"
        '
        'button22
        '
        Me.button22.Label = "button22"
        Me.button22.Name = "button22"
        '
        'group7
        '
        Me.group7.Items.Add(Me.splitButton1)
        Me.group7.Items.Add(Me.splitButton2)
        Me.group7.Items.Add(Me.toggleButton1)
        Me.group7.Label = "group7"
        Me.group7.Name = "group7"
        '
        'splitButton1
        '
        Me.splitButton1.Items.Add(Me.button26)
        Me.splitButton1.Items.Add(Me.button27)
        Me.splitButton1.Label = "splitButton1"
        Me.splitButton1.Name = "splitButton1"
        '
        'button26
        '
        Me.button26.Label = "button26"
        Me.button26.Name = "button26"
        Me.button26.ShowImage = True
        '
        'button27
        '
        Me.button27.Label = "button27"
        Me.button27.Name = "button27"
        Me.button27.ShowImage = True
        '
        'splitButton2
        '
        Me.splitButton2.ButtonType = Microsoft.Office.Tools.Ribbon.RibbonButtonType.ToggleButton
        Me.splitButton2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.splitButton2.Items.Add(Me.button28)
        Me.splitButton2.Items.Add(Me.button29)
        Me.splitButton2.Label = "splitButton2"
        Me.splitButton2.Name = "splitButton2"
        '
        'button28
        '
        Me.button28.Label = "button28"
        Me.button28.Name = "button28"
        Me.button28.ShowImage = True
        '
        'button29
        '
        Me.button29.Label = "button29"
        Me.button29.Name = "button29"
        Me.button29.ShowImage = True
        '
        'toggleButton1
        '
        Me.toggleButton1.Label = "toggleButton1"
        Me.toggleButton1.Name = "toggleButton1"
        '
        'Group3
        '
        Me.Group3.Items.Add(Me.button30)
        Me.Group3.Label = "TaskPaneler"
        Me.Group3.Name = "Group3"
        '
        'button30
        '
        Me.button30.Label = "TaskPane1"
        Me.button30.Name = "button30"
        '
        'Tab2
        '
        Me.Tab2.Groups.Add(Me.group2)
        Me.Tab2.Groups.Add(Me.Group5)
        Me.Tab2.Label = "VBNet_Tab2"
        Me.Tab2.Name = "Tab2"
        '
        'group2
        '
        Me.group2.DialogLauncher = RibbonDialogLauncherImpl1
        Me.group2.Items.Add(Me.button2)
        Me.group2.Items.Add(Me.button4)
        Me.group2.Items.Add(Me.button5)
        Me.group2.Items.Add(Me.separator1)
        Me.group2.Items.Add(Me.button6)
        Me.group2.Label = "VSTO test"
        Me.group2.Name = "group2"
        '
        'button2
        '
        Me.button2.Label = "dosya yarat"
        Me.button2.Name = "button2"
        '
        'button4
        '
        Me.button4.Label = "dosyaac"
        Me.button4.Name = "button4"
        '
        'button5
        '
        Me.button5.Label = "hücre bilgisi"
        Me.button5.Name = "button5"
        '
        'separator1
        '
        Me.separator1.Name = "separator1"
        '
        'button6
        '
        Me.button6.Label = "range işleri"
        Me.button6.Name = "button6"
        '
        'Group5
        '
        Me.Group5.Items.Add(Me.buttonGroup1)
        Me.Group5.Items.Add(Me.box2)
        Me.Group5.Items.Add(Me.box1)
        Me.Group5.Label = "group3"
        Me.Group5.Name = "Group5"
        '
        'buttonGroup1
        '
        Me.buttonGroup1.Items.Add(Me.button7)
        Me.buttonGroup1.Items.Add(Me.button8)
        Me.buttonGroup1.Items.Add(Me.button9)
        Me.buttonGroup1.Name = "buttonGroup1"
        '
        'button7
        '
        Me.button7.Label = "button7"
        Me.button7.Name = "button7"
        '
        'button8
        '
        Me.button8.Label = "button8"
        Me.button8.Name = "button8"
        '
        'button9
        '
        Me.button9.Label = "button9"
        Me.button9.Name = "button9"
        '
        'box2
        '
        Me.box2.Items.Add(Me.editBox1)
        Me.box2.Items.Add(Me.checkBox1)
        Me.box2.Name = "box2"
        '
        'editBox1
        '
        Me.editBox1.Label = "editBox1"
        Me.editBox1.Name = "editBox1"
        Me.editBox1.Text = Nothing
        '
        'checkBox1
        '
        Me.checkBox1.Label = "checkBox1"
        Me.checkBox1.Name = "checkBox1"
        '
        'box1
        '
        Me.box1.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.box1.Items.Add(Me.button10)
        Me.box1.Items.Add(Me.button11)
        Me.box1.Items.Add(Me.button12)
        Me.box1.Name = "box1"
        '
        'button10
        '
        Me.button10.Label = "button10"
        Me.button10.Name = "button10"
        '
        'button11
        '
        Me.button11.Label = "button11"
        Me.button11.Name = "button11"
        '
        'button12
        '
        Me.button12.Label = "button12"
        Me.button12.Name = "button12"
        '
        'Tab3
        '
        Me.Tab3.Label = "VBNet_Tab3"
        Me.Tab3.Name = "Tab3"
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.Tab1)
        Me.Tabs.Add(Me.Tab2)
        Me.Tabs.Add(Me.Tab3)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.Group8.ResumeLayout(False)
        Me.Group8.PerformLayout()
        Me.group6.ResumeLayout(False)
        Me.group6.PerformLayout()
        Me.buttonGroup2.ResumeLayout(False)
        Me.buttonGroup2.PerformLayout()
        Me.group4.ResumeLayout(False)
        Me.group4.PerformLayout()
        Me.group7.ResumeLayout(False)
        Me.group7.PerformLayout()
        Me.Group3.ResumeLayout(False)
        Me.Group3.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.Tab2.PerformLayout()
        Me.group2.ResumeLayout(False)
        Me.group2.PerformLayout()
        Me.Group5.ResumeLayout(False)
        Me.Group5.PerformLayout()
        Me.buttonGroup1.ResumeLayout(False)
        Me.buttonGroup1.PerformLayout()
        Me.box2.ResumeLayout(False)
        Me.box2.PerformLayout()
        Me.box1.ResumeLayout(False)
        Me.box1.PerformLayout()
        Me.Tab3.ResumeLayout(False)
        Me.Tab3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Button1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Tab2 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group8 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents menu1 As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents button13 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button14 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents menu2 As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents menu3 As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents button23 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button24 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button25 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button16 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button17 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button18 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button19 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button20 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents group6 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents buttonGroup2 As Microsoft.Office.Tools.Ribbon.RibbonButtonGroup
    Friend WithEvents gallery1 As Microsoft.Office.Tools.Ribbon.RibbonGallery
    Friend WithEvents gallery2 As Microsoft.Office.Tools.Ribbon.RibbonGallery
    Friend WithEvents gallery4 As Microsoft.Office.Tools.Ribbon.RibbonGallery
    Friend WithEvents gallery3 As Microsoft.Office.Tools.Ribbon.RibbonGallery
    Friend WithEvents group4 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents comboBox1 As Microsoft.Office.Tools.Ribbon.RibbonComboBox
    Friend WithEvents dropDown1 As Microsoft.Office.Tools.Ribbon.RibbonDropDown
    Private WithEvents button15 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Private WithEvents button21 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Private WithEvents button22 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents group7 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents splitButton1 As Microsoft.Office.Tools.Ribbon.RibbonSplitButton
    Friend WithEvents button26 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button27 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents splitButton2 As Microsoft.Office.Tools.Ribbon.RibbonSplitButton
    Friend WithEvents button28 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button29 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents toggleButton1 As Microsoft.Office.Tools.Ribbon.RibbonToggleButton
    Friend WithEvents Group3 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents button30 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button5 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents separator1 As Microsoft.Office.Tools.Ribbon.RibbonSeparator
    Friend WithEvents button6 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group5 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents buttonGroup1 As Microsoft.Office.Tools.Ribbon.RibbonButtonGroup
    Friend WithEvents button7 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button8 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button9 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents box2 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents editBox1 As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents checkBox1 As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents box1 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents button10 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button11 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents button12 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Tab3 As Microsoft.Office.Tools.Ribbon.RibbonTab
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
