<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembelian))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaSup = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LVPembelian = New System.Windows.Forms.ListView()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.btnBahan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblKodeBeli = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblJumBahan = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Beli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(508, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Pembelian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Operator"
        '
        'txtNamaSup
        '
        Me.txtNamaSup.Location = New System.Drawing.Point(180, 129)
        Me.txtNamaSup.Name = "txtNamaSup"
        Me.txtNamaSup.Size = New System.Drawing.Size(142, 20)
        Me.txtNamaSup.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kode Supplier"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(34, 128)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(121, 21)
        Me.cmbSupplier.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(177, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nama Supplier"
        '
        'LVPembelian
        '
        Me.LVPembelian.Location = New System.Drawing.Point(34, 211)
        Me.LVPembelian.Name = "LVPembelian"
        Me.LVPembelian.Size = New System.Drawing.Size(716, 209)
        Me.LVPembelian.TabIndex = 8
        Me.LVPembelian.UseCompatibleStateImageBehavior = False
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(34, 182)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(121, 20)
        Me.txtKode.TabIndex = 9
        '
        'btnBahan
        '
        Me.btnBahan.Location = New System.Drawing.Point(162, 182)
        Me.btnBahan.Name = "btnBahan"
        Me.btnBahan.Size = New System.Drawing.Size(75, 23)
        Me.btnBahan.TabIndex = 10
        Me.btnBahan.Text = "..."
        Me.btnBahan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Kode Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nama Barang"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(291, 185)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(168, 20)
        Me.txtNama.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(483, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(486, 182)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(71, 20)
        Me.txtQty.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(601, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(604, 182)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(146, 20)
        Me.txtHarga.TabIndex = 16
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(756, 211)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 44)
        Me.btnTambah.TabIndex = 19
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(756, 261)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 44)
        Me.btnHapus.TabIndex = 20
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(658, 25)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(42, 18)
        Me.lblTanggal.TabIndex = 21
        Me.lblTanggal.Text = "Label11"
        '
        'lblKodeBeli
        '
        Me.lblKodeBeli.AutoSize = True
        Me.lblKodeBeli.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeBeli.Location = New System.Drawing.Point(151, 25)
        Me.lblKodeBeli.Name = "lblKodeBeli"
        Me.lblKodeBeli.Size = New System.Drawing.Size(45, 18)
        Me.lblKodeBeli.TabIndex = 22
        Me.lblKodeBeli.Text = "Label12"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperator.Location = New System.Drawing.Point(151, 55)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(45, 18)
        Me.lblOperator.TabIndex = 23
        Me.lblOperator.Text = "Label13"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(115, 426)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 61)
        Me.btnSimpan.TabIndex = 25
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBaru
        '
        Me.btnBaru.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnBaru.FlatAppearance.BorderSize = 0
        Me.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaru.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnBaru.Image = CType(resources.GetObject("btnBaru.Image"), System.Drawing.Image)
        Me.btnBaru.Location = New System.Drawing.Point(34, 426)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 61)
        Me.btnBaru.TabIndex = 24
        Me.btnBaru.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.Location = New System.Drawing.Point(762, 452)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 44)
        Me.btnKeluar.TabIndex = 26
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(650, 436)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(557, 439)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 18)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Total Harga"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblJumBahan
        '
        Me.lblJumBahan.AutoSize = True
        Me.lblJumBahan.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumBahan.Location = New System.Drawing.Point(342, 426)
        Me.lblJumBahan.Name = "lblJumBahan"
        Me.lblJumBahan.Size = New System.Drawing.Size(45, 18)
        Me.lblJumBahan.TabIndex = 29
        Me.lblJumBahan.Text = "Label10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(217, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Jumlah Barang"
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(849, 508)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblJumBahan)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.lblKodeBeli)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBahan)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.LVPembelian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaSup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembelian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaSup As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LVPembelian As ListView
    Friend WithEvents txtKode As TextBox
    Friend WithEvents btnBahan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblKodeBeli As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblJumBahan As Label
    Friend WithEvents Label10 As Label
End Class
