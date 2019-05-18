Public Class ClsEntDetailBarang
    Private kodebrg As String
    Private kodejns As String
    Private ukur As String

    Public Property kode_barang() As String
        Get
            Return kodebrg
        End Get
        Set(value As String)
            kodebrg = value
        End Set
    End Property

    Public Property kode_jenis() As String
        Get
            Return kodejns
        End Get
        Set(value As String)
            kodejns = value
        End Set
    End Property

    Public Property ukuran() As String
        Get
            Return ukur
        End Get
        Set(value As String)
            ukur = value
        End Set
    End Property

End Class
