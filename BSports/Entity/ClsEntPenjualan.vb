Public Class ClsEntPenjualan
    Private kodejual As String
    Private kodeop As String
    Private tanggal As Date
    Private ttl As Integer


    Public Property kode_jual() As String
        Get
            Return kodejual
        End Get
        Set(value As String)
            kodejual = value
        End Set
    End Property

    Public Property kode_operator() As String
        Get
            Return kodeop
        End Get
        Set(value As String)
            kodeop = value
        End Set
    End Property

    Public Property tgl() As Date
        Get
            Return tanggal
        End Get
        Set(value As Date)
            tanggal = value
        End Set
    End Property

    Public Property total() As Integer
        Get
            Return ttl
        End Get
        Set(value As Integer)
            ttl = value
        End Set
    End Property
End Class
