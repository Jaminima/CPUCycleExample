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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel_CPU = New System.Windows.Forms.Panel()
        Me.Panel_ACC = New System.Windows.Forms.Panel()
        Me.Label_ACC_Binary = New System.Windows.Forms.Label()
        Me.Label_ACC = New System.Windows.Forms.Label()
        Me.Label_ALU = New System.Windows.Forms.Label()
        Me.Panel_Decoder = New System.Windows.Forms.Panel()
        Me.Label_Decoder = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel_CIR = New System.Windows.Forms.Panel()
        Me.Label_CIR_Binary = New System.Windows.Forms.Label()
        Me.Label_CIR = New System.Windows.Forms.Label()
        Me.Label_CU = New System.Windows.Forms.Label()
        Me.Panel_MDR = New System.Windows.Forms.Panel()
        Me.Label_MBR_Binary = New System.Windows.Forms.Label()
        Me.Label_MBR = New System.Windows.Forms.Label()
        Me.Panel_MAR = New System.Windows.Forms.Panel()
        Me.Label_MAR_Binary = New System.Windows.Forms.Label()
        Me.Label_MAR = New System.Windows.Forms.Label()
        Me.Panel_PC = New System.Windows.Forms.Panel()
        Me.Label_PC_Binary = New System.Windows.Forms.Label()
        Me.Label_PC = New System.Windows.Forms.Label()
        Me.Panel_Ram = New System.Windows.Forms.Panel()
        Me.Table_Ram = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtBox_Ram_1011 = New System.Windows.Forms.TextBox()
        Me.Label_Ram_Address = New System.Windows.Forms.Label()
        Me.Label_Ram_0000 = New System.Windows.Forms.Label()
        Me.Label_Ram_0010 = New System.Windows.Forms.Label()
        Me.Label_Ram_Content = New System.Windows.Forms.Label()
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
        Me.TxtBox_Ram_0000 = New System.Windows.Forms.TextBox()
        Me.Panel_Bus_Address = New System.Windows.Forms.Panel()
        Me.Panel_Bus_Data = New System.Windows.Forms.Panel()
        Me.Panel_Bus_Control = New System.Windows.Forms.Panel()
        Me.BtnCycle = New System.Windows.Forms.Button()
        Me.BtnRestart = New System.Windows.Forms.Button()
        Me.Panel_CPU.SuspendLayout()
        Me.Panel_ACC.SuspendLayout()
        Me.Panel_Decoder.SuspendLayout()
        Me.Panel_CIR.SuspendLayout()
        Me.Panel_MDR.SuspendLayout()
        Me.Panel_MAR.SuspendLayout()
        Me.Panel_PC.SuspendLayout()
        Me.Panel_Ram.SuspendLayout()
        Me.Table_Ram.SuspendLayout()
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
        resources.ApplyResources(Me.Panel_CPU, "Panel_CPU")
        Me.Panel_CPU.Name = "Panel_CPU"
        '
        'Panel_ACC
        '
        Me.Panel_ACC.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_ACC.Controls.Add(Me.Label_ACC_Binary)
        Me.Panel_ACC.Controls.Add(Me.Label_ACC)
        resources.ApplyResources(Me.Panel_ACC, "Panel_ACC")
        Me.Panel_ACC.Name = "Panel_ACC"
        '
        'Label_ACC_Binary
        '
        Me.Label_ACC_Binary.BackColor = System.Drawing.Color.Firebrick
        resources.ApplyResources(Me.Label_ACC_Binary, "Label_ACC_Binary")
        Me.Label_ACC_Binary.Name = "Label_ACC_Binary"
        '
        'Label_ACC
        '
        resources.ApplyResources(Me.Label_ACC, "Label_ACC")
        Me.Label_ACC.Name = "Label_ACC"
        '
        'Label_ALU
        '
        Me.Label_ALU.BackColor = System.Drawing.Color.DeepSkyBlue
        resources.ApplyResources(Me.Label_ALU, "Label_ALU")
        Me.Label_ALU.Name = "Label_ALU"
        '
        'Panel_Decoder
        '
        Me.Panel_Decoder.BackColor = System.Drawing.Color.Aqua
        Me.Panel_Decoder.Controls.Add(Me.Label_Decoder)
        Me.Panel_Decoder.Controls.Add(Me.ListBox1)
        resources.ApplyResources(Me.Panel_Decoder, "Panel_Decoder")
        Me.Panel_Decoder.Name = "Panel_Decoder"
        '
        'Label_Decoder
        '
        Me.Label_Decoder.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.Label_Decoder, "Label_Decoder")
        Me.Label_Decoder.Name = "Label_Decoder"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Aqua
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {resources.GetString("ListBox1.Items"), resources.GetString("ListBox1.Items1"), resources.GetString("ListBox1.Items2"), resources.GetString("ListBox1.Items3"), resources.GetString("ListBox1.Items4")})
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.Name = "ListBox1"
        '
        'Panel_CIR
        '
        Me.Panel_CIR.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_CIR.Controls.Add(Me.Label_CIR_Binary)
        Me.Panel_CIR.Controls.Add(Me.Label_CIR)
        resources.ApplyResources(Me.Panel_CIR, "Panel_CIR")
        Me.Panel_CIR.Name = "Panel_CIR"
        '
        'Label_CIR_Binary
        '
        Me.Label_CIR_Binary.BackColor = System.Drawing.Color.Firebrick
        resources.ApplyResources(Me.Label_CIR_Binary, "Label_CIR_Binary")
        Me.Label_CIR_Binary.Name = "Label_CIR_Binary"
        '
        'Label_CIR
        '
        resources.ApplyResources(Me.Label_CIR, "Label_CIR")
        Me.Label_CIR.Name = "Label_CIR"
        '
        'Label_CU
        '
        Me.Label_CU.BackColor = System.Drawing.Color.Green
        resources.ApplyResources(Me.Label_CU, "Label_CU")
        Me.Label_CU.Name = "Label_CU"
        '
        'Panel_MDR
        '
        Me.Panel_MDR.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_MDR.Controls.Add(Me.Label_MBR_Binary)
        Me.Panel_MDR.Controls.Add(Me.Label_MBR)
        resources.ApplyResources(Me.Panel_MDR, "Panel_MDR")
        Me.Panel_MDR.Name = "Panel_MDR"
        '
        'Label_MBR_Binary
        '
        Me.Label_MBR_Binary.BackColor = System.Drawing.Color.Firebrick
        resources.ApplyResources(Me.Label_MBR_Binary, "Label_MBR_Binary")
        Me.Label_MBR_Binary.Name = "Label_MBR_Binary"
        '
        'Label_MBR
        '
        resources.ApplyResources(Me.Label_MBR, "Label_MBR")
        Me.Label_MBR.Name = "Label_MBR"
        '
        'Panel_MAR
        '
        Me.Panel_MAR.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_MAR.Controls.Add(Me.Label_MAR_Binary)
        Me.Panel_MAR.Controls.Add(Me.Label_MAR)
        resources.ApplyResources(Me.Panel_MAR, "Panel_MAR")
        Me.Panel_MAR.Name = "Panel_MAR"
        '
        'Label_MAR_Binary
        '
        Me.Label_MAR_Binary.BackColor = System.Drawing.Color.Firebrick
        resources.ApplyResources(Me.Label_MAR_Binary, "Label_MAR_Binary")
        Me.Label_MAR_Binary.Name = "Label_MAR_Binary"
        '
        'Label_MAR
        '
        Me.Label_MAR.BackColor = System.Drawing.Color.OrangeRed
        resources.ApplyResources(Me.Label_MAR, "Label_MAR")
        Me.Label_MAR.Name = "Label_MAR"
        '
        'Panel_PC
        '
        Me.Panel_PC.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel_PC.Controls.Add(Me.Label_PC_Binary)
        Me.Panel_PC.Controls.Add(Me.Label_PC)
        resources.ApplyResources(Me.Panel_PC, "Panel_PC")
        Me.Panel_PC.Name = "Panel_PC"
        '
        'Label_PC_Binary
        '
        Me.Label_PC_Binary.BackColor = System.Drawing.Color.Firebrick
        resources.ApplyResources(Me.Label_PC_Binary, "Label_PC_Binary")
        Me.Label_PC_Binary.Name = "Label_PC_Binary"
        '
        'Label_PC
        '
        resources.ApplyResources(Me.Label_PC, "Label_PC")
        Me.Label_PC.Name = "Label_PC"
        '
        'Panel_Ram
        '
        Me.Panel_Ram.BackColor = System.Drawing.Color.Orange
        Me.Panel_Ram.Controls.Add(Me.Table_Ram)
        resources.ApplyResources(Me.Panel_Ram, "Panel_Ram")
        Me.Panel_Ram.Name = "Panel_Ram"
        '
        'Table_Ram
        '
        resources.ApplyResources(Me.Table_Ram, "Table_Ram")
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_1011, 1, 16)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_Address, 0, 4)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0000, 0, 5)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0010, 0, 7)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_Content, 1, 4)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0001, 0, 6)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0011, 0, 8)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0100, 0, 9)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0101, 0, 10)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0110, 0, 11)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_0111, 0, 12)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_1000, 0, 13)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_1001, 0, 14)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_1010, 0, 15)
        Me.Table_Ram.Controls.Add(Me.Label_Ram_1011, 0, 16)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0001, 1, 6)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0010, 1, 7)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0011, 1, 8)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0100, 1, 9)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0101, 1, 10)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0110, 1, 11)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0111, 1, 12)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_1000, 1, 13)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_1001, 1, 14)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_1010, 1, 15)
        Me.Table_Ram.Controls.Add(Me.TxtBox_Ram_0000, 1, 5)
        Me.Table_Ram.Name = "Table_Ram"
        '
        'TxtBox_Ram_1011
        '
        resources.ApplyResources(Me.TxtBox_Ram_1011, "TxtBox_Ram_1011")
        Me.TxtBox_Ram_1011.Name = "TxtBox_Ram_1011"
        '
        'Label_Ram_Address
        '
        resources.ApplyResources(Me.Label_Ram_Address, "Label_Ram_Address")
        Me.Label_Ram_Address.Name = "Label_Ram_Address"
        '
        'Label_Ram_0000
        '
        resources.ApplyResources(Me.Label_Ram_0000, "Label_Ram_0000")
        Me.Label_Ram_0000.Name = "Label_Ram_0000"
        '
        'Label_Ram_0010
        '
        resources.ApplyResources(Me.Label_Ram_0010, "Label_Ram_0010")
        Me.Label_Ram_0010.Name = "Label_Ram_0010"
        '
        'Label_Ram_Content
        '
        resources.ApplyResources(Me.Label_Ram_Content, "Label_Ram_Content")
        Me.Label_Ram_Content.Name = "Label_Ram_Content"
        '
        'Label_Ram_0001
        '
        resources.ApplyResources(Me.Label_Ram_0001, "Label_Ram_0001")
        Me.Label_Ram_0001.Name = "Label_Ram_0001"
        '
        'Label_Ram_0011
        '
        resources.ApplyResources(Me.Label_Ram_0011, "Label_Ram_0011")
        Me.Label_Ram_0011.Name = "Label_Ram_0011"
        '
        'Label_Ram_0100
        '
        resources.ApplyResources(Me.Label_Ram_0100, "Label_Ram_0100")
        Me.Label_Ram_0100.Name = "Label_Ram_0100"
        '
        'Label_Ram_0101
        '
        resources.ApplyResources(Me.Label_Ram_0101, "Label_Ram_0101")
        Me.Label_Ram_0101.Name = "Label_Ram_0101"
        '
        'Label_Ram_0110
        '
        resources.ApplyResources(Me.Label_Ram_0110, "Label_Ram_0110")
        Me.Label_Ram_0110.Name = "Label_Ram_0110"
        '
        'Label_Ram_0111
        '
        resources.ApplyResources(Me.Label_Ram_0111, "Label_Ram_0111")
        Me.Label_Ram_0111.Name = "Label_Ram_0111"
        '
        'Label_Ram_1000
        '
        resources.ApplyResources(Me.Label_Ram_1000, "Label_Ram_1000")
        Me.Label_Ram_1000.Name = "Label_Ram_1000"
        '
        'Label_Ram_1001
        '
        resources.ApplyResources(Me.Label_Ram_1001, "Label_Ram_1001")
        Me.Label_Ram_1001.Name = "Label_Ram_1001"
        '
        'Label_Ram_1010
        '
        resources.ApplyResources(Me.Label_Ram_1010, "Label_Ram_1010")
        Me.Label_Ram_1010.Name = "Label_Ram_1010"
        '
        'Label_Ram_1011
        '
        resources.ApplyResources(Me.Label_Ram_1011, "Label_Ram_1011")
        Me.Label_Ram_1011.Name = "Label_Ram_1011"
        '
        'TxtBox_Ram_0001
        '
        resources.ApplyResources(Me.TxtBox_Ram_0001, "TxtBox_Ram_0001")
        Me.TxtBox_Ram_0001.Name = "TxtBox_Ram_0001"
        '
        'TxtBox_Ram_0010
        '
        resources.ApplyResources(Me.TxtBox_Ram_0010, "TxtBox_Ram_0010")
        Me.TxtBox_Ram_0010.Name = "TxtBox_Ram_0010"
        '
        'TxtBox_Ram_0011
        '
        resources.ApplyResources(Me.TxtBox_Ram_0011, "TxtBox_Ram_0011")
        Me.TxtBox_Ram_0011.Name = "TxtBox_Ram_0011"
        '
        'TxtBox_Ram_0100
        '
        resources.ApplyResources(Me.TxtBox_Ram_0100, "TxtBox_Ram_0100")
        Me.TxtBox_Ram_0100.Name = "TxtBox_Ram_0100"
        '
        'TxtBox_Ram_0101
        '
        resources.ApplyResources(Me.TxtBox_Ram_0101, "TxtBox_Ram_0101")
        Me.TxtBox_Ram_0101.Name = "TxtBox_Ram_0101"
        '
        'TxtBox_Ram_0110
        '
        resources.ApplyResources(Me.TxtBox_Ram_0110, "TxtBox_Ram_0110")
        Me.TxtBox_Ram_0110.Name = "TxtBox_Ram_0110"
        '
        'TxtBox_Ram_0111
        '
        resources.ApplyResources(Me.TxtBox_Ram_0111, "TxtBox_Ram_0111")
        Me.TxtBox_Ram_0111.Name = "TxtBox_Ram_0111"
        '
        'TxtBox_Ram_1000
        '
        resources.ApplyResources(Me.TxtBox_Ram_1000, "TxtBox_Ram_1000")
        Me.TxtBox_Ram_1000.Name = "TxtBox_Ram_1000"
        '
        'TxtBox_Ram_1001
        '
        resources.ApplyResources(Me.TxtBox_Ram_1001, "TxtBox_Ram_1001")
        Me.TxtBox_Ram_1001.Name = "TxtBox_Ram_1001"
        '
        'TxtBox_Ram_1010
        '
        resources.ApplyResources(Me.TxtBox_Ram_1010, "TxtBox_Ram_1010")
        Me.TxtBox_Ram_1010.Name = "TxtBox_Ram_1010"
        '
        'TxtBox_Ram_0000
        '
        resources.ApplyResources(Me.TxtBox_Ram_0000, "TxtBox_Ram_0000")
        Me.TxtBox_Ram_0000.Name = "TxtBox_Ram_0000"
        '
        'Panel_Bus_Address
        '
        Me.Panel_Bus_Address.BackColor = System.Drawing.Color.Gray
        resources.ApplyResources(Me.Panel_Bus_Address, "Panel_Bus_Address")
        Me.Panel_Bus_Address.Name = "Panel_Bus_Address"
        '
        'Panel_Bus_Data
        '
        Me.Panel_Bus_Data.BackColor = System.Drawing.Color.Gray
        resources.ApplyResources(Me.Panel_Bus_Data, "Panel_Bus_Data")
        Me.Panel_Bus_Data.Name = "Panel_Bus_Data"
        '
        'Panel_Bus_Control
        '
        Me.Panel_Bus_Control.BackColor = System.Drawing.Color.Gray
        resources.ApplyResources(Me.Panel_Bus_Control, "Panel_Bus_Control")
        Me.Panel_Bus_Control.Name = "Panel_Bus_Control"
        '
        'BtnCycle
        '
        Me.BtnCycle.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BtnCycle, "BtnCycle")
        Me.BtnCycle.Name = "BtnCycle"
        Me.BtnCycle.UseVisualStyleBackColor = False
        '
        'BtnRestart
        '
        Me.BtnRestart.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BtnRestart, "BtnRestart")
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.UseVisualStyleBackColor = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.BtnCycle)
        Me.Controls.Add(Me.Panel_Bus_Control)
        Me.Controls.Add(Me.Panel_Bus_Data)
        Me.Controls.Add(Me.Panel_Bus_Address)
        Me.Controls.Add(Me.Panel_Ram)
        Me.Controls.Add(Me.Panel_CPU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Panel_CPU.ResumeLayout(False)
        Me.Panel_ACC.ResumeLayout(False)
        Me.Panel_Decoder.ResumeLayout(False)
        Me.Panel_CIR.ResumeLayout(False)
        Me.Panel_MDR.ResumeLayout(False)
        Me.Panel_MAR.ResumeLayout(False)
        Me.Panel_PC.ResumeLayout(False)
        Me.Panel_Ram.ResumeLayout(False)
        Me.Table_Ram.ResumeLayout(False)
        Me.Table_Ram.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_CPU As Panel
    Friend WithEvents Panel_PC As Panel
    Friend WithEvents Label_PC_Binary As Label
    Friend WithEvents Label_PC As Label
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
    Friend WithEvents Label_MBR_Binary As Label
    Friend WithEvents Label_MBR As Label
    Friend WithEvents Panel_Bus_Address As Panel
    Friend WithEvents Panel_Bus_Data As Panel
    Friend WithEvents Panel_Bus_Control As Panel
    Friend WithEvents Table_Ram As TableLayoutPanel
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
    Friend WithEvents BtnCycle As Button
    Friend WithEvents BtnRestart As Button
    Friend WithEvents ListBox1 As ListBox
End Class
