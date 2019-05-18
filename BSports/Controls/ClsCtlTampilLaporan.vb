Imports BSports
Imports System.Data.OleDb
Public Class ClsCtlTampilLaporan : Implements InfLaporan

    Public Function cariPeriode(tgl1 As Date, tgl2 As Date) As DataView Implements InfLaporan.cariPeriode
        Try
            DTA = New OleDbDataAdapter("Select * from penjualan where tgl between '" & Format(tgl1, "yyyy/MM/dd hh\:mm\:ss") & "'and '" & Format(tgl2, "yyyy/MM/dd hh\:mm\:ss") & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Periode")
            Dim grid As New DataView(DTS.Tables("Cari_Periode"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfLaporan.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from penjualan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Penjualan")
            Dim grid As New DataView(DTS.Tables("Tabel_Penjualan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
