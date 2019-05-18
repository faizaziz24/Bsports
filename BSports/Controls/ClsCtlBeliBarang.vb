Imports System.Data.OleDb
Imports BSports

Public Class ClsCtlBeliBarang : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("SELECT B.KODE_BARANG, B.NAMA_BARANG, B.QTY, DP.HARGA_BELI FROM BARANG B JOIN DETAIL_PEMBELIAN DP ON B.KODE_BARANG = DP.KODE_BARANG WHERE B.KODE_BARANG " & "LIKE '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Barang")
            Dim grid As New DataView(DTS.Tables("Cari_Barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function
End Class
