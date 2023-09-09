<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.grpEnter2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkFullEmp = New System.Windows.Forms.CheckBox()
        Me.txtGrossSalary = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpEnter = New System.Windows.Forms.GroupBox()
        Me.lblMonSal = New System.Windows.Forms.Label()
        Me.lblMontax = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblNetMonSalary = New System.Windows.Forms.Label()
        Me.lblMonthlyTaxPayable = New System.Windows.Forms.Label()
        Me.lblTaxPerc = New System.Windows.Forms.Label()
        Me.lblGrossMon = New System.Windows.Forms.Label()
        Me.grpEnter2.SuspendLayout()
        Me.grpEnter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelView
        '
        Me.PanelView.BackColor = System.Drawing.Color.Blue
        Me.PanelView.Location = New System.Drawing.Point(2, 2)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(380, 522)
        Me.PanelView.TabIndex = 0
        '
        'grpEnter2
        '
        Me.grpEnter2.Controls.Add(Me.Label1)
        Me.grpEnter2.Controls.Add(Me.chkFullEmp)
        Me.grpEnter2.Controls.Add(Me.txtGrossSalary)
        Me.grpEnter2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpEnter2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEnter2.Location = New System.Drawing.Point(399, 27)
        Me.grpEnter2.Name = "grpEnter2"
        Me.grpEnter2.Size = New System.Drawing.Size(792, 164)
        Me.grpEnter2.TabIndex = 2
        Me.grpEnter2.TabStop = False
        Me.grpEnter2.Text = "Provide The Following data For the Employee :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Enter Gross Annual Salary :"
        '
        'chkFullEmp
        '
        Me.chkFullEmp.AutoSize = True
        Me.chkFullEmp.Location = New System.Drawing.Point(590, 80)
        Me.chkFullEmp.Name = "chkFullEmp"
        Me.chkFullEmp.Size = New System.Drawing.Size(174, 25)
        Me.chkFullEmp.TabIndex = 1
        Me.chkFullEmp.Text = "Full Tim Employee "
        Me.chkFullEmp.UseVisualStyleBackColor = True
        '
        'txtGrossSalary
        '
        Me.txtGrossSalary.Location = New System.Drawing.Point(386, 77)
        Me.txtGrossSalary.Multiline = True
        Me.txtGrossSalary.Name = "txtGrossSalary"
        Me.txtGrossSalary.Size = New System.Drawing.Size(158, 35)
        Me.txtGrossSalary.TabIndex = 0
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(1042, 222)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(149, 75)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1042, 330)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(149, 73)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1042, 424)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 73)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpEnter
        '
        Me.grpEnter.Controls.Add(Me.lblMonSal)
        Me.grpEnter.Controls.Add(Me.lblMontax)
        Me.grpEnter.Controls.Add(Me.lbltax)
        Me.grpEnter.Controls.Add(Me.lblGross)
        Me.grpEnter.Controls.Add(Me.lblNetMonSalary)
        Me.grpEnter.Controls.Add(Me.lblMonthlyTaxPayable)
        Me.grpEnter.Controls.Add(Me.lblTaxPerc)
        Me.grpEnter.Controls.Add(Me.lblGrossMon)
        Me.grpEnter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEnter.Location = New System.Drawing.Point(399, 213)
        Me.grpEnter.Name = "grpEnter"
        Me.grpEnter.Size = New System.Drawing.Size(628, 299)
        Me.grpEnter.TabIndex = 6
        Me.grpEnter.TabStop = False
        Me.grpEnter.Text = "Provide The Following data For the Employee :"
        '
        'lblMonSal
        '
        Me.lblMonSal.AutoSize = True
        Me.lblMonSal.Location = New System.Drawing.Point(194, 239)
        Me.lblMonSal.Name = "lblMonSal"
        Me.lblMonSal.Size = New System.Drawing.Size(167, 21)
        Me.lblMonSal.TabIndex = 7
        Me.lblMonSal.Text = "Net Monthly Salary :"
        '
        'lblMontax
        '
        Me.lblMontax.AutoSize = True
        Me.lblMontax.Location = New System.Drawing.Point(182, 174)
        Me.lblMontax.Name = "lblMontax"
        Me.lblMontax.Size = New System.Drawing.Size(178, 21)
        Me.lblMontax.TabIndex = 6
        Me.lblMontax.Text = "Monthly Tax Payable :"
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Location = New System.Drawing.Point(161, 109)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(199, 21)
        Me.lbltax.TabIndex = 5
        Me.lbltax.Text = "Percentage Tax Payable :"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(167, 51)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(180, 21)
        Me.lblGross.TabIndex = 4
        Me.lblGross.Text = "Gross Monthly Salary :"
        '
        'lblNetMonSalary
        '
        Me.lblNetMonSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetMonSalary.Location = New System.Drawing.Point(367, 224)
        Me.lblNetMonSalary.Name = "lblNetMonSalary"
        Me.lblNetMonSalary.Size = New System.Drawing.Size(193, 50)
        Me.lblNetMonSalary.TabIndex = 3
        Me.lblNetMonSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthlyTaxPayable
        '
        Me.lblMonthlyTaxPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyTaxPayable.Location = New System.Drawing.Point(366, 162)
        Me.lblMonthlyTaxPayable.Name = "lblMonthlyTaxPayable"
        Me.lblMonthlyTaxPayable.Size = New System.Drawing.Size(194, 45)
        Me.lblMonthlyTaxPayable.TabIndex = 2
        Me.lblMonthlyTaxPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTaxPerc
        '
        Me.lblTaxPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxPerc.Location = New System.Drawing.Point(366, 97)
        Me.lblTaxPerc.Name = "lblTaxPerc"
        Me.lblTaxPerc.Size = New System.Drawing.Size(194, 45)
        Me.lblTaxPerc.TabIndex = 1
        Me.lblTaxPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossMon
        '
        Me.lblGrossMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossMon.Location = New System.Drawing.Point(366, 38)
        Me.lblGrossMon.Name = "lblGrossMon"
        Me.lblGrossMon.Size = New System.Drawing.Size(194, 46)
        Me.lblGrossMon.TabIndex = 0
        Me.lblGrossMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 524)
        Me.Controls.Add(Me.grpEnter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpEnter2)
        Me.Controls.Add(Me.PanelView)
        Me.Name = "frmSalary"
        Me.Text = "Volo Salary Program ."
        Me.grpEnter2.ResumeLayout(False)
        Me.grpEnter2.PerformLayout()
        Me.grpEnter.ResumeLayout(False)
        Me.grpEnter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelView As Panel
    Friend WithEvents grpEnter2 As GroupBox
    Friend WithEvents txtGrossSalary As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chkFullEmp As CheckBox
    Friend WithEvents grpEnter As GroupBox
    Friend WithEvents lblNetMonSalary As Label
    Friend WithEvents lblMonthlyTaxPayable As Label
    Friend WithEvents lblTaxPerc As Label
    Friend WithEvents lblGrossMon As Label
    Friend WithEvents lblMonSal As Label
    Friend WithEvents lblMontax As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents lblGross As Label
End Class
