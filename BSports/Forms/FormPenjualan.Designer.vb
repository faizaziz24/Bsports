<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblNamaOperator = New System.Windows.Forms.Label()
        Me.lblIDOperator = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.lblJumMenu = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LVPenjualan = New System.Windows.Forms.ListView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCariBarang = New System.Windows.Forms.Button()
        Me.txtKdBarang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIDJual = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 532)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Jumlah Barang"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(776, 609)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 67
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(776, 569)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(667, 609)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Kembali"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(667, 569)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Dibayar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(667, 534)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Total Harga"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(776, 535)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 71
        '
        'Button7
        '
        Me.Button7.Image = Global.BSports.My.Resources.Resources.cancel
        Me.Button7.Location = New System.Drawing.Point(919, 625)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 49)
        Me.Button7.TabIndex = 74
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.BSports.My.Resources.Resources.rubbish_bin
        Me.Button6.Location = New System.Drawing.Point(927, 308)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 41)
        Me.Button6.TabIndex = 73
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.BSports.My.Resources.Resources.save
        Me.Button4.Location = New System.Drawing.Point(132, 564)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 65)
        Me.Button4.TabIndex = 70
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.BSports.My.Resources.Resources.create_new_pencil_button
        Me.Button3.Location = New System.Drawing.Point(42, 564)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 65)
        Me.Button3.TabIndex = 69
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblNamaOperator
        '
        Me.lblNamaOperator.AutoSize = True
        Me.lblNamaOperator.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaOperator.Location = New System.Drawing.Point(463, 48)
        Me.lblNamaOperator.Name = "lblNamaOperator"
        Me.lblNamaOperator.Size = New System.Drawing.Size(45, 18)
        Me.lblNamaOperator.TabIndex = 95
        Me.lblNamaOperator.Text = "Label15"
        '
        'lblIDOperator
        '
        Me.lblIDOperator.AutoSize = True
        Me.lblIDOperator.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDOperator.Location = New System.Drawing.Point(461, 12)
        Me.lblIDOperator.Name = "lblIDOperator"
        Me.lblIDOperator.Size = New System.Drawing.Size(41, 18)
        Me.lblIDOperator.TabIndex = 94
        Me.lblIDOperator.Text = "Label5"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.SlateGray
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.Location = New System.Drawing.Point(776, 449)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 44)
        Me.btnKeluar.TabIndex = 93
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(623, 477)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(100, 20)
        Me.txtKembali.TabIndex = 92
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(623, 449)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(100, 20)
        Me.txtBayar.TabIndex = 91
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(623, 420)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(526, 476)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Kembali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Dibayar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Total Harga"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(110, 449)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 61)
        Me.btnSimpan.TabIndex = 86
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBaru
        '
        Me.btnBaru.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnBaru.FlatAppearance.BorderSize = 0
        Me.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaru.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnBaru.Image = CType(resources.GetObject("btnBaru.Image"), System.Drawing.Image)
        Me.btnBaru.Location = New System.Drawing.Point(29, 449)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 61)
        Me.btnBaru.TabIndex = 85
        Me.btnBaru.UseVisualStyleBackColor = False
        '
        'lblJumMenu
        '
        Me.lblJumMenu.AutoSize = True
        Me.lblJumMenu.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumMenu.Location = New System.Drawing.Point(184, 421)
        Me.lblJumMenu.Name = "lblJumMenu"
        Me.lblJumMenu.Size = New System.Drawing.Size(42, 18)
        Me.lblJumMenu.TabIndex = 84
        Me.lblJumMenu.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 422)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Jumlah Barang"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(784, 138)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 44)
        Me.btnHapus.TabIndex = 82
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(784, 88)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 44)
        Me.btnTambah.TabIndex = 81
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LVPenjualan)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnCariBarang)
        Me.GroupBox1.Controls.Add(Me.txtKdBarang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 328)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputkan Penjualan"
        '
        'LVPenjualan
        '
        Me.LVPenjualan.Location = New System.Drawing.Point(36, 105)
        Me.LVPenjualan.Name = "LVPenjualan"
        Me.LVPenjualan.Size = New System.Drawing.Size(688, 208)
        Me.LVPenjualan.TabIndex = 15
        Me.LVPenjualan.UseCompatibleStateImageBehavior = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(616, 65)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(108, 25)
        Me.txtJumlah.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(613, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Jumlah"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(479, 65)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(108, 25)
        Me.txtHarga.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Harga Barang"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(242, 65)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(218, 25)
        Me.txtNama.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(239, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nama Barang"
        '
        'btnCariBarang
        '
        Me.btnCariBarang.Location = New System.Drawing.Point(143, 65)
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnCariBarang.Size = New System.Drawing.Size(49, 23)
        Me.btnCariBarang.TabIndex = 8
        Me.btnCariBarang.Text = "..."
        Me.btnCariBarang.UseVisualStyleBackColor = True
        '
        'txtKdBarang
        '
        Me.txtKdBarang.Location = New System.Drawing.Point(36, 66)
        Me.txtKdBarang.Name = "txtKdBarang"
        Me.txtKdBarang.Size = New System.Drawing.Size(100, 25)
        Me.txtKdBarang.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kode Barang"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(137, 48)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(41, 18)
        Me.LblTanggal.TabIndex = 79
        Me.LblTanggal.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Nama Operator"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "ID Operator"
        '
        'lblIDJual
        '
        Me.lblIDJual.AutoSize = True
        Me.lblIDJual.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDJual.Location = New System.Drawing.Point(137, 12)
        Me.lblIDJual.Name = "lblIDJual"
        Me.lblIDJual.Size = New System.Drawing.Size(44, 18)
        Me.lblIDJual.TabIndex = 76
        Me.lblIDJual.Text = "LabelID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 18)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Kode Jual"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(30, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 18)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Tanggal"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(889, 523)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblNamaOperator)
        Me.Controls.Add(Me.lblIDOperator)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.lblJumMenu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblIDJual)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents lblNamaOperator As Label
    Friend WithEvents lblIDOperator As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents lblJumMenu As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LVPenjualan As ListView
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCariBarang As Button
    Friend WithEvents txtKdBarang As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblIDJual As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Timer1 As Timer
End Class
