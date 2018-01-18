Module RamController

    Public Function GetVal(Address As String)
        If Address = "1100" Then
            PCV.Counter = "0000"
            Form1.Label_PC_Binary.Text = PCV.Counter
        End If
        For Each Control In Form1.Table_Ram.Controls
            If Control.Name = ("TxtBox_Ram_" & Address) Then
                Control.BackColor = Color.Green
                Form1.Refresh()
                SharedCode.Wait(Form1.Delay)
                Control.BackColor = Color.White
                Return Control.Text
            End If
        Next
        Return "Er1"
    End Function

    Public Function WriteVal(Address As String, NewData As String)
        If Address = "1100" Then
            PCV.Counter = "0000"
            Form1.Label_PC_Binary.Text = PCV.Counter
        End If
        For Each Control In Form1.Table_Ram.Controls
            If Control.Name = ("TxtBox_Ram_" & Address) Then
                Control.BackColor = Color.Green
                Form1.Refresh()
                SharedCode.Wait(Form1.Delay)
                Control.BackColor = Color.White
                Control.Text = NewData
            End If
        Next
    End Function

End Module
