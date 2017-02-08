' Calculates projected sales for items
' Programmer: Zachary Murphy 

' Option statements
Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decStraw As Decimal
        Dim decRasp As Decimal
        Dim decBlue As Decimal
        Dim decProjInc As Decimal
        Dim decProjStraw As Decimal
        Dim decProjRasp As Decimal
        Dim decProjBlue As Decimal

        'get the projections parse
        Decimal.TryParse(txtProjIncrease.Text, decProjInc)

        'calculate the strawberry sales projection
        Decimal.TryParse(txtStraw.Text, decStraw)
        decProjStraw = decStraw + (decStraw * decProjInc)

        ' calculate the blueberry sales projection
        Decimal.TryParse(txtBlue.Text, decBlue)
        decProjBlue = decBlue + (decBlue * decProjInc)

        'calculate the rasp sales projection
        Decimal.TryParse(txtRasp.Text, decRasp)
        decProjRasp = decRasp + (decRasp * decProjInc)

        ' format output for dollar signs
        lblStraw.Text = decProjStraw.ToString("C2")
        lblBlue.Text = decProjBlue.ToString("C2")
        lblRasp.Text = decProjRasp.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears content entered by user
        txtProjIncrease.Text = String.Empty
        txtStraw.Text = String.Empty
        txtRasp.Text = String.Empty
        txtBlue.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty
        lblStraw.Text = String.Empty
        'focus to projection increase
        txtProjIncrease.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the application
        Me.Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnCalc.Visible = False
        btnClear.Visible = False
        btnPrint.Visible = False
        btnExit.Visible = False
        PrintForm1.Print()
        btnCalc.Visible = True
        btnClear.Visible = True
        btnPrint.Visible = True
        btnExit.Visible = True
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
