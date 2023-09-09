Public Class frmSalary
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossSalary.Text = ""
        lblGross.Text = ""
        lblGrossMon.Text = ""
        lblMonSal.Text = ""
        lblMontax.Text = ""
        lblMonthlyTaxPayable.Text = ""
        lblNetMonSalary.Text = ""
        lbltax.Text = ""
        lblTaxPerc.Text = ""
        txtGrossSalary.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decempAnnualsalary As Decimal
        Decimal.TryParse(txtGrossSalary.Text, decempAnnualsalary)

        Dim decgrossMonthlySalary As Decimal
        Dim decpercentageTax As Decimal
        Dim decmonthlyTaxPayable As Decimal
        Dim decNetmonthlySalary As Decimal


        'Processing 1--

        decgrossMonthlySalary = (decempAnnualsalary / 12)

        If Not Decimal.TryParse(txtGrossSalary.Text, decempAnnualsalary) Then
            MessageBox.Show("Please enter a valid Gross Annual Salary.")
            Return
        End If

        If chkFullEmp.Checked Then
            decempAnnualsalary = CDec(decgrossMonthlySalary * 0.29)
        Else
            decempAnnualsalary = CDec(decgrossMonthlySalary * 0.25)
        End If

        'Processing 2--

        decpercentageTax = decempAnnualsalary / decgrossMonthlySalary * 100

        'Processing 3--

        decmonthlyTaxPayable = decgrossMonthlySalary / decpercentageTax * 100

        'Processing 4--

        decNetmonthlySalary = decmonthlyTaxPayable - decNetmonthlySalary


































        lblGrossMon.Text = decgrossMonthlySalary.ToString("C")
        lblTaxPerc.Text = decpercentageTax.ToString("f2") & "%"
        lblMonthlyTaxPayable.Text = decpercentageTax.ToString("f2")
        lblNetMonSalary.Text = decNetmonthlySalary.ToString("C2")
    End Sub
End Class
