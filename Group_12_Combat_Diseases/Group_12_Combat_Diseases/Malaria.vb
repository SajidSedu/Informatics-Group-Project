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
Option Infer Off
Option Explicit On

<Serializable()> Public Class Malaria
    'Inherits Base Class Disease
    Inherits Disease
    'Implements the Interface
    Implements DiseaseCases

    'Variables
    Private _Nets As Integer
    Private _Mosquito As Integer
    Private _Area As Double
    Private _KlWater As Double

    'Constructor
    Public Sub New(Months As Integer, Mosquito As Integer, Area As Double, Water As Double, Nets As Integer)
        MyBase.New(Months)
        _Mosquito = enforceRange(Mosquito)
        _Area = enforceRange(Area)
        _KlWater = enforceRange(Water)
        _Nets = enforceRange(Nets)
    End Sub

    'Method
    'Details - Gives threat Level
    Public Function ThreatLevel() As String Implements DiseaseCases.ThreatLevel
        Dim Level As String
        If _Mosquito * _KlWater > _Area * 10000 Or _Area / _Nets < 2.5 Then
            Level = "Extreme Level Threat!"
        ElseIf _Mosquito * _KlWater > _Area * 1000 Or _Area / _Nets < 3.5 Then
            Level = "High Level Threat!"
        ElseIf _Mosquito * _KlWater > _Area * 100 Or _Area / _Nets < 4.5 Then
            Level = "Medium Level Threat!"
        Else
            Level = "Low Level Threat!"
        End If
        Return Level
    End Function
    'Symptoms Of Malaria
    Public Function Symptoms() As String Implements DiseaseCases.Symptoms
        Return "Symptoms of Malaria: " + Environment.NewLine + "-> Fever and Fatigue." _
                                       + Environment.NewLine + "-> Nausea and vomiting." _
                                       + Environment.NewLine + "-> Headache and Muscle Pain." _
                                       + Environment.NewLine + "-> Chills, Shivering and Sweating."
    End Function

	'polymorphism
    Public Overrides Function Display() As String'display the disease information and the added information about malaria 
        Dim output As String
        output = "Threat level: " & CStr(ThreatLevel()) & vbCrLf
        output += Environment.NewLine + Symptoms() & vbCrLf
        Return MyBase.Display() & output
    End Function
End Class
