Imports Syncfusion.Windows.Forms

Public Class frmDocument
    'Inherits MetroForm
    Inherits SmarttNursery.frmCopy

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.bmMain.Bars.Add(bSave)

    End Sub

    Private Sub ButtonAdv1_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
    End Sub
End Class
