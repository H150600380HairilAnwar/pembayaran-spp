<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Siswa
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
        Dim NamaLabel As System.Windows.Forms.Label
        Dim KelasLabel As System.Windows.Forms.Label
        Dim No_AbsenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Siswa))
        Dim JurusanLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim NISLabel As System.Windows.Forms.Label
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.TextCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SiswaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pembayaran_sppDataSet = New Pembayaran_SPP.pembayaran_sppDataSet()
        Me.SiswaTableAdapter = New Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.siswaTableAdapter()
        Me.TableAdapterManager = New Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager()
        Me.SiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NISTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.KelasTextBox = New System.Windows.Forms.TextBox()
        Me.No_AbsenTextBox = New System.Windows.Forms.TextBox()
        Me.JurusanTextBox = New System.Windows.Forms.TextBox()
        Me.SiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        NamaLabel = New System.Windows.Forms.Label()
        KelasLabel = New System.Windows.Forms.Label()
        No_AbsenLabel = New System.Windows.Forms.Label()
        JurusanLabel = New System.Windows.Forms.Label()
        NISLabel = New System.Windows.Forms.Label()
        CType(Me.SiswaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pembayaran_sppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.ForeColor = System.Drawing.Color.Red
        NamaLabel.Image = Global.Pembayaran_SPP.My.Resources.Resources.bgrn1
        NamaLabel.Location = New System.Drawing.Point(9, 57)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 27
        NamaLabel.Text = "Nama:"
        '
        'KelasLabel
        '
        KelasLabel.AutoSize = True
        KelasLabel.ForeColor = System.Drawing.Color.Red
        KelasLabel.Image = Global.Pembayaran_SPP.My.Resources.Resources.bgrn1
        KelasLabel.Location = New System.Drawing.Point(9, 83)
        KelasLabel.Name = "KelasLabel"
        KelasLabel.Size = New System.Drawing.Size(36, 13)
        KelasLabel.TabIndex = 29
        KelasLabel.Text = "Kelas:"
        '
        'No_AbsenLabel
        '
        No_AbsenLabel.AutoSize = True
        No_AbsenLabel.ForeColor = System.Drawing.Color.Red
        No_AbsenLabel.Image = CType(resources.GetObject("No_AbsenLabel.Image"), System.Drawing.Image)
        No_AbsenLabel.Location = New System.Drawing.Point(9, 109)
        No_AbsenLabel.Name = "No_AbsenLabel"
        No_AbsenLabel.Size = New System.Drawing.Size(57, 13)
        No_AbsenLabel.TabIndex = 31
        No_AbsenLabel.Text = "No Absen:"
        '
        'JurusanLabel
        '
        JurusanLabel.AutoSize = True
        JurusanLabel.ForeColor = System.Drawing.Color.Red
        JurusanLabel.Image = CType(resources.GetObject("JurusanLabel.Image"), System.Drawing.Image)
        JurusanLabel.Location = New System.Drawing.Point(9, 135)
        JurusanLabel.Name = "JurusanLabel"
        JurusanLabel.Size = New System.Drawing.Size(47, 13)
        JurusanLabel.TabIndex = 33
        JurusanLabel.Text = "Jurusan:"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.Lime
        Me.ButtonRefresh.Location = New System.Drawing.Point(305, 310)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 34)
        Me.ButtonRefresh.TabIndex = 26
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.BackColor = System.Drawing.Color.Red
        Me.ButtonKeluar.Location = New System.Drawing.Point(774, 310)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(75, 34)
        Me.ButtonKeluar.TabIndex = 24
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = False
        '
        'ButtonCari
        '
        Me.ButtonCari.BackColor = System.Drawing.Color.Yellow
        Me.ButtonCari.Location = New System.Drawing.Point(774, 43)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(75, 35)
        Me.ButtonCari.TabIndex = 23
        Me.ButtonCari.Text = "Cari"
        Me.ButtonCari.UseVisualStyleBackColor = False
        '
        'TextCari
        '
        Me.TextCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextCari.ForeColor = System.Drawing.Color.Red
        Me.TextCari.Location = New System.Drawing.Point(305, 43)
        Me.TextCari.Multiline = True
        Me.TextCari.Name = "TextCari"
        Me.TextCari.Size = New System.Drawing.Size(453, 35)
        Me.TextCari.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "DATA SISWA"
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
        Me.SiswaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SiswaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SiswaDataGridView.DataSource = Me.SiswaBindingSource1
        Me.SiswaDataGridView.GridColor = System.Drawing.Color.Red
        Me.SiswaDataGridView.Location = New System.Drawing.Point(305, 84)
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
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.Color.Fuchsia
        Me.ButtonTambah.Location = New System.Drawing.Point(13, 194)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(61, 39)
        Me.ButtonTambah.TabIndex = 1
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Blue
        Me.ButtonEdit.Location = New System.Drawing.Point(93, 194)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(61, 39)
        Me.ButtonEdit.TabIndex = 10
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.Cyan
        Me.ButtonHapus.Location = New System.Drawing.Point(175, 194)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(61, 39)
        Me.ButtonHapus.TabIndex = 11
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSimpan.Location = New System.Drawing.Point(175, 247)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(61, 34)
        Me.ButtonSimpan.TabIndex = 20
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.Yellow
        Me.ButtonBatal.Location = New System.Drawing.Point(13, 247)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(61, 34)
        Me.ButtonBatal.TabIndex = 25
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(NISLabel)
        Me.GroupBox1.Controls.Add(Me.NISTextBox)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(KelasLabel)
        Me.GroupBox1.Controls.Add(Me.KelasTextBox)
        Me.GroupBox1.Controls.Add(No_AbsenLabel)
        Me.GroupBox1.Controls.Add(Me.No_AbsenTextBox)
        Me.GroupBox1.Controls.Add(JurusanLabel)
        Me.GroupBox1.Controls.Add(Me.JurusanTextBox)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.ButtonBatal)
        Me.GroupBox1.Controls.Add(Me.ButtonTambah)
        Me.GroupBox1.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 303)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Siswa"
        '
        'NISTextBox
        '
        Me.NISTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "NIS", True))
        Me.NISTextBox.Enabled = False
        Me.NISTextBox.ForeColor = System.Drawing.Color.Red
        Me.NISTextBox.Location = New System.Drawing.Point(72, 31)
        Me.NISTextBox.Name = "NISTextBox"
        Me.NISTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NISTextBox.TabIndex = 26
        '
        'NamaTextBox
        '
        Me.NamaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "Nama", True))
        Me.NamaTextBox.Enabled = False
        Me.NamaTextBox.ForeColor = System.Drawing.Color.Red
        Me.NamaTextBox.Location = New System.Drawing.Point(72, 54)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextBox.TabIndex = 28
        '
        'KelasTextBox
        '
        Me.KelasTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KelasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "Kelas", True))
        Me.KelasTextBox.Enabled = False
        Me.KelasTextBox.ForeColor = System.Drawing.Color.Red
        Me.KelasTextBox.Location = New System.Drawing.Point(72, 80)
        Me.KelasTextBox.Name = "KelasTextBox"
        Me.KelasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KelasTextBox.TabIndex = 30
        '
        'No_AbsenTextBox
        '
        Me.No_AbsenTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.No_AbsenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "No_Absen", True))
        Me.No_AbsenTextBox.Enabled = False
        Me.No_AbsenTextBox.ForeColor = System.Drawing.Color.Red
        Me.No_AbsenTextBox.Location = New System.Drawing.Point(72, 106)
        Me.No_AbsenTextBox.Name = "No_AbsenTextBox"
        Me.No_AbsenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_AbsenTextBox.TabIndex = 32
        '
        'JurusanTextBox
        '
        Me.JurusanTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.JurusanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiswaBindingSource1, "Jurusan", True))
        Me.JurusanTextBox.Enabled = False
        Me.JurusanTextBox.ForeColor = System.Drawing.Color.Red
        Me.JurusanTextBox.Location = New System.Drawing.Point(72, 132)
        Me.JurusanTextBox.Name = "JurusanTextBox"
        Me.JurusanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JurusanTextBox.TabIndex = 34
        '
        'NISLabel
        '
        NISLabel.AutoSize = True
        NISLabel.ForeColor = System.Drawing.Color.Red
        NISLabel.Image = Global.Pembayaran_SPP.My.Resources.Resources.bgrn1
        NISLabel.Location = New System.Drawing.Point(9, 31)
        NISLabel.Name = "NISLabel"
        NISLabel.Size = New System.Drawing.Size(28, 13)
        NISLabel.TabIndex = 25
        NISLabel.Text = "NIS:"
        '
        'SiswaBindingSource
        '
        Me.SiswaBindingSource.DataMember = "siswa"
        '
        'Siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(917, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SiswaDataGridView)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonCari)
        Me.Controls.Add(Me.TextCari)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Siswa"
        Me.Text = "Tabel_Siswa"
        CType(Me.SiswaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pembayaran_sppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents TextCari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pembayaran_sppDataSet As Pembayaran_SPP.pembayaran_sppDataSet
    Friend WithEvents SiswaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SiswaTableAdapter As Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.siswaTableAdapter
    Friend WithEvents TableAdapterManager As Pembayaran_SPP.pembayaran_sppDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KelasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_AbsenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JurusanTextBox As System.Windows.Forms.TextBox
End Class
