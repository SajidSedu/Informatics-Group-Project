'*****************************************************************
' Team Number: 12
' Team Member 1 Details: Sedu, MSAS (220042255)
' Team Member 2 Details: Pathan, MP (220012601)
' Team Member 3 Details: Shabir, SK (220071049)
' Team Member 4 Details: Chopdat,MYC(219063106)
' Practical: Team Project
' Class name: Malaria
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class detailshiv
    Private nchildren As Integer 'number of children infected
    Private npreg As Integer 'pregnant woman infected with aids
    Private nfm(2) As Integer 'males and non pregnant females infected
    Private natvi As Integer 'infected and using anti viral therapy
    Public Sub New(males As Integer, females As Integer, preg As Integer, children As Integer)
        nfm(1) = males
        nfm(2) = females
        npreg = preg 'numbwer of pregnant woman with aids
        nchildren = children 'number of children with aids
    End Sub
    Public Property gnatvi As Integer 'get set number antiretroviral therapy (ART) 
        Get
            Return natvi
        End Get
        Set(value As Integer)
            natvi = value
        End Set
    End Property

    Public ReadOnly Property gchildren As Integer 'get children
        Get
            Return nchildren
        End Get
    End Property

    Public ReadOnly Property gpreg As Integer 'get pregnant
        Get
            Return npreg
        End Get
    End Property



    Public ReadOnly Property gnfm(i As Integer) As Integer 'get number of femalrs or male
        Get
            Return nfm(i)
        End Get
    End Property

End Class
