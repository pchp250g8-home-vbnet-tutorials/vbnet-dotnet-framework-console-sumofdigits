Module Module1

    Sub Main()
        Console.WriteLine("Input an Integer Number:")
        Dim strNum = Console.ReadLine()
        Dim iNum As Long = 0
        Int64.TryParse(strNum, iNum)
        Dim nSumDigits = 0 : Dim iVal = Math.Abs(iNum)
        Do While (iVal > 0)
            nSumDigits += iVal Mod 10
            iVal \= 10
        Loop
        Console.WriteLine("The sum of digits of the number {0} is {1}", iNum, nSumDigits)
        Console.Read()
    End Sub

End Module
