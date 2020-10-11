'*****************************************************************
' Team Number: 12
' Team Member 1 Details: Sedu, MSAS (220042255)
' Team Member 2 Details: Pathan, MP (220012601)
' Team Member 3 Details: Shabir, SK (220071049)
' Team Member 4 Details: Chopdat,MYC(219063106)
' Practical: Team Project
' Class name: frmCD
' *****************************************************************

Option Strict On
Option Infer Off
Option Explicit On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmCD
    'Object Array
    Private Disease() As Disease
    'File
    Private fls As FileStream
    Private bnf As BinaryFormatter

    Enum EDisease
        HIV
        Malaria
        TB
    End Enum
    Private Sub frmCD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim Disease(3)
    End Sub

    'TB
    'Details
    Private Sub BtnTBDetails_Click(sender As Object, e As EventArgs) Handles BtnTBDetails.Click
        Dim tb As TB
        Dim months As Integer = CInt(InputBox("How many months is the disease being monitored for?", "Months"))
        Dim medMonths As Integer = CInt(InputBox("How many many months has the medication been prescribed for?", "Medication"))
        tb = New TB(months, medMonths)
        For i As Integer = 1 To months
            tb.Cases(i) = CInt(InputBox("How many cases were recorded in the month " & CStr(i), "Cases?"))
        Next i
        tb.Deaths = CInt(InputBox("how many people died of TB?", "Deaths?"))
        Disease(EDisease.TB) = tb
    End Sub
    'File
    Private Sub BtnTBFile_Click(sender As Object, e As EventArgs) Handles BtnTBFile.Click
        fls = New FileStream("TBFile.ifm", FileMode.Create, FileAccess.Write)
        bnf = New BinaryFormatter
        bnf.Serialize(fls, Disease(EDisease.TB))
        TxtTBDisplay.Text = "File Has Been Saved Successfully!"
        fls.Close()
        bnf = Nothing
        fls = Nothing
    End Sub
    'Display
    Private Sub BtnTBDisplay_Click(sender As Object, e As EventArgs) Handles BtnTBDisplay.Click
        fls = New FileStream("TBFile.ifm", FileMode.Open, FileAccess.Read)
        bnf = New BinaryFormatter
        Dim tbTemp As TB
        tbTemp = DirectCast(bnf.Deserialize(fls), TB)
        TxtTBDisplay.Text = tbTemp.Display()
        fls.Close()
        bnf = Nothing
        fls = Nothing
    End Sub

    'Malaria
    'Details
    Private Sub BtnMDetails_Click(sender As Object, e As EventArgs) Handles BtnMDetails.Click
        Dim Malaria As Malaria
        Dim Months, Mosquito, Nets As Integer
        Dim Area, Water As Double
        'Get Values
        Months = CInt(InputBox("How many Months?"))
        Mosquito = CInt(InputBox("How many Mosquitos per Square KM (Integer)?"))
        Nets = CInt(InputBox("How many Nets in Houses per Square KM (Integer)?"))
        Area = CDbl(InputBox("What is the Area of the Location?"))
        Water = CDbl(InputBox("What is the Estimated Water Levels in the Location ?"))
        'Instantiate
        Malaria = New Malaria(Months, Mosquito, Area, Water, Nets)
        'Get Number of Cases
        Dim a As Integer
        For a = 1 To Months
            Malaria.Cases(a) = CInt(InputBox("How many Cases occured in Month " & a & "?"))
        Next a
        Malaria.Deaths = CInt(InputBox("How many People have died due to Malaria?"))
        Disease(EDisease.Malaria) = Malaria
    End Sub
    'File
    Private Sub BtnMFile_Click(sender As Object, e As EventArgs) Handles BtnMFile.Click
        fls = New FileStream("Malaria.ifm", FileMode.Create, FileAccess.Write)
        bnf = New BinaryFormatter
        bnf.Serialize(fls, Disease(EDisease.Malaria))
        TxtMDisplay.Text = "File Has Been Saved Successfully!"
        fls.Close()
        bnf = Nothing
        fls = Nothing
    End Sub
    'Display 
    Private Sub BtnMDisplay_Click(sender As Object, e As EventArgs) Handles BtnMDisplay.Click
        fls = New FileStream("Malaria.ifm", FileMode.Open, FileAccess.Read)
        bnf = New BinaryFormatter
        Dim MTemp As Malaria
        MTemp = DirectCast(bnf.Deserialize(fls), Malaria)
        TxtMDisplay.Text = MTemp.Display()
        fls.Close()
    End Sub

    'HIV 
    'Details
    Private Sub BtnHIVDetails_Click(sender As Object, e As EventArgs) Handles BtnHIVDetails.Click
        Dim haid As HIV 'temporary object
        Dim tp As Integer = CInt(InputBox("Please enter number of months HIV is been reviewed for", "HIV"))

        haid = New HIV(tp)
        For i As Integer = 1 To tp 'information per year/month

            Dim males As Integer = CInt(InputBox("Please enter number of males infected for Month " & i & "?", "HIV " + "MONTH " + CStr(i)))
            Dim females As Integer = CInt(InputBox("Please enter number of non-pregnant females infected for Month " & i & "?", "HIV " + "MONTH " + CStr(i)))
            Dim preg As Integer = CInt(InputBox("Please enter number of pregnant woman  infected for Month " & i & "?", "HIV " + "MONTH " + CStr(i)))
            Dim children As Integer = CInt(InputBox("Please enter number of children infected for Month " & i & "?", "HIV " + "MONTH " + CStr(i)))

            Dim art As Integer = CInt(InputBox("Enter number of people infected and are on antiretroviral therapy (ART) for Month " & i & "?", "HIV " + "MONTH " + CStr(i)))

            haid.gdet(i) = New detailshiv(males, females, preg, children)
            haid.gdet(i).gnatvi = art 'number of ppl using antiretroviral therapy (ART) 
        Next
        haid.Deaths = CInt(InputBox("enter total number of people who died of this disease", "HIV")) 'set total number of death
        Disease(EDisease.HIV) = haid 'upcasting
    End Sub
    'File
    Private Sub BtnHIVFile_Click_1(sender As Object, e As EventArgs) Handles BtnHIVFile.Click
        fls = New FileStream("HIV.ifm", FileMode.Create, FileAccess.Write)
        bnf = New BinaryFormatter
        bnf.Serialize(fls, Disease(EDisease.HIV))
        TxtHIVDisplay.Text = "File Has Been uploaded Successfully!"
        fls.Close()
        bnf = Nothing
        fls = Nothing
    End Sub
    'Display
    Private Sub BtnHIVDisplay_Click(sender As Object, e As EventArgs) Handles BtnHIVDisplay.Click
        fls = New FileStream("HIV.ifm", FileMode.Open, FileAccess.Read)
        bnf = New BinaryFormatter
        Dim HIVTemp As HIV
        HIVTemp = DirectCast(bnf.Deserialize(fls), HIV)
        TxtHIVDisplay.Text = HIVTemp.Display()
        fls.Close()
    End Sub
End Class
