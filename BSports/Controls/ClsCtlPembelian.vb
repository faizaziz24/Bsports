Imports System.Data.OleDb

Public Class ClsCtlPembelian
    Private SQL As String
    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPembelian, ByVal _item As List(Of ClsEntDetailPembelian)) As OleDbCommand
        Dim IDB As String
        IDB = ""
        TUTUPKONEKSI()
        With _pbl
            SQL = "SP_INSERTPEMBELIAN '" & .kode_operator & "','" & .kode_sup & "','" & Format(.tanggal, "yyyy/MM/dd") & "'"

            MsgBox(Sql)
            Try
                DTA = New OleDbDataAdapter(Sql, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_KODE_BELI")
                IDB = DTS.Tables("TABEL_KODE_BELI").Rows(0)(0).ToString
                ' MsgBox(IDP)'
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End With
        TUTUPKONEKSI()
        For i = 0 To _item.Count - 1
            With _item(i)
                SQL = "insert into DETAIL_PEMBELIAN values ('" _
                    & IDB & "','" & .kode_barang _
                    & "'," & .qty & "," & .harga_beli & "," & .sub_total & ")"

                CMD = New OleDbCommand(Sql, BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", TUTUPKONEKSI)
                MsgBox(Sql)
            End With
        Next
        Return CMD
    End Function

End Class
