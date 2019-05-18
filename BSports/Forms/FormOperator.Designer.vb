<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOperator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOperator))
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtKodeOperator = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaOperator = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbLevel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.DGOperator = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.GB1.SuspendLayout()
        CType(Me.DGOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(206, 230)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(177, 20)
        Me.txtPass.TabIndex = 85
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(206, 186)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(177, 20)
        Me.txtUsername.TabIndex = 84
        '
        'txtKodeOperator
        '
        Me.txtKodeOperator.Location = New System.Drawing.Point(206, 102)
        Me.txtKodeOperator.Name = "txtKodeOperator"
        Me.txtKodeOperator.Size = New System.Drawing.Size(177, 20)
        Me.txtKodeOperator.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "PASSWORD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "KODE OPERATOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "FORM OPERATOR"
        '
        'txtNamaOperator
        '
        Me.txtNamaOperator.Location = New System.Drawing.Point(206, 146)
        Me.txtNamaOperator.Name = "txtNamaOperator"
        Me.txtNamaOperator.Size = New System.Drawing.Size(177, 20)
        Me.txtNamaOperator.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "NAMA OPERATOR"
        '
        'cbLevel
        '
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Location = New System.Drawing.Point(206, 276)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(121, 21)
        Me.cbLevel.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 18)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "LEVEL"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.btnSimpan)
        Me.GB1.Controls.Add(Me.btnHapus)
        Me.GB1.Controls.Add(Me.btnTambah)
        Me.GB1.Controls.Add(Me.btnBatal)
        Me.GB1.Controls.Add(Me.btnUbah)
        Me.GB1.Location = New System.Drawing.Point(410, 102)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(113, 257)
        Me.GB1.TabIndex = 91
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
        'DGOperator
        '
        Me.DGOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOperator.Location = New System.Drawing.Point(56, 376)
        Me.DGOperator.Name = "DGOperator"
        Me.DGOperator.Size = New System.Drawing.Size(447, 147)
        Me.DGOperator.TabIndex = 93
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnCari)
        Me.GroupBox6.Controls.Add(Me.txtCari)
        Me.GroupBox6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(56, 314)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(331, 56)
        Me.GroupBox6.TabIndex = 92
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Masukkan Operator Yang Dicari"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(214, 18)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 27)
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
        'FormOperator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 535)
        Me.Controls.Add(Me.DGOperator)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbLevel)
        Me.Controls.Add(Me.txtNamaOperator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtKodeOperator)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormOperator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormOperator"
        Me.GB1.ResumeLayout(False)
        CType(Me.DGOperator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtKodeOperator As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaOperator As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbLevel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents DGOperator As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
End Class
