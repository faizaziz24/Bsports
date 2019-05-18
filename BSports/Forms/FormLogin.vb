Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'HalamanAdmin.lblAdmin.Text = txtUsername.Text
        DTGrid = KontrolOperator.loginOperator(txtUsername.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasOperator.kode_operator = DTGrid.Rows(0).Item(0)
            EntitasOperator.nama_operator = DTGrid.Rows(0).Item(1)
            EntitasOperator.userid = DTGrid.Rows(0).Item(2)
            EntitasOperator.pass = DTGrid.Rows(0).Item(3)
            EntitasOperator.level_operator = DTGrid.Rows(0).Item(4)

            KODELOG = EntitasOperator.kode_operator
            NAMALOG = EntitasOperator.nama_operator


            If txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "admin" Then
                HalamanAdmin.Show()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Hide()

            ElseIf txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "kasir" Then
                HalamanKasir.Show()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Hide()

            ElseIf txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "pemilik" Then
                HalamanPemilik.Show()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Hide()

            Else
                MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Focus()

            End If

        Else
            MessageBox.Show("ID tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Text = ""
            txtUsername.Text = ""
            txtUsername.Focus()
        End If
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ellipsradius As New Drawing2D.GraphicsPath
        ellipsradius.StartFigure()
        ellipsradius.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius.AddLine(10, 0, btnLogin.Width - 20, 0)
        ellipsradius.AddArc(New Rectangle(btnLogin.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius.AddLine(btnLogin.Width, 20, btnLogin.Width, btnLogin.Height - 10)
        ellipsradius.AddArc(New Rectangle(btnLogin.Width - 10, btnLogin.Height - 10, 10, 10), 0, 90)
        ellipsradius.AddLine(btnLogin.Width - 10, btnLogin.Height, 20, btnLogin.Height)
        ellipsradius.AddArc(New Rectangle(0, btnLogin.Height - 10, 10, 10), 90, 90)

        ellipsradius.CloseFigure()
        btnLogin.Region = New Region(ellipsradius)

        Dim ellipsradius2 As New Drawing2D.GraphicsPath
        ellipsradius2.StartFigure()
        ellipsradius2.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius2.AddLine(10, 0, btnKeluar.Width - 20, 0)
        ellipsradius2.AddArc(New Rectangle(btnKeluar.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius2.AddLine(btnKeluar.Width, 20, btnKeluar.Width, btnKeluar.Height - 10)
        ellipsradius2.AddArc(New Rectangle(btnKeluar.Width - 10, btnKeluar.Height - 10, 10, 10), 0, 90)
        ellipsradius2.AddLine(btnKeluar.Width - 10, btnKeluar.Height, 20, btnKeluar.Height)
        ellipsradius2.AddArc(New Rectangle(0, btnKeluar.Height - 10, 10, 10), 90, 90)

        ellipsradius2.CloseFigure()
        btnKeluar.Region = New Region(ellipsradius2)
    End Sub
End Class