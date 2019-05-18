Public Class ClsEntSupplier
    Private kodesup As String
    Private namasup As String
    Private almt As String
    Private telp As String
    Private eml As String

    Public Property kode_sup() As String
        Get
            Return kodesup
        End Get
        Set(value As String)
            kodesup = value
        End Set
    End Property

    Public Property nama_sup() As String
        Get
            Return namasup
        End Get
        Set(value As String)
            namasup = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return almt
        End Get
        Set(value As String)
            almt = value
        End Set
    End Property

    Public Property no_telp() As String
        Get
            Return telp
        End Get
        Set(value As String)
            telp = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return eml
        End Get
        Set(value As String)
            eml = value
        End Set
    End Property
End Class
