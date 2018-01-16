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
        Me.Panel_Ram = New System.Windows.Forms.Panel()
        Me.Panel_PC = New System.Windows.Forms.Panel()
        Me.Lbl_PC = New System.Windows.Forms.Label()
        Me.Label_PC_Binary = New System.Windows.Forms.Label()
        Me.Label_MAR = New System.Windows.Forms.Label()
        Me.Panel_MAR = New System.Windows.Forms.Panel()
        Me.Label_MAR_Binary = New System.Windows.Forms.Label()
        Me.Panel_MDR = New System.Windows.Forms.Panel()
        Me.Label_MDR_Binary = New System.Windows.Forms.Label()
        Me.Label_MDR = New System.Windows.Forms.Label()
        Me.Label_CU = New System.Windows.Forms.Label()
        Me.Panel_CIR = New System.Windows.Forms.Panel()
        Me.Label_CIR_Binary = New System.Windows.Forms.Label()
        Me.Label_CIR = New System.Windows.Forms.Label()
        Me.Panel_Decoder = New System.Windows.Forms.Panel()
        Me.Label_Decoder = New System.Windows.Forms.Label()
        Me.Label_ALU = New System.Windows.Forms.Label()
        Me.Panel_ACC = New System.Windows.Forms.Panel()
        Me.Label_ACC_Binary = New System.Windows.Forms.Label()
        Me.Label_ACC = New System.Windows.Forms.Label()
        Me.Panel_Bus_Address = New System.Windows.Forms.Panel()
        Me.Panel_Bus_Data = New System.Windows.Forms.Panel()
        Me.Panel_Bus_Control = New System.Windows.Forms.Panel()
        Me.Panel_CPU.SuspendLayout()
        Me.Panel_PC.SuspendLayout()
        Me.Panel_MAR.SuspendLayout()
        Me.Panel_MDR.SuspendLayout()
        Me.Panel_CIR.SuspendLayout()
        Me.Panel_Decoder.SuspendLayout()
        Me.Panel_ACC.SuspendLayout()
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
        'Panel_Ram
        '
        Me.Panel_Ram.BackColor = System.Drawing.Color.Orange
        Me.Panel_Ram.Location = New System.Drawing.Point(284, 13)
        Me.Panel_Ram.Name = "Panel_Ram"
        Me.Panel_Ram.Size = New System.Drawing.Size(200, 255)
        Me.Panel_Ram.TabIndex = 1
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
        'Lbl_PC
        '
        Me.Lbl_PC.Location = New System.Drawing.Point(1, 1)
        Me.Lbl_PC.Name = "Lbl_PC"
        Me.Lbl_PC.Size = New System.Drawing.Size(71, 18)
        Me.Lbl_PC.TabIndex = 0
        Me.Lbl_PC.Text = "PC"
        Me.Lbl_PC.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'Label_MAR
        '
        Me.Label_MAR.Location = New System.Drawing.Point(1, 1)
        Me.Label_MAR.Name = "Label_MAR"
        Me.Label_MAR.Size = New System.Drawing.Size(71, 18)
        Me.Label_MAR.TabIndex = 0
        Me.Label_MAR.Text = "MAR"
        Me.Label_MAR.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Text = "Form1"
        Me.Panel_CPU.ResumeLayout(False)
        Me.Panel_PC.ResumeLayout(False)
        Me.Panel_MAR.ResumeLayout(False)
        Me.Panel_MDR.ResumeLayout(False)
        Me.Panel_CIR.ResumeLayout(False)
        Me.Panel_Decoder.ResumeLayout(False)
        Me.Panel_ACC.ResumeLayout(False)
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
End Class
