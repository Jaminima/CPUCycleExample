﻿Module SharedCode

    Public BinaryV As New Binary

    Sub Wait(Delay As Integer)
        Threading.Thread.Sleep(Delay)
    End Sub

    Sub ResetPC()
    End Sub

    Function CutString(Str As String, SPos As Integer, EPos As Integer)
        Dim Out As String
        For i = SPos - 1 To EPos - 1
            Out = Out & GetChar(Str, i + 1)
        Next
        Return Out
    End Function

    Class Binary

        Public Function BinToDec(Bin As String)
            Dim Dec As Integer = 0
            For Pos As Integer = 1 To Len(Bin)
                Dec += CInt(CStr(GetChar(Bin, Pos))) * 2 ^ (Len(Bin) - Pos)
            Next
            Return Dec
        End Function

        Public Function DecToBin(Dec As String)
            Dim Bin As String = ""
            Do Until Dec = 0
                If Dec < 1 Then
                    Dec = 0
                Else
                    Bin = CStr(Dec Mod 2) & Bin
                    Dec \= 2
                End If
            Loop
            Return Bin
        End Function

        Public Function BinaryMath(A As String, B As String, MathOpcode As String)
            If MathOpcode = "+" Then Return DecToBin(BinToDec(A) + BinToDec(B))
            If MathOpcode = "-" Then Return DecToBin(BinToDec(A) - BinToDec(B))
        End Function

        Public Function MakeLength(Bin As String, NewLength As Integer)
            For i = Len(Bin) - 1 To NewLength - 2
                Bin = 0 & Bin
            Next
            Return Bin
        End Function

    End Class

End Module
