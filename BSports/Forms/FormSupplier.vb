Imports System.Data.OleDb
Public Class FormSupplier
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
    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        txtkode_sup.Enabled = False
        MdiParent = HalamanAdmin
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolSupplier.tampilData.ToTable
        DGSupplier.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSupplier.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSupplier.CurrentCell = DGSupplier.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGSupplier.Rows(br)
                txtKode_sup.Text = .Cells(0).Value.ToString
                txtNama_sup.Text = .Cells(1).Value.ToString
                txtAlamat.Text = .Cells(2).Value.ToString
                txtTelp.Text = .Cells(3).Value.ToString
                txtEmail.Text = .Cells(4).Value.ToString


            End With
            ' LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGMenu.RowCount - 1 & " data "
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1

        txtKode_Sup.Text = ""
        txtNama_Sup.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        txtEmail.Text = ""


        txtKode_Sup.Text = KontrolSupplier.kodeBaru()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNama_Sup.Focus()
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasSupplier
            .kode_sup = txtKode_Sup.Text
            .nama_sup = txtNama_Sup.Text
            .alamat = txtAlamat.Text
            .no_telp = txtTelp.Text
            .email = txtEmail.Text
        End With

        If modeProses = 1 Then
            KontrolSupplier.InsertData(EntitasSupplier)
        ElseIf modeProses = 2 Then
            KontrolSupplier.updateData(EntitasSupplier)
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
        status_referensi = KontrolSupplier.cekSupplierDireferensi(txtKode_Sup.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKode_Sup.Text & "-" & txtNama_Sup.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolSupplier.deleteData(txtKode_Sup.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolSupplier.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSupplier.DataSource = DTGrid
            DGSupplier.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSupplier.CurrentCell = DGSupplier.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Private Sub DGSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGSupplier.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
End Class