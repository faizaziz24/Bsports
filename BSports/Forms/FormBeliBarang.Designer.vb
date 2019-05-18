<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeliBarang
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
        Me.LVBarang = New System.Windows.Forms.ListView()
        Me.txtBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LVBarang
        '
        Me.LVBarang.Location = New System.Drawing.Point(34, 94)
        Me.LVBarang.Name = "LVBarang"
        Me.LVBarang.Size = New System.Drawing.Size(690, 355)
        Me.LVBarang.TabIndex = 7
        Me.LVBarang.UseCompatibleStateImageBehavior = False
        '
        'txtBarang
        '
        Me.txtBarang.Location = New System.Drawing.Point(93, 43)
        Me.txtBarang.Name = "txtBarang"
        Me.txtBarang.Size = New System.Drawing.Size(535, 20)
        Me.txtBarang.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Barang"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(649, 38)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'FormBeliBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 486)
        Me.Controls.Add(Me.LVBarang)
        Me.Controls.Add(Me.txtBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCari)
        Me.Name = "FormBeliBarang"
        Me.Text = "FormBeliBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVBarang As ListView
    Friend WithEvents txtBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
End Class
