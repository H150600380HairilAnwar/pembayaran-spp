<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelSPPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BandaharaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSiswaToolStripMenuItem, Me.BandaharaToolStripMenuItem, Me.PembayaranToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataSiswaToolStripMenuItem
        '
        Me.DataSiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabelSiswaToolStripMenuItem, Me.TabelSPPToolStripMenuItem})
        Me.DataSiswaToolStripMenuItem.Name = "DataSiswaToolStripMenuItem"
        Me.DataSiswaToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.DataSiswaToolStripMenuItem.Text = "Data Siswa"
        '
        'TabelSiswaToolStripMenuItem
        '
        Me.TabelSiswaToolStripMenuItem.Name = "TabelSiswaToolStripMenuItem"
        Me.TabelSiswaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TabelSiswaToolStripMenuItem.Text = "Tabel Siswa"
        '
        'TabelSPPToolStripMenuItem
        '
        Me.TabelSPPToolStripMenuItem.Name = "TabelSPPToolStripMenuItem"
        Me.TabelSPPToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TabelSPPToolStripMenuItem.Text = "Tabel SPP"
        '
        'BandaharaToolStripMenuItem
        '
        Me.BandaharaToolStripMenuItem.Name = "BandaharaToolStripMenuItem"
        Me.BandaharaToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BandaharaToolStripMenuItem.Text = "Bendahara"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabelSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabelSPPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BandaharaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
