Imports System.Data.OleDb
Public Class FormBarang
    Dim modeProses As Integer
    Dim baris As Integer

    'untuk mengatur pengaktifan button'
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        'Gr.Enabled = st
    End Sub
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        txtKodeBarang.Enabled = False
        MdiParent = HalamanAdmin
        Call TampilJenis()
    End Sub

    'untuk pengisian pada datagrid sehingga data yang diinputkan dari textbox maupun combobox
    'akan menempatkan pada cell2 yang sesuai' 
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                txtKodeBarang.Text = .Cells(0).Value.ToString
                CbKodeJenis.Text = .Cells(1).Value.ToString
                txtNamaBarang.Text = .Cells(2).Value.ToString
                txtHarga.Text = .Cells(3).Value.ToString
                txtBanyak.Text = .Cells(4).Value.ToString
            End With

        End If
    End Sub

    'untuk menampilkan data didata grid barang'
    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    'untuk mencari data barang'
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    'event ketika button tambah diklik maka dia akan menuju modeproses =1 (insert data)'
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1

        txtKodeBarang.Text = ""
        CbKodeJenis.Text = ""
        txtJenisBarang.Text = ""
        txtNamaBarang.Text = ""
        txtHarga.Text = ""
        txtBanyak.Text = ""

        txtKodeBarang.Text = KontrolBarang.kodeBaru() 'memanggil function kode barang agar otomatis'
    End Sub

    'event ketika button ubah diklik maka dia akan menuju modeproses =2 (update data)'
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        CbKodeJenis.Focus()
        modeProses = 2 '
    End Sub

    'event ketika button batal di klik'
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    'event ketika datagrid diklik cellnya'
    Private Sub DGBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGBarang.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    'event ketika button simpan diklik'
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasBarang
            .kode_barang = txtKodeBarang.Text
            .kode_jenis = CbKodeJenis.Text
            .nama_barang = txtNamaBarang.Text
            .harga = txtHarga.Text
            .stok = txtBanyak.Text
        End With

        If modeProses = 1 Then
            KontrolBarang.InsertData(EntitasBarang)
        ElseIf modeProses = 2 Then
            KontrolBarang.updateData(EntitasBarang)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    'event ketika btn hapus di klik'
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolBarang.cekBarangDireferensi(txtKodeBarang.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKodeBarang.Text & "-" & txtNamaBarang.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolBarang.deleteData(txtKodeBarang.Text)
        End If
        RefreshGrid()
    End Sub

    'event ketika button cari diklik'
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    'untuk menampilkan kode jenis yang tersimpan didatabase jenis_barang pada combo box'
    Sub TampilJenis()
        CMD = New OleDbCommand("select kode_jenis from jenis_barang", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        CbKodeJenis.Items.Clear()
        Do While DTR.Read
            CbKodeJenis.Items.Add(DTR.Item("kode_jenis"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    'untuk menampilkan kode jenis yang mana saat diklik salah satu kode akan tertampil pada textbox nama jenis'
    Private Sub CbKodeJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbKodeJenis.SelectedIndexChanged
        CMD = New OleDbCommand("select * from jenis_barang where kode_jenis='" & CbKodeJenis.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtJenisBarang.Text = DTR.Item("nama_jenis")
        Else
            MsgBox("Kode Jenis tidak terdaftar")
        End If
    End Sub
End Class