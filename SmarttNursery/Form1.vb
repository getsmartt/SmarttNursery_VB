Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Smartt_nurseryDataSet.plant_master' table. You can move, or remove it, as needed.
        Me.Plant_masterTableAdapter.Fill(Me.Smartt_nurseryDataSet.plant_master)

    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        frmReciept.Show()
    End Sub
End Class
