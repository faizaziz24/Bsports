Public Class ClsEntJenisBarang
    Private kodejenis As String
    Private namajen As String


    Public Property kode_jenis() As String
        Get
            Return kodejenis
        End Get
        Set(value As String)
            kodejenis = value
        End Set
    End Property

    Public Property nama_jenis() As String
        Get
            Return namajen
        End Get
        Set(value As String)
            namajen = value
        End Set
    End Property

End Class
