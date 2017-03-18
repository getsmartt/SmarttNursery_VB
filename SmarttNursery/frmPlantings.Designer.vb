<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlantings
    Inherits SmarttNursery.frmCopy

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdPlantings = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
        CType(Me.grdPlantings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPlantings
        '
        Me.grdPlantings.AllowDragSelectedCols = True
        Me.grdPlantings.Location = New System.Drawing.Point(13, 52)
        Me.grdPlantings.Name = "grdPlantings"
        Me.grdPlantings.OptimizeInsertRemoveCells = True
        Me.grdPlantings.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.grdPlantings.Size = New System.Drawing.Size(511, 602)
        Me.grdPlantings.SmartSizeBox = False
        Me.grdPlantings.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.grdPlantings.TabIndex = 4
        Me.grdPlantings.Text = "Plantings"
        Me.grdPlantings.UseListChangedEvent = True
        Me.grdPlantings.UseRightToLeftCompatibleTextBox = True
        '
        'frmPlantings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(536, 666)
        Me.Controls.Add(Me.grdPlantings)
        Me.Name = "frmPlantings"
        Me.Text = "Plantings"
        CType(Me.grdPlantings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdPlantings As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
End Class
