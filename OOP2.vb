' Module 8: Introduction to Object-Oriented Programming (OOP) in Visual Basic

' Class
' An object

' Example 1
' Student - class
' Student, name, reg Number , Gender, Marks,  - Objects

' Principal of OOP

' Enscapsulation
' Inheritance
' Polymorphism
' Abstration


' Example

Public Class Student
    ' Create Objects
    Private name As String
    Private  age As Integer

End Class

' Example Module

Module Module1
    Sub Main()

        Dim name1 As Student()
        Dim name2 As Student()

        ' Using Objects
        name1.SetDetails("Shaminah", 23)
        name2.SetDetails("Ali", 22)


        ' Output
        name1.Display()
        nam2.Display()
    
    End Sub

End Module


' Demostrate Using a Practical Example

' Use Encapsulation
' What is Encapsulation ?

' Use Console Application version of codes

Module Module1
    Sub Main()
        ' Create and use objects
        Dim s1 As New Student("Shadrach", 78)
        Dim s2 As New Student("Maria", 76)

        s1.Display()
        s2.Display()

        Console.ReadLine()
    End Sub
End Module


' Demonstrate Encapsulation
Public Class Student
    ' Encapsulation
    Private _name As String
    Private _marks As Integer

    ' Constructor 
    Public Sub New(n As String, m As Integer)
        _name = n
        _marks = m
    End Sub
    ' Function
    Public Function GetGrade() As String
    If _marks >= 50 Then 
        Return "Pass"
    Else
        Return "Fail"
    End Function

    ' Output / Display info within the console
    Public Sub Display()
        Console.WriteLine(_name & "scored " & _marks & "and has" & GetGrade())  
    End Sub
End Class

' Expected Output
' Maria scored 78 and has pass



' Why Enscapsultion 


' Exercises one

' Create a BankAccount class with a private _balance field. The Balance property should be read-only; deposits/withdrawals happen through Deposit(amount) and Withdraw(amount) methods that reject negative amounts and overdrafts. Use Encapsulation Concepts


' https://github.com/DivinePraise-star/MusiimentaTendoDivine5242
