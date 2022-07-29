Imports System.Console
Module program
    Sub Main(args As String())
        Dim dblInterest As Double
        Dim dblPrincipal As Double
        Dim dblRate As Double
        Dim intTime As Integer
        Dim dblAmount As Double

        WriteLine("Welcome")
        Write("Enter the principal amount: ")
        dblPrincipal = ReadLine()
        WriteLine()
        Write("Enter the rate: ")
        dblRate = ReadLine()
        WriteLine()
        Write("Enter the time in years: ")
        intTime = ReadLine()

        dblInterest = (dblPrincipal * dblRate * intTime) / 100
        dblAmount = dblPrincipal + dblInterest

        Write("Simple interest is " & dblInterest)
        Write(" and the amount is " & dblAmount)
        ReadKey()
    End Sub
End Module