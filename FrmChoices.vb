Public Class FrmChoices

    Private Sub LoadComboBoxChoices()
        cboSaleItems.Items.Add("Long Sleeve Shirt")
        cboSaleItems.Items.Add("Short Sleeve Shirt")
        cboSaleItems.Items.Add("Lightweight Jacket")
    End Sub

    Private Sub FrmChoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
