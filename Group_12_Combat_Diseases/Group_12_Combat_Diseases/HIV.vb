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

<Serializable()> Public Class HIV
    Inherits Disease
    Private details() As detailshiv

    Public Sub New(months As Integer) 'constructor
        MyBase.New(months)
        ReDim details(months)
    End Sub
    Public Property gdet(i As Integer) As detailshiv 'get/set detsails at a index
        Get
            Return details(i)
        End Get
        Set(value As detailshiv)
            details(i) = value
        End Set
    End Property
    Private Function ad(i As Integer, z As Integer) As Integer 'adds total infected
        Dim ttl As Integer = 0
        Select Case i
            Case 0
                For x As Integer = 1 To _months
                    ttl += details(x).gnfm(1) + details(x).gnfm(2)
                Next
                Return ttl
            Case 1
                For x As Integer = 1 To _months
                    ttl += details(x).gchildren
                Next
                Return ttl
            Case 2
                For x As Integer = 1 To _months
                    ttl += details(x).gnfm(z)
                Next
                Return ttl
            Case 3
                For x As Integer = 1 To _months
                    ttl += details(x).gpreg
                Next
                Return ttl
            Case 4
                For x As Integer = 1 To _months
                    ttl += details(x).gnatvi
                Next
                Return ttl
        End Select
        Return 0
    End Function


    Public Sub settotal() 'set number of ppl infected in that year
        For i As Integer = 1 To _months
            Cases(i) = details(i).gnfm(1) + details(i).gnfm(2) + details(i).gpreg + details(i).gchildren
        Next i
    End Sub


    Public Function progress() As String 'trend here if it decreased becasue of anti viral therapy or other,if anti increased
        Dim isdec As Boolean = True
        Dim cont As Integer = 1
        While isdec = True And cont < details.Length - 1 'checks if  cases decrease as a result of increase in antiviral therapy
            If details(cont).gnatvi < details(cont + 1).gnatvi And Cases(cont) > Cases(cont + 1) Then
                'comapres if cases decreased
                cont += 1


            Else
                isdec = False
            End If

        End While

        If isdec = True Then
            Return "Infections decreased and use of anti viral therapy increased 2030 goal acievable"
        Else
            Return " Awareness of HIV and anti viral therapy needs to increase to reduce Hiv Infection,more effort required"

        End If

    End Function

    Public Overrides Function Display() As String 'displays the disease information
        settotal() 'calculates cases and totals
        Dim output As String
        output = MyBase.Display() + vbCrLf + "Children infected " + CStr(ad(1, 0)) + vbCrLf + "Total adults infected " + CStr(ad(0, 0)) + vbCrLf
        output += "Total Males infected " + CStr(ad(2, 1)) + "Total Females infected " + CStr(ad(2, 2)) + vbCrLf + "Pregnant woman infected " + CStr(ad(3, 3)) + vbCrLf
        output += "Infected and using avt " + CStr(ad(4, 5)) + vbCrLf
        output += "Goal status/recomendation regarding HIV " + progress()
        Return output
    End Function
End Class
