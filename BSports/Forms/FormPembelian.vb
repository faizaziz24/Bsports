Imports System.Data.OleDb
Public Class FormPembelian
    Dim baris As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Timer1.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        lblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & " yyyy/MM/dd ")
    End Sub
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_beli,3)) from pembelian", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PB" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Sub Buattabel()
        LVPembelian.Columns.Add("Kode Barang", 120, HorizontalAlignment.Center)
        LVPembelian.Columns.Add("Nama Barang", 180, HorizontalAlignment.Center)
        LVPembelian.Columns.Add("Harga Barang", 120, HorizontalAlignment.Center)
        LVPembelian.Columns.Add("Qty", 120, HorizontalAlignment.Center)
        LVPembelian.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)


        LVPembelian.View = View.Details
        LVPembelian.GridLines = True
        LVPembelian.FullRowSelect = True
    End Sub

    Sub JumlahLVBahan()
        Dim jumBahan As Integer = 0
        Dim jumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVPembelian.Items.Count - 1
            jumBahan = jumBahan + LVPembelian.Items(baris).SubItems(3).Text
            total = total + (txtHarga.Text * txtQty.Text)
            jumHarga = jumHarga + LVPembelian.Items(baris).SubItems(4).Text

        Next
        txtTotal.Text = jumHarga
        lblJumBahan.Text = jumBahan
    End Sub

    Sub Bersih()
        LVPembelian.Items.Clear()
        lblJumBahan.Text = "0"
        txtTotal.Text = "0"
    End Sub
    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buattabel()
        Call Bersih()

        txtTotal.Enabled = False


        lblKodeBeli.Text = kodeBaru()
        lblOperator.Text = KODELOG
        Call TampilSupplier()

        MdiParent = HalamanPemilik


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

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim strMenu(4) As String

        strMenu(0) = txtKode.Text
        strMenu(1) = txtNama.Text
        strMenu(2) = txtHarga.Text
        strMenu(3) = txtQty.Text
        strMenu(4) = txtHarga.Text * txtQty.Text

        LVPembelian.Items.Add(New ListViewItem(strMenu))
        Call JumlahLVBahan()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        LVPembelian.SelectedItems(0).Remove()
        Call JumlahLVBahan()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim lsdetail As New List(Of ClsEntDetailPembelian)()
        If LVPembelian.Items.Count = 0 Then
            MsgBox("Masukkan Bahan yang akan dipesan terlebih dahulu")
            Exit Sub
        End If
        With EntitasPembelian
            .kode_beli = lblKodeBeli.Text
            .kode_operator = lblOperator.Text
            .kode_sup = cmbSupplier.Text
            .tanggal = Format(Now, " yyyy/MM/dd ")

        End With

        For i = 0 To LVPembelian.Items.Count - 1

            EntitasDetailPembelian = New ClsEntDetailPembelian
            With LVPembelian.Items(i)
                EntitasDetailPembelian.kode_beli = lblKodeBeli.Text
                EntitasDetailPembelian.kode_barang = .SubItems(0).Text
                EntitasDetailPembelian.qty = .SubItems(3).Text
                EntitasDetailPembelian.harga_beli = .SubItems(2).Text
            End With
            lsdetail.Add(EntitasDetailPembelian)
        Next i
        For I = 0 To lsdetail.Count - 1
        Next
        KontrolPembelian.SIMPAN_DATA(EntitasPembelian, lsdetail)
        Bersih()
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        CMD = New OleDbCommand("select * from supplier where kode_sup='" & cmbSupplier.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtNamaSup.Text = DTR.Item("nama_sup")
        Else
            MsgBox("Kode Supplier tidak terdaftar")
        End If
    End Sub

    Sub TampilSupplier()
        CMD = New OleDbCommand("select kode_sup from supplier", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cmbSupplier.Items.Clear()
        Do While DTR.Read
            cmbSupplier.Items.Add(DTR.Item("kode_sup"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub btnBahan_Click(sender As Object, e As EventArgs) Handles btnBahan.Click
        FormBeliBarang.Show()
    End Sub
End Class