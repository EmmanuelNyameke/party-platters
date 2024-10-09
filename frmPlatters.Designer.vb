<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlatters
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picPlatters = New PictureBox()
        lblHeading = New Label()
        grpPlatterType = New GroupBox()
        radRicePlatter = New RadioButton()
        radWaakyePlatter = New RadioButton()
        radBankuPlatter = New RadioButton()
        radAssortedJollofPlatter = New RadioButton()
        radBeansPlatter = New RadioButton()
        grpPaymentType = New GroupBox()
        radPay = New RadioButton()
        radPrePay = New RadioButton()
        lblInstruction = New Label()
        txtLoyaltyPoints = New TextBox()
        lblOrderCost = New Label()
        lblCost = New Label()
        btnOrderCost = New Button()
        btnClear = New Button()
        lblReturned = New Label()
        lblMoneyReturned = New Label()
        lblTotalCost = New Label()
        lblTotal = New Label()
        CType(picPlatters, ComponentModel.ISupportInitialize).BeginInit()
        grpPlatterType.SuspendLayout()
        grpPaymentType.SuspendLayout()
        SuspendLayout()
        ' 
        ' picPlatters
        ' 
        picPlatters.Dock = DockStyle.Left
        picPlatters.Image = My.Resources.Resources.platters
        picPlatters.Location = New Point(0, 0)
        picPlatters.Name = "picPlatters"
        picPlatters.Size = New Size(318, 420)
        picPlatters.SizeMode = PictureBoxSizeMode.StretchImage
        picPlatters.TabIndex = 0
        picPlatters.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(475, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(177, 29)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Party Platters"
        ' 
        ' grpPlatterType
        ' 
        grpPlatterType.BackColor = Color.ForestGreen
        grpPlatterType.Controls.Add(radRicePlatter)
        grpPlatterType.Controls.Add(radWaakyePlatter)
        grpPlatterType.Controls.Add(radBankuPlatter)
        grpPlatterType.Controls.Add(radAssortedJollofPlatter)
        grpPlatterType.Controls.Add(radBeansPlatter)
        grpPlatterType.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        grpPlatterType.ForeColor = Color.Tomato
        grpPlatterType.Location = New Point(348, 86)
        grpPlatterType.Name = "grpPlatterType"
        grpPlatterType.Size = New Size(330, 156)
        grpPlatterType.TabIndex = 2
        grpPlatterType.TabStop = False
        grpPlatterType.Text = "Party Platters and their Prices"
        ' 
        ' radRicePlatter
        ' 
        radRicePlatter.AutoSize = True
        radRicePlatter.Location = New Point(6, 126)
        radRicePlatter.Name = "radRicePlatter"
        radRicePlatter.Size = New Size(181, 23)
        radRicePlatter.TabIndex = 4
        radRicePlatter.TabStop = True
        radRicePlatter.Text = "Rice Platter - $300"
        radRicePlatter.UseVisualStyleBackColor = True
        ' 
        ' radWaakyePlatter
        ' 
        radWaakyePlatter.AutoSize = True
        radWaakyePlatter.Location = New Point(6, 103)
        radWaakyePlatter.Name = "radWaakyePlatter"
        radWaakyePlatter.Size = New Size(211, 23)
        radWaakyePlatter.TabIndex = 3
        radWaakyePlatter.TabStop = True
        radWaakyePlatter.Text = "Waakye Platter - $400"
        radWaakyePlatter.UseVisualStyleBackColor = True
        ' 
        ' radBankuPlatter
        ' 
        radBankuPlatter.AutoSize = True
        radBankuPlatter.Location = New Point(6, 79)
        radBankuPlatter.Name = "radBankuPlatter"
        radBankuPlatter.Size = New Size(197, 23)
        radBankuPlatter.TabIndex = 2
        radBankuPlatter.TabStop = True
        radBankuPlatter.Text = "Banku Platter - $700"
        radBankuPlatter.UseVisualStyleBackColor = True
        ' 
        ' radAssortedJollofPlatter
        ' 
        radAssortedJollofPlatter.AutoSize = True
        radAssortedJollofPlatter.Location = New Point(6, 56)
        radAssortedJollofPlatter.Name = "radAssortedJollofPlatter"
        radAssortedJollofPlatter.Size = New Size(267, 23)
        radAssortedJollofPlatter.TabIndex = 1
        radAssortedJollofPlatter.TabStop = True
        radAssortedJollofPlatter.Text = "Assorted Jollof Platter - $500"
        radAssortedJollofPlatter.UseVisualStyleBackColor = True
        ' 
        ' radBeansPlatter
        ' 
        radBeansPlatter.AutoSize = True
        radBeansPlatter.Location = New Point(6, 33)
        radBeansPlatter.Name = "radBeansPlatter"
        radBeansPlatter.Size = New Size(195, 23)
        radBeansPlatter.TabIndex = 0
        radBeansPlatter.TabStop = True
        radBeansPlatter.Text = "Beans Platter - $200"
        radBeansPlatter.UseVisualStyleBackColor = True
        ' 
        ' grpPaymentType
        ' 
        grpPaymentType.BackColor = Color.ForestGreen
        grpPaymentType.Controls.Add(radPay)
        grpPaymentType.Controls.Add(radPrePay)
        grpPaymentType.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        grpPaymentType.ForeColor = Color.Tomato
        grpPaymentType.Location = New Point(678, 86)
        grpPaymentType.Name = "grpPaymentType"
        grpPaymentType.Size = New Size(110, 156)
        grpPaymentType.TabIndex = 5
        grpPaymentType.TabStop = False
        grpPaymentType.Text = "Payment Type"
        ' 
        ' radPay
        ' 
        radPay.AutoSize = True
        radPay.Location = New Point(6, 103)
        radPay.Name = "radPay"
        radPay.Size = New Size(57, 23)
        radPay.TabIndex = 1
        radPay.TabStop = True
        radPay.Text = "Pay"
        radPay.UseVisualStyleBackColor = True
        ' 
        ' radPrePay
        ' 
        radPrePay.AutoSize = True
        radPrePay.Location = New Point(6, 56)
        radPrePay.Name = "radPrePay"
        radPrePay.Size = New Size(92, 23)
        radPrePay.TabIndex = 0
        radPrePay.TabStop = True
        radPrePay.Text = "Pre-Pay"
        radPrePay.UseVisualStyleBackColor = True
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Font = New Font("Tahoma", 14.25F)
        lblInstruction.Location = New Point(396, 50)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(231, 23)
        lblInstruction.TabIndex = 6
        lblInstruction.Text = "Enter Your Loyalty Points: "
        ' 
        ' txtLoyaltyPoints
        ' 
        txtLoyaltyPoints.Font = New Font("Tahoma", 14.25F)
        txtLoyaltyPoints.Location = New Point(659, 47)
        txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        txtLoyaltyPoints.Size = New Size(39, 30)
        txtLoyaltyPoints.TabIndex = 7
        txtLoyaltyPoints.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblOrderCost
        ' 
        lblOrderCost.AutoSize = True
        lblOrderCost.Font = New Font("Tahoma", 14.25F)
        lblOrderCost.Location = New Point(450, 259)
        lblOrderCost.Name = "lblOrderCost"
        lblOrderCost.Size = New Size(106, 23)
        lblOrderCost.TabIndex = 8
        lblOrderCost.Text = "Order Cost:"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Tahoma", 14.25F)
        lblCost.Location = New Point(647, 259)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(45, 23)
        lblCost.TabIndex = 9
        lblCost.Text = "Cost"
        ' 
        ' btnOrderCost
        ' 
        btnOrderCost.BackColor = Color.Tomato
        btnOrderCost.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        btnOrderCost.Location = New Point(481, 375)
        btnOrderCost.Name = "btnOrderCost"
        btnOrderCost.Size = New Size(107, 33)
        btnOrderCost.TabIndex = 10
        btnOrderCost.Text = "Order Cost"
        btnOrderCost.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Tomato
        btnClear.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        btnClear.Location = New Point(614, 375)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(107, 33)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblReturned
        ' 
        lblReturned.AutoSize = True
        lblReturned.Font = New Font("Tahoma", 14.25F)
        lblReturned.Location = New Point(450, 294)
        lblReturned.Name = "lblReturned"
        lblReturned.Size = New Size(153, 23)
        lblReturned.TabIndex = 12
        lblReturned.Text = "Money Received:"
        ' 
        ' lblMoneyReturned
        ' 
        lblMoneyReturned.AutoSize = True
        lblMoneyReturned.Font = New Font("Tahoma", 14.25F)
        lblMoneyReturned.Location = New Point(647, 294)
        lblMoneyReturned.Name = "lblMoneyReturned"
        lblMoneyReturned.Size = New Size(65, 23)
        lblMoneyReturned.TabIndex = 13
        lblMoneyReturned.Text = "Money"
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Tahoma", 14.25F)
        lblTotalCost.Location = New Point(450, 330)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(153, 23)
        lblTotalCost.TabIndex = 14
        lblTotalCost.Text = "Total Order Cost:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Tahoma", 14.25F)
        lblTotal.Location = New Point(647, 330)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(45, 23)
        lblTotal.TabIndex = 15
        lblTotal.Text = "Cost"
        ' 
        ' frmPlatters
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(800, 420)
        Controls.Add(lblTotal)
        Controls.Add(lblTotalCost)
        Controls.Add(lblMoneyReturned)
        Controls.Add(lblReturned)
        Controls.Add(btnClear)
        Controls.Add(btnOrderCost)
        Controls.Add(lblCost)
        Controls.Add(lblOrderCost)
        Controls.Add(txtLoyaltyPoints)
        Controls.Add(lblInstruction)
        Controls.Add(grpPaymentType)
        Controls.Add(grpPlatterType)
        Controls.Add(lblHeading)
        Controls.Add(picPlatters)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.ForestGreen
        Name = "frmPlatters"
        Text = "Party Platters"
        CType(picPlatters, ComponentModel.ISupportInitialize).EndInit()
        grpPlatterType.ResumeLayout(False)
        grpPlatterType.PerformLayout()
        grpPaymentType.ResumeLayout(False)
        grpPaymentType.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPlatters As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents grpPlatterType As GroupBox
    Friend WithEvents radRicePlatter As RadioButton
    Friend WithEvents radWaakyePlatter As RadioButton
    Friend WithEvents radBankuPlatter As RadioButton
    Friend WithEvents radAssortedJollofPlatter As RadioButton
    Friend WithEvents radBeansPlatter As RadioButton
    Friend WithEvents grpPaymentType As GroupBox
    Friend WithEvents radPay As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents lblOrderCost As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnOrderCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblReturned As Label
    Friend WithEvents lblMoneyReturned As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTotal As Label

End Class
