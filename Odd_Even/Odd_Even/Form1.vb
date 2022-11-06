Public Class Form1
    Dim input1 As Integer
    Dim input2 As Integer
    Dim input3 As Integer
    Dim input4 As Integer
    Dim input5 As Integer
    Dim input6 As Integer
    Dim input7 As Integer
    Dim input8 As Integer
    Dim input9 As Integer
    Dim input10 As Integer
    Dim Odd As String = ","
    Dim Even As String = ","

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
        txtNumber3.Clear()
        txtNumber4.Clear()
        txtNumber5.Clear()
        txtNumber6.Clear()
        txtNumber7.Clear()
        txtNumber8.Clear()
        txtNumber9.Clear()
        txtNumber10.Clear()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        input1 = Val(txtNumber1.Text)
        input2 = Val(txtNumber2.Text)
        input3 = Val(txtNumber3.Text)
        input4 = Val(txtNumber4.Text)
        input5 = Val(txtNumber5.Text)
        input6 = Val(txtNumber6.Text)
        input7 = Val(txtNumber7.Text)
        input8 = Val(txtNumber8.Text)
        input9 = Val(txtNumber9.Text)
        input10 = Val(txtNumber10.Text)

        If input1 Mod 2 = 0 Then
            Odd &= input1 & ","
        Else
            Even &= input1 & ","
        End If

        If input2 Mod 2 = 0 Then
            Odd &= input2 & ","
        Else
            Even &= input2 & ","
        End If

        If input3 Mod 2 = 0 Then
            Odd &= input3 & ","
        Else
            Even &= input3 & ","
        End If

        If input4 Mod 2 = 0 Then
            Odd &= input4 & ","
        Else
            Even &= input4 & ","
        End If

        If input5 Mod 2 = 0 Then
            Odd &= input5 & ","
        Else
            Even &= input5 & ","
        End If

        If input6 Mod 2 = 0 Then
            Odd &= input6 & ","
        Else
            Even &= input6 & ","
        End If

        If input7 Mod 2 = 0 Then
            Odd &= input7 & ","
        Else
            Even &= input7 & ","
        End If

        If input8 Mod 2 = 0 Then
            Odd &= input8 & ","
        Else
            Even &= input8 & ","
        End If

        If input9 Mod 2 = 0 Then
            Odd &= input9 & ","
        Else
            Even &= input9 & ","
        End If

        If input10 Mod 2 = 0 Then
            Odd &= input10 & ","
        Else
            Even &= input10 & ","
        End If

        Label1.Text = "เลขคู่ " & Odd & vbCrLf & "เลขคี่ " & Even

    End Sub
End Class
