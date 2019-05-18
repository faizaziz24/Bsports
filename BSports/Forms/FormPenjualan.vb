Imports System.Data.OleDb
Public Class FormPenjualan
    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buattabel()
        Call Bersih()

        lblIDJual.Text = kodeBaru()
        lblIDOperator.Text = KODELOG
        lblNamaOperator.Text = NAMALOG

        txtTotal.Enabled = False
        txtKembali.Enabled = False


        MdiParent = HalamanKasir

        'btn tambah'
        Dim ellipsradius As New Drawing2D.GraphicsPath
        ellipsradius.StartFigure()
        ellipsradius.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius.AddLine(10, 0, btnTambah.Width - 20, 0)
        ellipsradius.AddArc(New Rectangle(btnTambah.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius.AddLine(btnTambah.Width, 20, btnTambah.Width, btnTambah.Height - 10)
        ellipsradius.AddArc(New Rectangle(btnTambah.Width - 10, btnTambah.Height - 10, 10, 10), 0, 90)
        ellipsradius.AddLine(btnTambah.Width - 10, btnTambah.Height, 20, btnTambah.Height)
        ellipsradius.AddArc(New Rectangle(0, btnTambah.Height - 10, 10, 10), 90, 90)

        ellipsradius.CloseFigure()
        btnTambah.Region = New Region(ellipsradius)

        'btnhapus'
        Dim ellipsradius3 As New Drawing2D.GraphicsPath
        ellipsradius3.StartFigure()
        ellipsradius3.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius3.AddLine(10, 0, btnHapus.Width - 20, 0)
        ellipsradius3.AddArc(New Rectangle(btnHapus.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius3.AddLine(btnHapus.Width, 20, btnHapus.Width, btnHapus.Height - 10)
        ellipsradius3.AddArc(New Rectangle(btnHapus.Width - 10, btnHapus.Height - 10, 10, 10), 0, 90)
        ellipsradius3.AddLine(btnHapus.Width - 10, btnHapus.Height, 20, btnHapus.Height)
        ellipsradius3.AddArc(New Rectangle(0, btnHapus.Height - 10, 10, 10), 90, 90)

        ellipsradius3.CloseFigure()
        btnHapus.Region = New Region(ellipsradius3)

        'btn simpan'
        Dim ellipsradius5 As New Drawing2D.GraphicsPath
        ellipsradius5.StartFigure()
        ellipsradius5.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius5.AddLine(10, 0, btnSimpan.Width - 20, 0)
        ellipsradius5.AddArc(New Rectangle(btnSimpan.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius5.AddLine(btnSimpan.Width, 20, btnSimpan.Width, btnSimpan.Height - 10)
        ellipsradius5.AddArc(New Rectangle(btnSimpan.Width - 10, btnSimpan.Height - 10, 10, 10), 0, 90)
        ellipsradius5.AddLine(btnSimpan.Width - 10, btnSimpan.Height, 20, btnSimpan.Height)
        ellipsradius5.AddArc(New Rectangle(0, btnSimpan.Height - 10, 10, 10), 90, 90)

        ellipsradius5.CloseFigure()
        btnSimpan.Region = New Region(ellipsradius5)

        'btnbatal'
        Dim ellipsradius4 As New Drawing2D.GraphicsPath
        ellipsradius4.StartFigure()
        ellipsradius4.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius4.AddLine(10, 0, btnKeluar.Width - 20, 0)
        ellipsradius4.AddArc(New Rectangle(btnKeluar.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius4.AddLine(btnKeluar.Width, 20, btnKeluar.Width, btnKeluar.Height - 10)
        ellipsradius4.AddArc(New Rectangle(btnKeluar.Width - 10, btnKeluar.Height - 10, 10, 10), 0, 90)
        ellipsradius4.AddLine(btnKeluar.Width - 10, btnKeluar.Height, 20, btnKeluar.Height)
        ellipsradius4.AddArc(New Rectangle(0, btnKeluar.Height - 10, 10, 10), 90, 90)

        ellipsradius4.CloseFigure()
        btnKeluar.Region = New Region(ellipsradius4)

        'btn baru'
        Dim ellipsradius2 As New Drawing2D.GraphicsPath
        ellipsradius2.StartFigure()
        ellipsradius2.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius2.AddLine(10, 0, btnBaru.Width - 20, 0)
        ellipsradius2.AddArc(New Rectangle(btnBaru.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius2.AddLine(btnBaru.Width, 20, btnBaru.Width, btnBaru.Height - 10)
        ellipsradius2.AddArc(New Rectangle(btnBaru.Width - 10, btnBaru.Height - 10, 10, 10), 0, 90)
        ellipsradius2.AddLine(btnBaru.Width - 10, btnBaru.Height, 20, btnBaru.Height)
        ellipsradius2.AddArc(New Rectangle(0, btnBaru.Height - 10, 10, 10), 90, 90)

        ellipsradius2.CloseFigure()
        btnBaru.Region = New Region(ellipsradius2)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        LblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & " yyyy/MM/dd ")
    End Sub

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_jual,3)) from penjualan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PJ" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Sub Buattabel()
        LVPenjualan.Columns.Add("Kode Barang", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Nama Barang", 180, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Harga Barang", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Qty", 120, HorizontalAlignment.Center)
        LVPenjualan.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)


        LVPenjualan.View = View.Details
        LVPenjualan.GridLines = True
        LVPenjualan.FullRowSelect = True
    End Sub

    Sub JumlahLVMenu()
        Dim jumMenu As Integer = 0
        Dim jumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVPenjualan.Items.Count - 1
            jumMenu = jumMenu + LVPenjualan.Items(baris).SubItems(3).Text
            total = total + (txtHarga.Text * txtJumlah.Text)
            jumHarga = jumHarga + LVPenjualan.Items(baris).SubItems(4).Text

        Next
        txtTotal.Text = jumHarga
        lblJumMenu.Text = jumMenu
    End Sub

    Sub Bersih()
        LVPenjualan.Items.Clear()
        lblJumMenu.Text = "0"
        txtTotal.Text = "0"
        txtBayar.Text = "0"
        txtKembali.Text = "0"
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim strMenu(4) As String

        strMenu(0) = txtKdBarang.Text
        strMenu(1) = txtNama.Text
        strMenu(2) = txtHarga.Text
        strMenu(3) = txtJumlah.Text
        strMenu(4) = txtHarga.Text * txtJumlah.Text

        LVPenjualan.Items.Add(New ListViewItem(strMenu))
        Call JumlahLVMenu()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        LVPenjualan.SelectedItems(0).Remove()
        Call JumlahLVMenu()
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(txtTotal.Text) Then
                MsgBox("Pembayaran Kurang")
                Exit Sub
            ElseIf Val(txtBayar.Text) = Val(txtTotal.Text) Then
                txtKembali.Text = 0
                btnSimpan.Focus()
            ElseIf Val(txtBayar.Text) > Val(txtTotal.Text) Then
                txtKembali.Text = Val(txtBayar.Text) - Val(txtTotal.Text)
                btnSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub btnCariBarang_Click(sender As Object, e As EventArgs) Handles btnCariBarang.Click
        FormCariBarang.Show()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim lsdetail As New List(Of ClsEntDetailPenjualan)()
        If LVPenjualan.Items.Count = 0 Then
            MsgBox("Masukkan Barang yang akan dipesan terlebih dahulu")
            Exit Sub
        End If
        With EntitasPenjualan
            .kode_operator = lblIDOperator.Text
            .tgl = Format(Now, " yyyy/MM/dd ")
            .total = txtTotal.Text
        End With

        For i = 0 To LVPenjualan.Items.Count - 1
            EntitasDetailPenjualan = New ClsEntDetailPenjualan
            With LVPenjualan.Items(i)
                EntitasDetailPenjualan.kode_barang = .SubItems(0).Text
                EntitasDetailPenjualan.harga_jual = .SubItems(2).Text
                EntitasDetailPenjualan.qty = .SubItems(3).Text
                EntitasDetailPenjualan.sub_total = .SubItems(4).Text
            End With
            lsdetail.Add(EntitasDetailPenjualan)
        Next i
        For I = 0 To lsdetail.Count - 1
            MsgBox(lsdetail(I).kode_barang & " " & lsdetail(I).harga_jual)
        Next
        Dim NONOTA As String
        NONOTA = KontrolPenjualan.SIMPAN_DATA(EntitasPenjualan, lsdetail).ToString
        If MsgBox("Apakah Anda yakin ingin mencetak nota? ",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            FormCetakNota.Show()
            FormCetakNota.NotaPenjualan1.RecordSelectionFormula = "{PENJUALAN.KODE_JUAL}='" & NONOTA & "'"
            FormCetakNota.NotaPenjualan1.Refresh()
        End If
        Bersih()
    End Sub
End Class