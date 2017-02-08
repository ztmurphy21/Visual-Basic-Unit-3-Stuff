'Name: Cranston Toy's
' Purpose: Calculates the number of toys ordered and total
'Programmer: Zachary Murphy on 2-8-2017

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'var declarations
        Const twelvePRICE As Decimal = 14.99D
        Const fivePRICE As Decimal = 6.99D
        Const twoPrice As Decimal = 2.5D
        Dim orderDate As String
        Dim twelvePack As Decimal
        Dim fivePack As Decimal
        Dim twoPack As Decimal
        Dim totalItems As Decimal
        Dim totalSales As Decimal

        'assing order date
        orderDate = Convert.ToString(txtDate)

        'convert inputs as decimals 
        Decimal.TryParse(txtTwelvePack.Text, twelvePack)
        Decimal.TryParse(txtFivePack.Text, fivePack)
        Decimal.TryParse(txtTwoPack.Text, twoPack)

        'calc total items
        totalItems = twelvePack + fivePack + twoPack

        'cal order total
        totalSales = (twelvePack * twelvePRICE) + (fivePack * fivePRICE) + (twoPack * twoPrice)

        'display total items
        lblTotalItems.Text = Convert.ToString(totalItems)

        'display sales total
        lblTotalSales.Text = totalSales.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'prepare for next order yay!
        txtDate.Text = String.Empty
        txtTwelvePack.Text = String.Empty
        txtFivePack.Text = String.Empty
        txtTwoPack.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        'send the focus back to date box
        txtDate.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearText(sender As Object, e As EventArgs) Handles txtDate.TextChanged, txtTwelvePack.TextChanged, txtFivePack.TextChanged, txtTwoPack.TextChanged
        'clear totals as new info is enetered. 

        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty

    End Sub
End Class
