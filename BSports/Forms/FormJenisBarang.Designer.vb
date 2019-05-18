<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJenisBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJenisBarang))
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.txtKodeJenis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DGJenis = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(187, 175)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(212, 20)
        Me.txtNama.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "NAMA JENIS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Location = New System.Drawing.Point(455, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 257)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(19, 115)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 38)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(19, 203)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 38)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(19, 27)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 38)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.Location = New System.Drawing.Point(19, 159)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 38)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.Location = New System.Drawing.Point(19, 71)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 38)
        Me.btnUbah.TabIndex = 9
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'txtKodeJenis
        '
        Me.txtKodeJenis.Location = New System.Drawing.Point(187, 124)
        Me.txtKodeJenis.Name = "txtKodeJenis"
        Me.txtKodeJenis.Size = New System.Drawing.Size(212, 20)
        Me.txtKodeJenis.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "KODE JENIS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "FORM JENIS BARANG"
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(264, 20)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(24, 20)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(212, 25)
        Me.txtCari.TabIndex = 0
        '
        'DGJenis
        '
        Me.DGJenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGJenis.Location = New System.Drawing.Point(50, 328)
        Me.DGJenis.Name = "DGJenis"
        Me.DGJenis.Size = New System.Drawing.Size(518, 176)
        Me.DGJenis.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 56)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan Jenis Barang Yang Dicari"
        '
        'FormJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(591, 516)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtKodeJenis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGJenis)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormJenisBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJenisBarang"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents txtKodeJenis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DGJenis As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
End Class
