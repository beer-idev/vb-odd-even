Public Class Form1
    Dim numbers(10) As Integer
    Dim i As Integer
    Dim Even As String
    Dim Odd As String

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click

        For i = 1 To 10
            numbers(i) = InputBox("รับค่าตัวเลขตัวที่" & " " & i, "รับค่าตัวเลขจากคีย์บอร์ด", 0)
            If numbers(i) Mod 2 = 0 Then
                Even &= numbers(i) & ", "
            Else
                Odd &= numbers(i) & ", "
            End If
        Next i
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        For i = 1 To 10
            txtShowData.Text = txtShowData.Text & numbers(i) & ", "
        Next i
        txtEven.Text = Even
        txtOdd.Text = Odd
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtShowData.Clear()
        txtEven.Clear()
        txtOdd.Clear()
    End Sub
End Class
