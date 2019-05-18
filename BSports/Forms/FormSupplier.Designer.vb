<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSupplier))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNama_Sup = New System.Windows.Forms.TextBox()
        Me.txtKode_Sup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnCari)
        Me.GroupBox6.Controls.Add(Me.txtCari)
        Me.GroupBox6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(37, 299)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(331, 56)
        Me.GroupBox6.TabIndex = 67
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Masukkan Supplier Yang Dicari"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(192, 20)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 30)
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
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(149, 206)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(177, 20)
        Me.txtTelp.TabIndex = 66
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(149, 165)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(177, 20)
        Me.txtAlamat.TabIndex = 65
        '
        'txtNama_Sup
        '
        Me.txtNama_Sup.Location = New System.Drawing.Point(149, 119)
        Me.txtNama_Sup.Name = "txtNama_Sup"
        Me.txtNama_Sup.Size = New System.Drawing.Size(177, 20)
        Me.txtNama_Sup.TabIndex = 64
        '
        'txtKode_Sup
        '
        Me.txtKode_Sup.Location = New System.Drawing.Point(149, 75)
        Me.txtKode_Sup.Name = "txtKode_Sup"
        Me.txtKode_Sup.Size = New System.Drawing.Size(177, 20)
        Me.txtKode_Sup.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "NO.TELP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "NAMA SUPPLIER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "KODE SUPPLIER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "FORM SUPPLIER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Location = New System.Drawing.Point(371, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 257)
        Me.GroupBox2.TabIndex = 57
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 18)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "EMAIL"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(149, 252)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtEmail.TabIndex = 69
        '
        'DGSupplier
        '
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(37, 377)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.Size = New System.Drawing.Size(447, 174)
        Me.DGSupplier.TabIndex = 70
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(526, 570)
        Me.Controls.Add(Me.DGSupplier)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama_Sup)
        Me.Controls.Add(Me.txtKode_Sup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSupplier"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama_Sup As TextBox
    Friend WithEvents txtKode_Sup As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents DGSupplier As DataGridView
End Class
