Imports System.ComponentModel

Public Class Form1
    Public Delay = 600
    Private Sub BtnCycle_Click(sender As Object, e As EventArgs) Handles BtnCycle.Click
        BtnCycle.BackColor = Color.Green

        RegisterController.MARV.ReadFromPC()

        RegisterController.PCV.Iterate()

        RegisterController.MBRV.ReadFromRam()

        RegisterController.CIRV.ReadFromMBR()

        Decoder.DecodeCIR()

        SharedCode.Wait(Delay)
        BtnCycle.BackColor = Color.Transparent
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnRestart.Hide()
        For Each Control In Me.Table_Ram.Controls
            If Control.Name.Contains("TxtBox_Ram_") Then
                Control.Text = "00000000"
            End If
        Next
    End Sub
End Class