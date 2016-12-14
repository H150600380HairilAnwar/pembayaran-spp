<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabel_Siswa
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
        Dim NISLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim No_AbsenLabel As System.Windows.Forms.Label
        Dim JurusanLabel As System.Windows.Forms.Label
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.SiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.SiswaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pembayaran_sppDataSet = New Pembayaran_SPP.pembayaran_sppDataSet()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        Me.No_AbsenTextBox = New System.Windows.Forms.TextBox()
        Me.JurusanTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.SiswaTableAdapter = New Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.siswaTableAdapter()
        Me.TableAdapterManager = New Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager()
        Me.SiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NISLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        No_AbsenLabel = New System.Windows.Forms.Label()
        JurusanLabel = New System.Windows.Forms.Label()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SiswaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pembayaran_sppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.Location = New System.Drawing.Point(22, 25)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 11
        NISLabel.Text = "NIS:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(22, 51)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 13
        NamaLabel.Text = "Nama:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.Location = New System.Drawing.Point(22, 77)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(36, 13)
        KelasLabel.TabIndex = 15
        KelasLabel.Text = "Kelas:"
        '
        'No_AbsenLabel
        '
        No_AbsenLabel.AutoSize = True
        No_AbsenLabel.Location = New System.Drawing.Point(22, 103)
        No_AbsenLabel.Name = "No_AbsenLabel"
        No_AbsenLabel.Size = New System.Drawing.Size(57, 13)
        No_AbsenLabel.TabIndex = 17
        No_AbsenLabel.Text = "No Absen:"
        '
        'JurusanLabel
        '
        JurusanLabel.AutoSize = True
        JurusanLabel.Location = New System.Drawing.Point(22, 129)
        JurusanLabel.Name = "JurusanLabel"
        JurusanLabel.Size = New System.Drawing.Size(47, 13)
        JurusanLabel.TabIndex = 19
        JurusanLabel.Text = "Jurusan:"
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(13, 240)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(74, 23)
        Me.ButtonBatal.TabIndex = 25
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(161, 168)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(61, 23)
        Me.ButtonHapus.TabIndex = 11
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(747, 299)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonKeluar.TabIndex = 24
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'ButtonCari
        '
        Me.ButtonCari.Location = New System.Drawing.Point(746, 41)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCari.TabIndex = 23
        Me.ButtonCari.Text = "Cari"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(97, 168)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(61, 23)
        Me.ButtonEdit.TabIndex = 10
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'TextCari
        '
        Me.TextCari.Location = New System.Drawing.Point(278, 44)
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(463, 20)
        Me.TextCari.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "DATA SISWA"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(33, 168)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(61, 23)
        Me.ButtonTambah.TabIndex = 1
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'SiswaBindingSource
        '
        Me.SiswaBindingSource.DataMember = "siswa"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(278, 299)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 26
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NISLabel)
        Me.GroupBox1.Controls.Add(Me.NISTextBox)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(KelasLabel)
        Me.GroupBox1.Controls.Add(Me.KelasTextBox)
        Me.GroupBox1.Controls.Add(No_AbsenLabel)
        Me.GroupBox1.Controls.Add(Me.No_AbsenTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Controls.Add(JurusanLabel)
        Me.GroupBox1.Controls.Add(Me.JurusanTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 226)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Siswa"
        '
        'NISTextBox
        '
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "NIS", True))
        Me.NISTextBox.Location = New System.Drawing.Point(85, 22)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(89, 20)
        Me.NISTextBox.TabIndex = 12
        '
        'SiswaBindingSource1
        '
        Me.SiswaBindingSource1.DataMember = "siswa"
        Me.SiswaBindingSource1.DataSource = Me.Pembayaran_sppDataSet
        '
        'Pembayaran_sppDataSet
        '
        Me.Pembayaran_sppDataSet.DataSetName = "pembayaran_sppDataSet"
        Me.Pembayaran_sppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(85, 48)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(169, 20)
        Me.NamaTextBox.TabIndex = 14
        '
        'KelasTextBox
        '
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "Kelas", True))
        Me.KelasTextBox.Location = New System.Drawing.Point(85, 74)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.Size = New System.Drawing.Size(46, 20)
        Me.KelasTextBox.TabIndex = 16
        '
        'No_AbsenTextBox
        '
        Me.No_AbsenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "No_Absen", True))
        Me.No_AbsenTextBox.Location = New System.Drawing.Point(85, 100)
        Me.No_AbsenTextBox.Name = "No_AbsenTextBox"
        Me.No_AbsenTextBox.Size = New System.Drawing.Size(46, 20)
        Me.No_AbsenTextBox.TabIndex = 18
        '
        'JurusanTextBox
        '
        Me.JurusanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "Jurusan", True))
        Me.JurusanTextBox.Location = New System.Drawing.Point(85, 126)
        Me.JurusanTextBox.Name = "JurusanTextBox"
        Me.JurusanTextBox.Size = New System.Drawing.Size(169, 20)
        Me.JurusanTextBox.TabIndex = 20
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(161, 203)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(74, 23)
        Me.ButtonSimpan.TabIndex = 21
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'SiswaTableAdapter
        '
        Me.SiswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pembayaranTableAdapter = Nothing
        Me.TableAdapterManager.siswaTableAdapter = Me.SiswaTableAdapter
        Me.TableAdapterManager.sppTableAdapter = Nothing
        Me.TableAdapterManager.tabel_bendaharaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SiswaDataGridView
        '
        Me.SiswaDataGridView.AutoGenerateColumns = False
        Me.SiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SiswaDataGridView.DataSource = Me.SiswaBindingSource1
        Me.SiswaDataGridView.Location = New System.Drawing.Point(278, 73)
        Me.SiswaDataGridView.Name = "SiswaDataGridView"
        Me.SiswaDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.SiswaDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Kelas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "No_Absen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "No_Absen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Jurusan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Jurusan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Tabel_Siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 329)
        Me.Controls.Add(Me.SiswaDataGridView)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonCari)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tabel_Siswa"
        Me.Text = "Tabel_Siswa"
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SiswaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pembayaran_sppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents SiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents Pembayaran_sppDataSet As Pembayaran_SPP.pembayaran_sppDataSet
    Friend WithEvents SiswaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SiswaTableAdapter As Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.siswaTableAdapter
    Friend WithEvents TableAdapterManager As Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_AbsenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JurusanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
