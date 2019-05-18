<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtJenisBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbKodeJenis = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBanyak = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(41, 398)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(447, 130)
        Me.DGBarang.TabIndex = 83
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(190, 233)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(177, 20)
        Me.txtHarga.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "HARGA"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnCari)
        Me.GroupBox6.Controls.Add(Me.txtCari)
        Me.GroupBox6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(44, 336)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(331, 56)
        Me.GroupBox6.TabIndex = 80
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Masukkan Barang Yang Dicari"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(214, 18)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(6, 20)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(167, 25)
        Me.txtCari.TabIndex = 0
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(190, 186)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(177, 20)
        Me.txtNamaBarang.TabIndex = 79
        '
        'txtJenisBarang
        '
        Me.txtJenisBarang.Location = New System.Drawing.Point(190, 142)
        Me.txtJenisBarang.Name = "txtJenisBarang"
        Me.txtJenisBarang.Size = New System.Drawing.Size(177, 20)
        Me.txtJenisBarang.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "NAMA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "JENIS BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "KODE JENIS"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.btnSimpan)
        Me.GB1.Controls.Add(Me.btnHapus)
        Me.GB1.Controls.Add(Me.btnTambah)
        Me.GB1.Controls.Add(Me.btnBatal)
        Me.GB1.Controls.Add(Me.btnUbah)
        Me.GB1.Location = New System.Drawing.Point(380, 61)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(113, 257)
        Me.GB1.TabIndex = 71
        Me.GB1.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "FORM BARANG"
        '
        'CbKodeJenis
        '
        Me.CbKodeJenis.FormattingEnabled = True
        Me.CbKodeJenis.Location = New System.Drawing.Point(190, 98)
        Me.CbKodeJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.CbKodeJenis.Name = "CbKodeJenis"
        Me.CbKodeJenis.Size = New System.Drawing.Size(92, 21)
        Me.CbKodeJenis.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 18)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "QTY"
        '
        'txtBanyak
        '
        Me.txtBanyak.Location = New System.Drawing.Point(190, 277)
        Me.txtBanyak.Name = "txtBanyak"
        Me.txtBanyak.Size = New System.Drawing.Size(177, 20)
        Me.txtBanyak.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "KODE BARANG"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(190, 58)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(177, 20)
        Me.txtKodeBarang.TabIndex = 76
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(536, 547)
        Me.Controls.Add(Me.txtBanyak)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbKodeJenis)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtJenisBarang)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBarang"
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GB1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGBarang As DataGridView
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtJenisBarang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CbKodeJenis As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBanyak As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodeBarang As TextBox
End Class
