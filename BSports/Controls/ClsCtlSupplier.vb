Imports System.Data.OleDb
Imports BSports

Public Class ClsCtlSupplier : Implements InfProses
    's0001'
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_sup,4)) from supplier ", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "S" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntSupplier
        data = Ob
        CMD = New OleDbCommand("insert into Supplier values('" & data.kode_sup & "','" & data.nama_sup & "','" _
                               & data.alamat & "','" & data.no_telp & "','" & data.email & "')", BUKAKONEKSI)


        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntSupplier
        data = Ob
        CMD = New OleDbCommand("update supplier set nama_sup='" & data.nama_sup _
                               & "',alamat='" & data.alamat _
                               & "', no_telp='" & data.no_telp & "',email='" & data.email _
                               & "' where kode_sup='" & data.kode_sup & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from supplier " & "where kode_sup='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from supplier", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Supplier")
            Dim grid As New DataView(DTS.Tables("Tabel_Supplier"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from supplier where nama_sup " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Cari_Supplier")
            Dim grid As New DataView(DTS.Tables("Cari_Supplier"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekSupplierDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(kode_sup) from pembelian " _
                                       & "where kode_sup='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class
