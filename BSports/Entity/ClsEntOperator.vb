Public Class ClsEntOperator
    Private idop As String
    Private namaop As String
    Private username As String
    Private passwd As String
    Private levelop As String

    Public Property kode_operator() As String
        Get
            Return idop
        End Get
        Set(value As String)
            idop = value
        End Set
    End Property

    Public Property nama_operator() As String
        Get
            Return namaop
        End Get
        Set(value As String)
            namaop = value
        End Set
    End Property

    Public Property userid() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property pass() As String
        Get
            Return passwd
        End Get
        Set(value As String)
            passwd = value
        End Set
    End Property

    Public Property level_operator() As String
        Get
            Return levelop
        End Get
        Set(value As String)
            levelop = value
        End Set
    End Property
End Class
