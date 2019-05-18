Imports System.Data.OleDb
Imports BSports

Public Class ClsCtlJenisBarang : Implements InfProses

    'JN001'
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_jenis,3)) from jenis_barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "JN" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from jenis_barang where nama_jenis " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Cari_Jenis")
            Dim grid As New DataView(DTS.Tables("Cari_Jenis"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from jenis_barang " & "where kode_jenis='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntJenisBarang
        data = Ob
        CMD = New OleDbCommand("insert into jenis_barang values('" & data.kode_jenis & "','" & data.nama_jenis & "')", BUKAKONEKSI)


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from jenis_barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Jenis")
            Dim grid As New DataView(DTS.Tables("Tabel_Jenis"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntJenisBarang
        data = Ob
        CMD = New OleDbCommand("update jenis_barang set nama_jenis='" & data.nama_jenis & "' where kode_jenis='" & data.kode_jenis & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Function cekJenisDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(kode_jenis) from barang " _
                                           & "where kode_jenis='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class

