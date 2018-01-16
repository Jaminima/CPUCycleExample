<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel_CPU = New System.Windows.Forms.Panel()
        Me.Panel_ACC = New System.Windows.Forms.Panel()
        Me.Label_ACC_Binary = New System.Windows.Forms.Label()
        Me.Label_ACC = New System.Windows.Forms.Label()
        Me.Label_ALU = New System.Windows.Forms.Label()
        Me.Panel_Decoder = New System.Windows.Forms.Panel()
        Me.Label_Decoder = New System.Windows.Forms.Label()
        Me.Panel_CIR = New System.Windows.Forms.Panel()
        Me.Label_CIR_Binary = New System.Windows.Forms.Label()
        Me.Label_CIR = New System.Windows.Forms.Label()
        Me.Label_CU = New System.Windows.Forms.Label()
        Me.Panel_MDR = New System.Windows.Forms.Panel()
        Me.Label_MDR_Binary = New System.Windows.Forms.Label()
        Me.Label_MDR = New System.Windows.Forms.Label()
        Me.Panel_MAR = New System.Windows.Forms.Panel()
        Me.Label_MAR_Binary = New System.Windows.Forms.Label()
        Me.Label_MAR = New System.Windows.Forms.Label()
        Me.Panel_PC = New System.Windows.Forms.Panel()
        Me.Label_PC_Binary = New System.Windows.Forms.Label()
        Me.Lbl_PC = New System.Windows.Forms.Label()
        Me.Panel_Ram = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Ram_Address = New System.Windows.Forms.Label()
        Me.Label_Ram_0000 = New System.Windows.Forms.Label()
        Me.Label_Ram_0010 = New System.Windows.Forms.Label()
        Me.Label_Ram_Content = New System.Windows.Forms.Label()
        Me.Panel_Bus_Address = New System.Windows.Forms.Panel()
        Me.Panel_Bus_Data = New System.Windows.Forms.Panel()
        Me.Panel_Bus_Control = New System.Windows.Forms.Panel()
        Me.Label_Ram_0001 = New System.Windows.Forms.Label()
        Me.Label_Ram_0011 = New System.Windows.Forms.Label()
        Me.Label_Ram_0100 = New System.Windows.Forms.Label()
        Me.Label_Ram_0101 = New System.Windows.Forms.Label()
        Me.Label_Ram_0110 = New System.Windows.Forms.Label()
        Me.Label_Ram_0111 = New System.Windows.Forms.Label()
        Me.Label_Ram_1000 = New System.Windows.Forms.Label()
        Me.Label_Ram_1001 = New System.Windows.Forms.Label()
        Me.Label_Ram_1010 = New System.Windows.Forms.Label()
        Me.Label_Ram_1011 = New System.Windows.Forms.Label()
        Me.TxtBox_Ram_0000 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_0001 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_0010 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_0011 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_0100 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_0101 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_0110 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_0111 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_1000 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_1001 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_1010 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ram_1011 = New System.Windows.Forms.TextBox()
        Me.Panel_CPU.SuspendLayout()
        Me.Panel_ACC.SuspendLayout()
        Me.Panel_Decoder.SuspendLayout()
        Me.Panel_CIR.SuspendLayout()
        Me.Panel_MDR.SuspendLayout()
        Me.Panel_MAR.SuspendLayout()
        Me.Panel_PC.SuspendLayout()
        Me.Panel_Ram.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_CPU
        '
        Me.Panel_CPU.BackColor = System.Drawing.Color.Orange
        Me.Panel_CPU.Controls.Add(Me.Panel_ACC)
        Me.Panel_CPU.Controls.Add(Me.Label_ALU)
        Me.Panel_CPU.Controls.Add(Me.Panel_Decoder)
        Me.Panel_CPU.Controls.Add(Me.Panel_CIR)
        Me.Panel_CPU.Controls.Add(Me.Label_CU)
        Me.Panel_CPU.Controls.Add(Me.Panel_MDR)
        Me.Panel_CPU.Controls.Add(Me.Panel_MAR)
        Me.Panel_CPU.Controls.Add(Me.Panel_PC)
        Me.Panel_CPU.Location = New System.Drawing.Point(13, 13)
        Me.Panel_CPU.Name = "Panel_CPU"
        Me.Panel_CPU.Size = New System.Drawing.Size(200, 255)
        Me.Panel_CPU.TabIndex = 0
        '
        'Panel_ACC
        '
        Me.Panel_ACC.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_ACC.Controls.Add(Me.Label_ACC_Binary)
        Me.Panel_ACC.Controls.Add(Me.Label_ACC)
        Me.Panel_ACC.Location = New System.Drawing.Point(122, 69)
        Me.Panel_ACC.Name = "Panel_ACC"
        Me.Panel_ACC.Size = New System.Drawing.Size(75, 50)
        Me.Panel_ACC.TabIndex = 3
        '
        'Label_ACC_Binary
        '
        Me.Label_ACC_Binary.BackColor = System.Drawing.Color.Firebrick
        Me.Label_ACC_Binary.Location = New System.Drawing.Point(0, 27)
        Me.Label_ACC_Binary.Name = "Label_ACC_Binary"
        Me.Label_ACC_Binary.Size = New System.Drawing.Size(75, 23)
        Me.Label_ACC_Binary.TabIndex = 1
        Me.Label_ACC_Binary.Text = "0000"
        Me.Label_ACC_Binary.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_ACC
        '
        Me.Label_ACC.Location = New System.Drawing.Point(1, 1)
        Me.Label_ACC.Name = "Label_ACC"
        Me.Label_ACC.Size = New System.Drawing.Size(71, 18)
        Me.Label_ACC.TabIndex = 0
        Me.Label_ACC.Text = "ACC"
        Me.Label_ACC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_ALU
        '
        Me.Label_ALU.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label_ALU.Location = New System.Drawing.Point(122, 136)
        Me.Label_ALU.Name = "Label_ALU"
        Me.Label_ALU.Size = New System.Drawing.Size(40, 18)
        Me.Label_ALU.TabIndex = 6
        Me.Label_ALU.Text = "ALU"
        Me.Label_ALU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Decoder
        '
        Me.Panel_Decoder.BackColor = System.Drawing.Color.Aqua
        Me.Panel_Decoder.Controls.Add(Me.Label_Decoder)
        Me.Panel_Decoder.Location = New System.Drawing.Point(3, 69)
        Me.Panel_Decoder.Name = "Panel_Decoder"
        Me.Panel_Decoder.Size = New System.Drawing.Size(75, 114)
        Me.Panel_Decoder.TabIndex = 5
        '
        'Label_Decoder
        '
        Me.Label_Decoder.BackColor = System.Drawing.Color.OrangeRed
        Me.Label_Decoder.Location = New System.Drawing.Point(0, 0)
        Me.Label_Decoder.Name = "Label_Decoder"
        Me.Label_Decoder.Size = New System.Drawing.Size(75, 18)
        Me.Label_Decoder.TabIndex = 2
        Me.Label_Decoder.Text = "Decoder"
        Me.Label_Decoder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel_CIR
        '
        Me.Panel_CIR.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_CIR.Controls.Add(Me.Label_CIR_Binary)
        Me.Panel_CIR.Controls.Add(Me.Label_CIR)
        Me.Panel_CIR.Location = New System.Drawing.Point(3, 201)
        Me.Panel_CIR.Name = "Panel_CIR"
        Me.Panel_CIR.Size = New System.Drawing.Size(75, 50)
        Me.Panel_CIR.TabIndex = 4
        '
        'Label_CIR_Binary
        '
        Me.Label_CIR_Binary.BackColor = System.Drawing.Color.Firebrick
        Me.Label_CIR_Binary.Location = New System.Drawing.Point(0, 27)
        Me.Label_CIR_Binary.Name = "Label_CIR_Binary"
        Me.Label_CIR_Binary.Size = New System.Drawing.Size(75, 23)
        Me.Label_CIR_Binary.TabIndex = 1
        Me.Label_CIR_Binary.Text = "0000"
        Me.Label_CIR_Binary.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_CIR
        '
        Me.Label_CIR.Location = New System.Drawing.Point(1, 1)
        Me.Label_CIR.Name = "Label_CIR"
        Me.Label_CIR.Size = New System.Drawing.Size(71, 18)
        Me.Label_CIR.TabIndex = 0
        Me.Label_CIR.Text = "CIR"
        Me.Label_CIR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_CU
        '
        Me.Label_CU.BackColor = System.Drawing.Color.Green
        Me.Label_CU.Location = New System.Drawing.Point(122, 227)
        Me.Label_CU.Name = "Label_CU"
        Me.Label_CU.Size = New System.Drawing.Size(75, 24)
        Me.Label_CU.TabIndex = 4
        Me.Label_CU.Text = "CU"
        Me.Label_CU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_MDR
        '
        Me.Panel_MDR.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_MDR.Controls.Add(Me.Label_MDR_Binary)
        Me.Panel_MDR.Controls.Add(Me.Label_MDR)
        Me.Panel_MDR.Location = New System.Drawing.Point(122, 174)
        Me.Panel_MDR.Name = "Panel_MDR"
        Me.Panel_MDR.Size = New System.Drawing.Size(75, 50)
        Me.Panel_MDR.TabIndex = 3
        '
        'Label_MDR_Binary
        '
        Me.Label_MDR_Binary.BackColor = System.Drawing.Color.Firebrick
        Me.Label_MDR_Binary.Location = New System.Drawing.Point(0, 27)
        Me.Label_MDR_Binary.Name = "Label_MDR_Binary"
        Me.Label_MDR_Binary.Size = New System.Drawing.Size(75, 23)
        Me.Label_MDR_Binary.TabIndex = 1
        Me.Label_MDR_Binary.Text = "0000"
        Me.Label_MDR_Binary.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_MDR
        '
        Me.Label_MDR.Location = New System.Drawing.Point(1, 1)
        Me.Label_MDR.Name = "Label_MDR"
        Me.Label_MDR.Size = New System.Drawing.Size(71, 18)
        Me.Label_MDR.TabIndex = 0
        Me.Label_MDR.Text = "MDR"
        Me.Label_MDR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel_MAR
        '
        Me.Panel_MAR.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_MAR.Controls.Add(Me.Label_MAR_Binary)
        Me.Panel_MAR.Controls.Add(Me.Label_MAR)
        Me.Panel_MAR.Location = New System.Drawing.Point(122, 3)
        Me.Panel_MAR.Name = "Panel_MAR"
        Me.Panel_MAR.Size = New System.Drawing.Size(75, 50)
        Me.Panel_MAR.TabIndex = 2
        '
        'Label_MAR_Binary
        '
        Me.Label_MAR_Binary.BackColor = System.Drawing.Color.Firebrick
        Me.Label_MAR_Binary.Location = New System.Drawing.Point(0, 27)
        Me.Label_MAR_Binary.Name = "Label_MAR_Binary"
        Me.Label_MAR_Binary.Size = New System.Drawing.Size(75, 23)
        Me.Label_MAR_Binary.TabIndex = 1
        Me.Label_MAR_Binary.Text = "0000"
        Me.Label_MAR_Binary.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_MAR
        '
        Me.Label_MAR.Location = New System.Drawing.Point(1, 1)
        Me.Label_MAR.Name = "Label_MAR"
        Me.Label_MAR.Size = New System.Drawing.Size(71, 18)
        Me.Label_MAR.TabIndex = 0
        Me.Label_MAR.Text = "MAR"
        Me.Label_MAR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel_PC
        '
        Me.Panel_PC.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_PC.Controls.Add(Me.Label_PC_Binary)
        Me.Panel_PC.Controls.Add(Me.Lbl_PC)
        Me.Panel_PC.Location = New System.Drawing.Point(3, 3)
        Me.Panel_PC.Name = "Panel_PC"
        Me.Panel_PC.Size = New System.Drawing.Size(75, 50)
        Me.Panel_PC.TabIndex = 0
        '
        'Label_PC_Binary
        '
        Me.Label_PC_Binary.BackColor = System.Drawing.Color.Firebrick
        Me.Label_PC_Binary.Location = New System.Drawing.Point(0, 27)
        Me.Label_PC_Binary.Name = "Label_PC_Binary"
        Me.Label_PC_Binary.Size = New System.Drawing.Size(75, 23)
        Me.Label_PC_Binary.TabIndex = 1
        Me.Label_PC_Binary.Text = "0000"
        Me.Label_PC_Binary.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_PC
        '
        Me.Lbl_PC.Location = New System.Drawing.Point(1, 1)
        Me.Lbl_PC.Name = "Lbl_PC"
        Me.Lbl_PC.Size = New System.Drawing.Size(71, 18)
        Me.Lbl_PC.TabIndex = 0
        Me.Lbl_PC.Text = "PC"
        Me.Lbl_PC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel_Ram
        '
        Me.Panel_Ram.BackColor = System.Drawing.Color.Orange
        Me.Panel_Ram.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel_Ram.Location = New System.Drawing.Point(284, 13)
        Me.Panel_Ram.Name = "Panel_Ram"
        Me.Panel_Ram.Size = New System.Drawing.Size(200, 255)
        Me.Panel_Ram.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_1011, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_Address, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0000, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0010, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_Content, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0001, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0011, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0100, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0101, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0110, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_0111, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_1000, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_1001, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_1010, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Ram_1011, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0001, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0010, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0011, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0100, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0101, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0110, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0111, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_1000, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_1001, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_1010, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtBox_Ram_0000, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 17
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 255)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label_Ram_Address
        '
        Me.Label_Ram_Address.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_Ram_Address.Location = New System.Drawing.Point(3, -1)
        Me.Label_Ram_Address.Name = "Label_Ram_Address"
        Me.Label_Ram_Address.Size = New System.Drawing.Size(76, 13)
        Me.Label_Ram_Address.TabIndex = 0
        Me.Label_Ram_Address.Text = "Address"
        '
        'Label_Ram_0000
        '
        Me.Label_Ram_0000.AutoSize = True
        Me.Label_Ram_0000.Location = New System.Drawing.Point(3, 16)
        Me.Label_Ram_0000.Name = "Label_Ram_0000"
        Me.Label_Ram_0000.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0000.TabIndex = 2
        Me.Label_Ram_0000.Text = "0000"
        '
        'Label_Ram_0010
        '
        Me.Label_Ram_0010.AutoSize = True
        Me.Label_Ram_0010.Location = New System.Drawing.Point(3, 56)
        Me.Label_Ram_0010.Name = "Label_Ram_0010"
        Me.Label_Ram_0010.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0010.TabIndex = 4
        Me.Label_Ram_0010.Text = "0010"
        '
        'Label_Ram_Content
        '
        Me.Label_Ram_Content.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_Ram_Content.Location = New System.Drawing.Point(85, -1)
        Me.Label_Ram_Content.Name = "Label_Ram_Content"
        Me.Label_Ram_Content.Size = New System.Drawing.Size(100, 13)
        Me.Label_Ram_Content.TabIndex = 1
        Me.Label_Ram_Content.Text = "Content"
        '
        'Panel_Bus_Address
        '
        Me.Panel_Bus_Address.BackColor = System.Drawing.Color.Gray
        Me.Panel_Bus_Address.Location = New System.Drawing.Point(216, 43)
        Me.Panel_Bus_Address.Name = "Panel_Bus_Address"
        Me.Panel_Bus_Address.Size = New System.Drawing.Size(62, 10)
        Me.Panel_Bus_Address.TabIndex = 2
        '
        'Panel_Bus_Data
        '
        Me.Panel_Bus_Data.BackColor = System.Drawing.Color.Gray
        Me.Panel_Bus_Data.Location = New System.Drawing.Point(216, 205)
        Me.Panel_Bus_Data.Name = "Panel_Bus_Data"
        Me.Panel_Bus_Data.Size = New System.Drawing.Size(62, 10)
        Me.Panel_Bus_Data.TabIndex = 3
        '
        'Panel_Bus_Control
        '
        Me.Panel_Bus_Control.BackColor = System.Drawing.Color.Gray
        Me.Panel_Bus_Control.Location = New System.Drawing.Point(216, 245)
        Me.Panel_Bus_Control.Name = "Panel_Bus_Control"
        Me.Panel_Bus_Control.Size = New System.Drawing.Size(62, 10)
        Me.Panel_Bus_Control.TabIndex = 4
        '
        'Label_Ram_0001
        '
        Me.Label_Ram_0001.AutoSize = True
        Me.Label_Ram_0001.Location = New System.Drawing.Point(3, 36)
        Me.Label_Ram_0001.Name = "Label_Ram_0001"
        Me.Label_Ram_0001.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0001.TabIndex = 5
        Me.Label_Ram_0001.Text = "0001"
        '
        'Label_Ram_0011
        '
        Me.Label_Ram_0011.AutoSize = True
        Me.Label_Ram_0011.Location = New System.Drawing.Point(3, 76)
        Me.Label_Ram_0011.Name = "Label_Ram_0011"
        Me.Label_Ram_0011.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0011.TabIndex = 6
        Me.Label_Ram_0011.Text = "0011"
        '
        'Label_Ram_0100
        '
        Me.Label_Ram_0100.AutoSize = True
        Me.Label_Ram_0100.Location = New System.Drawing.Point(3, 96)
        Me.Label_Ram_0100.Name = "Label_Ram_0100"
        Me.Label_Ram_0100.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0100.TabIndex = 7
        Me.Label_Ram_0100.Text = "0100"
        '
        'Label_Ram_0101
        '
        Me.Label_Ram_0101.AutoSize = True
        Me.Label_Ram_0101.Location = New System.Drawing.Point(3, 116)
        Me.Label_Ram_0101.Name = "Label_Ram_0101"
        Me.Label_Ram_0101.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0101.TabIndex = 8
        Me.Label_Ram_0101.Text = "0101"
        '
        'Label_Ram_0110
        '
        Me.Label_Ram_0110.AutoSize = True
        Me.Label_Ram_0110.Location = New System.Drawing.Point(3, 136)
        Me.Label_Ram_0110.Name = "Label_Ram_0110"
        Me.Label_Ram_0110.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0110.TabIndex = 9
        Me.Label_Ram_0110.Text = "0110"
        '
        'Label_Ram_0111
        '
        Me.Label_Ram_0111.AutoSize = True
        Me.Label_Ram_0111.Location = New System.Drawing.Point(3, 156)
        Me.Label_Ram_0111.Name = "Label_Ram_0111"
        Me.Label_Ram_0111.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_0111.TabIndex = 10
        Me.Label_Ram_0111.Text = "0111"
        '
        'Label_Ram_1000
        '
        Me.Label_Ram_1000.AutoSize = True
        Me.Label_Ram_1000.Location = New System.Drawing.Point(3, 176)
        Me.Label_Ram_1000.Name = "Label_Ram_1000"
        Me.Label_Ram_1000.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_1000.TabIndex = 11
        Me.Label_Ram_1000.Text = "1000"
        '
        'Label_Ram_1001
        '
        Me.Label_Ram_1001.AutoSize = True
        Me.Label_Ram_1001.Location = New System.Drawing.Point(3, 196)
        Me.Label_Ram_1001.Name = "Label_Ram_1001"
        Me.Label_Ram_1001.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_1001.TabIndex = 12
        Me.Label_Ram_1001.Text = "1001"
        '
        'Label_Ram_1010
        '
        Me.Label_Ram_1010.AutoSize = True
        Me.Label_Ram_1010.Location = New System.Drawing.Point(3, 216)
        Me.Label_Ram_1010.Name = "Label_Ram_1010"
        Me.Label_Ram_1010.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_1010.TabIndex = 13
        Me.Label_Ram_1010.Text = "1010"
        '
        'Label_Ram_1011
        '
        Me.Label_Ram_1011.AutoSize = True
        Me.Label_Ram_1011.Location = New System.Drawing.Point(3, 236)
        Me.Label_Ram_1011.Name = "Label_Ram_1011"
        Me.Label_Ram_1011.Size = New System.Drawing.Size(31, 13)
        Me.Label_Ram_1011.TabIndex = 14
        Me.Label_Ram_1011.Text = "1011"
        '
        'TxtBox_Ram_0000
        '
        Me.TxtBox_Ram_0000.Location = New System.Drawing.Point(85, 19)
        Me.TxtBox_Ram_0000.MaxLength = 8
        Me.TxtBox_Ram_0000.Name = "TxtBox_Ram_0000"
        Me.TxtBox_Ram_0000.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0000.TabIndex = 15
        '
        'TxtBox_Ram_0001
        '
        Me.TxtBox_Ram_0001.Location = New System.Drawing.Point(85, 39)
        Me.TxtBox_Ram_0001.MaxLength = 8
        Me.TxtBox_Ram_0001.Name = "TxtBox_Ram_0001"
        Me.TxtBox_Ram_0001.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0001.TabIndex = 16
        '
        'TxtBox_Ram_0010
        '
        Me.TxtBox_Ram_0010.Location = New System.Drawing.Point(85, 59)
        Me.TxtBox_Ram_0010.MaxLength = 8
        Me.TxtBox_Ram_0010.Name = "TxtBox_Ram_0010"
        Me.TxtBox_Ram_0010.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0010.TabIndex = 17
        '
        'TxtBox_Ram_0011
        '
        Me.TxtBox_Ram_0011.Location = New System.Drawing.Point(85, 79)
        Me.TxtBox_Ram_0011.MaxLength = 8
        Me.TxtBox_Ram_0011.Name = "TxtBox_Ram_0011"
        Me.TxtBox_Ram_0011.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0011.TabIndex = 18
        '
        'TxtBox_Ram_0100
        '
        Me.TxtBox_Ram_0100.Location = New System.Drawing.Point(85, 99)
        Me.TxtBox_Ram_0100.MaxLength = 8
        Me.TxtBox_Ram_0100.Name = "TxtBox_Ram_0100"
        Me.TxtBox_Ram_0100.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0100.TabIndex = 19
        '
        'TxtBox_Ram_0101
        '
        Me.TxtBox_Ram_0101.Location = New System.Drawing.Point(85, 119)
        Me.TxtBox_Ram_0101.MaxLength = 8
        Me.TxtBox_Ram_0101.Name = "TxtBox_Ram_0101"
        Me.TxtBox_Ram_0101.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0101.TabIndex = 20
        '
        'TxtBox_Ram_0110
        '
        Me.TxtBox_Ram_0110.Location = New System.Drawing.Point(85, 139)
        Me.TxtBox_Ram_0110.MaxLength = 8
        Me.TxtBox_Ram_0110.Name = "TxtBox_Ram_0110"
        Me.TxtBox_Ram_0110.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0110.TabIndex = 21
        '
        'TxtBox_Ram_0111
        '
        Me.TxtBox_Ram_0111.Location = New System.Drawing.Point(85, 159)
        Me.TxtBox_Ram_0111.MaxLength = 8
        Me.TxtBox_Ram_0111.Name = "TxtBox_Ram_0111"
        Me.TxtBox_Ram_0111.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_0111.TabIndex = 22
        '
        'TxtBox_Ram_1000
        '
        Me.TxtBox_Ram_1000.Location = New System.Drawing.Point(85, 179)
        Me.TxtBox_Ram_1000.MaxLength = 8
        Me.TxtBox_Ram_1000.Name = "TxtBox_Ram_1000"
        Me.TxtBox_Ram_1000.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_1000.TabIndex = 23
        '
        'TxtBox_Ram_1001
        '
        Me.TxtBox_Ram_1001.Location = New System.Drawing.Point(85, 199)
        Me.TxtBox_Ram_1001.MaxLength = 8
        Me.TxtBox_Ram_1001.Name = "TxtBox_Ram_1001"
        Me.TxtBox_Ram_1001.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_1001.TabIndex = 24
        '
        'TxtBox_Ram_1010
        '
        Me.TxtBox_Ram_1010.Location = New System.Drawing.Point(85, 219)
        Me.TxtBox_Ram_1010.MaxLength = 8
        Me.TxtBox_Ram_1010.Name = "TxtBox_Ram_1010"
        Me.TxtBox_Ram_1010.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_1010.TabIndex = 25
        '
        'TxtBox_Ram_1011
        '
        Me.TxtBox_Ram_1011.Location = New System.Drawing.Point(85, 239)
        Me.TxtBox_Ram_1011.MaxLength = 8
        Me.TxtBox_Ram_1011.Name = "TxtBox_Ram_1011"
        Me.TxtBox_Ram_1011.Size = New System.Drawing.Size(100, 20)
        Me.TxtBox_Ram_1011.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 283)
        Me.Controls.Add(Me.Panel_Bus_Control)
        Me.Controls.Add(Me.Panel_Bus_Data)
        Me.Controls.Add(Me.Panel_Bus_Address)
        Me.Controls.Add(Me.Panel_Ram)
        Me.Controls.Add(Me.Panel_CPU)
        Me.Name = "Form1"
        Me.Text = "CPU Cycle"
        Me.Panel_CPU.ResumeLayout(False)
        Me.Panel_ACC.ResumeLayout(False)
        Me.Panel_Decoder.ResumeLayout(False)
        Me.Panel_CIR.ResumeLayout(False)
        Me.Panel_MDR.ResumeLayout(False)
        Me.Panel_MAR.ResumeLayout(False)
        Me.Panel_PC.ResumeLayout(False)
        Me.Panel_Ram.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_CPU As Panel
    Friend WithEvents Panel_PC As Panel
    Friend WithEvents Label_PC_Binary As Label
    Friend WithEvents Lbl_PC As Label
    Friend WithEvents Panel_Ram As Panel
    Friend WithEvents Panel_MAR As Panel
    Friend WithEvents Label_MAR_Binary As Label
    Friend WithEvents Label_MAR As Label
    Friend WithEvents Panel_ACC As Panel
    Friend WithEvents Label_ACC_Binary As Label
    Friend WithEvents Label_ACC As Label
    Friend WithEvents Label_ALU As Label
    Friend WithEvents Panel_Decoder As Panel
    Friend WithEvents Label_Decoder As Label
    Friend WithEvents Panel_CIR As Panel
    Friend WithEvents Label_CIR_Binary As Label
    Friend WithEvents Label_CIR As Label
    Friend WithEvents Label_CU As Label
    Friend WithEvents Panel_MDR As Panel
    Friend WithEvents Label_MDR_Binary As Label
    Friend WithEvents Label_MDR As Label
    Friend WithEvents Panel_Bus_Address As Panel
    Friend WithEvents Panel_Bus_Data As Panel
    Friend WithEvents Panel_Bus_Control As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label_Ram_Address As Label
    Friend WithEvents Label_Ram_Content As Label
    Friend WithEvents Label_Ram_0000 As Label
    Friend WithEvents Label_Ram_0010 As Label
    Friend WithEvents Label_Ram_0001 As Label
    Friend WithEvents Label_Ram_0011 As Label
    Friend WithEvents Label_Ram_0100 As Label
    Friend WithEvents Label_Ram_0101 As Label
    Friend WithEvents Label_Ram_0110 As Label
    Friend WithEvents Label_Ram_0111 As Label
    Friend WithEvents Label_Ram_1000 As Label
    Friend WithEvents Label_Ram_1001 As Label
    Friend WithEvents Label_Ram_1010 As Label
    Friend WithEvents Label_Ram_1011 As Label
    Friend WithEvents TxtBox_Ram_0001 As TextBox
    Friend WithEvents TxtBox_Ram_0010 As TextBox
    Friend WithEvents TxtBox_Ram_0011 As TextBox
    Friend WithEvents TxtBox_Ram_0100 As TextBox
    Friend WithEvents TxtBox_Ram_0101 As TextBox
    Friend WithEvents TxtBox_Ram_0110 As TextBox
    Friend WithEvents TxtBox_Ram_0111 As TextBox
    Friend WithEvents TxtBox_Ram_1000 As TextBox
    Friend WithEvents TxtBox_Ram_1001 As TextBox
    Friend WithEvents TxtBox_Ram_1010 As TextBox
    Friend WithEvents TxtBox_Ram_1011 As TextBox
    Friend WithEvents TxtBox_Ram_0000 As TextBox
End Class
