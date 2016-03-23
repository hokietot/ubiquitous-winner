Public Class frmOrderForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        If rbnCheeseburger.Checked = True Then
            MsgBox("You have ordered a " & rbnCheeseburger.Text, MsgBoxStyle.OkOnly, "Order")
        ElseIf rbnPizza.Checked = True Then
            MsgBox("You have ordered a " & rbnPizza.Text, MsgBoxStyle.OkOnly, "Order")
        ElseIf rbnPizza.Checked = True AndAlso rbnCheeseburger.Checked = True Then
            MsgBox("You have not ordered anything.", MsgBoxStyle.OkOnly, "Sadness")
        End If
        Me.Close()
    End Sub

End Class
