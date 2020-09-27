'*****************************************************************
' Team Number: 12
' Team Member 1 Details: Sedu, MSAS (220042255)
' Team Member 2 Details: Pathan, MP (220012601)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: frmCD
' *****************************************************************

Option Strict On
Option Infer Off
Option Explicit On

Public Class frmCD
    Private disease() As Disease

    Private Sub frmCD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim disease(3)
    End Sub

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        Dim tb As TB
        Dim months As Integer = CInt(InputBox("How many months is the disease being monitored for?", "Months"))
        Dim medMonths As Integer = CInt(InputBox("How many many months has the mediacation been prescribed for?", "Medication"))
        tb = New TB(months, medMonths)
        For i As Integer = 1 To months
            tb.Cases(i) = CInt(InputBox("How many cases were recorded in the month " & CStr(i), "Cases?"))
        Next i
        tb.Deaths = CInt(InputBox("how many people died of TB?", "Deaths?"))
        disease(3) = tb
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtDisplay.Text = disease(3).Display()
    End Sub

End Class
