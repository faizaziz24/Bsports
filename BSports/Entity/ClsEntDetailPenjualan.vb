Public Class ClsEntDetailPenjualan
    Private kdjual As String
    Private kdbrg As String
    Private jum As Integer
    Private harga As Integer
    Private subtot As Integer

    Public Property kode_jual() As String
        Get
            Return kdjual
        End Get
        Set(value As String)
            kdjual = value
        End Set
    End Property
    Public Property kode_barang() As String
        Get
            Return kdbrg
        End Get
        Set(value As String)
            kdbrg = value
        End Set
    End Property

    Public Property harga_jual() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property qty() As Integer
        Get
            Return jum
        End Get
        Set(value As Integer)
            jum = value
        End Set
    End Property

    Public Property sub_total() As Integer
        Get
            Return subtot
        End Get
        Set(value As Integer)
            subtot = value
        End Set
    End Property
End Class
