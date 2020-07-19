Imports System.IO

Public Class Form1
    Dim confLocation
    Dim saveEnable As Boolean = False
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Sub openConf()
        TextBox1.Clear()
        confLocation = OpenFileDialog1.FileName
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(confLocation)
        Dim stringReader As String
        stringReader = fileReader.ReadLine()

        'Loop to read each line and check if it is a valid setting.
        While stringReader IsNot Nothing
            If stringReader.StartsWith("fullscreen=") Then
                fullscreenLabel1.Text = Split(stringReader, "=")(0)
                Dim fullscreen = Split(stringReader, "=")(1)
                If fullscreenComboBox1.Items.Contains(fullscreen) Then
                    fullscreenComboBox1.SelectedIndex = fullscreenComboBox1.Items.IndexOf(fullscreen)
                End If

            ElseIf stringReader.StartsWith("fulldouble=") Then
                fulldoubleLabel1.Text = Split(stringReader, "=")(0)
                Dim fulldouble = Split(stringReader, "=")(1)
                If fulldoubleComboBox1.Items.Contains(fulldouble) Then
                    fulldoubleComboBox1.SelectedIndex = fulldoubleComboBox1.Items.IndexOf(fulldouble)
                End If

            ElseIf stringReader.StartsWith("fullresolution=") Then
                fullresolutionLabel.Text = Split(stringReader, "=")(0)
                Dim fullresolution = Split(stringReader, "=")(1)
                'Check if full resoltion option exists
                If fullresolutionComboBox1.Items.Contains(fullresolution) Then
                    fullresolutionComboBox1.SelectedIndex = fullresolutionComboBox1.Items.IndexOf(fullresolution)
                Else
                    fullresolutionComboBox1.Text = fullresolution
                End If

            ElseIf stringReader.StartsWith("windowresolution=") Then
                windowresolutionLabel2.Text = Split(stringReader, "=")(0)
                Dim windowresolution = Split(stringReader, "=")(1)
                If windowresolutionComboBox1.Items.Contains(windowresolution) Then
                    windowresolutionComboBox1.SelectedIndex = windowresolutionComboBox1.Items.IndexOf(windowresolution)
                Else
                    windowresolutionComboBox1.Text = windowresolution
                End If

            ElseIf stringReader.StartsWith("output=") Then
                outputLabel2.Text = Split(stringReader, "=")(0)
                Dim output = Split(stringReader, "=")(1)
                If outputComboBox1.Items.Contains(output) Then
                    outputComboBox1.SelectedIndex = outputComboBox1.Items.IndexOf(output)
                End If

            ElseIf stringReader.StartsWith("autolock=") Then
                autolockLabel2.Text = Split(stringReader, "=")(0)
                Dim autolock = Split(stringReader, "=")(1)
                If autolockComboBox1.Items.Contains(autolock) Then
                    autolockComboBox1.SelectedIndex = autolockComboBox1.Items.IndexOf(autolock)
                End If

            ElseIf stringReader.StartsWith("sensitivity=") Then
                sensitivityLabel2.Text = Split(stringReader, "=")(0)
                Dim sensitivity = Split(stringReader, "=")(1)
                sensitivityNumericUpDown1.Value = sensitivity

            ElseIf stringReader.StartsWith("waitonerror=") Then
                waitonerrorLabel2.Text = Split(stringReader, "=")(0)
                Dim waitonerror = Split(stringReader, "=")(1)
                If waitonerrorComboBox1.Items.Contains(waitonerror) Then
                    waitonerrorComboBox1.SelectedIndex = waitonerrorComboBox1.Items.IndexOf(waitonerror)
                End If

            ElseIf stringReader.StartsWith("priority=") Then
                fulldoubleLabel1.Text = Split(stringReader, "=")(0)
                Dim priority1 = Split(stringReader, "=")(1)
                Dim priorityFirst = Split(priority1, ",")(0)
                Dim prioritySecond = Split(priority1, ",")(1)
                priorityComboBox1.SelectedIndex = priorityComboBox1.Items.IndexOf(priorityFirst)
                priorityComboBox2.SelectedIndex = priorityComboBox2.Items.IndexOf(prioritySecond)

            ElseIf stringReader.StartsWith("mapperfile=") Then
                mapperfileLabel2.Text = Split(stringReader, "=")(0)
                Dim mapperfile = Split(stringReader, "=")(1)
                mapperfileTextBox2.Text = mapperfile

            ElseIf stringReader.StartsWith("usescancodes=") Then
                usescancodesLabel2.Text = Split(stringReader, "=")(0)
                Dim usescancodes = Split(stringReader, "=")(1)
                If usescancodesComboBox1.Items.Contains(usescancodes) Then
                    usescancodesComboBox1.SelectedIndex = usescancodesComboBox1.Items.IndexOf(usescancodes)
                End If

            ElseIf stringReader.StartsWith("language=") Then
                languageLabel2.Text = Split(stringReader, "=")(0)
                Dim language = Split(stringReader, "=")(1)
                languageTextBox2.Text = language

            ElseIf stringReader.StartsWith("machine=") Then
                machineLabel2.Text = Split(stringReader, "=")(0)
                Dim machine = Split(stringReader, "=")(1)
                If machineComboBox1.Items.Contains(machine) Then
                    machineComboBox1.SelectedIndex = machineComboBox1.Items.IndexOf(machine)
                End If

            ElseIf stringReader.StartsWith("captures=") Then
                capturesLabel2.Text = Split(stringReader, "=")(0)
                Dim captures = Split(stringReader, "=")(1)
                capturesTextBox2.Text = captures

            ElseIf stringReader.StartsWith("memsize=") Then
                memsizeLabel2.Text = Split(stringReader, "=")(0)
                Dim memsize = Split(stringReader, "=")(1)
                memsizeTextBox2.Text = memsize

            ElseIf stringReader.StartsWith("frameskip=") Then
                frameskip_Label2.Text = Split(stringReader, "=")(0)
                Dim frameskip = Split(stringReader, "=")(1)
                frameskip_TextBox2.Text = frameskip

            ElseIf stringReader.StartsWith("aspect=") Then
                aspect_Label2.Text = Split(stringReader, "=")(0)
                Dim aspect = Split(stringReader, "=")(1)
                If aspect_ComboBox1.Items.Contains(aspect) Then
                    aspect_ComboBox1.SelectedIndex = aspect_ComboBox1.Items.IndexOf(aspect)
                End If

            ElseIf stringReader.StartsWith("scaler=") Then
                scalerLabel2.Text = Split(stringReader, "=")(0)
                Dim scaler = Split(stringReader, "=")(1)
                If scalerComboBox1.Items.Contains(scaler) Then
                    scalerComboBox1.SelectedIndex = scalerComboBox1.Items.IndexOf(scaler)
                End If

            ElseIf stringReader.StartsWith("core=") Then
                coreLabel2.Text = Split(stringReader, "=")(0)
                Dim core = Split(stringReader, "=")(1)
                If coreComboBox1.Items.Contains(core) Then
                    coreComboBox1.SelectedIndex = coreComboBox1.Items.IndexOf(core)
                End If

            ElseIf stringReader.StartsWith("cputype=") Then
                cputypeLabel2.Text = Split(stringReader, "=")(0)
                Dim cputype = Split(stringReader, "=")(1)
                If cputypeComboBox1.Items.Contains(cputype) Then
                    cputypeComboBox1.SelectedIndex = cputypeComboBox1.Items.IndexOf(cputype)
                End If

            ElseIf stringReader.StartsWith("cycles=") Then
                cyclesLabel2.Text = Split(stringReader, "=")(0)
                Dim cycles = Split(stringReader, "=")(1)
                'Check if full resoltion option exists
                If cyclesComboBox1.Items.Contains(cycles) Then
                    cyclesComboBox1.SelectedIndex = cyclesComboBox1.Items.IndexOf(cycles)
                Else
                    cyclesComboBox1.Text = cycles
                End If

            ElseIf stringReader.StartsWith("cycleup=") Then
                cycleupLabel2.Text = Split(stringReader, "=")(0)
                Dim cycleup = Split(stringReader, "=")(1)
                cycleupTextBox2.Text = cycleup

            ElseIf stringReader.StartsWith("cycledown=") Then
                cycledownLabel2.Text = Split(stringReader, "=")(0)
                Dim cycledown = Split(stringReader, "=")(1)
                cycledownTextBox2.Text = cycledown

            ElseIf stringReader.StartsWith("nosound=") Then
                nosoundLabel2.Text = Split(stringReader, "=")(0)
                Dim nosound = Split(stringReader, "=")(1)
                If nosoundComboBox1.Items.Contains(nosound) Then
                    nosoundComboBox1.SelectedIndex = nosoundComboBox1.Items.IndexOf(nosound)
                End If

            ElseIf stringReader.StartsWith("rate=") Then
                rateLabel2.Text = Split(stringReader, "=")(0)
                Dim rate = Split(stringReader, "=")(1)
                If rateComboBox1.Items.Contains(rate) Then
                    rateComboBox1.SelectedIndex = rateComboBox1.Items.IndexOf(rate)
                End If

            ElseIf stringReader.StartsWith("blocksize=") Then
                blocksizeLabel2.Text = Split(stringReader, "=")(0)
                Dim blocksize = Split(stringReader, "=")(1)
                If blocksizeComboBox1.Items.Contains(blocksize) Then
                    blocksizeComboBox1.SelectedIndex = blocksizeComboBox1.Items.IndexOf(blocksize)
                End If

            ElseIf stringReader.StartsWith("prebuffer=") Then
                prebufferLabel2.Text = Split(stringReader, "=")(0)
                Dim prebuffer = Split(stringReader, "=")(1)
                prebufferTextBox2.Text = prebuffer

            ElseIf stringReader.StartsWith("mpu401=") Then
                mpu401Label2.Text = Split(stringReader, "=")(0)
                Dim mpu401 = Split(stringReader, "=")(1)
                If mpu401ComboBox1.Items.Contains(mpu401) Then
                    mpu401ComboBox1.SelectedIndex = mpu401ComboBox1.Items.IndexOf(mpu401)
                End If

            ElseIf stringReader.StartsWith("mididevice=") Then
                midideviceLabel2.Text = Split(stringReader, "=")(0)
                Dim mididevice = Split(stringReader, "=")(1)
                If midideviceComboBox1.Items.Contains(mididevice) Then
                    midideviceComboBox1.SelectedIndex = midideviceComboBox1.Items.IndexOf(mididevice)
                End If

            ElseIf stringReader.StartsWith("midiconfig=") Then
                midiconfigLabel2.Text = Split(stringReader, "=")(0)
                Dim midiconfig = Split(stringReader, "=")(1)
                midiconfigTextBox2.Text = midiconfig

            ElseIf stringReader.StartsWith("sbtype=") Then
                sbtypeLabel2.Text = Split(stringReader, "=")(0)
                Dim sbtype = Split(stringReader, "=")(1)
                If sbtypeComboBox1.Items.Contains(sbtype) Then
                    sbtypeComboBox1.SelectedIndex = sbtypeComboBox1.Items.IndexOf(sbtype)
                End If

            ElseIf stringReader.StartsWith("sbbase=") Then
                sbbaseLabel2.Text = Split(stringReader, "=")(0)
                Dim sbbase = Split(stringReader, "=")(1)
                If sbbaseComboBox1.Items.Contains(sbbase) Then
                    sbbaseComboBox1.SelectedIndex = sbbaseComboBox1.Items.IndexOf(sbbase)
                End If

            ElseIf stringReader.StartsWith("irq=") Then
                irqLabel2.Text = Split(stringReader, "=")(0)
                Dim irq = Split(stringReader, "=")(1)
                If irqComboBox1.Items.Contains(irq) Then
                    irqComboBox1.SelectedIndex = irqComboBox1.Items.IndexOf(irq)
                End If

            ElseIf stringReader.StartsWith("dma=") Then
                dmaLabel2.Text = Split(stringReader, "=")(0)
                Dim dma = Split(stringReader, "=")(1)
                If dmaComboBox1.Items.Contains(dma) Then
                    dmaComboBox1.SelectedIndex = dmaComboBox1.Items.IndexOf(dma)
                End If

            ElseIf stringReader.StartsWith("hdma=") Then
                hdmaLabel2.Text = Split(stringReader, "=")(0)
                Dim hdma = Split(stringReader, "=")(1)
                If hdmaComboBox1.Items.Contains(hdma) Then
                    hdmaComboBox1.SelectedIndex = hdmaComboBox1.Items.IndexOf(hdma)
                End If

            ElseIf stringReader.StartsWith("sbmixer=") Then
                sbmixerLabel2.Text = Split(stringReader, "=")(0)
                Dim sbmixer = Split(stringReader, "=")(1)
                If sbmixerComboBox1.Items.Contains(sbmixer) Then
                    sbmixerComboBox1.SelectedIndex = sbmixerComboBox1.Items.IndexOf(sbmixer)
                End If

            ElseIf stringReader.StartsWith("oplmode=") Then
                oplmodeLabel2.Text = Split(stringReader, "=")(0)
                Dim oplmode = Split(stringReader, "=")(1)
                If oplmodeComboBox1.Items.Contains(oplmode) Then
                    oplmodeComboBox1.SelectedIndex = oplmodeComboBox1.Items.IndexOf(oplmode)
                End If

            ElseIf stringReader.StartsWith("oplemu=") Then
                oplemuLabel2.Text = Split(stringReader, "=")(0)
                Dim oplemu = Split(stringReader, "=")(1)
                If oplemuComboBox1.Items.Contains(oplemu) Then
                    oplemuComboBox1.SelectedIndex = oplemuComboBox1.Items.IndexOf(oplemu)
                End If

            ElseIf stringReader.StartsWith("oplrate=") Then
                oplrateLabel2.Text = Split(stringReader, "=")(0)
                Dim oplrate = Split(stringReader, "=")(1)
                If oplrateComboBox1.Items.Contains(oplrate) Then
                    oplrateComboBox1.SelectedIndex = oplrateComboBox1.Items.IndexOf(oplrate)
                End If

            ElseIf stringReader.StartsWith("gus=") Then
                gusLabel2.Text = Split(stringReader, "=")(0)
                Dim gus = Split(stringReader, "=")(1)
                If gusComboBox1.Items.Contains(gus) Then
                    gusComboBox1.SelectedIndex = gusComboBox1.Items.IndexOf(gus)
                End If

            ElseIf stringReader.StartsWith("gusrate=") Then
                gusrateLabel2.Text = Split(stringReader, "=")(0)
                Dim gusrate = Split(stringReader, "=")(1)
                If gusrateComboBox1.Items.Contains(gusrate) Then
                    gusrateComboBox1.SelectedIndex = gusrateComboBox1.Items.IndexOf(gusrate)
                End If

            ElseIf stringReader.StartsWith("gusbase=") Then
                gusbaseLabel2.Text = Split(stringReader, "=")(0)
                Dim gusbase = Split(stringReader, "=")(1)
                If gusbaseComboBox1.Items.Contains(gusbase) Then
                    gusbaseComboBox1.SelectedIndex = gusbaseComboBox1.Items.IndexOf(gusbase)
                End If

            ElseIf stringReader.StartsWith("gusirq=") Then
                gusirqLabel2.Text = Split(stringReader, "=")(0)
                Dim gusirq = Split(stringReader, "=")(1)
                If gusirqComboBox1.Items.Contains(gusirq) Then
                    gusirqComboBox1.SelectedIndex = gusirqComboBox1.Items.IndexOf(gusirq)
                End If

            ElseIf stringReader.StartsWith("gusdma=") Then
                gusdmaLabel2.Text = Split(stringReader, "=")(0)
                Dim gusdma = Split(stringReader, "=")(1)
                If gusdmaComboBox1.Items.Contains(gusdma) Then
                    gusdmaComboBox1.SelectedIndex = gusdmaComboBox1.Items.IndexOf(gusdma)
                End If

            ElseIf stringReader.StartsWith("ultradir=") Then
                ultradirLabel2.Text = Split(stringReader, "=")(0)
                Dim ultradir = Split(stringReader, "=")(1)
                ultradirTextBox2.Text = ultradir

            ElseIf stringReader.StartsWith("pcspeaker=") Then
                pcspeakerLabel2.Text = Split(stringReader, "=")(0)
                Dim pcspeaker = Split(stringReader, "=")(1)
                If pcspeakerComboBox1.Items.Contains(pcspeaker) Then
                    pcspeakerComboBox1.SelectedIndex = pcspeakerComboBox1.Items.IndexOf(pcspeaker)
                End If

            ElseIf stringReader.StartsWith("pcrate=") Then
                pcrateLabel2.Text = Split(stringReader, "=")(0)
                Dim pcrate = Split(stringReader, "=")(1)
                If pcrateComboBox1.Items.Contains(pcrate) Then
                    pcrateComboBox1.SelectedIndex = pcrateComboBox1.Items.IndexOf(pcrate)
                End If

            ElseIf stringReader.StartsWith("tandy=") Then
                tandyLabel2.Text = Split(stringReader, "=")(0)
                Dim tandy = Split(stringReader, "=")(1)
                If tandyComboBox1.Items.Contains(tandy) Then
                    tandyComboBox1.SelectedIndex = tandyComboBox1.Items.IndexOf(tandy)
                End If

            ElseIf stringReader.StartsWith("tandyrate=") Then
                tandyrateLabel2.Text = Split(stringReader, "=")(0)
                Dim tandyrate = Split(stringReader, "=")(1)
                If tandyrateComboBox1.Items.Contains(tandyrate) Then
                    tandyrateComboBox1.SelectedIndex = tandyrateComboBox1.Items.IndexOf(tandyrate)
                End If

            ElseIf stringReader.StartsWith("disney=") Then
                disneyLabel2.Text = Split(stringReader, "=")(0)
                Dim disney = Split(stringReader, "=")(1)
                If disneyComboBox1.Items.Contains(disney) Then
                    disneyComboBox1.SelectedIndex = disneyComboBox1.Items.IndexOf(disney)
                End If

            ElseIf stringReader.StartsWith("joysticktype=") Then
                joysticktypeLabel2.Text = Split(stringReader, "=")(0)
                Dim joysticktype = Split(stringReader, "=")(1)
                If joysticktypeComboBox1.Items.Contains(joysticktype) Then
                    joysticktypeComboBox1.SelectedIndex = joysticktypeComboBox1.Items.IndexOf(joysticktype)
                End If

            ElseIf stringReader.StartsWith("timed=") Then
                timedLabel2.Text = Split(stringReader, "=")(0)
                Dim timed = Split(stringReader, "=")(1)
                If timedComboBox1.Items.Contains(timed) Then
                    timedComboBox1.SelectedIndex = timedComboBox1.Items.IndexOf(timed)
                End If

            ElseIf stringReader.StartsWith("autofire=") Then
                autofireLabel2.Text = Split(stringReader, "=")(0)
                Dim autofire = Split(stringReader, "=")(1)
                If autofireComboBox1.Items.Contains(autofire) Then
                    autofireComboBox1.SelectedIndex = autofireComboBox1.Items.IndexOf(autofire)
                End If

            ElseIf stringReader.StartsWith("swap34=") Then
                swap34Label2.Text = Split(stringReader, "=")(0)
                Dim swap34 = Split(stringReader, "=")(1)
                If swap34ComboBox1.Items.Contains(swap34) Then
                    swap34ComboBox1.SelectedIndex = swap34ComboBox1.Items.IndexOf(swap34)
                End If

            ElseIf stringReader.StartsWith("buttonwrap=") Then
                buttonwrapLabel2.Text = Split(stringReader, "=")(0)
                Dim buttonwrap = Split(stringReader, "=")(1)
                If buttonwrapComboBox1.Items.Contains(buttonwrap) Then
                    buttonwrapComboBox1.SelectedIndex = buttonwrapComboBox1.Items.IndexOf(buttonwrap)
                End If

            ElseIf stringReader.StartsWith("serial1=") Then
                serial1Label2.Text = Split(stringReader, "=")(0)
                Dim serial1 = Split(stringReader, "=")(1)
                If serial1ComboBox1.Items.Contains(serial1) Then
                    serial1ComboBox1.SelectedIndex = serial1ComboBox1.Items.IndexOf(serial1)
                End If

            ElseIf stringReader.StartsWith("serial2=") Then
                serial2Label2.Text = Split(stringReader, "=")(0)
                Dim serial2 = Split(stringReader, "=")(1)
                If serial2ComboBox1.Items.Contains(serial2) Then
                    serial2ComboBox1.SelectedIndex = serial2ComboBox1.Items.IndexOf(serial2)
                End If

            ElseIf stringReader.StartsWith("serial3=") Then
                serial3Label2.Text = Split(stringReader, "=")(0)
                Dim serial3 = Split(stringReader, "=")(1)
                If serial3ComboBox1.Items.Contains(serial3) Then
                    serial3ComboBox1.SelectedIndex = serial3ComboBox1.Items.IndexOf(serial3)
                End If

            ElseIf stringReader.StartsWith("serial4=") Then
                serial4Label2.Text = Split(stringReader, "=")(0)
                Dim serial4 = Split(stringReader, "=")(1)
                If serial4ComboBox1.Items.Contains(serial4) Then
                    serial4ComboBox1.SelectedIndex = serial4ComboBox1.Items.IndexOf(serial4)
                End If

            ElseIf stringReader.StartsWith("xms=") Then
                xmsLabel2.Text = Split(stringReader, "=")(0)
                Dim xms = Split(stringReader, "=")(1)
                If xmsComboBox1.Items.Contains(xms) Then
                    xmsComboBox1.SelectedIndex = xmsComboBox1.Items.IndexOf(xms)
                End If


            ElseIf stringReader.StartsWith("ems=") Then
                emsLabel2.Text = Split(stringReader, "=")(0)
                Dim ems = Split(stringReader, "=")(1)
                If emsComboBox1.Items.Contains(ems) Then
                    emsComboBox1.SelectedIndex = emsComboBox1.Items.IndexOf(ems)
                End If

            ElseIf stringReader.StartsWith("umb=") Then
                umbLabel2.Text = Split(stringReader, "=")(0)
                Dim umb = Split(stringReader, "=")(1)
                If umbComboBox1.Items.Contains(umb) Then
                    umbComboBox1.SelectedIndex = umbComboBox1.Items.IndexOf(umb)
                End If

            ElseIf stringReader.StartsWith("keyboardlayout=") Then
                keyboardlayoutLabel2.Text = Split(stringReader, "=")(0)
                Dim keyboardlayout = Split(stringReader, "=")(1)
                If keyboardlayoutComboBox1.Items.Contains(keyboardlayout) Then
                    keyboardlayoutComboBox1.SelectedIndex = keyboardlayoutComboBox1.Items.IndexOf(keyboardlayout)
                End If

            ElseIf stringReader.StartsWith("ipx=") Then
                ipxLabel2.Text = Split(stringReader, "=")(0)
                Dim ipx = Split(stringReader, "=")(1)
                If ipxComboBox1.Items.Contains(ipx) Then
                    ipxComboBox1.SelectedIndex = ipxComboBox1.Items.IndexOf(ipx)
                End If

            End If

            'Populate textbox with read conf file.
            TextBox1.AppendText(stringReader & vbCrLf)
            'Read next line
            stringReader = fileReader.ReadLine()

        End While

        fileReader.Close()

        If saveEnable = False Then
            saveEnable = True
        End If
        If OpenConfDirectlyToolStripMenuItem.Enabled = False Then
            OpenConfDirectlyToolStripMenuItem.Enabled = True
        End If
        enableSave()

    End Sub
    Sub backupConf()
        Dim newFileName As String = Path.GetDirectoryName(OpenFileDialog1.FileName) + "\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_dosbox-0.74-3.conf"
        My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, newFileName)
    End Sub
    Sub enableSave()
        If saveEnable = False Then
            SaveToolStripMenuItem.Enabled = False
            SaveASToolStripMenuItem.Enabled = False
        Else
            SaveToolStripMenuItem.Enabled = True
            SaveASToolStripMenuItem.Enabled = True
        End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim Msg, Style, Title, Response
        Msg = "Do you want to backup your conf file before continuing ?"    ' Define message.
        Style = vbYesNo + vbCritical + vbDefaultButton2    ' Define buttons.
        Title = "Opening CONF file"    ' Define title.
        ' Display message.
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' User chose Yes.
            backupConf()
            openConf()
        Else    ' User chose No.
            openConf()
        End If
        If TabControl.Visible = False Then
            TabControl.Visible = True
        End If

    End Sub
    Sub loadOptionsFullScreen()
        fullscreenComboBox1.Items.Add("true")
        fullscreenComboBox1.Items.Add("false")
    End Sub
    Sub loadOptionsFullDouble()
        fulldoubleComboBox1.Items.Add("true")
        fulldoubleComboBox1.Items.Add("false")
    End Sub
    Sub loadOptionAutoLock()
        autolockComboBox1.Items.Add("true")
        autolockComboBox1.Items.Add("false")
    End Sub
    Sub loadOptionwaitonerror()
        waitonerrorComboBox1.Items.Add("true")
        waitonerrorComboBox1.Items.Add("false")
    End Sub
    Sub loadOptionsFullResolution()
        fullresolutionComboBox1.Items.Add("original")
        fullresolutionComboBox1.Items.Add("desktop")
        windowresolutionComboBox1.Items.Add("original")
        windowresolutionComboBox1.Items.Add("desktop")
    End Sub
    Sub loadOutputOptions()
        outputComboBox1.Items.Add("surface")
        outputComboBox1.Items.Add("overlay")
        outputComboBox1.Items.Add("opengl")
        outputComboBox1.Items.Add("openglnb")
        outputComboBox1.Items.Add("ddraw")
    End Sub
    Sub loadOutputpriority()
        priorityComboBox1.Items.Add("lowest")
        priorityComboBox1.Items.Add("lower")
        priorityComboBox1.Items.Add("normal")
        priorityComboBox1.Items.Add("higher")
        priorityComboBox1.Items.Add("highest")
        priorityComboBox1.Items.Add("pause")

        priorityComboBox2.Items.Add("lowest")
        priorityComboBox2.Items.Add("lower")
        priorityComboBox2.Items.Add("normal")
        priorityComboBox2.Items.Add("higher")
        priorityComboBox2.Items.Add("highest")
        priorityComboBox2.Items.Add("pause")
    End Sub
    Sub loadOptionsusescancodes()
        usescancodesComboBox1.Items.Add("true")
        usescancodesComboBox1.Items.Add("false")
    End Sub
    Sub loadOutputmachine()
        machineComboBox1.Items.Add("hercules")
        machineComboBox1.Items.Add("cga")
        machineComboBox1.Items.Add("tandy")
        machineComboBox1.Items.Add("pcjr")
        machineComboBox1.Items.Add("ega")
        machineComboBox1.Items.Add("vgaonly")
        machineComboBox1.Items.Add("svga_s3")
        machineComboBox1.Items.Add("svga_et3000")
        machineComboBox1.Items.Add("svga_et4000")
        machineComboBox1.Items.Add("svga_paradise")
        machineComboBox1.Items.Add("vesa_nolfb")
        machineComboBox1.Items.Add("vesa_oldvbe")
    End Sub
    Sub loadOutputscaler()
        scalerComboBox1.Items.Add("none")
        scalerComboBox1.Items.Add("normal2x")
        scalerComboBox1.Items.Add("normal3x")
        scalerComboBox1.Items.Add("advmame2x")
        scalerComboBox1.Items.Add("advmame3x")
        scalerComboBox1.Items.Add("advinterp2x")
        scalerComboBox1.Items.Add("advinterp3x")
        scalerComboBox1.Items.Add("hq2x")
        scalerComboBox1.Items.Add("hq3x")
        scalerComboBox1.Items.Add("2xsai")
        scalerComboBox1.Items.Add("super2xsai")
        scalerComboBox1.Items.Add("supereagle")
        scalerComboBox1.Items.Add("tv2x")
        scalerComboBox1.Items.Add("tv3x")
        scalerComboBox1.Items.Add("rgb2x")
        scalerComboBox1.Items.Add("rgb3x")
        scalerComboBox1.Items.Add("scan2x")
        scalerComboBox1.Items.Add("scan3x")
    End Sub
    Sub loadOption_aspect()
        aspect_ComboBox1.Items.Add("true")
        aspect_ComboBox1.Items.Add("false")
    End Sub
    Sub loadOptionCore()
        coreComboBox1.Items.Add("auto")
        coreComboBox1.Items.Add("dynamic")
        coreComboBox1.Items.Add("normal")
        coreComboBox1.Items.Add("simple")
    End Sub
    Sub loadcputype()
        cputypeComboBox1.Items.Add("auto")
        cputypeComboBox1.Items.Add("386")
        cputypeComboBox1.Items.Add("386_slow")
        cputypeComboBox1.Items.Add("486_slow")
        cputypeComboBox1.Items.Add("pentium_slow")
        cputypeComboBox1.Items.Add("386_prefetch")
    End Sub
    Sub loadcycles()
        cyclesComboBox1.Items.Add("auto")
        cyclesComboBox1.Items.Add("fixed #")
        cyclesComboBox1.Items.Add("max")
    End Sub
    Sub loadNoSound()
        nosoundComboBox1.Items.Add("true")
        nosoundComboBox1.Items.Add("false")
    End Sub
    Sub loadmixerRate()
        rateComboBox1.Items.Add("44100")
        rateComboBox1.Items.Add("48000")
        rateComboBox1.Items.Add("32000")
        rateComboBox1.Items.Add("22050")
        rateComboBox1.Items.Add("16000")
        rateComboBox1.Items.Add("11025")
        rateComboBox1.Items.Add("8000")
        rateComboBox1.Items.Add("49716")
    End Sub
    Sub loadmixerblocksize()
        blocksizeComboBox1.Items.Add("1024")
        blocksizeComboBox1.Items.Add("2048")
        blocksizeComboBox1.Items.Add("4096")
        blocksizeComboBox1.Items.Add("8192")
        blocksizeComboBox1.Items.Add("512")
        blocksizeComboBox1.Items.Add("256")
    End Sub
    Sub loadOptionsmpu401()
        mpu401ComboBox1.Items.Add("intelligent")
        mpu401ComboBox1.Items.Add("uart")
        mpu401ComboBox1.Items.Add("none")
    End Sub
    Sub loadmididevice()
        midideviceComboBox1.Items.Add("default")
        midideviceComboBox1.Items.Add("win32")
        midideviceComboBox1.Items.Add("alsa")
        midideviceComboBox1.Items.Add("oss")
        midideviceComboBox1.Items.Add("coreaudio")
        midideviceComboBox1.Items.Add("coremidi")
        midideviceComboBox1.Items.Add("none")
    End Sub
    Sub loadsbtype()
        sbtypeComboBox1.Items.Add("sb1")
        sbtypeComboBox1.Items.Add("sb2")
        sbtypeComboBox1.Items.Add("sbpro1")
        sbtypeComboBox1.Items.Add("sbpro2")
        sbtypeComboBox1.Items.Add("sb16")
        sbtypeComboBox1.Items.Add("gb")
        sbtypeComboBox1.Items.Add("none")
    End Sub
    Sub loadsbbase()
        sbbaseComboBox1.Items.Add("220")
        sbbaseComboBox1.Items.Add("240")
        sbbaseComboBox1.Items.Add("260")
        sbbaseComboBox1.Items.Add("280")
        sbbaseComboBox1.Items.Add("2a0")
        sbbaseComboBox1.Items.Add("2c0")
        sbbaseComboBox1.Items.Add("2e0")
        sbbaseComboBox1.Items.Add("300")
    End Sub
    Sub loadirq()
        irqComboBox1.Items.Add("7")
        irqComboBox1.Items.Add("5")
        irqComboBox1.Items.Add("3")
        irqComboBox1.Items.Add("9")
        irqComboBox1.Items.Add("10")
        irqComboBox1.Items.Add("11")
        irqComboBox1.Items.Add("12")
    End Sub
    Sub loaddma()
        dmaComboBox1.Items.Add("1")
        dmaComboBox1.Items.Add("5")
        dmaComboBox1.Items.Add("0")
        dmaComboBox1.Items.Add("3")
        dmaComboBox1.Items.Add("6")
        dmaComboBox1.Items.Add("7")
    End Sub
    Sub loadhdma()
        hdmaComboBox1.Items.Add("1")
        hdmaComboBox1.Items.Add("5")
        hdmaComboBox1.Items.Add("0")
        hdmaComboBox1.Items.Add("3")
        hdmaComboBox1.Items.Add("6")
        hdmaComboBox1.Items.Add("7")
    End Sub
    Sub loadsbmixer()
        sbmixerComboBox1.Items.Add("true")
        sbmixerComboBox1.Items.Add("false")
    End Sub
    Sub loadoplmode()
        oplmodeComboBox1.Items.Add("auto")
        oplmodeComboBox1.Items.Add("cms")
        oplmodeComboBox1.Items.Add("opl2")
        oplmodeComboBox1.Items.Add("dualopl2")
        oplmodeComboBox1.Items.Add("opl3")
        oplmodeComboBox1.Items.Add("none")
    End Sub
    Sub loadoplemu()
        oplemuComboBox1.Items.Add("default")
        oplemuComboBox1.Items.Add("compat")
        oplemuComboBox1.Items.Add("fast")
    End Sub
    Sub loadoplrate()
        oplrateComboBox1.Items.Add("44100")
        oplrateComboBox1.Items.Add("49716")
        oplrateComboBox1.Items.Add("48000")
        oplrateComboBox1.Items.Add("32000")
        oplrateComboBox1.Items.Add("22050")
        oplrateComboBox1.Items.Add("16000")
        oplrateComboBox1.Items.Add("11025")
        oplrateComboBox1.Items.Add("8000")
    End Sub
    Sub loadgus()
        gusComboBox1.Items.Add("true")
        gusComboBox1.Items.Add("false")
    End Sub
    Sub loadgusrate()
        gusrateComboBox1.Items.Add("44100")
        gusrateComboBox1.Items.Add("48000")
        gusrateComboBox1.Items.Add("32000")
        gusrateComboBox1.Items.Add("22050")
        gusrateComboBox1.Items.Add("16000")
        gusrateComboBox1.Items.Add("11025")
        gusrateComboBox1.Items.Add("8000")
        gusrateComboBox1.Items.Add("49716")
    End Sub
    Sub loadgusbase()
        gusbaseComboBox1.Items.Add("240")
        gusbaseComboBox1.Items.Add("220")
        gusbaseComboBox1.Items.Add("260")
        gusbaseComboBox1.Items.Add("280")
        gusbaseComboBox1.Items.Add("2a0")
        gusbaseComboBox1.Items.Add("2c0")
        gusbaseComboBox1.Items.Add("2e0")
        gusbaseComboBox1.Items.Add("300")
    End Sub
    Sub loadgusirq()
        gusirqComboBox1.Items.Add("5")
        gusirqComboBox1.Items.Add("3")
        gusirqComboBox1.Items.Add("7")
        gusirqComboBox1.Items.Add("9")
        gusirqComboBox1.Items.Add("10")
        gusirqComboBox1.Items.Add("11")
        gusirqComboBox1.Items.Add("12")
    End Sub
    Sub loadgusdma()
        gusdmaComboBox1.Items.Add("3")
        gusdmaComboBox1.Items.Add("0")
        gusdmaComboBox1.Items.Add("1")
        gusdmaComboBox1.Items.Add("5")
        gusdmaComboBox1.Items.Add("6")
        gusdmaComboBox1.Items.Add("7")
    End Sub
    Sub loadpcspeaker()
        pcspeakerComboBox1.Items.Add("true")
        pcspeakerComboBox1.Items.Add("false")
    End Sub
    Sub loadpcrate()
        pcrateComboBox1.Items.Add("44100")
        pcrateComboBox1.Items.Add("48000")
        pcrateComboBox1.Items.Add("32000")
        pcrateComboBox1.Items.Add("22050")
        pcrateComboBox1.Items.Add("16000")
        pcrateComboBox1.Items.Add("11025")
        pcrateComboBox1.Items.Add("8000")
        pcrateComboBox1.Items.Add("49716")
    End Sub
    Sub loadtandy()
        tandyComboBox1.Items.Add("auto")
        tandyComboBox1.Items.Add("on")
        tandyComboBox1.Items.Add("off")
    End Sub
    Sub loadtandyrate()
        tandyrateComboBox1.Items.Add("44100")
        tandyrateComboBox1.Items.Add("48000")
        tandyrateComboBox1.Items.Add("32000")
        tandyrateComboBox1.Items.Add("22050")
        tandyrateComboBox1.Items.Add("16000")
        tandyrateComboBox1.Items.Add("11025")
        tandyrateComboBox1.Items.Add("8000")
        tandyrateComboBox1.Items.Add("49716")
    End Sub
    Sub loaddisney()
        disneyComboBox1.Items.Add("true")
        disneyComboBox1.Items.Add("false")
    End Sub
    Sub loadjoysticktype()
        joysticktypeComboBox1.Items.Add("auto")
        joysticktypeComboBox1.Items.Add("2axis")
        joysticktypeComboBox1.Items.Add("4axis")
        joysticktypeComboBox1.Items.Add("4axis_2")
        joysticktypeComboBox1.Items.Add("fcs")
        joysticktypeComboBox1.Items.Add("ch")
        joysticktypeComboBox1.Items.Add("none")
    End Sub
    Sub loadautofire()
        autofireComboBox1.Items.Add("true")
        autofireComboBox1.Items.Add("false")
    End Sub
    Sub loadswap34()
        swap34ComboBox1.Items.Add("true")
        swap34ComboBox1.Items.Add("false")
    End Sub
    Sub loadbuttonwrap()
        buttonwrapComboBox1.Items.Add("true")
        buttonwrapComboBox1.Items.Add("false")
    End Sub
    Sub loadtimed()
        timedComboBox1.Items.Add("true")
        timedComboBox1.Items.Add("false")
    End Sub
    Sub loadserial()
        serial1ComboBox1.Items.Add("dummy")
        serial1ComboBox1.Items.Add("disabled")
        serial1ComboBox1.Items.Add("nullmodem")
        serial1ComboBox1.Items.Add("directserial")
        serial2ComboBox1.Items.Add("dummy")
        serial2ComboBox1.Items.Add("disabled")
        serial2ComboBox1.Items.Add("nullmodem")
        serial2ComboBox1.Items.Add("directserial")
        serial3ComboBox1.Items.Add("dummy")
        serial3ComboBox1.Items.Add("disabled")
        serial3ComboBox1.Items.Add("nullmodem")
        serial3ComboBox1.Items.Add("directserial")
        serial4ComboBox1.Items.Add("dummy")
        serial4ComboBox1.Items.Add("disabled")
        serial4ComboBox1.Items.Add("nullmodem")
        serial4ComboBox1.Items.Add("directserial")
    End Sub
    Sub loadxms()
        xmsComboBox1.Items.Add("true")
        xmsComboBox1.Items.Add("false")
    End Sub
    Sub loadems()
        emsComboBox1.Items.Add("true")
        emsComboBox1.Items.Add("false")
    End Sub
    Sub loadumb()
        umbComboBox1.Items.Add("true")
        umbComboBox1.Items.Add("false")
    End Sub
    Sub loadkeyboardlayout()
        keyboardlayoutComboBox1.Items.Add("auto")
        keyboardlayoutComboBox1.Items.Add("none")
    End Sub
    Sub loadipx()
        ipxComboBox1.Items.Add("true")
        ipxComboBox1.Items.Add("false")
    End Sub
    Sub loadOptions()
        loadkeyboardlayout()
        loadipx()
        loadumb()
        loadems()
        loadxms()
        loadserial()
        loadtimed()
        loadswap34()
        loadbuttonwrap()
        loadautofire()
        loadjoysticktype()
        loaddisney()
        loadtandyrate()
        loadtandy()
        loadpcrate()
        loadpcspeaker()
        loadgusdma()
        loadgusirq()
        loadgusbase()
        loadgusrate()
        loadgus()
        loadoplrate()
        loadoplemu()
        loadoplmode()
        loadsbmixer()
        loadhdma()
        loaddma()
        loadirq()
        loadsbbase()
        loadOptionsFullScreen()
        loadOptionsFullDouble()
        loadOptionsFullResolution()
        loadOutputOptions()
        loadOptionAutoLock()
        loadOptionwaitonerror()
        loadOutputpriority()
        loadOptionsusescancodes()
        loadOutputmachine()
        loadOption_aspect()
        loadOutputscaler()
        loadOptionCore()
        loadcputype()
        loadcycles()
        loadNoSound()
        loadmixerRate()
        loadmixerblocksize()
        loadOptionsmpu401()
        loadmididevice()
        loadsbtype()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl.Visible = False
        enableSave()
        loadOptions()
    End Sub

    Private Sub SaveASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveASToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Sub saveConf()
        'Replace settings in textbox1 text to save as file.
        Dim tempArray() As String
        tempArray = TextBox1.Lines
        For i = 0 To tempArray.Length - 1

            '====
            'sdl
            '====

            If tempArray(i).StartsWith("fullscreen=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "fullscreen=" + fullscreenComboBox1.Text)

            ElseIf tempArray(i).StartsWith("fulldouble=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "fulldouble=" + fulldoubleComboBox1.Text)

            ElseIf tempArray(i).StartsWith("fullresolution=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "fullresolution=" + fullresolutionComboBox1.Text)

            ElseIf tempArray(i).StartsWith("windowresolution=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "windowresolution=" + windowresolutionComboBox1.Text)

            ElseIf tempArray(i).StartsWith("output=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "output=" + outputComboBox1.Text)

            ElseIf tempArray(i).StartsWith("autolock=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "autolock=" + autolockComboBox1.Text)

            ElseIf tempArray(i).StartsWith("sensitivity=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "sensitivity=" + sensitivityNumericUpDown1.Value.ToString)

            ElseIf tempArray(i).StartsWith("waitonerror=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "waitonerror=" + waitonerrorComboBox1.Text)

            ElseIf tempArray(i).StartsWith("priority=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "priority=" + priorityComboBox1.Text + "," + priorityComboBox2.Text)

            ElseIf tempArray(i).StartsWith("mapperfile=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "mapperfile=" + mapperfileTextBox2.Text)

            ElseIf tempArray(i).StartsWith("usescancodes=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "usescancodes=" + usescancodesComboBox1.Text)

                '======
                'dosbox
                '======

            ElseIf tempArray(i).StartsWith("language=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "language=" + languageTextBox2.Text)

            ElseIf tempArray(i).StartsWith("machine=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "machine=" + machineComboBox1.Text)

            ElseIf tempArray(i).StartsWith("captures=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "captures=" + capturesTextBox2.Text)

            ElseIf tempArray(i).StartsWith("memsize=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "memsize=" + memsizeTextBox2.Text)

                '======
                'render
                '======

            ElseIf tempArray(i).StartsWith("frameskip=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "frameskip=" + frameskip_TextBox2.Text)

            ElseIf tempArray(i).StartsWith("aspect=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "aspect=" + aspect_ComboBox1.Text)

            ElseIf tempArray(i).StartsWith("scaler=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "scaler=" + scalerComboBox1.Text)

                '====
                'cpu
                '====

            ElseIf tempArray(i).StartsWith("core=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "core=" + coreComboBox1.Text)

            ElseIf tempArray(i).StartsWith("cputype=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "cputype=" + cputypeComboBox1.Text)

            ElseIf tempArray(i).StartsWith("cycles=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "cycles=" + cyclesComboBox1.Text)

            ElseIf tempArray(i).StartsWith("cycleup=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "cycleup=" + cycleupTextBox2.Text)

            ElseIf tempArray(i).StartsWith("cycledown=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "cycledown=" + cycledownTextBox2.Text)

            ElseIf tempArray(i).StartsWith("nosound=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "nosound=" + nosoundComboBox1.Text)

            ElseIf tempArray(i).StartsWith("rate=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "rate=" + rateComboBox1.Text)

            ElseIf tempArray(i).StartsWith("blocksize=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "blocksize=" + blocksizeComboBox1.Text)

            ElseIf tempArray(i).StartsWith("prebuffer=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "prebuffer=" + prebufferTextBox2.Text)

            ElseIf tempArray(i).StartsWith("mpu401=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "mpu401=" + mpu401ComboBox1.Text)

            ElseIf tempArray(i).StartsWith("mididevice=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "mididevice=" + midideviceComboBox1.Text)

            ElseIf tempArray(i).StartsWith("midiconfig=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "midiconfig=" + midiconfigTextBox2.Text)

            ElseIf tempArray(i).StartsWith("sbtype=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "sbtype=" + sbtypeComboBox1.Text)

            ElseIf tempArray(i).StartsWith("sbbase=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "sbbase=" + sbbaseComboBox1.Text)

            ElseIf tempArray(i).StartsWith("irq=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "irq=" + irqComboBox1.Text)

            ElseIf tempArray(i).StartsWith("dma=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "dma=" + dmaComboBox1.Text)

            ElseIf tempArray(i).StartsWith("hdma=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "hdma=" + hdmaComboBox1.Text)

            ElseIf tempArray(i).StartsWith("sbmixer=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "sbmixer=" + sbmixerComboBox1.Text)

            ElseIf tempArray(i).StartsWith("oplmode=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "oplmode=" + oplmodeComboBox1.Text)

            ElseIf tempArray(i).StartsWith("oplemu=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "oplemu=" + oplemuComboBox1.Text)

            ElseIf tempArray(i).StartsWith("oplrate=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "oplrate=" + oplrateComboBox1.Text)

            ElseIf tempArray(i).StartsWith("gus=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "gus=" + gusComboBox1.Text)

            ElseIf tempArray(i).StartsWith("gusrate=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "gusrate=" + gusrateComboBox1.Text)

            ElseIf tempArray(i).StartsWith("gusbase=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "gusbase=" + gusbaseComboBox1.Text)

            ElseIf tempArray(i).StartsWith("gusirq=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "gusirq=" + gusirqComboBox1.Text)

            ElseIf tempArray(i).StartsWith("gusdma=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "gusdma=" + gusdmaComboBox1.Text)

            ElseIf tempArray(i).StartsWith("ultradir=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "ultradir=" + ultradirTextBox2.Text)

            ElseIf tempArray(i).StartsWith("pcspeaker=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "pcspeaker=" + pcspeakerComboBox1.Text)

            ElseIf tempArray(i).StartsWith("pcrate=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "pcrate=" + pcrateComboBox1.Text)

            ElseIf tempArray(i).StartsWith("tandy=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "tandy=" + tandyComboBox1.Text)

            ElseIf tempArray(i).StartsWith("tandyrate=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "tandyrate=" + tandyrateComboBox1.Text)

            ElseIf tempArray(i).StartsWith("disney=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "disney=" + disneyComboBox1.Text)

            ElseIf tempArray(i).StartsWith("joysticktype=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "joysticktype=" + joysticktypeComboBox1.Text)

            ElseIf tempArray(i).StartsWith("timed=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "timed=" + timedComboBox1.Text)

            ElseIf tempArray(i).StartsWith("autofire=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "autofire=" + autofireComboBox1.Text)

            ElseIf tempArray(i).StartsWith("swap34=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "swap34=" + swap34ComboBox1.Text)

            ElseIf tempArray(i).StartsWith("buttonwrap=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "buttonwrap=" + buttonwrapComboBox1.Text)

            ElseIf tempArray(i).StartsWith("serial1=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "serial1=" + serial1ComboBox1.Text)

            ElseIf tempArray(i).StartsWith("serial2=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "serial2=" + serial2ComboBox1.Text)

            ElseIf tempArray(i).StartsWith("serial3=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "serial3=" + serial3ComboBox1.Text)

            ElseIf tempArray(i).StartsWith("serial4=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "serial4=" + serial4ComboBox1.Text)

            ElseIf tempArray(i).StartsWith("xms=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "xms=" + xmsComboBox1.Text)

            ElseIf tempArray(i).StartsWith("ems=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "ems=" + emsComboBox1.Text)

            ElseIf tempArray(i).StartsWith("umb=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "umb=" + umbComboBox1.Text)

            ElseIf tempArray(i).StartsWith("keyboardlayout=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "keyboardlayout=" + keyboardlayoutComboBox1.Text)

            ElseIf tempArray(i).StartsWith("ipx=") Then
                tempArray(i) = tempArray(i).Replace(tempArray(i), "ipx=" + ipxComboBox1.Text)
            End If

        Next

        TextBox1.Lines = tempArray
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        saveConf()
        My.Computer.FileSystem.WriteAllText(confLocation, TextBox1.Text, False)
        'TextBox1.Clear()
        'Dim fileReader As System.IO.StreamReader
        'fileReader = My.Computer.FileSystem.OpenTextFileReader(confLocation)
        'Dim stringReader As String
        'stringReader = fileReader.ReadLine()
        'While stringReader IsNot Nothing
        '    If stringReader.Contains("fullscreen=") Then
        '        stringReader = ("fullscreen=" + fullscreenComboBox1.Text)
        '    ElseIf stringReader.Contains("fulldouble=") Then
        '        stringReader = ("fulldouble=" + fulldoubleComboBox1.Text)
        '    End If
        '    TextBox1.AppendText(stringReader & vbCrLf)
        '    stringReader = fileReader.ReadLine()
        'End While
        'fileReader.Close()
        'My.Computer.FileSystem.WriteAllText(confLocation, TextBox1.Text, False)

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        saveConf()
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
    End Sub

    Private Sub OpenConfDirectlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConfDirectlyToolStripMenuItem.Click
        Process.Start(confLocation)
    End Sub

    Private Sub mapperfileOpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)
        mapperfileTextBox2.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub DownloadDosBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadDosBoxToolStripMenuItem.Click
        Process.Start("https://www.dosbox.com/")
    End Sub

    Private Sub ConfWikiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfWikiToolStripMenuItem.Click
        Process.Start("https://www.dosbox.com/wiki/Dosbox.conf")
    End Sub

    Private Sub capturesButton2_Click(sender As Object, e As EventArgs) Handles capturesButton2.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            capturesTextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

End Class
