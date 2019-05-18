<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HalamanAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JenisBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JenisBarangToolStripMenuItem, Me.BarangToolStripMenuItem, Me.ToolStripMenuItem1, Me.SupplierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1378, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JenisBarangToolStripMenuItem
        '
        Me.JenisBarangToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JenisBarangToolStripMenuItem.Image = CType(resources.GetObject("JenisBarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JenisBarangToolStripMenuItem.Name = "JenisBarangToolStripMenuItem"
        Me.JenisBarangToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.JenisBarangToolStripMenuItem.Text = "Jenis Barang"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarangToolStripMenuItem.Image = CType(resources.GetObject("BarangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(104, 24)
        Me.ToolStripMenuItem1.Text = "Operator"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierToolStripMenuItem.Image = CType(resources.GetObject("SupplierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(1283, 50)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(64, 44)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'HalamanAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1378, 572)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HalamanAdmin"
        Me.Text = "HalamanPemilik"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnExit As Button
    Friend WithEvents JenisBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
End Class
