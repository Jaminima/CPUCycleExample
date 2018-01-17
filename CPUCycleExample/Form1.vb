Public Class Form1
    Public Delay = 1000
    Private Sub BtnCycle_Click(sender As Object, e As EventArgs) Handles BtnCycle.Click
        BtnCycle.BackColor = Color.Green
        Debug.WriteLine(RamController.GetVal(RegisterController.PCV.Counter))
        RegisterController.PCV.Iterate()
        SharedCode.Wait(Delay)
        BtnCycle.BackColor = Color.Transparent
    End Sub

End Class