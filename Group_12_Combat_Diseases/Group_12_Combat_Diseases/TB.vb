'*****************************************************************
' Team Number: 12
' Team Member 1 Details: Sedu, MSAS (220042255)
' Team Member 2 Details: Pathan, MP (220012601)
' Team Member 3 Details: Shabir, SK (220071049)
' Team Member 4 Details: Chopdat,MYC(219063106)
' Practical: Team Project
' Class name: TB
' *****************************************************************

Option Strict On
Option Infer Off
Option Explicit On

<Serializable()> Public Class TB
    Inherits Disease

    Private _medMonths As Integer ' number of months the medication needs to be taken

    Public Sub New(months As Integer, medMonths As Integer)
        MyBase.New(months)
        _medMonths = enforceRange(medMonths)
    End Sub

    Public Function TBType() As String 'type of TB
        Select Case _medMonths
            Case 0 To 6
                Return "Normal TB"
            Case 7 To 9
                Return "Drug resistant TB"
            Case 10 To 11
                Return "Multi-Drug resistant TB"
            Case Else
                Return "Extreme drug resistant TB"
        End Select
    End Function

    Public Overrides Function Display() As String 'pylymorphism
        Return MyBase.Display() + "TB type: " & TBType()
    End Function


End Class
