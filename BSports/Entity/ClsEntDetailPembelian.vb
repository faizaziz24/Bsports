Public Class ClsEntDetailPembelian
    Private kdbeli As String
    Private kdbarang As String
    Private qt As Integer
    Private hrgbeli As Integer
    Private subtot As Integer


    Public Property kode_beli() As String
        Get
            Return kdbeli
        End Get
        Set(value As String)
            kdbeli = value
        End Set
    End Property

    Public Property kode_barang() As String
        Get
            Return kdbarang
        End Get
        Set(value As String)
            kdbarang = value
        End Set
    End Property


    Public Property qty() As Integer
        Get
            Return qt
        End Get
        Set(value As Integer)
            qt = value
        End Set
    End Property

    Public Property harga_beli() As Integer
        Get
            Return hrgbeli
        End Get
        Set(value As Integer)
            hrgbeli = value
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
