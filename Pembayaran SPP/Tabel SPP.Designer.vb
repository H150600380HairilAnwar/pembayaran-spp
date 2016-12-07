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
        Me.components = New System.ComponentModel.Container()
        Dim Id_sppLabel As System.Windows.Forms.Label
        Dim Bulan_bayarLabel As System.Windows.Forms.Label
        Dim NominalLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Me.Pembayaran_sppDataSet = New Pembayaran_SPP.pembayaran_sppDataSet()
        Me.SppBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SppTableAdapter = New Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.sppTableAdapter()
        Me.TableAdapterManager = New Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager()
        Me.SppDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Id_sppSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Bulan_bayarTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NominalSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.KeteranganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_sppLabel = New System.Windows.Forms.Label()
        Bulan_bayarLabel = New System.Windows.Forms.Label()
        NominalLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        CType(Me.Pembayaran_sppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SppBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SppDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Id_sppSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bulan_bayarTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pembayaran_sppDataSet
        '
        Me.Pembayaran_sppDataSet.DataSetName = "pembayaran_sppDataSet"
        Me.Pembayaran_sppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SppBindingSource
        '
        Me.SppBindingSource.DataMember = "spp"
        Me.SppBindingSource.DataSource = Me.Pembayaran_sppDataSet
        '
        'SppTableAdapter
        '
        Me.SppTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pembayaranTableAdapter = Nothing
        Me.TableAdapterManager.siswaTableAdapter = Nothing
        Me.TableAdapterManager.sppTableAdapter = Me.SppTableAdapter
        Me.TableAdapterManager.tabel_bendaharaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SppDataGridView
        '
        Me.SppDataGridView.AutoGenerateColumns = False
        Me.SppDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SppDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SppDataGridView.DataSource = Me.SppBindingSource
        Me.SppDataGridView.Location = New System.Drawing.Point(341, 80)
        Me.SppDataGridView.Name = "SppDataGridView"
        Me.SppDataGridView.Size = New System.Drawing.Size(445, 253)
        Me.SppDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_spp"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_spp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bulan_bayar"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bulan_bayar"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nominal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nominal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Keterangan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Keterangan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Id_sppLabel)
        Me.GroupBox1.Controls.Add(Me.Id_sppSpinEdit)
        Me.GroupBox1.Controls.Add(Bulan_bayarLabel)
        Me.GroupBox1.Controls.Add(Me.Bulan_bayarTextEdit)
        Me.GroupBox1.Controls.Add(NominalLabel)
        Me.GroupBox1.Controls.Add(Me.NominalSpinEdit)
        Me.GroupBox1.Controls.Add(KeteranganLabel)
        Me.GroupBox1.Controls.Add(Me.KeteranganTextEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 246)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SPP"
        '
        'Id_sppLabel
        '
        Id_sppLabel.AutoSize = True
        Id_sppLabel.Location = New System.Drawing.Point(15, 33)
        Id_sppLabel.Name = "Id_sppLabel"
        Id_sppLabel.Size = New System.Drawing.Size(39, 13)
        Id_sppLabel.TabIndex = 0
        Id_sppLabel.Text = "Id spp:"
        '
        'Id_sppSpinEdit
        '
        Me.Id_sppSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Id_spp", True))
        Me.Id_sppSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Id_sppSpinEdit.Location = New System.Drawing.Point(87, 30)
        Me.Id_sppSpinEdit.Name = "Id_sppSpinEdit"
        Me.Id_sppSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Id_sppSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Id_sppSpinEdit.TabIndex = 1
        '
        'Bulan_bayarLabel
        '
        Bulan_bayarLabel.AutoSize = True
        Bulan_bayarLabel.Location = New System.Drawing.Point(15, 59)
        Bulan_bayarLabel.Name = "Bulan_bayarLabel"
        Bulan_bayarLabel.Size = New System.Drawing.Size(66, 13)
        Bulan_bayarLabel.TabIndex = 2
        Bulan_bayarLabel.Text = "Bulan bayar:"
        '
        'Bulan_bayarTextEdit
        '
        Me.Bulan_bayarTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Bulan_bayar", True))
        Me.Bulan_bayarTextEdit.Location = New System.Drawing.Point(87, 56)
        Me.Bulan_bayarTextEdit.Name = "Bulan_bayarTextEdit"
        Me.Bulan_bayarTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Bulan_bayarTextEdit.TabIndex = 3
        '
        'NominalLabel
        '
        NominalLabel.AutoSize = True
        NominalLabel.Location = New System.Drawing.Point(15, 85)
        NominalLabel.Name = "NominalLabel"
        NominalLabel.Size = New System.Drawing.Size(48, 13)
        NominalLabel.TabIndex = 4
        NominalLabel.Text = "Nominal:"
        '
        'NominalSpinEdit
        '
        Me.NominalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Nominal", True))
        Me.NominalSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NominalSpinEdit.Location = New System.Drawing.Point(87, 82)
        Me.NominalSpinEdit.Name = "NominalSpinEdit"
        Me.NominalSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NominalSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.NominalSpinEdit.TabIndex = 5
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(15, 111)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(65, 13)
        KeteranganLabel.TabIndex = 6
        KeteranganLabel.Text = "Keterangan:"
        '
        'KeteranganTextEdit
        '
        Me.KeteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Keterangan", True))
        Me.KeteranganTextEdit.Location = New System.Drawing.Point(87, 108)
        Me.KeteranganTextEdit.Name = "KeteranganTextEdit"
        Me.KeteranganTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.KeteranganTextEdit.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Edit "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(221, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Batal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(260, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Simpan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(341, 339)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(711, 339)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Keluar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(711, 54)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Cari"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(341, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(364, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PEMBAYARAN SPP"
        '
        'Tabel_SPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 391)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SppDataGridView)
        Me.Name = "Tabel_SPP"
        Me.Text = " "
        CType(Me.Pembayaran_sppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SppBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SppDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Id_sppSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bulan_bayarTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominalSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
