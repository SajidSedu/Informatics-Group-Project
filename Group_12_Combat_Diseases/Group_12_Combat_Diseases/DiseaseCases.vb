'*****************************************************************
' Team Number: 12
' Team Member 1 Details: Sedu, MSAS (220042255)
' Team Member 2 Details: Pathan, MP (220012601)
' Team Member 3 Details: Shabir, SK (220071049)
' Team Member 4 Details: Chopdat,MYC(219063106)
' Practical: Team Project
' Class name: Disease
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Interface DiseaseCases
    'Gives the Threat Level in that particular region
    Function ThreatLevel() As String
    'Gives the Symptoms of the Disease
    Function Symptoms() As String
End Interface
