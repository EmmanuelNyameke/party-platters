' Program Name: Party Platters
' Date: October 5, 2024
' Author: K Bola
' Purpose: This Application allows customers to enter their orders on a flat-screen computer
Public Class frmPlatters
    Private Sub btnOrderCost_Click(sender As Object, e As EventArgs) Handles btnOrderCost.Click
        Const _cdblDiscount As Double = 0.05
        Const _cdecBeansPrice As Decimal = 200
        Const _cdecJollofPrice As Decimal = 500
        Const _cdecBanku As Decimal = 700
        Const _cdecWaakye As Decimal = 400
        Const _cdecRice As Decimal = 300
        Dim dblDiscount As Double
        Dim intLoyaltyPoints As Integer
        Dim decTotalOrderCost As Decimal
        Dim decTotalCostAfterDiscount As Decimal
        If (IsNumeric(txtLoyaltyPoints.Text)) Then
            intLoyaltyPoints = Convert.ToInt32(txtLoyaltyPoints.Text)
            If (intLoyaltyPoints > 0) Then

                If (radBeansPlatter.Checked And (radPay.Checked Or radPrePay.Checked)) Then
                    decTotalOrderCost = _cdecBeansPrice.ToString("C")
                    dblDiscount = (intLoyaltyPoints / 10) * (_cdblDiscount / 100 * decTotalOrderCost)
                    decTotalCostAfterDiscount = decTotalOrderCost - dblDiscount
                    lblCost.Text = decTotalOrderCost.ToString("C")
                    lblMoneyReturned.Text = dblDiscount.ToString("C")
                    lblTotal.Text = decTotalCostAfterDiscount.ToString("C")
                ElseIf (radAssortedJollofPlatter.Checked And (radPay.Checked Or radPrePay.Checked)) Then
                    decTotalOrderCost = _cdecJollofPrice.ToString("C")
                    dblDiscount = (intLoyaltyPoints / 10) * (_cdblDiscount / 100 * decTotalOrderCost)
                    decTotalCostAfterDiscount = decTotalOrderCost - dblDiscount
                    lblCost.Text = decTotalOrderCost.ToString("C")
                    lblMoneyReturned.Text = dblDiscount.ToString("C")
                    lblTotal.Text = decTotalCostAfterDiscount.ToString("C")
                ElseIf (radBankuPlatter.Checked And (radPay.Checked Or radPrePay.Checked)) Then
                    decTotalOrderCost = _cdecBanku.ToString("C")
                    dblDiscount = (intLoyaltyPoints / 10) * (_cdblDiscount / 100 * decTotalOrderCost)
                    decTotalCostAfterDiscount = decTotalOrderCost - dblDiscount
                    lblCost.Text = decTotalOrderCost.ToString("C")
                    lblMoneyReturned.Text = dblDiscount.ToString("C")
                    lblTotal.Text = decTotalCostAfterDiscount.ToString("C")
                ElseIf (radWaakyePlatter.Checked And (radPay.Checked Or radPrePay.Checked)) Then
                    decTotalOrderCost = _cdecWaakye.ToString("C")
                    dblDiscount = (intLoyaltyPoints / 10) * (_cdblDiscount / 100 * decTotalOrderCost)
                    decTotalCostAfterDiscount = decTotalOrderCost - dblDiscount
                    lblCost.Text = decTotalOrderCost.ToString("C")
                    lblMoneyReturned.Text = dblDiscount.ToString("C")
                    lblTotal.Text = decTotalCostAfterDiscount.ToString("C")
                ElseIf (radRicePlatter.Checked And (radPay.Checked Or radPrePay.Checked)) Then
                    decTotalOrderCost = _cdecRice.ToString("C")
                    dblDiscount = (intLoyaltyPoints / 10) * (_cdblDiscount / 100 * decTotalOrderCost)
                    decTotalCostAfterDiscount = decTotalOrderCost - dblDiscount
                    lblCost.Text = decTotalOrderCost.ToString("C")
                    lblMoneyReturned.Text = dblDiscount.ToString("C")
                    lblTotal.Text = decTotalCostAfterDiscount.ToString("C")
                Else
                    MsgBox("Mandatory: A Platter and A Payment Type must be Selected", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Party Platter or Payment Type")
                End If
            Else
                MsgBox("Enter a number greater than Zero", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Input")
            End If
        Else
            MsgBox("Enter a number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Entry")
            txtLoyaltyPoints.Clear()
            txtLoyaltyPoints.Focus()
        End If
    End Sub

    Private Sub frmPlatters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
        lblMoneyReturned.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoyaltyPoints.Clear()
        txtLoyaltyPoints.Focus()
        lblCost.Text = ""
        lblMoneyReturned.Text = ""
        lblTotal.Text = ""
        radBeansPlatter.Checked = False
        radAssortedJollofPlatter.Checked = False
        radBankuPlatter.Checked = False
        radWaakyePlatter.Checked = False
        radRicePlatter.Checked = False
        radPrePay.Checked = False
        radPay.Checked = False
    End Sub
End Class
