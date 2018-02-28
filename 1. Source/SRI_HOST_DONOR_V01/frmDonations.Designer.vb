<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDonations))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnPDFGen = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_FundType = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_JournalEntry = New System.Windows.Forms.Button()
        Me.Dgv_BPList = New System.Windows.Forms.DataGridView()
        Me.Choose = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vertical = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.region = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.program = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDonors = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtGroupNo = New System.Windows.Forms.TextBox()
        Me.lblMsg1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtverticals = New System.Windows.Forms.TextBox()
        Me.btnVerticals = New System.Windows.Forms.Button()
        Me.btnRegions = New System.Windows.Forms.Button()
        Me.txtregions = New System.Windows.Forms.TextBox()
        Me.btnProgrammes = New System.Windows.Forms.Button()
        Me.txtprogrammes = New System.Windows.Forms.TextBox()
        Me.btnLocations = New System.Windows.Forms.Button()
        Me.txtlocations = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_Paymentmode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnDebitAcct = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnCreditAcct = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        CType(Me.Dgv_BPList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Verticals"
        Me.Label1.Visible = False
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(334, 100)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(99, 30)
        Me.btnShow.TabIndex = 77
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(191, 577)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 33)
        Me.Button3.TabIndex = 88
        Me.Button3.Text = "&Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnPDFGen
        '
        Me.btnPDFGen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPDFGen.Location = New System.Drawing.Point(23, 575)
        Me.btnPDFGen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPDFGen.Name = "btnPDFGen"
        Me.btnPDFGen.Size = New System.Drawing.Size(157, 33)
        Me.btnPDFGen.TabIndex = 66
        Me.btnPDFGen.Text = "&Send Email"
        Me.btnPDFGen.UseVisualStyleBackColor = True
        Me.btnPDFGen.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Fund Type"
        '
        'cmb_FundType
        '
        Me.cmb_FundType.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmb_FundType.FormattingEnabled = True
        Me.cmb_FundType.Items.AddRange(New Object() {"--Choose--", "Local", "FCRA"})
        Me.cmb_FundType.Location = New System.Drawing.Point(153, 20)
        Me.cmb_FundType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_FundType.Name = "cmb_FundType"
        Me.cmb_FundType.Size = New System.Drawing.Size(113, 24)
        Me.cmb_FundType.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(927, 13)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowCheckBox = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(139, 23)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(863, 23)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(444, 109)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Donors"
        Me.Label12.Visible = False
        '
        'btn_JournalEntry
        '
        Me.btn_JournalEntry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_JournalEntry.Location = New System.Drawing.Point(23, 576)
        Me.btn_JournalEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_JournalEntry.Name = "btn_JournalEntry"
        Me.btn_JournalEntry.Size = New System.Drawing.Size(157, 33)
        Me.btn_JournalEntry.TabIndex = 100
        Me.btn_JournalEntry.Text = "&Journal Entry Posting"
        Me.btn_JournalEntry.UseVisualStyleBackColor = True
        '
        'Dgv_BPList
        '
        Me.Dgv_BPList.AllowUserToAddRows = False
        Me.Dgv_BPList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_BPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_BPList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Choose, Me.DRN, Me.RD, Me.PM, Me.DA, Me.CDP, Me.D, Me.B, Me.N, Me.SM, Me.ID, Me.Vertical, Me.region, Me.location, Me.program, Me.donorcode, Me.donorname})
        Me.Dgv_BPList.Location = New System.Drawing.Point(19, 138)
        Me.Dgv_BPList.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_BPList.Name = "Dgv_BPList"
        Me.Dgv_BPList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Dgv_BPList.Size = New System.Drawing.Size(1050, 429)
        Me.Dgv_BPList.TabIndex = 102
        '
        'Choose
        '
        Me.Choose.Frozen = True
        Me.Choose.HeaderText = "Choose"
        Me.Choose.Name = "Choose"
        Me.Choose.Width = 60
        '
        'DRN
        '
        Me.DRN.Frozen = True
        Me.DRN.HeaderText = "Donation Receipt No."
        Me.DRN.Name = "DRN"
        Me.DRN.ReadOnly = True
        Me.DRN.Width = 130
        '
        'RD
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.RD.DefaultCellStyle = DataGridViewCellStyle1
        Me.RD.Frozen = True
        Me.RD.HeaderText = "Receipt Date"
        Me.RD.Name = "RD"
        Me.RD.ReadOnly = True
        '
        'PM
        '
        Me.PM.Frozen = True
        Me.PM.HeaderText = "Payment Mode"
        Me.PM.Name = "PM"
        Me.PM.ReadOnly = True
        '
        'DA
        '
        Me.DA.Frozen = True
        Me.DA.HeaderText = "Donation Amount"
        Me.DA.Name = "DA"
        Me.DA.ReadOnly = True
        '
        'CDP
        '
        Me.CDP.Frozen = True
        Me.CDP.HeaderText = "Cheque/DD/Payment No."
        Me.CDP.Name = "CDP"
        Me.CDP.ReadOnly = True
        Me.CDP.Width = 130
        '
        'D
        '
        Me.D.HeaderText = "Date"
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        '
        'B
        '
        Me.B.HeaderText = "Bank"
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        '
        'N
        '
        Me.N.HeaderText = "Narration"
        Me.N.Name = "N"
        Me.N.Width = 200
        '
        'SM
        '
        Me.SM.HeaderText = "Status Message"
        Me.SM.Name = "SM"
        Me.SM.ReadOnly = True
        Me.SM.Width = 200
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Vertical
        '
        Me.Vertical.HeaderText = "Vertical"
        Me.Vertical.Name = "Vertical"
        Me.Vertical.ReadOnly = True
        Me.Vertical.Visible = False
        '
        'region
        '
        Me.region.HeaderText = "region"
        Me.region.Name = "region"
        Me.region.ReadOnly = True
        Me.region.Visible = False
        '
        'location
        '
        Me.location.HeaderText = "location"
        Me.location.Name = "location"
        Me.location.ReadOnly = True
        Me.location.Visible = False
        '
        'program
        '
        Me.program.HeaderText = "program"
        Me.program.Name = "program"
        Me.program.ReadOnly = True
        Me.program.Visible = False
        '
        'donorcode
        '
        Me.donorcode.HeaderText = "donorcode"
        Me.donorcode.Name = "donorcode"
        Me.donorcode.ReadOnly = True
        Me.donorcode.Visible = False
        '
        'donorname
        '
        Me.donorname.HeaderText = "donorname"
        Me.donorname.Name = "donorname"
        Me.donorname.ReadOnly = True
        Me.donorname.Visible = False
        '
        'btnDonors
        '
        Me.btnDonors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonors.Location = New System.Drawing.Point(717, 103)
        Me.btnDonors.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonors.Name = "btnDonors"
        Me.btnDonors.Size = New System.Drawing.Size(35, 25)
        Me.btnDonors.TabIndex = 104
        Me.btnDonors.Text = "..."
        Me.btnDonors.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDonors.UseVisualStyleBackColor = True
        Me.btnDonors.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblMsg.Location = New System.Drawing.Point(444, 78)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(568, 25)
        Me.lblMsg.TabIndex = 106
        '
        'txtGroupNo
        '
        Me.txtGroupNo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtGroupNo.Location = New System.Drawing.Point(581, 104)
        Me.txtGroupNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGroupNo.Name = "txtGroupNo"
        Me.txtGroupNo.Size = New System.Drawing.Size(139, 23)
        Me.txtGroupNo.TabIndex = 107
        Me.txtGroupNo.Visible = False
        '
        'lblMsg1
        '
        Me.lblMsg1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg1.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblMsg1.Location = New System.Drawing.Point(446, 101)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(600, 25)
        Me.lblMsg1.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Regions"
        '
        'txtverticals
        '
        Me.txtverticals.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtverticals.Location = New System.Drawing.Point(153, 49)
        Me.txtverticals.Margin = New System.Windows.Forms.Padding(4)
        Me.txtverticals.Name = "txtverticals"
        Me.txtverticals.Size = New System.Drawing.Size(139, 23)
        Me.txtverticals.TabIndex = 111
        Me.txtverticals.Visible = False
        '
        'btnVerticals
        '
        Me.btnVerticals.FlatAppearance.BorderSize = 0
        Me.btnVerticals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerticals.Location = New System.Drawing.Point(290, 48)
        Me.btnVerticals.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerticals.Name = "btnVerticals"
        Me.btnVerticals.Size = New System.Drawing.Size(35, 25)
        Me.btnVerticals.TabIndex = 112
        Me.btnVerticals.Text = "..."
        Me.btnVerticals.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVerticals.UseVisualStyleBackColor = True
        Me.btnVerticals.Visible = False
        '
        'btnRegions
        '
        Me.btnRegions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegions.Location = New System.Drawing.Point(291, 75)
        Me.btnRegions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegions.Name = "btnRegions"
        Me.btnRegions.Size = New System.Drawing.Size(35, 25)
        Me.btnRegions.TabIndex = 114
        Me.btnRegions.Text = "..."
        Me.btnRegions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegions.UseVisualStyleBackColor = True
        '
        'txtregions
        '
        Me.txtregions.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtregions.Location = New System.Drawing.Point(153, 76)
        Me.txtregions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtregions.Name = "txtregions"
        Me.txtregions.Size = New System.Drawing.Size(139, 23)
        Me.txtregions.TabIndex = 113
        '
        'btnProgrammes
        '
        Me.btnProgrammes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgrammes.Location = New System.Drawing.Point(718, 75)
        Me.btnProgrammes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProgrammes.Name = "btnProgrammes"
        Me.btnProgrammes.Size = New System.Drawing.Size(35, 25)
        Me.btnProgrammes.TabIndex = 120
        Me.btnProgrammes.Text = "..."
        Me.btnProgrammes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProgrammes.UseVisualStyleBackColor = True
        Me.btnProgrammes.Visible = False
        '
        'txtprogrammes
        '
        Me.txtprogrammes.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtprogrammes.Location = New System.Drawing.Point(581, 76)
        Me.txtprogrammes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprogrammes.Name = "txtprogrammes"
        Me.txtprogrammes.Size = New System.Drawing.Size(139, 23)
        Me.txtprogrammes.TabIndex = 119
        Me.txtprogrammes.Visible = False
        '
        'btnLocations
        '
        Me.btnLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocations.Location = New System.Drawing.Point(718, 48)
        Me.btnLocations.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLocations.Name = "btnLocations"
        Me.btnLocations.Size = New System.Drawing.Size(35, 25)
        Me.btnLocations.TabIndex = 118
        Me.btnLocations.Text = "..."
        Me.btnLocations.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLocations.UseVisualStyleBackColor = True
        Me.btnLocations.Visible = False
        '
        'txtlocations
        '
        Me.txtlocations.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txtlocations.Location = New System.Drawing.Point(581, 49)
        Me.txtlocations.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlocations.Name = "txtlocations"
        Me.txtlocations.Size = New System.Drawing.Size(139, 23)
        Me.txtlocations.TabIndex = 117
        Me.txtlocations.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Programmes"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Locations"
        Me.Label4.Visible = False
        '
        'cmb_Paymentmode
        '
        Me.cmb_Paymentmode.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.cmb_Paymentmode.FormattingEnabled = True
        Me.cmb_Paymentmode.Items.AddRange(New Object() {"--Choose--", "Cash", "Bank"})
        Me.cmb_Paymentmode.Location = New System.Drawing.Point(153, 48)
        Me.cmb_Paymentmode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Paymentmode.Name = "cmb_Paymentmode"
        Me.cmb_Paymentmode.Size = New System.Drawing.Size(113, 24)
        Me.cmb_Paymentmode.TabIndex = 121
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Payment Mode"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TextBox5.Location = New System.Drawing.Point(581, 20)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(139, 23)
        Me.TextBox5.TabIndex = 125
        '
        'btnDebitAcct
        '
        Me.btnDebitAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebitAcct.Location = New System.Drawing.Point(718, 19)
        Me.btnDebitAcct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDebitAcct.Name = "btnDebitAcct"
        Me.btnDebitAcct.Size = New System.Drawing.Size(35, 25)
        Me.btnDebitAcct.TabIndex = 124
        Me.btnDebitAcct.Text = "..."
        Me.btnDebitAcct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDebitAcct.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(444, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Debit Account"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TextBox6.Location = New System.Drawing.Point(581, 49)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(139, 23)
        Me.TextBox6.TabIndex = 128
        '
        'btnCreditAcct
        '
        Me.btnCreditAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreditAcct.Location = New System.Drawing.Point(718, 48)
        Me.btnCreditAcct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreditAcct.Name = "btnCreditAcct"
        Me.btnCreditAcct.Size = New System.Drawing.Size(35, 25)
        Me.btnCreditAcct.TabIndex = 127
        Me.btnCreditAcct.Text = "..."
        Me.btnCreditAcct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCreditAcct.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(444, 54)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Credit Account"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(18, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox1.TabIndex = 130
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(18, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox2.TabIndex = 131
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox10)
        Me.GroupBox4.Location = New System.Drawing.Point(448, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox4.TabIndex = 133
        Me.GroupBox4.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Location = New System.Drawing.Point(4, -23)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox10.TabIndex = 137
        Me.GroupBox10.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(449, 104)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox5.TabIndex = 134
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(448, 125)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox6.TabIndex = 131
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(867, 36)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox7.TabIndex = 135
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Location = New System.Drawing.Point(19, 99)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox8.TabIndex = 136
        Me.GroupBox8.TabStop = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Location = New System.Drawing.Point(455, 72)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(201, 1)
        Me.GroupBox11.TabIndex = 131
        Me.GroupBox11.TabStop = False
        '
        'frmDonations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 613)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.btnCreditAcct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.btnDebitAcct)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_Paymentmode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnProgrammes)
        Me.Controls.Add(Me.txtprogrammes)
        Me.Controls.Add(Me.btnLocations)
        Me.Controls.Add(Me.txtlocations)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegions)
        Me.Controls.Add(Me.txtregions)
        Me.Controls.Add(Me.btnVerticals)
        Me.Controls.Add(Me.txtverticals)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMsg1)
        Me.Controls.Add(Me.txtGroupNo)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnDonors)
        Me.Controls.Add(Me.Dgv_BPList)
        Me.Controls.Add(Me.btn_JournalEntry)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_FundType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnPDFGen)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmDonations"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hope - Donations"
        CType(Me.Dgv_BPList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnPDFGen As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_FundType As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_JournalEntry As System.Windows.Forms.Button
    Friend WithEvents Dgv_BPList As System.Windows.Forms.DataGridView
    Friend WithEvents btnDonors As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents txtGroupNo As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtverticals As System.Windows.Forms.TextBox
    Friend WithEvents btnVerticals As System.Windows.Forms.Button
    Friend WithEvents btnRegions As System.Windows.Forms.Button
    Friend WithEvents txtregions As System.Windows.Forms.TextBox
    Friend WithEvents btnProgrammes As System.Windows.Forms.Button
    Friend WithEvents txtprogrammes As System.Windows.Forms.TextBox
    Friend WithEvents btnLocations As System.Windows.Forms.Button
    Friend WithEvents txtlocations As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_Paymentmode As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnDebitAcct As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents btnCreditAcct As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Choose As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents B As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vertical As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents region As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents program As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents donorcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents donorname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
