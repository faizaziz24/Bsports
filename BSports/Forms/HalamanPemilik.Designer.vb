<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanPemilik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HalamanPemilik))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.LihatLaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PembelianToolStripMenuItem.Image = CType(resources.GetObject("PembelianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.PembelianToolStripMenuItem.Text = "Transaksi Pembelian"
        '
        'LihatLaporanToolStripMenuItem
        '
        Me.LihatLaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem})
        Me.LihatLaporanToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LihatLaporanToolStripMenuItem.Image = CType(resources.GetObject("LihatLaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LihatLaporanToolStripMenuItem.Name = "LihatLaporanToolStripMenuItem"
        Me.LihatLaporanToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.LihatLaporanToolStripMenuItem.Text = "Lihat Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1242, 50)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 47)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HalamanPemilik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1362, 487)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "HalamanPemilik"
        Me.Text = "HalamanPemilik"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents LihatLaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As ToolStripMenuItem
End Class
