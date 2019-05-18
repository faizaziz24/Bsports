Imports BSports
Imports System.Data.OleDb
Public Class ClsCtlTampilLaporan2 : Implements InfLaporan

    Public Function cariPeriode(tgl1 As Date, tgl2 As Date) As DataView Implements InfLaporan.cariPeriode
        Try
            DTA = New OleDbDataAdapter("Select * from pembelian where tanggal between '" & Format(tgl1, "yyyy/MM/dd hh\:mm\:ss") & "'and '" & Format(tgl2, "yyyy/MM/dd hh\:mm\:ss") & "'", BUKAKONEKSI)
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
            DTA = New OleDbDataAdapter("Select * from pembelian", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Pembelian")
            Dim grid As New DataView(DTS.Tables("Tabel_Pembelian"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
