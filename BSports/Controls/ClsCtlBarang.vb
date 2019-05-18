Imports System.Data.OleDb
Imports BSports

Public Class ClsCtlBarang : Implements InfProses

    Dim SQL As String

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from barang where nama_barang " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Cari_Barang")
            Dim grid As New DataView(DTS.Tables("Cari_Barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from barang " & "where kode_barang='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntBarang
        data = Ob
        CMD = New OleDbCommand("insert into barang values('" & data.kode_barang & "','" & data.kode_jenis & "','" _
                               & data.nama_barang & "'," & data.harga & ", " & data.stok & ")", BUKAKONEKSI)

        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_barang,3)) from barang", BUKAKONEKSI) '
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "BR" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Barang")
            Dim grid As New DataView(DTS.Tables("Tabel_Barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Function cekBarangDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(kode_barang) from detail_penjualan " _
                                           & "where kode_barang='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function


    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntBarang
        data = Ob
        CMD = New OleDbCommand("update barang set kode_jenis='" _
                               & data.kode_jenis & "',nama_barang='" & data.nama_barang _
                               & "',harga =" & data.harga _
                               & ", stok = " & data.stok _
                               & " where kode_barang='" & data.kode_barang & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class
