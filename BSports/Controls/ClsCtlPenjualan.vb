Imports System.Data.OleDb
Public Class ClsCtlPenjualan
    Dim SQL As String

    Function kodeBaru() As String
        Dim kodeakhir As Integer
        Dim baru As String
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_jual,3)) from penjualan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PJ" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPenjualan, ByVal _item As List(Of ClsEntDetailPenjualan)) As String
        Dim KDJ As String
        KDJ = ""
        TUTUPKONEKSI()
        With _pbl
            SQL = "SP_INSERTPENJUALAN '" & .kode_operator & "','" & Format(.tgl, "yyyy/MM/dd") & "'," & .total
            'MsgBox(SQL)
            Try
                DTA = New OleDbDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_KODE_JUAL")
                KDJ = DTS.Tables("TABEL_KODE_JUAL").Rows(0)(0).ToString
                ' MsgBox(IDP)'
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End With
        TUTUPKONEKSI()
        For i = 0 To _item.Count - 1
            With _item(i)
                SQL = "insert into Detail_Penjualan values ('" _
                    & KDJ & "','" & .kode_barang _
                    & "'," & .harga_jual & "," & .qty & "," & .sub_total & ")"

                CMD = New OleDbCommand(SQL, BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", TUTUPKONEKSI)
                MsgBox(SQL)
            End With
        Next
        Return KDJ
    End Function
End Class
