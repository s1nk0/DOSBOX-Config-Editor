<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabSdl = New System.Windows.Forms.TabPage()
        Me.usescancodesComboBox1 = New System.Windows.Forms.ComboBox()
        Me.usescancodesLabel2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mapperfileTextBox2 = New System.Windows.Forms.TextBox()
        Me.mapperfileLabel2 = New System.Windows.Forms.Label()
        Me.priorityComboBox2 = New System.Windows.Forms.ComboBox()
        Me.priorityComboBox1 = New System.Windows.Forms.ComboBox()
        Me.priorityLabel2 = New System.Windows.Forms.Label()
        Me.waitonerrorComboBox1 = New System.Windows.Forms.ComboBox()
        Me.waitonerrorLabel2 = New System.Windows.Forms.Label()
        Me.sensitivityNumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.sensitivityLabel2 = New System.Windows.Forms.Label()
        Me.autolockComboBox1 = New System.Windows.Forms.ComboBox()
        Me.autolockLabel2 = New System.Windows.Forms.Label()
        Me.outputComboBox1 = New System.Windows.Forms.ComboBox()
        Me.outputLabel2 = New System.Windows.Forms.Label()
        Me.windowresolutionComboBox1 = New System.Windows.Forms.ComboBox()
        Me.windowresolutionLabel2 = New System.Windows.Forms.Label()
        Me.fullresolutionComboBox1 = New System.Windows.Forms.ComboBox()
        Me.fullresolutionLabel = New System.Windows.Forms.Label()
        Me.fulldoubleComboBox1 = New System.Windows.Forms.ComboBox()
        Me.fulldoubleLabel1 = New System.Windows.Forms.Label()
        Me.fullscreenComboBox1 = New System.Windows.Forms.ComboBox()
        Me.fullscreenLabel1 = New System.Windows.Forms.Label()
        Me.tabDosbox = New System.Windows.Forms.TabPage()
        Me.memsizeTextBox2 = New System.Windows.Forms.TextBox()
        Me.memsizeLabel2 = New System.Windows.Forms.Label()
        Me.capturesButton2 = New System.Windows.Forms.Button()
        Me.capturesTextBox2 = New System.Windows.Forms.TextBox()
        Me.capturesLabel2 = New System.Windows.Forms.Label()
        Me.machineComboBox1 = New System.Windows.Forms.ComboBox()
        Me.machineLabel2 = New System.Windows.Forms.Label()
        Me.languageTextBox2 = New System.Windows.Forms.TextBox()
        Me.languageLabel2 = New System.Windows.Forms.Label()
        Me.tabRender = New System.Windows.Forms.TabPage()
        Me.scalerComboBox1 = New System.Windows.Forms.ComboBox()
        Me.scalerLabel2 = New System.Windows.Forms.Label()
        Me.aspect_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.aspect_Label2 = New System.Windows.Forms.Label()
        Me.frameskip_TextBox2 = New System.Windows.Forms.TextBox()
        Me.frameskip_Label2 = New System.Windows.Forms.Label()
        Me.tabCpu = New System.Windows.Forms.TabPage()
        Me.cycledownTextBox2 = New System.Windows.Forms.TextBox()
        Me.cycledownLabel2 = New System.Windows.Forms.Label()
        Me.cycleupTextBox2 = New System.Windows.Forms.TextBox()
        Me.cycleupLabel2 = New System.Windows.Forms.Label()
        Me.cyclesComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cyclesLabel2 = New System.Windows.Forms.Label()
        Me.cputypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cputypeLabel2 = New System.Windows.Forms.Label()
        Me.coreComboBox1 = New System.Windows.Forms.ComboBox()
        Me.coreLabel2 = New System.Windows.Forms.Label()
        Me.tabMixer = New System.Windows.Forms.TabPage()
        Me.prebufferTextBox2 = New System.Windows.Forms.TextBox()
        Me.prebufferLabel2 = New System.Windows.Forms.Label()
        Me.blocksizeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.blocksizeLabel2 = New System.Windows.Forms.Label()
        Me.rateComboBox1 = New System.Windows.Forms.ComboBox()
        Me.rateLabel2 = New System.Windows.Forms.Label()
        Me.nosoundComboBox1 = New System.Windows.Forms.ComboBox()
        Me.nosoundLabel2 = New System.Windows.Forms.Label()
        Me.tabMidi = New System.Windows.Forms.TabPage()
        Me.midiconfigTextBox2 = New System.Windows.Forms.TextBox()
        Me.midiconfigLabel2 = New System.Windows.Forms.Label()
        Me.midideviceComboBox1 = New System.Windows.Forms.ComboBox()
        Me.midideviceLabel2 = New System.Windows.Forms.Label()
        Me.mpu401ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.mpu401Label2 = New System.Windows.Forms.Label()
        Me.tabSblaster = New System.Windows.Forms.TabPage()
        Me.irqComboBox1 = New System.Windows.Forms.ComboBox()
        Me.irqLabel2 = New System.Windows.Forms.Label()
        Me.oplrateComboBox1 = New System.Windows.Forms.ComboBox()
        Me.oplrateLabel2 = New System.Windows.Forms.Label()
        Me.oplemuComboBox1 = New System.Windows.Forms.ComboBox()
        Me.oplemuLabel2 = New System.Windows.Forms.Label()
        Me.oplmodeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.oplmodeLabel2 = New System.Windows.Forms.Label()
        Me.sbmixerComboBox1 = New System.Windows.Forms.ComboBox()
        Me.sbmixerLabel2 = New System.Windows.Forms.Label()
        Me.hdmaComboBox1 = New System.Windows.Forms.ComboBox()
        Me.hdmaLabel2 = New System.Windows.Forms.Label()
        Me.dmaComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dmaLabel2 = New System.Windows.Forms.Label()
        Me.sbbaseComboBox1 = New System.Windows.Forms.ComboBox()
        Me.sbbaseLabel2 = New System.Windows.Forms.Label()
        Me.sbtypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.sbtypeLabel2 = New System.Windows.Forms.Label()
        Me.tabGus = New System.Windows.Forms.TabPage()
        Me.gusComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gusLabel2 = New System.Windows.Forms.Label()
        Me.tabSpeaker = New System.Windows.Forms.TabPage()
        Me.tabJoystick = New System.Windows.Forms.TabPage()
        Me.tabSerial = New System.Windows.Forms.TabPage()
        Me.tabDos = New System.Windows.Forms.TabPage()
        Me.tabIpx = New System.Windows.Forms.TabPage()
        Me.tabAutoexec = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.confEditorTab = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConfDirectlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadDosBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfWikiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.gusrateComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gusrateLabel2 = New System.Windows.Forms.Label()
        Me.gusbaseComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gusbaseLabel2 = New System.Windows.Forms.Label()
        Me.gusirqComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gusirqLabel2 = New System.Windows.Forms.Label()
        Me.gusdmaComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gusdmaLabel2 = New System.Windows.Forms.Label()
        Me.ultradirTextBox2 = New System.Windows.Forms.TextBox()
        Me.ultradirLabel2 = New System.Windows.Forms.Label()
        Me.pcspeakerComboBox1 = New System.Windows.Forms.ComboBox()
        Me.pcspeakerLabel2 = New System.Windows.Forms.Label()
        Me.pcrateComboBox1 = New System.Windows.Forms.ComboBox()
        Me.pcrateLabel2 = New System.Windows.Forms.Label()
        Me.tandyComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tandyLabel2 = New System.Windows.Forms.Label()
        Me.tandyrateComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tandyrateLabel2 = New System.Windows.Forms.Label()
        Me.disneyComboBox1 = New System.Windows.Forms.ComboBox()
        Me.disneyLabel2 = New System.Windows.Forms.Label()
        Me.joysticktypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.joysticktypeLabel2 = New System.Windows.Forms.Label()
        Me.timedComboBox1 = New System.Windows.Forms.ComboBox()
        Me.timedLabel2 = New System.Windows.Forms.Label()
        Me.autofireComboBox1 = New System.Windows.Forms.ComboBox()
        Me.autofireLabel2 = New System.Windows.Forms.Label()
        Me.swap34ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.swap34Label2 = New System.Windows.Forms.Label()
        Me.buttonwrapComboBox1 = New System.Windows.Forms.ComboBox()
        Me.buttonwrapLabel2 = New System.Windows.Forms.Label()
        Me.serial1ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.serial1Label2 = New System.Windows.Forms.Label()
        Me.serial2ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.serial2Label2 = New System.Windows.Forms.Label()
        Me.serial3ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.serial3Label2 = New System.Windows.Forms.Label()
        Me.serial4ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.serial4Label2 = New System.Windows.Forms.Label()
        Me.xmsComboBox1 = New System.Windows.Forms.ComboBox()
        Me.xmsLabel2 = New System.Windows.Forms.Label()
        Me.emsComboBox1 = New System.Windows.Forms.ComboBox()
        Me.emsLabel2 = New System.Windows.Forms.Label()
        Me.umbComboBox1 = New System.Windows.Forms.ComboBox()
        Me.umbLabel2 = New System.Windows.Forms.Label()
        Me.keyboardlayoutLabel2 = New System.Windows.Forms.Label()
        Me.keyboardlayoutComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ipxComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ipxLabel2 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.tabSdl.SuspendLayout()
        CType(Me.sensitivityNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDosbox.SuspendLayout()
        Me.tabRender.SuspendLayout()
        Me.tabCpu.SuspendLayout()
        Me.tabMixer.SuspendLayout()
        Me.tabMidi.SuspendLayout()
        Me.tabSblaster.SuspendLayout()
        Me.tabGus.SuspendLayout()
        Me.tabSpeaker.SuspendLayout()
        Me.tabJoystick.SuspendLayout()
        Me.tabSerial.SuspendLayout()
        Me.tabDos.SuspendLayout()
        Me.tabIpx.SuspendLayout()
        Me.tabAutoexec.SuspendLayout()
        Me.confEditorTab.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabSdl)
        Me.TabControl.Controls.Add(Me.tabDosbox)
        Me.TabControl.Controls.Add(Me.tabRender)
        Me.TabControl.Controls.Add(Me.tabCpu)
        Me.TabControl.Controls.Add(Me.tabMixer)
        Me.TabControl.Controls.Add(Me.tabMidi)
        Me.TabControl.Controls.Add(Me.tabSblaster)
        Me.TabControl.Controls.Add(Me.tabGus)
        Me.TabControl.Controls.Add(Me.tabSpeaker)
        Me.TabControl.Controls.Add(Me.tabJoystick)
        Me.TabControl.Controls.Add(Me.tabSerial)
        Me.TabControl.Controls.Add(Me.tabDos)
        Me.TabControl.Controls.Add(Me.tabIpx)
        Me.TabControl.Controls.Add(Me.tabAutoexec)
        Me.TabControl.Controls.Add(Me.confEditorTab)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.ImageList = Me.icons
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(598, 427)
        Me.TabControl.TabIndex = 0
        '
        'tabSdl
        '
        Me.tabSdl.Controls.Add(Me.usescancodesComboBox1)
        Me.tabSdl.Controls.Add(Me.usescancodesLabel2)
        Me.tabSdl.Controls.Add(Me.Button1)
        Me.tabSdl.Controls.Add(Me.mapperfileTextBox2)
        Me.tabSdl.Controls.Add(Me.mapperfileLabel2)
        Me.tabSdl.Controls.Add(Me.priorityComboBox2)
        Me.tabSdl.Controls.Add(Me.priorityComboBox1)
        Me.tabSdl.Controls.Add(Me.priorityLabel2)
        Me.tabSdl.Controls.Add(Me.waitonerrorComboBox1)
        Me.tabSdl.Controls.Add(Me.waitonerrorLabel2)
        Me.tabSdl.Controls.Add(Me.sensitivityNumericUpDown1)
        Me.tabSdl.Controls.Add(Me.sensitivityLabel2)
        Me.tabSdl.Controls.Add(Me.autolockComboBox1)
        Me.tabSdl.Controls.Add(Me.autolockLabel2)
        Me.tabSdl.Controls.Add(Me.outputComboBox1)
        Me.tabSdl.Controls.Add(Me.outputLabel2)
        Me.tabSdl.Controls.Add(Me.windowresolutionComboBox1)
        Me.tabSdl.Controls.Add(Me.windowresolutionLabel2)
        Me.tabSdl.Controls.Add(Me.fullresolutionComboBox1)
        Me.tabSdl.Controls.Add(Me.fullresolutionLabel)
        Me.tabSdl.Controls.Add(Me.fulldoubleComboBox1)
        Me.tabSdl.Controls.Add(Me.fulldoubleLabel1)
        Me.tabSdl.Controls.Add(Me.fullscreenComboBox1)
        Me.tabSdl.Controls.Add(Me.fullscreenLabel1)
        Me.tabSdl.ImageKey = "computer-4.png"
        Me.tabSdl.Location = New System.Drawing.Point(4, 42)
        Me.tabSdl.Name = "tabSdl"
        Me.tabSdl.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSdl.Size = New System.Drawing.Size(590, 381)
        Me.tabSdl.TabIndex = 0
        Me.tabSdl.Text = "[sdl]"
        Me.tabSdl.UseVisualStyleBackColor = True
        '
        'usescancodesComboBox1
        '
        Me.usescancodesComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usescancodesComboBox1.FormattingEnabled = True
        Me.usescancodesComboBox1.Location = New System.Drawing.Point(101, 65)
        Me.usescancodesComboBox1.Name = "usescancodesComboBox1"
        Me.usescancodesComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.usescancodesComboBox1.TabIndex = 25
        '
        'usescancodesLabel2
        '
        Me.usescancodesLabel2.AutoSize = True
        Me.usescancodesLabel2.Location = New System.Drawing.Point(98, 49)
        Me.usescancodesLabel2.Name = "usescancodesLabel2"
        Me.usescancodesLabel2.Size = New System.Drawing.Size(76, 13)
        Me.usescancodesLabel2.TabIndex = 24
        Me.usescancodesLabel2.Text = "usescancodes"
        Me.ToolTip1.SetToolTip(Me.usescancodesLabel2, "Avoid usage of symkeys, might not work on all operating systems.")
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(287, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 27)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Browse..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mapperfileTextBox2
        '
        Me.mapperfileTextBox2.Location = New System.Drawing.Point(101, 25)
        Me.mapperfileTextBox2.Name = "mapperfileTextBox2"
        Me.mapperfileTextBox2.Size = New System.Drawing.Size(180, 20)
        Me.mapperfileTextBox2.TabIndex = 22
        '
        'mapperfileLabel2
        '
        Me.mapperfileLabel2.AutoSize = True
        Me.mapperfileLabel2.Location = New System.Drawing.Point(98, 9)
        Me.mapperfileLabel2.Name = "mapperfileLabel2"
        Me.mapperfileLabel2.Size = New System.Drawing.Size(55, 13)
        Me.mapperfileLabel2.TabIndex = 21
        Me.mapperfileLabel2.Text = "mapperfile"
        Me.ToolTip1.SetToolTip(Me.mapperfileLabel2, "File used to load/save the key/event mappings from. Resetmapper only works with t" &
        "he defaul value.")
        '
        'priorityComboBox2
        '
        Me.priorityComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.priorityComboBox2.FormattingEnabled = True
        Me.priorityComboBox2.Location = New System.Drawing.Point(101, 344)
        Me.priorityComboBox2.Name = "priorityComboBox2"
        Me.priorityComboBox2.Size = New System.Drawing.Size(84, 21)
        Me.priorityComboBox2.TabIndex = 20
        '
        'priorityComboBox1
        '
        Me.priorityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.priorityComboBox1.FormattingEnabled = True
        Me.priorityComboBox1.Location = New System.Drawing.Point(11, 344)
        Me.priorityComboBox1.Name = "priorityComboBox1"
        Me.priorityComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.priorityComboBox1.TabIndex = 19
        '
        'priorityLabel2
        '
        Me.priorityLabel2.AutoSize = True
        Me.priorityLabel2.Location = New System.Drawing.Point(8, 328)
        Me.priorityLabel2.Name = "priorityLabel2"
        Me.priorityLabel2.Size = New System.Drawing.Size(37, 13)
        Me.priorityLabel2.TabIndex = 18
        Me.priorityLabel2.Text = "priority"
        Me.ToolTip1.SetToolTip(Me.priorityLabel2, resources.GetString("priorityLabel2.ToolTip"))
        '
        'waitonerrorComboBox1
        '
        Me.waitonerrorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.waitonerrorComboBox1.FormattingEnabled = True
        Me.waitonerrorComboBox1.Location = New System.Drawing.Point(11, 304)
        Me.waitonerrorComboBox1.Name = "waitonerrorComboBox1"
        Me.waitonerrorComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.waitonerrorComboBox1.TabIndex = 17
        '
        'waitonerrorLabel2
        '
        Me.waitonerrorLabel2.AutoSize = True
        Me.waitonerrorLabel2.Location = New System.Drawing.Point(8, 288)
        Me.waitonerrorLabel2.Name = "waitonerrorLabel2"
        Me.waitonerrorLabel2.Size = New System.Drawing.Size(59, 13)
        Me.waitonerrorLabel2.TabIndex = 16
        Me.waitonerrorLabel2.Text = "waitonerror"
        Me.ToolTip1.SetToolTip(Me.waitonerrorLabel2, "Wait before closing the console if dosbox has an error.")
        '
        'sensitivityNumericUpDown1
        '
        Me.sensitivityNumericUpDown1.Location = New System.Drawing.Point(11, 265)
        Me.sensitivityNumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sensitivityNumericUpDown1.Name = "sensitivityNumericUpDown1"
        Me.sensitivityNumericUpDown1.Size = New System.Drawing.Size(45, 20)
        Me.sensitivityNumericUpDown1.TabIndex = 15
        Me.sensitivityNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sensitivityNumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'sensitivityLabel2
        '
        Me.sensitivityLabel2.AutoSize = True
        Me.sensitivityLabel2.Location = New System.Drawing.Point(8, 249)
        Me.sensitivityLabel2.Name = "sensitivityLabel2"
        Me.sensitivityLabel2.Size = New System.Drawing.Size(52, 13)
        Me.sensitivityLabel2.TabIndex = 14
        Me.sensitivityLabel2.Text = "sensitivity"
        Me.ToolTip1.SetToolTip(Me.sensitivityLabel2, "Mouse sensitivity.")
        '
        'autolockComboBox1
        '
        Me.autolockComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.autolockComboBox1.FormattingEnabled = True
        Me.autolockComboBox1.Location = New System.Drawing.Point(11, 225)
        Me.autolockComboBox1.Name = "autolockComboBox1"
        Me.autolockComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.autolockComboBox1.TabIndex = 13
        '
        'autolockLabel2
        '
        Me.autolockLabel2.AutoSize = True
        Me.autolockLabel2.Location = New System.Drawing.Point(8, 209)
        Me.autolockLabel2.Name = "autolockLabel2"
        Me.autolockLabel2.Size = New System.Drawing.Size(48, 13)
        Me.autolockLabel2.TabIndex = 12
        Me.autolockLabel2.Text = "autolock"
        Me.ToolTip1.SetToolTip(Me.autolockLabel2, "Mouse will automatically lock, if you click on the screen. (Press CTRL-F10 to unl" &
        "ock)")
        '
        'outputComboBox1
        '
        Me.outputComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.outputComboBox1.FormattingEnabled = True
        Me.outputComboBox1.Location = New System.Drawing.Point(11, 185)
        Me.outputComboBox1.Name = "outputComboBox1"
        Me.outputComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.outputComboBox1.TabIndex = 11
        '
        'outputLabel2
        '
        Me.outputLabel2.AutoSize = True
        Me.outputLabel2.Location = New System.Drawing.Point(8, 169)
        Me.outputLabel2.Name = "outputLabel2"
        Me.outputLabel2.Size = New System.Drawing.Size(39, 13)
        Me.outputLabel2.TabIndex = 10
        Me.outputLabel2.Text = "Label1"
        Me.ToolTip1.SetToolTip(Me.outputLabel2, "What video system to use for output." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#                   Possible values: surfac" &
        "e, overlay, opengl, openglnb, ddraw.")
        '
        'windowresolutionComboBox1
        '
        Me.windowresolutionComboBox1.FormattingEnabled = True
        Me.windowresolutionComboBox1.Location = New System.Drawing.Point(11, 145)
        Me.windowresolutionComboBox1.Name = "windowresolutionComboBox1"
        Me.windowresolutionComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.windowresolutionComboBox1.TabIndex = 9
        '
        'windowresolutionLabel2
        '
        Me.windowresolutionLabel2.AutoSize = True
        Me.windowresolutionLabel2.Location = New System.Drawing.Point(8, 129)
        Me.windowresolutionLabel2.Name = "windowresolutionLabel2"
        Me.windowresolutionLabel2.Size = New System.Drawing.Size(39, 13)
        Me.windowresolutionLabel2.TabIndex = 8
        Me.windowresolutionLabel2.Text = "Label1"
        Me.ToolTip1.SetToolTip(Me.windowresolutionLabel2, "Scale the window to this size IF the output device supports hardware scaling." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(o" &
        "utput=surface does not!)")
        '
        'fullresolutionComboBox1
        '
        Me.fullresolutionComboBox1.FormattingEnabled = True
        Me.fullresolutionComboBox1.Location = New System.Drawing.Point(11, 105)
        Me.fullresolutionComboBox1.Name = "fullresolutionComboBox1"
        Me.fullresolutionComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.fullresolutionComboBox1.TabIndex = 7
        '
        'fullresolutionLabel
        '
        Me.fullresolutionLabel.AutoSize = True
        Me.fullresolutionLabel.Location = New System.Drawing.Point(8, 89)
        Me.fullresolutionLabel.Name = "fullresolutionLabel"
        Me.fullresolutionLabel.Size = New System.Drawing.Size(39, 13)
        Me.fullresolutionLabel.TabIndex = 6
        Me.fullresolutionLabel.Text = "Label1"
        Me.ToolTip1.SetToolTip(Me.fullresolutionLabel, resources.GetString("fullresolutionLabel.ToolTip"))
        '
        'fulldoubleComboBox1
        '
        Me.fulldoubleComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fulldoubleComboBox1.FormattingEnabled = True
        Me.fulldoubleComboBox1.Location = New System.Drawing.Point(11, 65)
        Me.fulldoubleComboBox1.Name = "fulldoubleComboBox1"
        Me.fulldoubleComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.fulldoubleComboBox1.TabIndex = 5
        '
        'fulldoubleLabel1
        '
        Me.fulldoubleLabel1.AutoSize = True
        Me.fulldoubleLabel1.Location = New System.Drawing.Point(8, 49)
        Me.fulldoubleLabel1.Name = "fulldoubleLabel1"
        Me.fulldoubleLabel1.Size = New System.Drawing.Size(39, 13)
        Me.fulldoubleLabel1.TabIndex = 4
        Me.fulldoubleLabel1.Text = "Label1"
        Me.ToolTip1.SetToolTip(Me.fulldoubleLabel1, "Use double buffering in fullscreen. It can reduce screen flickering, but it can a" &
        "lso result in a slow DOSBox.")
        '
        'fullscreenComboBox1
        '
        Me.fullscreenComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fullscreenComboBox1.FormattingEnabled = True
        Me.fullscreenComboBox1.Location = New System.Drawing.Point(11, 25)
        Me.fullscreenComboBox1.Name = "fullscreenComboBox1"
        Me.fullscreenComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.fullscreenComboBox1.TabIndex = 3
        '
        'fullscreenLabel1
        '
        Me.fullscreenLabel1.AutoSize = True
        Me.fullscreenLabel1.Location = New System.Drawing.Point(8, 9)
        Me.fullscreenLabel1.Name = "fullscreenLabel1"
        Me.fullscreenLabel1.Size = New System.Drawing.Size(39, 13)
        Me.fullscreenLabel1.TabIndex = 2
        Me.fullscreenLabel1.Text = "Label1"
        Me.ToolTip1.SetToolTip(Me.fullscreenLabel1, "Start dosbox directly in fullscreen. (Press ALT-Enter to go back)")
        '
        'tabDosbox
        '
        Me.tabDosbox.Controls.Add(Me.memsizeTextBox2)
        Me.tabDosbox.Controls.Add(Me.memsizeLabel2)
        Me.tabDosbox.Controls.Add(Me.capturesButton2)
        Me.tabDosbox.Controls.Add(Me.capturesTextBox2)
        Me.tabDosbox.Controls.Add(Me.capturesLabel2)
        Me.tabDosbox.Controls.Add(Me.machineComboBox1)
        Me.tabDosbox.Controls.Add(Me.machineLabel2)
        Me.tabDosbox.Controls.Add(Me.languageTextBox2)
        Me.tabDosbox.Controls.Add(Me.languageLabel2)
        Me.tabDosbox.ImageKey = "dosbox_icon_jYr_icon.ico"
        Me.tabDosbox.Location = New System.Drawing.Point(4, 42)
        Me.tabDosbox.Name = "tabDosbox"
        Me.tabDosbox.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDosbox.Size = New System.Drawing.Size(590, 381)
        Me.tabDosbox.TabIndex = 1
        Me.tabDosbox.Text = "[dosbox]"
        Me.tabDosbox.UseVisualStyleBackColor = True
        '
        'memsizeTextBox2
        '
        Me.memsizeTextBox2.Location = New System.Drawing.Point(11, 137)
        Me.memsizeTextBox2.Name = "memsizeTextBox2"
        Me.memsizeTextBox2.Size = New System.Drawing.Size(61, 20)
        Me.memsizeTextBox2.TabIndex = 31
        '
        'memsizeLabel2
        '
        Me.memsizeLabel2.AutoSize = True
        Me.memsizeLabel2.Location = New System.Drawing.Point(8, 121)
        Me.memsizeLabel2.Name = "memsizeLabel2"
        Me.memsizeLabel2.Size = New System.Drawing.Size(47, 13)
        Me.memsizeLabel2.TabIndex = 30
        Me.memsizeLabel2.Text = "memsize"
        Me.ToolTip1.SetToolTip(Me.memsizeLabel2, resources.GetString("memsizeLabel2.ToolTip"))
        '
        'capturesButton2
        '
        Me.capturesButton2.AutoSize = True
        Me.capturesButton2.Location = New System.Drawing.Point(197, 96)
        Me.capturesButton2.Name = "capturesButton2"
        Me.capturesButton2.Size = New System.Drawing.Size(76, 27)
        Me.capturesButton2.TabIndex = 29
        Me.capturesButton2.Text = "Browse..."
        Me.capturesButton2.UseVisualStyleBackColor = True
        '
        'capturesTextBox2
        '
        Me.capturesTextBox2.Location = New System.Drawing.Point(11, 98)
        Me.capturesTextBox2.Name = "capturesTextBox2"
        Me.capturesTextBox2.Size = New System.Drawing.Size(180, 20)
        Me.capturesTextBox2.TabIndex = 28
        '
        'capturesLabel2
        '
        Me.capturesLabel2.AutoSize = True
        Me.capturesLabel2.Location = New System.Drawing.Point(8, 82)
        Me.capturesLabel2.Name = "capturesLabel2"
        Me.capturesLabel2.Size = New System.Drawing.Size(48, 13)
        Me.capturesLabel2.TabIndex = 27
        Me.capturesLabel2.Text = "captures"
        Me.ToolTip1.SetToolTip(Me.capturesLabel2, "Directory where things like wave, midi, screenshot get captured.")
        '
        'machineComboBox1
        '
        Me.machineComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.machineComboBox1.FormattingEnabled = True
        Me.machineComboBox1.Location = New System.Drawing.Point(11, 58)
        Me.machineComboBox1.Name = "machineComboBox1"
        Me.machineComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.machineComboBox1.TabIndex = 26
        '
        'machineLabel2
        '
        Me.machineLabel2.AutoSize = True
        Me.machineLabel2.Location = New System.Drawing.Point(8, 42)
        Me.machineLabel2.Name = "machineLabel2"
        Me.machineLabel2.Size = New System.Drawing.Size(47, 13)
        Me.machineLabel2.TabIndex = 25
        Me.machineLabel2.Text = "machine"
        Me.ToolTip1.SetToolTip(Me.machineLabel2, "The type of machine DOSBox tries to emulate." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#           Possible values: hercul" &
        "es, cga, tandy, pcjr, ega, vgaonly, svga_s3, svga_et3000, svga_et4000, svga_para" &
        "dise, vesa_nolfb, vesa_oldvbe.")
        '
        'languageTextBox2
        '
        Me.languageTextBox2.Location = New System.Drawing.Point(11, 19)
        Me.languageTextBox2.Name = "languageTextBox2"
        Me.languageTextBox2.Size = New System.Drawing.Size(180, 20)
        Me.languageTextBox2.TabIndex = 24
        '
        'languageLabel2
        '
        Me.languageLabel2.AutoSize = True
        Me.languageLabel2.Location = New System.Drawing.Point(8, 3)
        Me.languageLabel2.Name = "languageLabel2"
        Me.languageLabel2.Size = New System.Drawing.Size(51, 13)
        Me.languageLabel2.TabIndex = 23
        Me.languageLabel2.Text = "language"
        Me.ToolTip1.SetToolTip(Me.languageLabel2, "Select another language file.")
        '
        'tabRender
        '
        Me.tabRender.Controls.Add(Me.scalerComboBox1)
        Me.tabRender.Controls.Add(Me.scalerLabel2)
        Me.tabRender.Controls.Add(Me.aspect_ComboBox1)
        Me.tabRender.Controls.Add(Me.aspect_Label2)
        Me.tabRender.Controls.Add(Me.frameskip_TextBox2)
        Me.tabRender.Controls.Add(Me.frameskip_Label2)
        Me.tabRender.ImageKey = "display_properties-3.png"
        Me.tabRender.Location = New System.Drawing.Point(4, 42)
        Me.tabRender.Name = "tabRender"
        Me.tabRender.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRender.Size = New System.Drawing.Size(590, 381)
        Me.tabRender.TabIndex = 2
        Me.tabRender.Text = "[render]"
        Me.tabRender.UseVisualStyleBackColor = True
        '
        'scalerComboBox1
        '
        Me.scalerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.scalerComboBox1.FormattingEnabled = True
        Me.scalerComboBox1.Location = New System.Drawing.Point(4, 97)
        Me.scalerComboBox1.Name = "scalerComboBox1"
        Me.scalerComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.scalerComboBox1.TabIndex = 29
        '
        'scalerLabel2
        '
        Me.scalerLabel2.AutoSize = True
        Me.scalerLabel2.Location = New System.Drawing.Point(2, 80)
        Me.scalerLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.scalerLabel2.Name = "scalerLabel2"
        Me.scalerLabel2.Size = New System.Drawing.Size(39, 13)
        Me.scalerLabel2.TabIndex = 28
        Me.scalerLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.scalerLabel2, resources.GetString("scalerLabel2.ToolTip"))
        '
        'aspect_ComboBox1
        '
        Me.aspect_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.aspect_ComboBox1.FormattingEnabled = True
        Me.aspect_ComboBox1.Location = New System.Drawing.Point(4, 57)
        Me.aspect_ComboBox1.Name = "aspect_ComboBox1"
        Me.aspect_ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.aspect_ComboBox1.TabIndex = 27
        '
        'aspect_Label2
        '
        Me.aspect_Label2.AutoSize = True
        Me.aspect_Label2.Location = New System.Drawing.Point(2, 40)
        Me.aspect_Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.aspect_Label2.Name = "aspect_Label2"
        Me.aspect_Label2.Size = New System.Drawing.Size(39, 13)
        Me.aspect_Label2.TabIndex = 2
        Me.aspect_Label2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.aspect_Label2, "Do aspect correction, if your output method doesn't support scaling this can slow" &
        " things down!")
        '
        'frameskip_TextBox2
        '
        Me.frameskip_TextBox2.Location = New System.Drawing.Point(4, 20)
        Me.frameskip_TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.frameskip_TextBox2.Name = "frameskip_TextBox2"
        Me.frameskip_TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.frameskip_TextBox2.TabIndex = 1
        '
        'frameskip_Label2
        '
        Me.frameskip_Label2.AutoSize = True
        Me.frameskip_Label2.Location = New System.Drawing.Point(2, 3)
        Me.frameskip_Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.frameskip_Label2.Name = "frameskip_Label2"
        Me.frameskip_Label2.Size = New System.Drawing.Size(52, 13)
        Me.frameskip_Label2.TabIndex = 0
        Me.frameskip_Label2.Text = "frameskip"
        Me.ToolTip1.SetToolTip(Me.frameskip_Label2, "How many frames DOSBox skips before drawing one.")
        '
        'tabCpu
        '
        Me.tabCpu.Controls.Add(Me.cycledownTextBox2)
        Me.tabCpu.Controls.Add(Me.cycledownLabel2)
        Me.tabCpu.Controls.Add(Me.cycleupTextBox2)
        Me.tabCpu.Controls.Add(Me.cycleupLabel2)
        Me.tabCpu.Controls.Add(Me.cyclesComboBox1)
        Me.tabCpu.Controls.Add(Me.cyclesLabel2)
        Me.tabCpu.Controls.Add(Me.cputypeComboBox1)
        Me.tabCpu.Controls.Add(Me.cputypeLabel2)
        Me.tabCpu.Controls.Add(Me.coreComboBox1)
        Me.tabCpu.Controls.Add(Me.coreLabel2)
        Me.tabCpu.ImageKey = "processor-1.png"
        Me.tabCpu.Location = New System.Drawing.Point(4, 42)
        Me.tabCpu.Name = "tabCpu"
        Me.tabCpu.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCpu.Size = New System.Drawing.Size(590, 381)
        Me.tabCpu.TabIndex = 3
        Me.tabCpu.Text = "[cpu]"
        Me.tabCpu.UseVisualStyleBackColor = True
        '
        'cycledownTextBox2
        '
        Me.cycledownTextBox2.Location = New System.Drawing.Point(8, 180)
        Me.cycledownTextBox2.Name = "cycledownTextBox2"
        Me.cycledownTextBox2.Size = New System.Drawing.Size(37, 20)
        Me.cycledownTextBox2.TabIndex = 37
        '
        'cycledownLabel2
        '
        Me.cycledownLabel2.AutoSize = True
        Me.cycledownLabel2.Location = New System.Drawing.Point(6, 164)
        Me.cycledownLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cycledownLabel2.Name = "cycledownLabel2"
        Me.cycledownLabel2.Size = New System.Drawing.Size(39, 13)
        Me.cycledownLabel2.TabIndex = 36
        Me.cycledownLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.cycledownLabel2, "Setting it lower than 100 will be a percentage.")
        '
        'cycleupTextBox2
        '
        Me.cycleupTextBox2.Location = New System.Drawing.Point(8, 141)
        Me.cycleupTextBox2.Name = "cycleupTextBox2"
        Me.cycleupTextBox2.Size = New System.Drawing.Size(37, 20)
        Me.cycleupTextBox2.TabIndex = 35
        '
        'cycleupLabel2
        '
        Me.cycleupLabel2.AutoSize = True
        Me.cycleupLabel2.Location = New System.Drawing.Point(6, 125)
        Me.cycleupLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cycleupLabel2.Name = "cycleupLabel2"
        Me.cycleupLabel2.Size = New System.Drawing.Size(39, 13)
        Me.cycleupLabel2.TabIndex = 34
        Me.cycleupLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.cycleupLabel2, "Amount of cycles to decrease/increase with keycombos.(CTRL-F11/CTRL-F12)")
        '
        'cyclesComboBox1
        '
        Me.cyclesComboBox1.FormattingEnabled = True
        Me.cyclesComboBox1.Location = New System.Drawing.Point(8, 101)
        Me.cyclesComboBox1.Name = "cyclesComboBox1"
        Me.cyclesComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.cyclesComboBox1.TabIndex = 33
        '
        'cyclesLabel2
        '
        Me.cyclesLabel2.AutoSize = True
        Me.cyclesLabel2.Location = New System.Drawing.Point(6, 84)
        Me.cyclesLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cyclesLabel2.Name = "cyclesLabel2"
        Me.cyclesLabel2.Size = New System.Drawing.Size(39, 13)
        Me.cyclesLabel2.TabIndex = 32
        Me.cyclesLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.cyclesLabel2, resources.GetString("cyclesLabel2.ToolTip"))
        '
        'cputypeComboBox1
        '
        Me.cputypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cputypeComboBox1.FormattingEnabled = True
        Me.cputypeComboBox1.Location = New System.Drawing.Point(8, 60)
        Me.cputypeComboBox1.Name = "cputypeComboBox1"
        Me.cputypeComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.cputypeComboBox1.TabIndex = 31
        '
        'cputypeLabel2
        '
        Me.cputypeLabel2.AutoSize = True
        Me.cputypeLabel2.Location = New System.Drawing.Point(6, 43)
        Me.cputypeLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cputypeLabel2.Name = "cputypeLabel2"
        Me.cputypeLabel2.Size = New System.Drawing.Size(39, 13)
        Me.cputypeLabel2.TabIndex = 30
        Me.cputypeLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.cputypeLabel2, "CPU Type used in emulation. auto is the fastest choice." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#            Possible va" &
        "lues: auto, 386, 386_slow, 486_slow, pentium_slow, 386_prefetch.")
        '
        'coreComboBox1
        '
        Me.coreComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.coreComboBox1.FormattingEnabled = True
        Me.coreComboBox1.Location = New System.Drawing.Point(8, 20)
        Me.coreComboBox1.Name = "coreComboBox1"
        Me.coreComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.coreComboBox1.TabIndex = 29
        '
        'coreLabel2
        '
        Me.coreLabel2.AutoSize = True
        Me.coreLabel2.Location = New System.Drawing.Point(6, 3)
        Me.coreLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.coreLabel2.Name = "coreLabel2"
        Me.coreLabel2.Size = New System.Drawing.Size(39, 13)
        Me.coreLabel2.TabIndex = 28
        Me.coreLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.coreLabel2, "CPU Core used in emulation. auto will switch to dynamic if available and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#      " &
        "      appropriate." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#            Possible values: auto, dynamic, normal, simple." &
        "")
        '
        'tabMixer
        '
        Me.tabMixer.Controls.Add(Me.prebufferTextBox2)
        Me.tabMixer.Controls.Add(Me.prebufferLabel2)
        Me.tabMixer.Controls.Add(Me.blocksizeComboBox1)
        Me.tabMixer.Controls.Add(Me.blocksizeLabel2)
        Me.tabMixer.Controls.Add(Me.rateComboBox1)
        Me.tabMixer.Controls.Add(Me.rateLabel2)
        Me.tabMixer.Controls.Add(Me.nosoundComboBox1)
        Me.tabMixer.Controls.Add(Me.nosoundLabel2)
        Me.tabMixer.ImageKey = "mixer_cd_sound-1.png"
        Me.tabMixer.Location = New System.Drawing.Point(4, 42)
        Me.tabMixer.Name = "tabMixer"
        Me.tabMixer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMixer.Size = New System.Drawing.Size(590, 381)
        Me.tabMixer.TabIndex = 4
        Me.tabMixer.Text = "[mixer]"
        Me.tabMixer.UseVisualStyleBackColor = True
        '
        'prebufferTextBox2
        '
        Me.prebufferTextBox2.Location = New System.Drawing.Point(9, 142)
        Me.prebufferTextBox2.Name = "prebufferTextBox2"
        Me.prebufferTextBox2.Size = New System.Drawing.Size(37, 20)
        Me.prebufferTextBox2.TabIndex = 37
        '
        'prebufferLabel2
        '
        Me.prebufferLabel2.AutoSize = True
        Me.prebufferLabel2.Location = New System.Drawing.Point(7, 126)
        Me.prebufferLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.prebufferLabel2.Name = "prebufferLabel2"
        Me.prebufferLabel2.Size = New System.Drawing.Size(39, 13)
        Me.prebufferLabel2.TabIndex = 36
        Me.prebufferLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.prebufferLabel2, "How many milliseconds of data to keep on top of the blocksize")
        '
        'blocksizeComboBox1
        '
        Me.blocksizeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.blocksizeComboBox1.FormattingEnabled = True
        Me.blocksizeComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.blocksizeComboBox1.Name = "blocksizeComboBox1"
        Me.blocksizeComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.blocksizeComboBox1.TabIndex = 35
        '
        'blocksizeLabel2
        '
        Me.blocksizeLabel2.AutoSize = True
        Me.blocksizeLabel2.Location = New System.Drawing.Point(7, 85)
        Me.blocksizeLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.blocksizeLabel2.Name = "blocksizeLabel2"
        Me.blocksizeLabel2.Size = New System.Drawing.Size(39, 13)
        Me.blocksizeLabel2.TabIndex = 34
        Me.blocksizeLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.blocksizeLabel2, "Mixer block size, larger blocks might help sound stuttering but sound will also b" &
        "e more lagged." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#            Possible values: 1024, 2048, 4096, 8192, 512, 256.")
        '
        'rateComboBox1
        '
        Me.rateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rateComboBox1.FormattingEnabled = True
        Me.rateComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.rateComboBox1.Name = "rateComboBox1"
        Me.rateComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.rateComboBox1.TabIndex = 33
        '
        'rateLabel2
        '
        Me.rateLabel2.AutoSize = True
        Me.rateLabel2.Location = New System.Drawing.Point(7, 44)
        Me.rateLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rateLabel2.Name = "rateLabel2"
        Me.rateLabel2.Size = New System.Drawing.Size(39, 13)
        Me.rateLabel2.TabIndex = 32
        Me.rateLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.rateLabel2, "rate: Mixer sample rate, setting any device's rate higher than this will probably" &
        " lower their sound quality." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#            Possible values: 44100, 48000, 32000, " &
        "22050, 16000, 11025, 8000, 49716.")
        '
        'nosoundComboBox1
        '
        Me.nosoundComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nosoundComboBox1.FormattingEnabled = True
        Me.nosoundComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.nosoundComboBox1.Name = "nosoundComboBox1"
        Me.nosoundComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.nosoundComboBox1.TabIndex = 31
        '
        'nosoundLabel2
        '
        Me.nosoundLabel2.AutoSize = True
        Me.nosoundLabel2.Location = New System.Drawing.Point(7, 3)
        Me.nosoundLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nosoundLabel2.Name = "nosoundLabel2"
        Me.nosoundLabel2.Size = New System.Drawing.Size(39, 13)
        Me.nosoundLabel2.TabIndex = 30
        Me.nosoundLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.nosoundLabel2, "Enable silent mode, sound is still emulated though.")
        '
        'tabMidi
        '
        Me.tabMidi.Controls.Add(Me.midiconfigTextBox2)
        Me.tabMidi.Controls.Add(Me.midiconfigLabel2)
        Me.tabMidi.Controls.Add(Me.midideviceComboBox1)
        Me.tabMidi.Controls.Add(Me.midideviceLabel2)
        Me.tabMidi.Controls.Add(Me.mpu401ComboBox1)
        Me.tabMidi.Controls.Add(Me.mpu401Label2)
        Me.tabMidi.ImageKey = "midi_bl-0.png"
        Me.tabMidi.Location = New System.Drawing.Point(4, 42)
        Me.tabMidi.Name = "tabMidi"
        Me.tabMidi.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMidi.Size = New System.Drawing.Size(590, 381)
        Me.tabMidi.TabIndex = 5
        Me.tabMidi.Text = "[midi]"
        Me.tabMidi.UseVisualStyleBackColor = True
        '
        'midiconfigTextBox2
        '
        Me.midiconfigTextBox2.Location = New System.Drawing.Point(9, 102)
        Me.midiconfigTextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.midiconfigTextBox2.Name = "midiconfigTextBox2"
        Me.midiconfigTextBox2.Size = New System.Drawing.Size(84, 20)
        Me.midiconfigTextBox2.TabIndex = 37
        '
        'midiconfigLabel2
        '
        Me.midiconfigLabel2.AutoSize = True
        Me.midiconfigLabel2.Location = New System.Drawing.Point(7, 85)
        Me.midiconfigLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.midiconfigLabel2.Name = "midiconfigLabel2"
        Me.midiconfigLabel2.Size = New System.Drawing.Size(52, 13)
        Me.midiconfigLabel2.TabIndex = 36
        Me.midiconfigLabel2.Text = "frameskip"
        Me.ToolTip1.SetToolTip(Me.midiconfigLabel2, resources.GetString("midiconfigLabel2.ToolTip"))
        '
        'midideviceComboBox1
        '
        Me.midideviceComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.midideviceComboBox1.FormattingEnabled = True
        Me.midideviceComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.midideviceComboBox1.Name = "midideviceComboBox1"
        Me.midideviceComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.midideviceComboBox1.TabIndex = 35
        '
        'midideviceLabel2
        '
        Me.midideviceLabel2.AutoSize = True
        Me.midideviceLabel2.Location = New System.Drawing.Point(7, 44)
        Me.midideviceLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.midideviceLabel2.Name = "midideviceLabel2"
        Me.midideviceLabel2.Size = New System.Drawing.Size(39, 13)
        Me.midideviceLabel2.TabIndex = 34
        Me.midideviceLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.midideviceLabel2, " Device that will receive the MIDI data from MPU-401." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#             Possible val" &
        "ues: default, win32, alsa, oss, coreaudio, coremidi, none.")
        '
        'mpu401ComboBox1
        '
        Me.mpu401ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mpu401ComboBox1.FormattingEnabled = True
        Me.mpu401ComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.mpu401ComboBox1.Name = "mpu401ComboBox1"
        Me.mpu401ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.mpu401ComboBox1.TabIndex = 33
        '
        'mpu401Label2
        '
        Me.mpu401Label2.AutoSize = True
        Me.mpu401Label2.Location = New System.Drawing.Point(7, 3)
        Me.mpu401Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.mpu401Label2.Name = "mpu401Label2"
        Me.mpu401Label2.Size = New System.Drawing.Size(39, 13)
        Me.mpu401Label2.TabIndex = 32
        Me.mpu401Label2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.mpu401Label2, "Type of MPU-401 to emulate." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#             Possible values: intelligent, uart, no" &
        "ne.")
        '
        'tabSblaster
        '
        Me.tabSblaster.Controls.Add(Me.irqComboBox1)
        Me.tabSblaster.Controls.Add(Me.irqLabel2)
        Me.tabSblaster.Controls.Add(Me.oplrateComboBox1)
        Me.tabSblaster.Controls.Add(Me.oplrateLabel2)
        Me.tabSblaster.Controls.Add(Me.oplemuComboBox1)
        Me.tabSblaster.Controls.Add(Me.oplemuLabel2)
        Me.tabSblaster.Controls.Add(Me.oplmodeComboBox1)
        Me.tabSblaster.Controls.Add(Me.oplmodeLabel2)
        Me.tabSblaster.Controls.Add(Me.sbmixerComboBox1)
        Me.tabSblaster.Controls.Add(Me.sbmixerLabel2)
        Me.tabSblaster.Controls.Add(Me.hdmaComboBox1)
        Me.tabSblaster.Controls.Add(Me.hdmaLabel2)
        Me.tabSblaster.Controls.Add(Me.dmaComboBox1)
        Me.tabSblaster.Controls.Add(Me.dmaLabel2)
        Me.tabSblaster.Controls.Add(Me.sbbaseComboBox1)
        Me.tabSblaster.Controls.Add(Me.sbbaseLabel2)
        Me.tabSblaster.Controls.Add(Me.sbtypeComboBox1)
        Me.tabSblaster.Controls.Add(Me.sbtypeLabel2)
        Me.tabSblaster.ImageKey = "expansion_board-1.png"
        Me.tabSblaster.Location = New System.Drawing.Point(4, 42)
        Me.tabSblaster.Name = "tabSblaster"
        Me.tabSblaster.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSblaster.Size = New System.Drawing.Size(590, 381)
        Me.tabSblaster.TabIndex = 6
        Me.tabSblaster.Text = "[sblaster]"
        Me.tabSblaster.UseVisualStyleBackColor = True
        '
        'irqComboBox1
        '
        Me.irqComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.irqComboBox1.FormattingEnabled = True
        Me.irqComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.irqComboBox1.Name = "irqComboBox1"
        Me.irqComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.irqComboBox1.TabIndex = 53
        '
        'irqLabel2
        '
        Me.irqLabel2.AutoSize = True
        Me.irqLabel2.Location = New System.Drawing.Point(7, 85)
        Me.irqLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.irqLabel2.Name = "irqLabel2"
        Me.irqLabel2.Size = New System.Drawing.Size(39, 13)
        Me.irqLabel2.TabIndex = 52
        Me.irqLabel2.Text = "Label2"
        '
        'oplrateComboBox1
        '
        Me.oplrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.oplrateComboBox1.FormattingEnabled = True
        Me.oplrateComboBox1.Location = New System.Drawing.Point(9, 348)
        Me.oplrateComboBox1.Name = "oplrateComboBox1"
        Me.oplrateComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.oplrateComboBox1.TabIndex = 51
        '
        'oplrateLabel2
        '
        Me.oplrateLabel2.AutoSize = True
        Me.oplrateLabel2.Location = New System.Drawing.Point(7, 331)
        Me.oplrateLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.oplrateLabel2.Name = "oplrateLabel2"
        Me.oplrateLabel2.Size = New System.Drawing.Size(39, 13)
        Me.oplrateLabel2.TabIndex = 50
        Me.oplrateLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.oplrateLabel2, "Sample rate of OPL music emulation. Use 49716 for highest quality (set the mixer " &
        "rate accordingly)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#          Possible values: 44100, 49716, 48000, 32000, 2205" &
        "0, 16000, 11025, 8000.")
        '
        'oplemuComboBox1
        '
        Me.oplemuComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.oplemuComboBox1.FormattingEnabled = True
        Me.oplemuComboBox1.Location = New System.Drawing.Point(9, 307)
        Me.oplemuComboBox1.Name = "oplemuComboBox1"
        Me.oplemuComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.oplemuComboBox1.TabIndex = 49
        '
        'oplemuLabel2
        '
        Me.oplemuLabel2.AutoSize = True
        Me.oplemuLabel2.Location = New System.Drawing.Point(7, 290)
        Me.oplemuLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.oplemuLabel2.Name = "oplemuLabel2"
        Me.oplemuLabel2.Size = New System.Drawing.Size(39, 13)
        Me.oplemuLabel2.TabIndex = 48
        Me.oplemuLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.oplemuLabel2, "Provider for the OPL emulation. compat might provide better quality (see oplrate " &
        "as well)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#          Possible values: default, compat, fast.")
        '
        'oplmodeComboBox1
        '
        Me.oplmodeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.oplmodeComboBox1.FormattingEnabled = True
        Me.oplmodeComboBox1.Location = New System.Drawing.Point(9, 266)
        Me.oplmodeComboBox1.Name = "oplmodeComboBox1"
        Me.oplmodeComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.oplmodeComboBox1.TabIndex = 47
        '
        'oplmodeLabel2
        '
        Me.oplmodeLabel2.AutoSize = True
        Me.oplmodeLabel2.Location = New System.Drawing.Point(7, 249)
        Me.oplmodeLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.oplmodeLabel2.Name = "oplmodeLabel2"
        Me.oplmodeLabel2.Size = New System.Drawing.Size(39, 13)
        Me.oplmodeLabel2.TabIndex = 46
        Me.oplmodeLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.oplmodeLabel2, "Type of OPL emulation. On 'auto' the mode is determined by sblaster type. All OPL" &
        " modes are Adlib-compatible, except for 'cms'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#          Possible values: auto" &
        ", cms, opl2, dualopl2, opl3, none.")
        '
        'sbmixerComboBox1
        '
        Me.sbmixerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sbmixerComboBox1.FormattingEnabled = True
        Me.sbmixerComboBox1.Location = New System.Drawing.Point(9, 225)
        Me.sbmixerComboBox1.Name = "sbmixerComboBox1"
        Me.sbmixerComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.sbmixerComboBox1.TabIndex = 45
        '
        'sbmixerLabel2
        '
        Me.sbmixerLabel2.AutoSize = True
        Me.sbmixerLabel2.Location = New System.Drawing.Point(7, 208)
        Me.sbmixerLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sbmixerLabel2.Name = "sbmixerLabel2"
        Me.sbmixerLabel2.Size = New System.Drawing.Size(39, 13)
        Me.sbmixerLabel2.TabIndex = 44
        Me.sbmixerLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.sbmixerLabel2, "Allow the soundblaster mixer to modify the DOSBox mixer.")
        '
        'hdmaComboBox1
        '
        Me.hdmaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hdmaComboBox1.FormattingEnabled = True
        Me.hdmaComboBox1.Location = New System.Drawing.Point(9, 184)
        Me.hdmaComboBox1.Name = "hdmaComboBox1"
        Me.hdmaComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.hdmaComboBox1.TabIndex = 43
        '
        'hdmaLabel2
        '
        Me.hdmaLabel2.AutoSize = True
        Me.hdmaLabel2.Location = New System.Drawing.Point(7, 167)
        Me.hdmaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hdmaLabel2.Name = "hdmaLabel2"
        Me.hdmaLabel2.Size = New System.Drawing.Size(39, 13)
        Me.hdmaLabel2.TabIndex = 42
        Me.hdmaLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.hdmaLabel2, " The High DMA number of the soundblaster." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#          Possible values: 1, 5, 0, 3" &
        ", 6, 7.")
        '
        'dmaComboBox1
        '
        Me.dmaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dmaComboBox1.FormattingEnabled = True
        Me.dmaComboBox1.Location = New System.Drawing.Point(9, 143)
        Me.dmaComboBox1.Name = "dmaComboBox1"
        Me.dmaComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.dmaComboBox1.TabIndex = 41
        '
        'dmaLabel2
        '
        Me.dmaLabel2.AutoSize = True
        Me.dmaLabel2.Location = New System.Drawing.Point(7, 126)
        Me.dmaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dmaLabel2.Name = "dmaLabel2"
        Me.dmaLabel2.Size = New System.Drawing.Size(39, 13)
        Me.dmaLabel2.TabIndex = 40
        Me.dmaLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.dmaLabel2, "The DMA number of the soundblaster." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#          Possible values: 1, 5, 0, 3, 6, 7" &
        ".")
        '
        'sbbaseComboBox1
        '
        Me.sbbaseComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sbbaseComboBox1.FormattingEnabled = True
        Me.sbbaseComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.sbbaseComboBox1.Name = "sbbaseComboBox1"
        Me.sbbaseComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.sbbaseComboBox1.TabIndex = 37
        '
        'sbbaseLabel2
        '
        Me.sbbaseLabel2.AutoSize = True
        Me.sbbaseLabel2.Location = New System.Drawing.Point(7, 44)
        Me.sbbaseLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sbbaseLabel2.Name = "sbbaseLabel2"
        Me.sbbaseLabel2.Size = New System.Drawing.Size(39, 13)
        Me.sbbaseLabel2.TabIndex = 36
        Me.sbbaseLabel2.Text = "Label2"
        '
        'sbtypeComboBox1
        '
        Me.sbtypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sbtypeComboBox1.FormattingEnabled = True
        Me.sbtypeComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.sbtypeComboBox1.Name = "sbtypeComboBox1"
        Me.sbtypeComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.sbtypeComboBox1.TabIndex = 35
        '
        'sbtypeLabel2
        '
        Me.sbtypeLabel2.AutoSize = True
        Me.sbtypeLabel2.Location = New System.Drawing.Point(7, 3)
        Me.sbtypeLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sbtypeLabel2.Name = "sbtypeLabel2"
        Me.sbtypeLabel2.Size = New System.Drawing.Size(39, 13)
        Me.sbtypeLabel2.TabIndex = 34
        Me.sbtypeLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.sbtypeLabel2, "Type of Soundblaster to emulate. gb is Gameblaster." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#          Possible values: " &
        "sb1, sb2, sbpro1, sbpro2, sb16, gb, none.")
        '
        'tabGus
        '
        Me.tabGus.Controls.Add(Me.ultradirTextBox2)
        Me.tabGus.Controls.Add(Me.ultradirLabel2)
        Me.tabGus.Controls.Add(Me.gusdmaComboBox1)
        Me.tabGus.Controls.Add(Me.gusdmaLabel2)
        Me.tabGus.Controls.Add(Me.gusirqComboBox1)
        Me.tabGus.Controls.Add(Me.gusirqLabel2)
        Me.tabGus.Controls.Add(Me.gusbaseComboBox1)
        Me.tabGus.Controls.Add(Me.gusbaseLabel2)
        Me.tabGus.Controls.Add(Me.gusrateComboBox1)
        Me.tabGus.Controls.Add(Me.gusrateLabel2)
        Me.tabGus.Controls.Add(Me.gusComboBox1)
        Me.tabGus.Controls.Add(Me.gusLabel2)
        Me.tabGus.ImageKey = "expansion_board_modem-1.png"
        Me.tabGus.Location = New System.Drawing.Point(4, 42)
        Me.tabGus.Name = "tabGus"
        Me.tabGus.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGus.Size = New System.Drawing.Size(590, 381)
        Me.tabGus.TabIndex = 7
        Me.tabGus.Text = "[gus]"
        Me.tabGus.UseVisualStyleBackColor = True
        '
        'gusComboBox1
        '
        Me.gusComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gusComboBox1.FormattingEnabled = True
        Me.gusComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.gusComboBox1.Name = "gusComboBox1"
        Me.gusComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.gusComboBox1.TabIndex = 37
        '
        'gusLabel2
        '
        Me.gusLabel2.AutoSize = True
        Me.gusLabel2.Location = New System.Drawing.Point(7, 3)
        Me.gusLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.gusLabel2.Name = "gusLabel2"
        Me.gusLabel2.Size = New System.Drawing.Size(39, 13)
        Me.gusLabel2.TabIndex = 36
        Me.gusLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.gusLabel2, "Enable the Gravis Ultrasound emulation.")
        '
        'tabSpeaker
        '
        Me.tabSpeaker.Controls.Add(Me.disneyComboBox1)
        Me.tabSpeaker.Controls.Add(Me.disneyLabel2)
        Me.tabSpeaker.Controls.Add(Me.tandyrateComboBox1)
        Me.tabSpeaker.Controls.Add(Me.tandyrateLabel2)
        Me.tabSpeaker.Controls.Add(Me.tandyComboBox1)
        Me.tabSpeaker.Controls.Add(Me.tandyLabel2)
        Me.tabSpeaker.Controls.Add(Me.pcrateComboBox1)
        Me.tabSpeaker.Controls.Add(Me.pcrateLabel2)
        Me.tabSpeaker.Controls.Add(Me.pcspeakerComboBox1)
        Me.tabSpeaker.Controls.Add(Me.pcspeakerLabel2)
        Me.tabSpeaker.ImageKey = "loudspeaker_rays-0.png"
        Me.tabSpeaker.Location = New System.Drawing.Point(4, 42)
        Me.tabSpeaker.Name = "tabSpeaker"
        Me.tabSpeaker.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSpeaker.Size = New System.Drawing.Size(590, 381)
        Me.tabSpeaker.TabIndex = 8
        Me.tabSpeaker.Text = "[speaker]"
        Me.tabSpeaker.UseVisualStyleBackColor = True
        '
        'tabJoystick
        '
        Me.tabJoystick.Controls.Add(Me.buttonwrapComboBox1)
        Me.tabJoystick.Controls.Add(Me.buttonwrapLabel2)
        Me.tabJoystick.Controls.Add(Me.swap34ComboBox1)
        Me.tabJoystick.Controls.Add(Me.swap34Label2)
        Me.tabJoystick.Controls.Add(Me.autofireComboBox1)
        Me.tabJoystick.Controls.Add(Me.autofireLabel2)
        Me.tabJoystick.Controls.Add(Me.timedComboBox1)
        Me.tabJoystick.Controls.Add(Me.timedLabel2)
        Me.tabJoystick.Controls.Add(Me.joysticktypeComboBox1)
        Me.tabJoystick.Controls.Add(Me.joysticktypeLabel2)
        Me.tabJoystick.ImageKey = "joystick-0.png"
        Me.tabJoystick.Location = New System.Drawing.Point(4, 42)
        Me.tabJoystick.Name = "tabJoystick"
        Me.tabJoystick.Padding = New System.Windows.Forms.Padding(3)
        Me.tabJoystick.Size = New System.Drawing.Size(590, 381)
        Me.tabJoystick.TabIndex = 9
        Me.tabJoystick.Text = "[joystick]"
        Me.tabJoystick.UseVisualStyleBackColor = True
        '
        'tabSerial
        '
        Me.tabSerial.Controls.Add(Me.serial4ComboBox1)
        Me.tabSerial.Controls.Add(Me.serial4Label2)
        Me.tabSerial.Controls.Add(Me.serial3ComboBox1)
        Me.tabSerial.Controls.Add(Me.serial3Label2)
        Me.tabSerial.Controls.Add(Me.serial2ComboBox1)
        Me.tabSerial.Controls.Add(Me.serial2Label2)
        Me.tabSerial.Controls.Add(Me.serial1ComboBox1)
        Me.tabSerial.Controls.Add(Me.serial1Label2)
        Me.tabSerial.ImageKey = "cable-0.png"
        Me.tabSerial.Location = New System.Drawing.Point(4, 42)
        Me.tabSerial.Name = "tabSerial"
        Me.tabSerial.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSerial.Size = New System.Drawing.Size(590, 381)
        Me.tabSerial.TabIndex = 10
        Me.tabSerial.Text = "[serial]"
        Me.tabSerial.UseVisualStyleBackColor = True
        '
        'tabDos
        '
        Me.tabDos.Controls.Add(Me.keyboardlayoutComboBox1)
        Me.tabDos.Controls.Add(Me.keyboardlayoutLabel2)
        Me.tabDos.Controls.Add(Me.umbComboBox1)
        Me.tabDos.Controls.Add(Me.umbLabel2)
        Me.tabDos.Controls.Add(Me.emsComboBox1)
        Me.tabDos.Controls.Add(Me.emsLabel2)
        Me.tabDos.Controls.Add(Me.xmsComboBox1)
        Me.tabDos.Controls.Add(Me.xmsLabel2)
        Me.tabDos.ImageKey = "console_prompt-1.png"
        Me.tabDos.Location = New System.Drawing.Point(4, 42)
        Me.tabDos.Name = "tabDos"
        Me.tabDos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDos.Size = New System.Drawing.Size(590, 381)
        Me.tabDos.TabIndex = 11
        Me.tabDos.Text = "[dos]"
        Me.tabDos.UseVisualStyleBackColor = True
        '
        'tabIpx
        '
        Me.tabIpx.Controls.Add(Me.ipxComboBox1)
        Me.tabIpx.Controls.Add(Me.ipxLabel2)
        Me.tabIpx.ImageKey = "connected_world-1.png"
        Me.tabIpx.Location = New System.Drawing.Point(4, 42)
        Me.tabIpx.Name = "tabIpx"
        Me.tabIpx.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIpx.Size = New System.Drawing.Size(590, 381)
        Me.tabIpx.TabIndex = 12
        Me.tabIpx.Text = "[ipx]"
        Me.tabIpx.UseVisualStyleBackColor = True
        '
        'tabAutoexec
        '
        Me.tabAutoexec.Controls.Add(Me.Label1)
        Me.tabAutoexec.ImageKey = "registration-1.png"
        Me.tabAutoexec.Location = New System.Drawing.Point(4, 42)
        Me.tabAutoexec.Name = "tabAutoexec"
        Me.tabAutoexec.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAutoexec.Size = New System.Drawing.Size(590, 381)
        Me.tabAutoexec.TabIndex = 13
        Me.tabAutoexec.Text = "[autoexec]"
        Me.tabAutoexec.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Edit AutoExec in ""Config Editor"". Work in progress. :)"
        '
        'confEditorTab
        '
        Me.confEditorTab.Controls.Add(Me.TextBox1)
        Me.confEditorTab.ImageKey = "notepad_file-1.png"
        Me.confEditorTab.Location = New System.Drawing.Point(4, 42)
        Me.confEditorTab.Name = "confEditorTab"
        Me.confEditorTab.Padding = New System.Windows.Forms.Padding(3)
        Me.confEditorTab.Size = New System.Drawing.Size(590, 381)
        Me.confEditorTab.TabIndex = 14
        Me.confEditorTab.Text = "Config Editor"
        Me.confEditorTab.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(584, 375)
        Me.TextBox1.TabIndex = 10
        '
        'icons
        '
        Me.icons.ImageStream = CType(resources.GetObject("icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        Me.icons.Images.SetKeyName(0, "computer-4.png")
        Me.icons.Images.SetKeyName(1, "display_properties-3.png")
        Me.icons.Images.SetKeyName(2, "expansion_board-1.png")
        Me.icons.Images.SetKeyName(3, "loudspeaker_rays-0.png")
        Me.icons.Images.SetKeyName(4, "processor-1.png")
        Me.icons.Images.SetKeyName(5, "midi_bl-0.png")
        Me.icons.Images.SetKeyName(6, "mixer_cd_sound-1.png")
        Me.icons.Images.SetKeyName(7, "expansion_board_modem-1.png")
        Me.icons.Images.SetKeyName(8, "joystick-0.png")
        Me.icons.Images.SetKeyName(9, "cable-0.png")
        Me.icons.Images.SetKeyName(10, "connected_world-1.png")
        Me.icons.Images.SetKeyName(11, "console_prompt-1.png")
        Me.icons.Images.SetKeyName(12, "notepad_file-1.png")
        Me.icons.Images.SetKeyName(13, "registration-1.png")
        Me.icons.Images.SetKeyName(14, "dosbox_icon_jYr_icon.ico")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.LinksToolStripMenuItem, Me.ExtraToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(598, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveASToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveASToolStripMenuItem
        '
        Me.SaveASToolStripMenuItem.Name = "SaveASToolStripMenuItem"
        Me.SaveASToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveASToolStripMenuItem.Text = "Save As"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenConfDirectlyToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.OptionsToolStripMenuItem.Text = "Edit"
        '
        'OpenConfDirectlyToolStripMenuItem
        '
        Me.OpenConfDirectlyToolStripMenuItem.Enabled = False
        Me.OpenConfDirectlyToolStripMenuItem.Name = "OpenConfDirectlyToolStripMenuItem"
        Me.OpenConfDirectlyToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OpenConfDirectlyToolStripMenuItem.Text = "Open Conf Directly"
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LinksToolStripMenuItem
        '
        Me.LinksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadDosBoxToolStripMenuItem, Me.ConfWikiToolStripMenuItem})
        Me.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        Me.LinksToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.LinksToolStripMenuItem.Text = "Links"
        '
        'DownloadDosBoxToolStripMenuItem
        '
        Me.DownloadDosBoxToolStripMenuItem.Name = "DownloadDosBoxToolStripMenuItem"
        Me.DownloadDosBoxToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DownloadDosBoxToolStripMenuItem.Text = "Download DosBox"
        '
        'ConfWikiToolStripMenuItem
        '
        Me.ConfWikiToolStripMenuItem.Name = "ConfWikiToolStripMenuItem"
        Me.ConfWikiToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ConfWikiToolStripMenuItem.Text = "Conf Wiki"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "CONF file|*.conf"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "dosbox-0.74-3.conf"
        Me.SaveFileDialog1.Filter = "Conf Files|*.conf"
        '
        'gusrateComboBox1
        '
        Me.gusrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gusrateComboBox1.FormattingEnabled = True
        Me.gusrateComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.gusrateComboBox1.Name = "gusrateComboBox1"
        Me.gusrateComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.gusrateComboBox1.TabIndex = 39
        '
        'gusrateLabel2
        '
        Me.gusrateLabel2.AutoSize = True
        Me.gusrateLabel2.Location = New System.Drawing.Point(7, 44)
        Me.gusrateLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.gusrateLabel2.Name = "gusrateLabel2"
        Me.gusrateLabel2.Size = New System.Drawing.Size(39, 13)
        Me.gusrateLabel2.TabIndex = 38
        Me.gusrateLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.gusrateLabel2, "Sample rate of Ultrasound emulation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#           Possible values: 44100, 48000, " &
        "32000, 22050, 16000, 11025, 8000, 49716.")
        '
        'gusbaseComboBox1
        '
        Me.gusbaseComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gusbaseComboBox1.FormattingEnabled = True
        Me.gusbaseComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.gusbaseComboBox1.Name = "gusbaseComboBox1"
        Me.gusbaseComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.gusbaseComboBox1.TabIndex = 41
        '
        'gusbaseLabel2
        '
        Me.gusbaseLabel2.AutoSize = True
        Me.gusbaseLabel2.Location = New System.Drawing.Point(7, 85)
        Me.gusbaseLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.gusbaseLabel2.Name = "gusbaseLabel2"
        Me.gusbaseLabel2.Size = New System.Drawing.Size(39, 13)
        Me.gusbaseLabel2.TabIndex = 40
        Me.gusbaseLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.gusbaseLabel2, "The IO base address of the Gravis Ultrasound." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#           Possible values: 240, " &
        "220, 260, 280, 2a0, 2c0, 2e0, 300.")
        '
        'gusirqComboBox1
        '
        Me.gusirqComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gusirqComboBox1.FormattingEnabled = True
        Me.gusirqComboBox1.Location = New System.Drawing.Point(9, 143)
        Me.gusirqComboBox1.Name = "gusirqComboBox1"
        Me.gusirqComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.gusirqComboBox1.TabIndex = 43
        '
        'gusirqLabel2
        '
        Me.gusirqLabel2.AutoSize = True
        Me.gusirqLabel2.Location = New System.Drawing.Point(7, 126)
        Me.gusirqLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.gusirqLabel2.Name = "gusirqLabel2"
        Me.gusirqLabel2.Size = New System.Drawing.Size(39, 13)
        Me.gusirqLabel2.TabIndex = 42
        Me.gusirqLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.gusirqLabel2, "The IRQ number of the Gravis Ultrasound." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#           Possible values: 5, 3, 7, 9" &
        ", 10, 11, 12.")
        '
        'gusdmaComboBox1
        '
        Me.gusdmaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gusdmaComboBox1.FormattingEnabled = True
        Me.gusdmaComboBox1.Location = New System.Drawing.Point(9, 184)
        Me.gusdmaComboBox1.Name = "gusdmaComboBox1"
        Me.gusdmaComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.gusdmaComboBox1.TabIndex = 45
        '
        'gusdmaLabel2
        '
        Me.gusdmaLabel2.AutoSize = True
        Me.gusdmaLabel2.Location = New System.Drawing.Point(7, 167)
        Me.gusdmaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.gusdmaLabel2.Name = "gusdmaLabel2"
        Me.gusdmaLabel2.Size = New System.Drawing.Size(39, 13)
        Me.gusdmaLabel2.TabIndex = 44
        Me.gusdmaLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.gusdmaLabel2, "The DMA channel of the Gravis Ultrasound." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#           Possible values: 3, 0, 1, " &
        "5, 6, 7.")
        '
        'ultradirTextBox2
        '
        Me.ultradirTextBox2.Location = New System.Drawing.Point(9, 225)
        Me.ultradirTextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ultradirTextBox2.Name = "ultradirTextBox2"
        Me.ultradirTextBox2.Size = New System.Drawing.Size(84, 20)
        Me.ultradirTextBox2.TabIndex = 47
        '
        'ultradirLabel2
        '
        Me.ultradirLabel2.AutoSize = True
        Me.ultradirLabel2.Location = New System.Drawing.Point(7, 208)
        Me.ultradirLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ultradirLabel2.Name = "ultradirLabel2"
        Me.ultradirLabel2.Size = New System.Drawing.Size(52, 13)
        Me.ultradirLabel2.TabIndex = 46
        Me.ultradirLabel2.Text = "frameskip"
        Me.ToolTip1.SetToolTip(Me.ultradirLabel2, resources.GetString("ultradirLabel2.ToolTip"))
        '
        'pcspeakerComboBox1
        '
        Me.pcspeakerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pcspeakerComboBox1.FormattingEnabled = True
        Me.pcspeakerComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.pcspeakerComboBox1.Name = "pcspeakerComboBox1"
        Me.pcspeakerComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.pcspeakerComboBox1.TabIndex = 39
        '
        'pcspeakerLabel2
        '
        Me.pcspeakerLabel2.AutoSize = True
        Me.pcspeakerLabel2.Location = New System.Drawing.Point(7, 3)
        Me.pcspeakerLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pcspeakerLabel2.Name = "pcspeakerLabel2"
        Me.pcspeakerLabel2.Size = New System.Drawing.Size(39, 13)
        Me.pcspeakerLabel2.TabIndex = 38
        Me.pcspeakerLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.pcspeakerLabel2, "Enable PC-Speaker emulation.")
        '
        'pcrateComboBox1
        '
        Me.pcrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pcrateComboBox1.FormattingEnabled = True
        Me.pcrateComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.pcrateComboBox1.Name = "pcrateComboBox1"
        Me.pcrateComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.pcrateComboBox1.TabIndex = 41
        '
        'pcrateLabel2
        '
        Me.pcrateLabel2.AutoSize = True
        Me.pcrateLabel2.Location = New System.Drawing.Point(7, 44)
        Me.pcrateLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pcrateLabel2.Name = "pcrateLabel2"
        Me.pcrateLabel2.Size = New System.Drawing.Size(39, 13)
        Me.pcrateLabel2.TabIndex = 40
        Me.pcrateLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.pcrateLabel2, "Sample rate of the PC-Speaker sound generation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#            Possible values: 44" &
        "100, 48000, 32000, 22050, 16000, 11025, 8000, 49716.")
        '
        'tandyComboBox1
        '
        Me.tandyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tandyComboBox1.FormattingEnabled = True
        Me.tandyComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.tandyComboBox1.Name = "tandyComboBox1"
        Me.tandyComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.tandyComboBox1.TabIndex = 43
        '
        'tandyLabel2
        '
        Me.tandyLabel2.AutoSize = True
        Me.tandyLabel2.Location = New System.Drawing.Point(7, 85)
        Me.tandyLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tandyLabel2.Name = "tandyLabel2"
        Me.tandyLabel2.Size = New System.Drawing.Size(39, 13)
        Me.tandyLabel2.TabIndex = 42
        Me.tandyLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.tandyLabel2, "Enable Tandy Sound System emulation. For 'auto', emulation is present only if mac" &
        "hine is set to 'tandy'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#            Possible values: auto, on, off.")
        '
        'tandyrateComboBox1
        '
        Me.tandyrateComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tandyrateComboBox1.FormattingEnabled = True
        Me.tandyrateComboBox1.Location = New System.Drawing.Point(9, 143)
        Me.tandyrateComboBox1.Name = "tandyrateComboBox1"
        Me.tandyrateComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.tandyrateComboBox1.TabIndex = 45
        '
        'tandyrateLabel2
        '
        Me.tandyrateLabel2.AutoSize = True
        Me.tandyrateLabel2.Location = New System.Drawing.Point(7, 126)
        Me.tandyrateLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tandyrateLabel2.Name = "tandyrateLabel2"
        Me.tandyrateLabel2.Size = New System.Drawing.Size(39, 13)
        Me.tandyrateLabel2.TabIndex = 44
        Me.tandyrateLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.tandyrateLabel2, "Sample rate of the Tandy 3-Voice generation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#            Possible values: 44100" &
        ", 48000, 32000, 22050, 16000, 11025, 8000, 49716.")
        '
        'disneyComboBox1
        '
        Me.disneyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.disneyComboBox1.FormattingEnabled = True
        Me.disneyComboBox1.Location = New System.Drawing.Point(9, 184)
        Me.disneyComboBox1.Name = "disneyComboBox1"
        Me.disneyComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.disneyComboBox1.TabIndex = 47
        '
        'disneyLabel2
        '
        Me.disneyLabel2.AutoSize = True
        Me.disneyLabel2.Location = New System.Drawing.Point(7, 167)
        Me.disneyLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.disneyLabel2.Name = "disneyLabel2"
        Me.disneyLabel2.Size = New System.Drawing.Size(39, 13)
        Me.disneyLabel2.TabIndex = 46
        Me.disneyLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.disneyLabel2, "Enable Disney Sound Source emulation. (Covox Voice Master and Speech Thing compat" &
        "ible).")
        '
        'joysticktypeComboBox1
        '
        Me.joysticktypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.joysticktypeComboBox1.FormattingEnabled = True
        Me.joysticktypeComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.joysticktypeComboBox1.Name = "joysticktypeComboBox1"
        Me.joysticktypeComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.joysticktypeComboBox1.TabIndex = 41
        '
        'joysticktypeLabel2
        '
        Me.joysticktypeLabel2.AutoSize = True
        Me.joysticktypeLabel2.Location = New System.Drawing.Point(7, 3)
        Me.joysticktypeLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.joysticktypeLabel2.Name = "joysticktypeLabel2"
        Me.joysticktypeLabel2.Size = New System.Drawing.Size(39, 13)
        Me.joysticktypeLabel2.TabIndex = 40
        Me.joysticktypeLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.joysticktypeLabel2, resources.GetString("joysticktypeLabel2.ToolTip"))
        '
        'timedComboBox1
        '
        Me.timedComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.timedComboBox1.FormattingEnabled = True
        Me.timedComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.timedComboBox1.Name = "timedComboBox1"
        Me.timedComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.timedComboBox1.TabIndex = 43
        '
        'timedLabel2
        '
        Me.timedLabel2.AutoSize = True
        Me.timedLabel2.Location = New System.Drawing.Point(7, 44)
        Me.timedLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.timedLabel2.Name = "timedLabel2"
        Me.timedLabel2.Size = New System.Drawing.Size(39, 13)
        Me.timedLabel2.TabIndex = 42
        Me.timedLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.timedLabel2, "enable timed intervals for axis. Experiment with this option, if your joystick dr" &
        "ifts (away).")
        '
        'autofireComboBox1
        '
        Me.autofireComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.autofireComboBox1.FormattingEnabled = True
        Me.autofireComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.autofireComboBox1.Name = "autofireComboBox1"
        Me.autofireComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.autofireComboBox1.TabIndex = 45
        '
        'autofireLabel2
        '
        Me.autofireLabel2.AutoSize = True
        Me.autofireLabel2.Location = New System.Drawing.Point(7, 85)
        Me.autofireLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.autofireLabel2.Name = "autofireLabel2"
        Me.autofireLabel2.Size = New System.Drawing.Size(39, 13)
        Me.autofireLabel2.TabIndex = 44
        Me.autofireLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.autofireLabel2, "continuously fires as long as you keep the button pressed.")
        '
        'swap34ComboBox1
        '
        Me.swap34ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.swap34ComboBox1.FormattingEnabled = True
        Me.swap34ComboBox1.Location = New System.Drawing.Point(9, 143)
        Me.swap34ComboBox1.Name = "swap34ComboBox1"
        Me.swap34ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.swap34ComboBox1.TabIndex = 47
        '
        'swap34Label2
        '
        Me.swap34Label2.AutoSize = True
        Me.swap34Label2.Location = New System.Drawing.Point(7, 126)
        Me.swap34Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.swap34Label2.Name = "swap34Label2"
        Me.swap34Label2.Size = New System.Drawing.Size(39, 13)
        Me.swap34Label2.TabIndex = 46
        Me.swap34Label2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.swap34Label2, "swap the 3rd and the 4th axis. Can be useful for certain joysticks.")
        '
        'buttonwrapComboBox1
        '
        Me.buttonwrapComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.buttonwrapComboBox1.FormattingEnabled = True
        Me.buttonwrapComboBox1.Location = New System.Drawing.Point(9, 184)
        Me.buttonwrapComboBox1.Name = "buttonwrapComboBox1"
        Me.buttonwrapComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.buttonwrapComboBox1.TabIndex = 49
        '
        'buttonwrapLabel2
        '
        Me.buttonwrapLabel2.AutoSize = True
        Me.buttonwrapLabel2.Location = New System.Drawing.Point(7, 167)
        Me.buttonwrapLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.buttonwrapLabel2.Name = "buttonwrapLabel2"
        Me.buttonwrapLabel2.Size = New System.Drawing.Size(39, 13)
        Me.buttonwrapLabel2.TabIndex = 48
        Me.buttonwrapLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.buttonwrapLabel2, "enable button wrapping at the number of emulated buttons.")
        '
        'serial1ComboBox1
        '
        Me.serial1ComboBox1.FormattingEnabled = True
        Me.serial1ComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.serial1ComboBox1.Name = "serial1ComboBox1"
        Me.serial1ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.serial1ComboBox1.TabIndex = 43
        '
        'serial1Label2
        '
        Me.serial1Label2.AutoSize = True
        Me.serial1Label2.Location = New System.Drawing.Point(7, 3)
        Me.serial1Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.serial1Label2.Name = "serial1Label2"
        Me.serial1Label2.Size = New System.Drawing.Size(39, 13)
        Me.serial1Label2.TabIndex = 42
        Me.serial1Label2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.serial1Label2, resources.GetString("serial1Label2.ToolTip"))
        '
        'serial2ComboBox1
        '
        Me.serial2ComboBox1.FormattingEnabled = True
        Me.serial2ComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.serial2ComboBox1.Name = "serial2ComboBox1"
        Me.serial2ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.serial2ComboBox1.TabIndex = 45
        '
        'serial2Label2
        '
        Me.serial2Label2.AutoSize = True
        Me.serial2Label2.Location = New System.Drawing.Point(7, 44)
        Me.serial2Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.serial2Label2.Name = "serial2Label2"
        Me.serial2Label2.Size = New System.Drawing.Size(39, 13)
        Me.serial2Label2.TabIndex = 44
        Me.serial2Label2.Text = "Label2"
        '
        'serial3ComboBox1
        '
        Me.serial3ComboBox1.FormattingEnabled = True
        Me.serial3ComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.serial3ComboBox1.Name = "serial3ComboBox1"
        Me.serial3ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.serial3ComboBox1.TabIndex = 47
        '
        'serial3Label2
        '
        Me.serial3Label2.AutoSize = True
        Me.serial3Label2.Location = New System.Drawing.Point(7, 85)
        Me.serial3Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.serial3Label2.Name = "serial3Label2"
        Me.serial3Label2.Size = New System.Drawing.Size(39, 13)
        Me.serial3Label2.TabIndex = 46
        Me.serial3Label2.Text = "Label2"
        '
        'serial4ComboBox1
        '
        Me.serial4ComboBox1.FormattingEnabled = True
        Me.serial4ComboBox1.Location = New System.Drawing.Point(9, 143)
        Me.serial4ComboBox1.Name = "serial4ComboBox1"
        Me.serial4ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.serial4ComboBox1.TabIndex = 49
        '
        'serial4Label2
        '
        Me.serial4Label2.AutoSize = True
        Me.serial4Label2.Location = New System.Drawing.Point(7, 126)
        Me.serial4Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.serial4Label2.Name = "serial4Label2"
        Me.serial4Label2.Size = New System.Drawing.Size(39, 13)
        Me.serial4Label2.TabIndex = 48
        Me.serial4Label2.Text = "Label2"
        '
        'xmsComboBox1
        '
        Me.xmsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.xmsComboBox1.FormattingEnabled = True
        Me.xmsComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.xmsComboBox1.Name = "xmsComboBox1"
        Me.xmsComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.xmsComboBox1.TabIndex = 43
        '
        'xmsLabel2
        '
        Me.xmsLabel2.AutoSize = True
        Me.xmsLabel2.Location = New System.Drawing.Point(7, 3)
        Me.xmsLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.xmsLabel2.Name = "xmsLabel2"
        Me.xmsLabel2.Size = New System.Drawing.Size(39, 13)
        Me.xmsLabel2.TabIndex = 42
        Me.xmsLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.xmsLabel2, "Enable XMS support.")
        '
        'emsComboBox1
        '
        Me.emsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.emsComboBox1.FormattingEnabled = True
        Me.emsComboBox1.Location = New System.Drawing.Point(9, 61)
        Me.emsComboBox1.Name = "emsComboBox1"
        Me.emsComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.emsComboBox1.TabIndex = 45
        '
        'emsLabel2
        '
        Me.emsLabel2.AutoSize = True
        Me.emsLabel2.Location = New System.Drawing.Point(7, 44)
        Me.emsLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.emsLabel2.Name = "emsLabel2"
        Me.emsLabel2.Size = New System.Drawing.Size(39, 13)
        Me.emsLabel2.TabIndex = 44
        Me.emsLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.emsLabel2, "Enable ems support.")
        '
        'umbComboBox1
        '
        Me.umbComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.umbComboBox1.FormattingEnabled = True
        Me.umbComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.umbComboBox1.Name = "umbComboBox1"
        Me.umbComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.umbComboBox1.TabIndex = 47
        '
        'umbLabel2
        '
        Me.umbLabel2.AutoSize = True
        Me.umbLabel2.Location = New System.Drawing.Point(7, 85)
        Me.umbLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.umbLabel2.Name = "umbLabel2"
        Me.umbLabel2.Size = New System.Drawing.Size(39, 13)
        Me.umbLabel2.TabIndex = 46
        Me.umbLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.umbLabel2, "Enable umb support.")
        '
        'keyboardlayoutLabel2
        '
        Me.keyboardlayoutLabel2.AutoSize = True
        Me.keyboardlayoutLabel2.Location = New System.Drawing.Point(7, 126)
        Me.keyboardlayoutLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.keyboardlayoutLabel2.Name = "keyboardlayoutLabel2"
        Me.keyboardlayoutLabel2.Size = New System.Drawing.Size(39, 13)
        Me.keyboardlayoutLabel2.TabIndex = 48
        Me.keyboardlayoutLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.keyboardlayoutLabel2, "Language code of the keyboard layout (or none).")
        '
        'keyboardlayoutComboBox1
        '
        Me.keyboardlayoutComboBox1.FormattingEnabled = True
        Me.keyboardlayoutComboBox1.Location = New System.Drawing.Point(10, 142)
        Me.keyboardlayoutComboBox1.Name = "keyboardlayoutComboBox1"
        Me.keyboardlayoutComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.keyboardlayoutComboBox1.TabIndex = 49
        '
        'ipxComboBox1
        '
        Me.ipxComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ipxComboBox1.FormattingEnabled = True
        Me.ipxComboBox1.Location = New System.Drawing.Point(9, 20)
        Me.ipxComboBox1.Name = "ipxComboBox1"
        Me.ipxComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.ipxComboBox1.TabIndex = 45
        '
        'ipxLabel2
        '
        Me.ipxLabel2.AutoSize = True
        Me.ipxLabel2.Location = New System.Drawing.Point(7, 3)
        Me.ipxLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ipxLabel2.Name = "ipxLabel2"
        Me.ipxLabel2.Size = New System.Drawing.Size(39, 13)
        Me.ipxLabel2.TabIndex = 44
        Me.ipxLabel2.Text = "Label2"
        Me.ToolTip1.SetToolTip(Me.ipxLabel2, "Enable ipx over UDP/IP emulation.")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 451)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOSBOX Config Editor for 0.74-3"
        Me.TabControl.ResumeLayout(False)
        Me.tabSdl.ResumeLayout(False)
        Me.tabSdl.PerformLayout()
        CType(Me.sensitivityNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDosbox.ResumeLayout(False)
        Me.tabDosbox.PerformLayout()
        Me.tabRender.ResumeLayout(False)
        Me.tabRender.PerformLayout()
        Me.tabCpu.ResumeLayout(False)
        Me.tabCpu.PerformLayout()
        Me.tabMixer.ResumeLayout(False)
        Me.tabMixer.PerformLayout()
        Me.tabMidi.ResumeLayout(False)
        Me.tabMidi.PerformLayout()
        Me.tabSblaster.ResumeLayout(False)
        Me.tabSblaster.PerformLayout()
        Me.tabGus.ResumeLayout(False)
        Me.tabGus.PerformLayout()
        Me.tabSpeaker.ResumeLayout(False)
        Me.tabSpeaker.PerformLayout()
        Me.tabJoystick.ResumeLayout(False)
        Me.tabJoystick.PerformLayout()
        Me.tabSerial.ResumeLayout(False)
        Me.tabSerial.PerformLayout()
        Me.tabDos.ResumeLayout(False)
        Me.tabDos.PerformLayout()
        Me.tabIpx.ResumeLayout(False)
        Me.tabIpx.PerformLayout()
        Me.tabAutoexec.ResumeLayout(False)
        Me.tabAutoexec.PerformLayout()
        Me.confEditorTab.ResumeLayout(False)
        Me.confEditorTab.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents tabSdl As TabPage
    Friend WithEvents tabDosbox As TabPage
    Friend WithEvents tabRender As TabPage
    Friend WithEvents tabCpu As TabPage
    Friend WithEvents tabMixer As TabPage
    Friend WithEvents tabMidi As TabPage
    Friend WithEvents tabSblaster As TabPage
    Friend WithEvents tabGus As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabSpeaker As TabPage
    Friend WithEvents tabJoystick As TabPage
    Friend WithEvents tabSerial As TabPage
    Friend WithEvents tabDos As TabPage
    Friend WithEvents tabIpx As TabPage
    Friend WithEvents tabAutoexec As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents fullscreenLabel1 As Label
    Friend WithEvents fullscreenComboBox1 As ComboBox
    Friend WithEvents fulldoubleComboBox1 As ComboBox
    Friend WithEvents fulldoubleLabel1 As Label
    Friend WithEvents SaveASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents confEditorTab As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents icons As ImageList
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenConfDirectlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fullresolutionComboBox1 As ComboBox
    Friend WithEvents fullresolutionLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents windowresolutionComboBox1 As ComboBox
    Friend WithEvents windowresolutionLabel2 As Label
    Friend WithEvents outputComboBox1 As ComboBox
    Friend WithEvents outputLabel2 As Label
    Friend WithEvents autolockComboBox1 As ComboBox
    Friend WithEvents autolockLabel2 As Label
    Friend WithEvents sensitivityLabel2 As Label
    Friend WithEvents sensitivityNumericUpDown1 As NumericUpDown
    Friend WithEvents waitonerrorComboBox1 As ComboBox
    Friend WithEvents waitonerrorLabel2 As Label
    Friend WithEvents priorityComboBox2 As ComboBox
    Friend WithEvents priorityComboBox1 As ComboBox
    Friend WithEvents priorityLabel2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents mapperfileTextBox2 As TextBox
    Friend WithEvents mapperfileLabel2 As Label
    Friend WithEvents usescancodesComboBox1 As ComboBox
    Friend WithEvents usescancodesLabel2 As Label
    Friend WithEvents ExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadDosBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfWikiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents memsizeTextBox2 As TextBox
    Friend WithEvents memsizeLabel2 As Label
    Friend WithEvents capturesButton2 As Button
    Friend WithEvents capturesTextBox2 As TextBox
    Friend WithEvents capturesLabel2 As Label
    Friend WithEvents machineComboBox1 As ComboBox
    Friend WithEvents machineLabel2 As Label
    Friend WithEvents languageTextBox2 As TextBox
    Friend WithEvents languageLabel2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents frameskip_TextBox2 As TextBox
    Friend WithEvents frameskip_Label2 As Label
    Friend WithEvents aspect_ComboBox1 As ComboBox
    Friend WithEvents aspect_Label2 As Label
    Friend WithEvents scalerComboBox1 As ComboBox
    Friend WithEvents scalerLabel2 As Label
    Friend WithEvents coreComboBox1 As ComboBox
    Friend WithEvents coreLabel2 As Label
    Friend WithEvents cputypeComboBox1 As ComboBox
    Friend WithEvents cputypeLabel2 As Label
    Friend WithEvents cyclesComboBox1 As ComboBox
    Friend WithEvents cyclesLabel2 As Label
    Friend WithEvents cycledownTextBox2 As TextBox
    Friend WithEvents cycledownLabel2 As Label
    Friend WithEvents cycleupTextBox2 As TextBox
    Friend WithEvents cycleupLabel2 As Label
    Friend WithEvents prebufferTextBox2 As TextBox
    Friend WithEvents prebufferLabel2 As Label
    Friend WithEvents blocksizeComboBox1 As ComboBox
    Friend WithEvents blocksizeLabel2 As Label
    Friend WithEvents rateComboBox1 As ComboBox
    Friend WithEvents rateLabel2 As Label
    Friend WithEvents nosoundComboBox1 As ComboBox
    Friend WithEvents nosoundLabel2 As Label
    Friend WithEvents midiconfigTextBox2 As TextBox
    Friend WithEvents midiconfigLabel2 As Label
    Friend WithEvents midideviceComboBox1 As ComboBox
    Friend WithEvents midideviceLabel2 As Label
    Friend WithEvents mpu401ComboBox1 As ComboBox
    Friend WithEvents mpu401Label2 As Label
    Friend WithEvents oplrateComboBox1 As ComboBox
    Friend WithEvents oplrateLabel2 As Label
    Friend WithEvents oplemuComboBox1 As ComboBox
    Friend WithEvents oplemuLabel2 As Label
    Friend WithEvents oplmodeComboBox1 As ComboBox
    Friend WithEvents oplmodeLabel2 As Label
    Friend WithEvents sbmixerComboBox1 As ComboBox
    Friend WithEvents sbmixerLabel2 As Label
    Friend WithEvents hdmaComboBox1 As ComboBox
    Friend WithEvents hdmaLabel2 As Label
    Friend WithEvents dmaComboBox1 As ComboBox
    Friend WithEvents dmaLabel2 As Label
    Friend WithEvents sbbaseComboBox1 As ComboBox
    Friend WithEvents sbbaseLabel2 As Label
    Friend WithEvents sbtypeComboBox1 As ComboBox
    Friend WithEvents sbtypeLabel2 As Label
    Friend WithEvents irqComboBox1 As ComboBox
    Friend WithEvents irqLabel2 As Label
    Friend WithEvents gusComboBox1 As ComboBox
    Friend WithEvents gusLabel2 As Label
    Friend WithEvents ultradirTextBox2 As TextBox
    Friend WithEvents ultradirLabel2 As Label
    Friend WithEvents gusdmaComboBox1 As ComboBox
    Friend WithEvents gusdmaLabel2 As Label
    Friend WithEvents gusirqComboBox1 As ComboBox
    Friend WithEvents gusirqLabel2 As Label
    Friend WithEvents gusbaseComboBox1 As ComboBox
    Friend WithEvents gusbaseLabel2 As Label
    Friend WithEvents gusrateComboBox1 As ComboBox
    Friend WithEvents gusrateLabel2 As Label
    Friend WithEvents disneyComboBox1 As ComboBox
    Friend WithEvents disneyLabel2 As Label
    Friend WithEvents tandyrateComboBox1 As ComboBox
    Friend WithEvents tandyrateLabel2 As Label
    Friend WithEvents tandyComboBox1 As ComboBox
    Friend WithEvents tandyLabel2 As Label
    Friend WithEvents pcrateComboBox1 As ComboBox
    Friend WithEvents pcrateLabel2 As Label
    Friend WithEvents pcspeakerComboBox1 As ComboBox
    Friend WithEvents pcspeakerLabel2 As Label
    Friend WithEvents buttonwrapComboBox1 As ComboBox
    Friend WithEvents buttonwrapLabel2 As Label
    Friend WithEvents swap34ComboBox1 As ComboBox
    Friend WithEvents swap34Label2 As Label
    Friend WithEvents autofireComboBox1 As ComboBox
    Friend WithEvents autofireLabel2 As Label
    Friend WithEvents timedComboBox1 As ComboBox
    Friend WithEvents timedLabel2 As Label
    Friend WithEvents joysticktypeComboBox1 As ComboBox
    Friend WithEvents joysticktypeLabel2 As Label
    Friend WithEvents serial4ComboBox1 As ComboBox
    Friend WithEvents serial4Label2 As Label
    Friend WithEvents serial3ComboBox1 As ComboBox
    Friend WithEvents serial3Label2 As Label
    Friend WithEvents serial2ComboBox1 As ComboBox
    Friend WithEvents serial2Label2 As Label
    Friend WithEvents serial1ComboBox1 As ComboBox
    Friend WithEvents serial1Label2 As Label
    Friend WithEvents umbComboBox1 As ComboBox
    Friend WithEvents umbLabel2 As Label
    Friend WithEvents emsComboBox1 As ComboBox
    Friend WithEvents emsLabel2 As Label
    Friend WithEvents xmsComboBox1 As ComboBox
    Friend WithEvents xmsLabel2 As Label
    Friend WithEvents keyboardlayoutComboBox1 As ComboBox
    Friend WithEvents keyboardlayoutLabel2 As Label
    Friend WithEvents ipxComboBox1 As ComboBox
    Friend WithEvents ipxLabel2 As Label
End Class
