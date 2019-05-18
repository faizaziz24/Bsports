<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPajak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanPajak))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.LVLaporanPajak = New System.Windows.Forms.ListView()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(116, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(243, 24)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "FORM LAPORAN PAJAK"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnCari)
        Me.GroupBox6.Controls.Add(Me.txtCari)
        Me.GroupBox6.Location = New System.Drawing.Point(36, 83)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(364, 56)
        Me.GroupBox6.TabIndex = 81
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Masukkan Data Pajak Yang Dicari"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(231, 15)
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
        Me.txtCari.Size = New System.Drawing.Size(167, 20)
        Me.txtCari.TabIndex = 0
        '
        'LVLaporanPajak
        '
        Me.LVLaporanPajak.Location = New System.Drawing.Point(36, 145)
        Me.LVLaporanPajak.Name = "LVLaporanPajak"
        Me.LVLaporanPajak.Size = New System.Drawing.Size(418, 250)
        Me.LVLaporanPajak.TabIndex = 82
        Me.LVLaporanPajak.UseCompatibleStateImageBehavior = False
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(36, 416)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 58)
        Me.btnHapus.TabIndex = 83
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'FormLaporanPajak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 503)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.LVLaporanPajak)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label12)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormLaporanPajak"
        Me.Text = "FormLaporanPajak"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents LVLaporanPajak As ListView
    Friend WithEvents btnHapus As Button
End Class
