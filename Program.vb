Imports System

Module MainProgram


    Sub Main()

        'Declare variables
        Dim salary As Double = 2300000
        Dim dependants As Integer = 4
        Dim schoolFees As Double = 430000

        Dim totalExpenses As Double
        Dim takeHomeBalance As Double

        Dim nssf As Double
        Dim paye As Double
        Dim sacco As Double
        Dim totalDeductions As Double
        Dim balanceAfterDeductions As Double

        'Calculate total school fees
        totalExpenses = dependants * schoolFees

        'Calculate take-home balance
        takeHomeBalance = salary - totalExpenses

        'Calculate deductions
        nssf = salary * 0.1
        paye = salary * 0.09
        sacco = salary * 0.05

        'Calculate total deductions
        totalDeductions = nssf + paye + sacco

        'Calculate balance after deductions
        balanceAfterDeductions = takeHomeBalance - totalDeductions

        'Display results
        Console.WriteLine("Sam's Salary Calculations")
        Console.WriteLine("-------------------------")
        Console.WriteLine("Monthly Salary: UGX " & salary.ToString("N0"))
        Console.WriteLine("Total School Fees: UGX " & totalExpenses.ToString("N0"))
        Console.WriteLine("Take-Home Balance: UGX " & takeHomeBalance.ToString("N0"))

        Console.WriteLine("NSSF Deduction: UGX " & nssf.ToString("N0"))
        Console.WriteLine("PAYE Deduction: UGX " & paye.ToString("N0"))
        Console.WriteLine("SACCO Deduction: UGX " & sacco.ToString("N0"))
        Console.WriteLine("Total Deductions: UGX " & totalDeductions.ToString("N0"))

        Console.WriteLine("Balance After Deductions: UGX " & balanceAfterDeductions.ToString("N0"))

        Console.ReadLine()

    End Sub

End Module


