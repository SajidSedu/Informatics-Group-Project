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

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmCD
    Private disease() As Disease
    Private fls As FileStream
    Private bnf As BinaryFormatter
    Private Const FILENAME As String = "tb.ifm"

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

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        fls = New FileStream(FILENAME, FileMode.Create, FileAccess.Write)
        bnf = New BinaryFormatter
        bnf.Serialize(fls, disease(3))
        fls.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        fls = New FileStream(FILENAME, FileMode.Open, FileAccess.Read)
        bnf = New BinaryFormatter
        Dim tbTemp As TB
        tbTemp = DirectCast(bnf.Deserialize(fls), TB)
        txtDisplay.Text = tbTemp.Display()
    End Sub


End Class
