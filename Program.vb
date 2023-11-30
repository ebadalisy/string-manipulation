Imports System

Module smq1
    Sub Main()
        Dim FirstName As String
        Dim SecondName As String
        Dim String1 As String
        Dim String2 As String
        Dim SpacePos1 As Integer
        Dim SpacePos2 As Integer

        FirstName = ""
        SecondName = ""
        String1 = ""
        String2 = ""
        SpacePos1 = 0
        SpacePos2 = 0

        Console.Write("Enter first full name: ")
        FirstName = Console.ReadLine
        Console.Write("Enter second full name: ")
        SecondName = Console.ReadLine

        SpacePos1 = InStr(FirstName, " ")
        String1 = Left(FirstName, SpacePos1)

        SpacePos2 = InStr(SecondName, " ")
        String2 = Right(SecondName, Len(SecondName) - SpacePos2)

        Console.WriteLine("Combined name is: " & String1 & String2)


    End Sub
End Module

