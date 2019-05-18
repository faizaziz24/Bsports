Imports System.Data.OleDb
Public Class FormJenisBarang
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st

        'Gr.Enabled = st
    End Sub
    Private Sub FormJenisBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        txtKodeJenis.Enabled = False
        MdiParent = HalamanAdmin
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGJenis.Rows(br)

                txtKodeJenis.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
            End With
            ' LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGKasir.RowCount - 1 & " data "
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolJenisBarang.tampilData.ToTable
        DGJenis.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGJenis.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGJenis.CurrentCell = DGJenis.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolJenisBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGJenis.DataSource = DTGrid
            DGJenis.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGJenis.CurrentCell = DGJenis.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1

        txtKodeJenis.Text = ""
        txtNama.Text = ""


        txtKodeJenis.Text = KontrolJenisBarang.kodeBaru()

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasJenisBarang
            .kode_jenis = txtKodeJenis.Text
            .nama_jenis = txtNama.Text

        End With

        If modeProses = 1 Then
            KontrolJenisBarang.InsertData(EntitasJenisBarang)
        ElseIf modeProses = 2 Then
            KontrolJenisBarang.updateData(EntitasJenisBarang)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolJenisBarang.cekJenisDireferensi(txtKodeJenis.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKodeJenis.Text & "-" & txtNama.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolJenisBarang.deleteData(txtKodeJenis.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub
End Class