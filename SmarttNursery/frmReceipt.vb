Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class frmReciept
    'Inherits Office2010Form
    Inherits MetroForm

    Private Sub grdItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdItems.CellContentClick

    End Sub

    Private Sub autoLabel2_Click(sender As Object, e As EventArgs) Handles lblDateOrdered.Click, lblDatePaid.Click

    End Sub

    Private Sub frmReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbReceipt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddCompany_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        frmCustomer.Show()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        frmAddItem.Show()
    End Sub

    Private Sub sbtnNotes_Click(sender As Object, e As EventArgs) Handles sbtnNotes.Click
        Dim frmNotes As Form
        frmNotes = New frmNote
        frmNotes.Show()
    End Sub

    Private Sub SplitButton1_Click(sender As Object, e As EventArgs) Handles SplitButton1.Click
        frmDocument.Show()
    End Sub
End Class