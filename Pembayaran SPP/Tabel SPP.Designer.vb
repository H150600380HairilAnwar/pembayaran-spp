<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabel_SPP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tabel_SPP
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Tabel_SPP"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pembayaran_sppDataSet As Pembayaran_SPP.pembayaran_sppDataSet
    Friend WithEvents SppBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SppTableAdapter As Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.sppTableAdapter
    Friend WithEvents TableAdapterManager As Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SppDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Id_sppSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Bulan_bayarTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NominalSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents KeteranganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
