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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
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
        'Id_sppLabel
        '
        Id_sppLabel.AutoSize = True
        Id_sppLabel.Location = New System.Drawing.Point(15, 29)
        Id_sppLabel.Name = "Id_sppLabel"
        Id_sppLabel.Size = New System.Drawing.Size(39, 13)
        Id_sppLabel.TabIndex = 0
        Id_sppLabel.Text = "Id spp:"
        '
        'Bulan_bayarLabel
        '
        Bulan_bayarLabel.AutoSize = True
        Bulan_bayarLabel.Location = New System.Drawing.Point(15, 55)
        Bulan_bayarLabel.Name = "Bulan_bayarLabel"
        Bulan_bayarLabel.Size = New System.Drawing.Size(66, 13)
        Bulan_bayarLabel.TabIndex = 2
        Bulan_bayarLabel.Text = "Bulan bayar:"
        '
        'NominalLabel
        '
        NominalLabel.AutoSize = True
        NominalLabel.Location = New System.Drawing.Point(15, 81)
        NominalLabel.Name = "NominalLabel"
        NominalLabel.Size = New System.Drawing.Size(48, 13)
        NominalLabel.TabIndex = 4
        NominalLabel.Text = "Nominal:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(15, 107)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(65, 13)
        KeteranganLabel.TabIndex = 6
        KeteranganLabel.Text = "Keterangan:"
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
        Me.SppDataGridView.Location = New System.Drawing.Point(253, 72)
        Me.SppDataGridView.Name = "SppDataGridView"
        Me.SppDataGridView.Size = New System.Drawing.Size(544, 231)
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
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Controls.Add(Id_sppLabel)
        Me.GroupBox1.Controls.Add(Me.Id_sppSpinEdit)
        Me.GroupBox1.Controls.Add(Bulan_bayarLabel)
        Me.GroupBox1.Controls.Add(Me.Bulan_bayarTextEdit)
        Me.GroupBox1.Controls.Add(NominalLabel)
        Me.GroupBox1.Controls.Add(Me.NominalSpinEdit)
        Me.GroupBox1.Controls.Add(KeteranganLabel)
        Me.GroupBox1.Controls.Add(Me.KeteranganTextEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 202)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SPP"
        '
        'Id_sppSpinEdit
        '
        Me.Id_sppSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Id_spp", True))
        Me.Id_sppSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Id_sppSpinEdit.Enabled = False
        Me.Id_sppSpinEdit.Location = New System.Drawing.Point(87, 26)
        Me.Id_sppSpinEdit.Name = "Id_sppSpinEdit"
        Me.Id_sppSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Id_sppSpinEdit.Size = New System.Drawing.Size(85, 20)
        Me.Id_sppSpinEdit.TabIndex = 1
        '
        'Bulan_bayarTextEdit
        '
        Me.Bulan_bayarTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Bulan_bayar", True))
        Me.Bulan_bayarTextEdit.Enabled = False
        Me.Bulan_bayarTextEdit.Location = New System.Drawing.Point(87, 52)
        Me.Bulan_bayarTextEdit.Name = "Bulan_bayarTextEdit"
        Me.Bulan_bayarTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Bulan_bayarTextEdit.TabIndex = 3
        '
        'NominalSpinEdit
        '
        Me.NominalSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Nominal", True))
        Me.NominalSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NominalSpinEdit.Enabled = False
        Me.NominalSpinEdit.Location = New System.Drawing.Point(87, 78)
        Me.NominalSpinEdit.Name = "NominalSpinEdit"
        Me.NominalSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NominalSpinEdit.Size = New System.Drawing.Size(141, 20)
        Me.NominalSpinEdit.TabIndex = 5
        '
        'KeteranganTextEdit
        '
        Me.KeteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SppBindingSource, "Keterangan", True))
        Me.KeteranganTextEdit.Enabled = False
        Me.KeteranganTextEdit.Location = New System.Drawing.Point(87, 104)
        Me.KeteranganTextEdit.Name = "KeteranganTextEdit"
        Me.KeteranganTextEdit.Size = New System.Drawing.Size(141, 20)
        Me.KeteranganTextEdit.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Darktech LDR", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PEMBAYARAN SPP"
        '
        'ButtonCari
        '
        Me.ButtonCari.Location = New System.Drawing.Point(722, 46)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCari.TabIndex = 15
        Me.ButtonCari.Text = "Cari"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'TextCari
        '
        Me.TextCari.Location = New System.Drawing.Point(253, 46)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(463, 20)
        Me.TextCari.TabIndex = 16
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(151, 172)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(61, 23)
        Me.ButtonHapus.TabIndex = 14
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(87, 172)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(61, 23)
        Me.ButtonEdit.TabIndex = 13
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(23, 172)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(61, 23)
        Me.ButtonTambah.TabIndex = 12
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(253, 307)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 19
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(722, 307)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 18
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(13, 247)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(74, 23)
        Me.ButtonBatal.TabIndex = 21
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(173, 247)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(74, 23)
        Me.ButtonSimpan.TabIndex = 20
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'Tabel_SPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 336)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.ButtonCari)
        Me.Controls.Add(Me.Label1)
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
End Class
