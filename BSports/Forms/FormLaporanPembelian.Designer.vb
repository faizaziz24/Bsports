<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanPembelian))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGLaporanPembelian = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGLaporanPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "FORM LAPORAN PEMBELIAN"
        '
        'DGLaporanPembelian
        '
        Me.DGLaporanPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLaporanPembelian.Location = New System.Drawing.Point(27, 169)
        Me.DGLaporanPembelian.Name = "DGLaporanPembelian"
        Me.DGLaporanPembelian.Size = New System.Drawing.Size(752, 278)
        Me.DGLaporanPembelian.TabIndex = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCetak)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.DTP2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 77)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan Tanggal"
        '
        'btnCetak
        '
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.Location = New System.Drawing.Point(634, 19)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 51)
        Me.btnCetak.TabIndex = 4
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(543, 19)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 51)
        Me.btnCari.TabIndex = 3
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'DTP2
        '
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(283, 34)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(200, 25)
        Me.DTP2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "s/d"
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(27, 34)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(200, 25)
        Me.DTP1.TabIndex = 0
        '
        'FormLaporanPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 500)
        Me.Controls.Add(Me.DGLaporanPembelian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormLaporanPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanPembelian"
        CType(Me.DGLaporanPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DGLaporanPembelian As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DTP1 As DateTimePicker
End Class
