
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging


Public Class frmDonations

    Dim sErrdesc As String = String.Empty

    Public Sub WriteToStatusScreen(ByVal Clear As Boolean, ByVal msg As String)
        ''If Clear Then
        ''    txtStatusMsg.Text = ""
        ''End If
        ''txtStatusMsg.HideSelection = True
        ''txtStatusMsg.Text &= msg & vbCrLf
        ''txtStatusMsg.SelectAll()
        ''txtStatusMsg.ScrollToCaret()
        ''txtStatusMsg.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If Me.DocType.Text = String.Empty Then Exit Sub
        'If Me.cmbSenderEmail.Text = String.Empty Then Exit Sub


        ''If Me.txtBpCode.Text = String.Empty Then
        ''    MsgBox("Please Enter Batch No", MsgBoxStyle.Information, "MBMS PDF Generation")
        ''    Exit Sub
        ''End If

        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        WriteToStatusScreen(True, "Please wait PDF Genearation in progress ...")
        ' Me.Button1.Enabled = Not Me.Button1.Enabled
        '' Call btnPDFGen_Click(Me, New System.EventArgs)
        ' Me.Button1.Enabled = Not Me.Button1.Enabled
        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmPDFGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''   oCompany = New SAPbobsCOM.Company
        '------------  Selecting the Document Type and set Select as default
        cmb_FundType.SelectedIndex = 0
        cmb_Paymentmode.SelectedIndex = 0
        '' Give3dLook()
        '-------------------------------------------------------------------


        'If Get_CompanyList(sErrdesc) <> RTN_SUCCESS Then Throw New ArgumentException(sErrdesc)
        '' If Get_BPGroupList(sErrdesc) <> RTN_SUCCESS Then Throw New ArgumentException(sErrdesc)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_JournalEntry.Click

        Dim bCheck As Boolean = False
        Dim sReceiptno As String = String.Empty
        Dim sReceiptDate As String = String.Empty
        Dim dAmount As String = String.Empty
        Dim dDate As String = String.Empty
        Dim sNarration As String = String.Empty
        Dim sDebitAccount As String = String.Empty
        Dim sCreditAccount As String = String.Empty
        Dim sChequeno As String = String.Empty
        Dim sLocation As String = String.Empty
        Dim sDName As String = String.Empty
        Dim sID As String = String.Empty
        Dim svertical As String = String.Empty
        Dim sregion As String = String.Empty
        Dim sprogram As String = String.Empty
        Dim sdonorcode As String = String.Empty
        Dim sdonorname As String = String.Empty


        Try

            If Me.cmb_FundType.Text = "--Choose--" Then
                MsgBox("Fund Type Should not be Blank ......!  ", MsgBoxStyle.Information, "Hope")
                Exit Sub
            End If

            If Me.cmb_Paymentmode.Text = "--Choose--" Then
                MsgBox("Payment Mode Should not be Blank ......!  ", MsgBoxStyle.Information, "Hope")
                Exit Sub
            End If

            If String.IsNullOrEmpty(txtregions.Text.Trim()) Then
                MsgBox("Region Should not be Blank ......!  ", MsgBoxStyle.Information, "Hope")
                Exit Sub
            End If

            If String.IsNullOrEmpty(TextBox5.Text.Trim()) Then
                MsgBox("Debit Account Should not be Blank ......!  ", MsgBoxStyle.Information, "Hope")
                Exit Sub
            End If

            If String.IsNullOrEmpty(TextBox6.Text.Trim()) Then
                MsgBox("Credit Account Should not be Blank ......!  ", MsgBoxStyle.Information, "Hope")
                Exit Sub
            End If

            For imjs As Integer = 0 To Dgv_BPList.Rows.Count - 1
                If Convert.ToBoolean(Dgv_BPList.Rows(imjs).Cells(0).Value) = True Then
                    bCheck = True
                End If
            Next imjs

            If bCheck = False Then
                MsgBox("Choose the Donors ....")
            End If

            lblMsg1.Text = "Please Wait ... "
            Me.Refresh()

            p_oCompanyLC = New SAPbobsCOM.Company
            p_oCompanyCON = New SAPbobsCOM.Company

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Me.btn_JournalEntry.Enabled = Not Me.btn_JournalEntry.Enabled

            lblMsg1.Text = "Connecting to the LC Entity " & p_oCompDef.sSAPDBNameLC
            Me.Refresh()

            If ConnectToTargetCompany(p_oCompanyLC, p_oCompDef.sSAPDBNameLC, sErrdesc) <> RTN_SUCCESS Then
                MsgBox("Error While Connecting LC Entity " & sErrdesc)
                Exit Sub
            End If

            lblMsg1.Text = "Successfully Connected ...."
            Me.Refresh()

            lblMsg1.Text = "Connecting to the Consolidation Entity " & p_oCompDef.sSAPDBNameCON
            Me.Refresh()

            If ConnectToTargetCompany(p_oCompanyCON, p_oCompDef.sSAPDBNameCON, sErrdesc) <> RTN_SUCCESS Then
                MsgBox("Error While Connecting Consolidation Entity " & sErrdesc)
                Exit Sub
            End If
            lblMsg1.Text = "Successfully Connected ...."
            Me.Refresh()
            sCreditAccount = TextBox6.Text.Trim()
            sDebitAccount = TextBox5.Text.Trim()

            For imjs As Integer = 0 To Dgv_BPList.Rows.Count - 1
                If Convert.ToBoolean(Dgv_BPList.Rows(imjs).Cells(0).Value) = True Then
                    sReceiptno = Dgv_BPList.Rows(imjs).Cells(1).Value
                    sReceiptDate = Dgv_BPList.Rows(imjs).Cells(2).Value
                    dAmount = Dgv_BPList.Rows(imjs).Cells(4).Value
                    dDate = Dgv_BPList.Rows(imjs).Cells(6).Value
                    sNarration = Dgv_BPList.Rows(imjs).Cells(8).Value
                    sChequeno = Dgv_BPList.Rows(imjs).Cells(5).Value
                    svertical = Dgv_BPList.Rows(imjs).Cells(11).Value
                    sregion = Dgv_BPList.Rows(imjs).Cells(12).Value
                    sLocation = Dgv_BPList.Rows(imjs).Cells(13).Value
                    sprogram = Dgv_BPList.Rows(imjs).Cells(14).Value
                    '' sdonorcode = Dgv_BPList.Rows(imjs).Cells(15).Value
                    sdonorname = Dgv_BPList.Rows(imjs).Cells(16).Value

                    lblMsg1.Text = "Processing for Receipt No. " & sReceiptno
                    Dgv_BPList.Rows(imjs).Cells(9).Value = "Processing ... "
                    Me.Refresh()

                    If p_oCompanyLC.InTransaction = False Then
                        p_oCompanyLC.StartTransaction()
                    End If
                    If p_oCompanyCON.InTransaction = False Then
                        p_oCompanyCON.StartTransaction()
                    End If

                    lblMsg1.Text = "Attempting Journal Entry for LC Entity  " & sReceiptno
                    Dgv_BPList.Rows(imjs).Cells(9).Value = "Attempting Journal Entry for LC Entity "
                    Me.Refresh()

                    If JournalEntry_PostingLC(p_oCompanyLC, sReceiptDate, sReceiptno, dAmount, dDate, sNarration, sDebitAccount, sCreditAccount, sChequeno, sLocation, _
                                               sDName, svertical, sregion, sprogram, sdonorcode, sdonorname, sErrdesc) <> RTN_SUCCESS Then
                        If Not p_oCompanyLC Is Nothing Then
                            If p_oCompanyLC.Connected = True Then
                                If p_oCompanyLC.InTransaction = True Then
                                    If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Rollback transaction on company database " & p_oCompanyLC.CompanyDB, "")
                                    p_oCompanyLC.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                End If
                            End If
                        End If
                        Dgv_BPList.Rows(imjs).Cells(9).Value = "Error : While Posting JE in the LC Entity " & sErrdesc
                        lblMsg1.Text = "Error : While Posting JE in the LC Entity " & sErrdesc
                        Me.Refresh()

                    Else
                        lblMsg1.Text = "Attempting Journal Entry for Consolidation Entity"
                        Dgv_BPList.Rows(imjs).Cells(9).Value = "Attempting Journal Entry for Consolidation Entity "
                        Me.Refresh()

                        If JournalEntry_PostingCON(p_oCompanyCON, sReceiptDate, sReceiptno, dAmount, dDate, sNarration, sDebitAccount, sCreditAccount, sChequeno, sLocation, _
                                              sDName, svertical, sregion, sprogram, sdonorcode, sdonorname, sErrdesc) <> RTN_SUCCESS Then
                            If Not p_oCompanyLC Is Nothing Then
                                If p_oCompanyLC.Connected = True Then
                                    If p_oCompanyLC.InTransaction = True Then
                                        If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Rollback transaction on company database " & p_oCompanyLC.CompanyDB, "")
                                        p_oCompanyLC.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                    End If
                                End If
                            End If
                            If Not p_oCompanyCON Is Nothing Then
                                If p_oCompanyCON.Connected = True Then
                                    If p_oCompanyCON.InTransaction = True Then
                                        If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Rollback transaction on company database " & p_oCompanyCON.CompanyDB, "")
                                        p_oCompanyCON.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_RollBack)
                                    End If
                                End If
                            End If

                            Dgv_BPList.Rows(imjs).Cells(9).Value = "Error : While Posting JE in the Consolidation Entity " & sErrdesc
                            lblMsg1.Text = "Error : While Posting JE in the Consolidation Entity " & sErrdesc
                            Me.Refresh()

                        Else
                            If Not p_oCompanyLC Is Nothing Then
                                If p_oCompanyLC.Connected = True Then
                                    If p_oCompanyLC.InTransaction = True Then
                                        If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Commit transaction on company database " & p_oCompanyLC.CompanyDB, "")
                                        p_oCompanyLC.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                    End If
                                End If
                            End If
                            If Not p_oCompanyCON Is Nothing Then
                                If p_oCompanyCON.Connected = True Then
                                    If p_oCompanyCON.InTransaction = True Then
                                        If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Commit transaction on company database " & p_oCompanyCON.CompanyDB, "")
                                        p_oCompanyCON.EndTransaction(SAPbobsCOM.BoWfTransOpt.wf_Commit)
                                    End If
                                End If
                            End If
                            sID += "'" & Dgv_BPList.Rows(imjs).Cells(10).Value & "',"
                            Dgv_BPList.Rows(imjs).Cells(9).Value = "Success :  Journal Entry Posting Successfully created .... !"
                            lblMsg1.Text = "Success :  Journal Entry Posting Successfully created .... !"
                            Me.Refresh()
                        End If
                    End If
                End If

            Next

            sID = Microsoft.VisualBasic.Left(sID, sID.Length - 1)

            Dim scondition = String.Empty
            If cmb_Paymentmode.Text.ToLower.Trim() = "bank" Then
                scondition = "AND  lcase( `payment_mode`) <> 'cash'"
            Else
                scondition = "AND  lcase( `payment_mode`) = 'cash'"
            End If

            Dim query = "UPDATE `purple_employee_donation_receipts` SET `status`= 'SUCCESS' WHERE `status` = 'OPEN' AND `region` = '" & txtregions.Text.Trim() & "' AND lcase( `fcra_local`) = '" & cmb_FundType.Text.ToLower.Trim() & "' AND `id` in (" & sID & ") " & scondition & ""

            ExecuteMYSQLNONEXEC(query)
            '' btnShow_Click(sender, e)


        Catch ex As Exception
            Me.btn_JournalEntry.Enabled = Not Me.btn_JournalEntry.Enabled
        End Try


    End Sub

    ''Private Sub Bt_CFL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    Dim sErrdesc As String = String.Empty
    ''    If Not Me.SCompany.Text = "--Select Company-- " Then
    ''        If Customer_CFL("3", Me.SCompany.Text, sErrdesc) <> RTN_SUCCESS Then
    ''            Throw New ArgumentException(sErrdesc)
    ''        End If
    ''    End If
    ''End Sub

    ''Private Sub Bt_CFL2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    Dim sErrdesc As String = String.Empty
    ''    If Not Me.SCompany.Text = "--Select Company-- " Then
    ''        If Customer_CFL("1", Me.SCompany.Text, sErrdesc) <> RTN_SUCCESS Then Throw New ArgumentException(sErrdesc)
    ''    End If

    ''End Sub

    '' ''Private Sub Bt_CFL3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '' ''    Dim sErrdesc As String = String.Empty
    '' ''    If Not Me.SCompany.Text = "--Select Company-- " Then
    '' ''        If Customer_CFL("2", Me.SCompany.Text, sErrdesc) <> RTN_SUCCESS Then Throw New ArgumentException(sErrdesc)
    '' ''    End If
    '' ''End Sub


    ''Private Sub SCompany_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SCompany.SelectedIndexChanged
    ''    Dim sErrdesc As String = String.Empty
    ''    Try
    ''        If Me.SCompany.Text <> "--Select Company-- " Then
    ''            If Get_BPGroupList(sErrdesc, Me.SCompany.Text) <> RTN_SUCCESS Then Throw New ArgumentException(sErrdesc)
    ''        End If

    ''    Catch ex As Exception
    ''        Eadvice_F.ToolStripStatusLabel1.Text = sErrdesc
    ''    End Try

    ''End Sub

    Private Sub btnGroup_Click(sender As System.Object, e As System.EventArgs) Handles btnDonors.Click
        ''Dim ssql As String = "SELECT T0.[ItemCode], T0.[ItemName] FROM " & sCompanyName & " ..OITM T0"

        Dim ssql As String = "SELECT T0.[Code], T0.[U_DCode], T0.[U_Dname], T0.[U_Procode], T0.[U_Proname] FROM " & sCompanyName & " ..[@DONPRG]  T0 where T0.[U_Procode] ='" & txtprogrammes.Text.Trim() & "'"
        Dim oCFL = New CFL(ssql, "6")
        oCFL.ShowDialog()
        txtGroupNo.Text = sCFL
    End Sub

    Private Sub btnShow_Click(sender As System.Object, e As System.EventArgs) Handles btnShow.Click
        ''ConnectDatabase()
        Dim FundType As String = String.Empty
        Dim PaymentMode As String = String.Empty
        Dim Verticals As String = String.Empty
        Dim Regions As String = String.Empty
        Dim Locations As String = String.Empty
        Dim Programmes As String = String.Empty
        Dim Donors As String = String.Empty
        Dim DAccount As String = String.Empty
        Dim CAccount As String = String.Empty

        If Me.cmb_FundType.Text = "--Choose--" Then
            MsgBox("Choose Fund Type ......!  ", MsgBoxStyle.Information, "Hope")
            FundType = ""
            Exit Sub
        Else
            FundType = Me.cmb_FundType.Text
        End If

        If Me.cmb_Paymentmode.Text = "--Choose--" Then
            MsgBox("Choose Payment Mode ......!  ", MsgBoxStyle.Information, "Hope")
            PaymentMode = ""
            Exit Sub
        Else
            PaymentMode = Me.cmb_Paymentmode.Text
        End If

        If String.IsNullOrEmpty(txtverticals.Text.Trim()) Then
            Verticals = "%"
        Else
            Verticals = txtverticals.Text.Trim()
        End If

        If String.IsNullOrEmpty(txtregions.Text.Trim()) Then
            MsgBox("Choose Region ......!  ", MsgBoxStyle.Information, "Hope")
            Regions = ""
            Exit Sub
        Else
            Regions = txtregions.Text.Trim()
        End If

        If String.IsNullOrEmpty(txtlocations.Text.Trim()) Then
            Locations = "%"
        Else
            Locations = txtlocations.Text.Trim()
        End If

        If String.IsNullOrEmpty(txtprogrammes.Text.Trim()) Then
            Programmes = "%"
        Else
            Programmes = txtprogrammes.Text.Trim()
        End If

        If String.IsNullOrEmpty(txtGroupNo.Text.Trim()) Then
            Donors = "%"
        Else
            Donors = txtGroupNo.Text.Trim()
        End If



        Dim sErrDesc As String = String.Empty
        Load_DonorReceiptList(sErrDesc, FundType, PaymentMode, Verticals, Regions, Locations, Programmes, Donors, DAccount, CAccount)


        Me.btn_JournalEntry.Enabled = True


    End Sub


    Private Function Load_DonorReceiptList(ByRef sErrDesc As String, ByVal FundType As String, ByVal PaymentMode As String _
                                           , ByVal Verticals As String, ByVal Regions As String _
                                           , ByVal Locations As String, ByVal Programmes As String, ByVal Donors As String, _
                                           ByVal DAccount As String, ByVal CAccount As String) As Long

        ' **********************************************************************************
        '   Function    :   Load_DonorReceiptList()
        '   Purpose     :   This function will provide the BP Group list 
        '               
        '   Parameters  :   ByRef sErrDesc AS String 
        '                       sErrDesc = Error Description to be returned to calling function
        '               
        '   Return      :   0 - FAILURE
        '                   1 - SUCCESS
        '   Author      :   JOHN

        ' **********************************************************************************

        Dim sFuncName As String = String.Empty
        Dim sConnection As String = String.Empty
        Dim sSQL As String = String.Empty
        Dim oDsBPList As DataTable = Nothing
        Try

            sFuncName = "Load_DonorReceiptList()"
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function", sFuncName)

            '    sSQL = "SELECT 'Y' [Choose], [id] ,[receipt_no],[receipt_date],[payment_mode],[donation_amount],[payment_type_num],[payment_type_date],[bank_id]   " & _
            '"FROM [dbo].[purple_employee_donation_receip] where  [region] like '" & Regions & "' and [location] like '" & Locations & "' and [program] like '" & Programmes & "' and [vertical] like '" & Verticals & "' and [id] <> ''"

            '      sSQL = "SELECT 'Y' [Choose], [id] ,[receipt_no],[receipt_date],[payment_mode],[donation_amount],[payment_type_num],[payment_type_date],[bank_id]   " & _
            '"FROM [dbo].[purple_employee_donation_receip] "
            ''   sSQL = "SELECT 'y' Choose, `id`,`receipt_no`,`receipt_date`,`payment_mode`,`donation_amount`,`payment_type_num`,`payment_type_date`,`bank_id` FROM `purple_employee_donation_receipts`"


            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Execute SQL" & sSQL, sFuncName)

            ''Dim query = "UPDATE `purple_employee_donation_receipts` SET `status`= 'OPEN' WHERE `region` = '" & txtregions.Text.Trim() & "' AND `location` = '" & txtlocations.Text.Trim() & "' AND `program`= '" & txtprogrammes.Text.Trim() & "' AND `vertical` = '" & txtverticals.Text.Trim() & "' AND `status` <> 'SUCCESS' "
            Dim scondition = String.Empty
            If PaymentMode.ToLower.Trim() = "bank" Then
                scondition = "AND  lcase( `payment_mode`) <> 'cash'"
            Else
                scondition = "AND  lcase( `payment_mode`) = 'cash'"
            End If


            Dim query = "UPDATE `purple_employee_donation_receipts` SET `status`= 'OPEN' WHERE `region` = '" & Regions & "' AND `status` <> 'SUCCESS' AND lcase( `fcra_local`) = '" & FundType.ToLower().Trim() & "' " & scondition & " "
            ''query = "SELECT 'y' Choose, `id`,`receipt_no`,`receipt_date`,`payment_mode`,`donation_amount`,`payment_type_num`,`payment_type_date`,`bank_id` FROM `purple_employee_donation_receipts` WHERE `region` = '" & Regions & "' AND `location` = '" & Locations & "' AND `program`= '" & programm & "' AND `vertical` = '" & Verticals & "' AND WHERE `status` = 'SUCCESS' "
            ExecuteMYSQLNONEXEC(query)

            oDsBPList = ExecuteMYSQLSQLQuery_DT(Verticals, Locations, Regions, Programmes, FundType, PaymentMode, scondition)
            Me.Dgv_BPList.Rows.Clear()
            Dim imjs As Integer
            lblMsg1.Text = String.Empty
            If oDsBPList.Rows.Count = 0 Then
                lblMsg1.Text = "No Matching Records Found ..!"
            End If

            For imjs = 0 To oDsBPList.Rows.Count - 1
                Me.Dgv_BPList.Rows.Add(1)

                '' MsgBox(oDsBPList.Tables(0).Rows(imjs)("CardCode").ToString)
                ''  Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("Choose").Selected = True
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("Choose").Value = "True"
                '' Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("Choose").Value = oDsBPList.Tables(0).Rows(imjs)("Choose").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("DRN").Value = oDsBPList.Rows(imjs)("receipt_no").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("RD").Value = oDsBPList.Rows(imjs)("receipt_date").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("PM").Value = oDsBPList.Rows(imjs)("payment_mode").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("DA").Value = oDsBPList.Rows(imjs)("donation_amount").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("CDP").Value = oDsBPList.Rows(imjs)("payment_type_num").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("D").Value = oDsBPList.Rows(imjs)("payment_type_date").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("B").Value = oDsBPList.Rows(imjs)("bank_id").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("ID").Value = oDsBPList.Rows(imjs)("id").ToString

                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("Vertical").Value = oDsBPList.Rows(imjs)("vertical").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("region").Value = oDsBPList.Rows(imjs)("region").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("location").Value = oDsBPList.Rows(imjs)("location").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("program").Value = oDsBPList.Rows(imjs)("program").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("donorcode").Value = oDsBPList.Rows(imjs)("donor_code_individual").ToString
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("donorname").Value = oDsBPList.Rows(imjs)("donor_name_individual").ToString

            Next

            Me.Dgv_BPList.AllowUserToAddRows = False
            '' Me.Dgv_BPList.Rows.RemoveAt(Dgv_BPList.Rows.Count)

            Me.Dgv_BPList.Rows(0).Cells(2).Selected = True

            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with SUCCESS", sFuncName)
            Load_DonorReceiptList = RTN_SUCCESS

        Catch ex As Exception
            WriteToLogFile(ex.Message, sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR", sFuncName)
            Load_DonorReceiptList = RTN_ERROR
        End Try
    End Function

    'Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    If Me.CheckBox1.Checked = True Then
    '        Me.txtGroup.Clear()
    '        Me.txtGroup.Enabled = False
    '        Me.btnDonors.Enabled = False
    '    Else
    '        Me.txtGroup.Enabled = True
    '        Me.btnDonors.Enabled = True
    '    End If
    'End Sub

    Private Sub Dgv_BPList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_BPList.CellContentClick

        If Dgv_BPList.Columns.Item(e.ColumnIndex).Name = "Choose" And e.RowIndex = -1 Then
            Dim bflag As Boolean = False
            If Convert.ToBoolean(Dgv_BPList.Rows(0).Cells(0).Value) = True Then
                bflag = False
            Else
                bflag = True
            End If

            Me.Dgv_BPList.Rows(0).Cells(2).Selected = True
            For imjs As Integer = 0 To Me.Dgv_BPList.Rows.Count - 1 'oDsBPList.Tables(0).Rows.Count - 1
                Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("Choose").Value = bflag  'oDsBPList.Tables(0).Rows(imjs)("Check").ToString
            Next
            Me.Dgv_BPList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            'CheckBox1.Focus()

            ''Me.Dgv_BPList.Rows(1).Cells(0).Selected = True
            'Me.Dgv_BPList.Rows(1).Cells(0). = True
            '' Me.Dgv_BPList.Rows.Add(1)
            '' MsgBox(oDsBPList.Tables(0).Rows(imjs)("CardCode").ToString)
            ''Dim sSQL As String = String.Empty
            ''Dim oDsBPList As DataSet = Nothing
            ''Dim sGroupCode As String = String.Empty

            ''If Me.CheckBox1.Checked = True Then
            ''    sGroupCode = "%"
            ''Else
            ''    sGroupCode = Me.txtGroup.Text
            ''End If

            ''If Convert.ToBoolean(Dgv_BPList.Rows(0).Cells(0).Value) = True Then
            ''    sSQL = "SELECT 'False' ""Check"", T0.""CardCode"", T0.""CardName"",T0.""E_Mail"", T0.""U_AI_EMAILSOA"" from " & """" & Me.SCompany.Text & """" & ".OCRD T0 " & _
            ''              " WHERE T0.""frozenFor"" ='N' AND T0.""GroupCode"" like '" & sGroupCode & "'"
            ''Else
            ''    sSQL = "SELECT 'True' ""Check"",T0.""CardCode"", T0.""CardName"",T0.""E_Mail"", T0.""U_AI_EMAILSOA"" from " & """" & Me.SCompany.Text & """" & ".OCRD T0 " & _
            ''              " WHERE T0.""frozenFor"" ='N' AND T0.""GroupCode"" like '" & sGroupCode & "'"
            ''End If

            ''Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("CardCode").Value = oDsBPList.Tables(0).Rows(imjs)("CardCode").ToString
            ''Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("CardName").Value = oDsBPList.Tables(0).Rows(imjs)("CardName").ToString
            ''Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("Email").Value = oDsBPList.Tables(0).Rows(imjs)("E_Mail").ToString
            ''Me.Dgv_BPList.Rows.Item(imjs).Cells.Item("SendEmail").Value = oDsBPList.Tables(0).Rows(imjs)("U_AI_EMAILSOA").ToString

            ''oDsBPList = ExecuteSQLQuery(sSQL)
            '' Me.Dgv_BPList.Rows.Clear()


        End If
    End Sub


    Private Sub Give3dLook()
        btnVerticals.FlatStyle = FlatStyle.Flat
        btnVerticals.FlatAppearance.BorderSize = 0
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(0, 0, btnVerticals.Width - 2, btnVerticals.Height - 2)
        btnVerticals.Region = New Region(grPath)


        Dim newbitmap As Bitmap
        newbitmap = New Bitmap(btnVerticals.Width, btnVerticals.Height, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(newbitmap)

        Dim brish As LinearGradientBrush
        Dim rect As New Rectangle(0, 0, btnVerticals.Width, btnVerticals.Height)
        brish = New LinearGradientBrush(rect, Color.FromArgb(134, 179, 209), Color.FromArgb(127, 151, 173), LinearGradientMode.Vertical)
        g.FillEllipse(brish, New Rectangle(0, 0, btnVerticals.Width, btnVerticals.Height))


        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, btnVerticals.Width, btnVerticals.Height)
        Dim pthGrBrush As New PathGradientBrush(path)
        pthGrBrush.CenterColor = Color.White

        Dim colors As Color() = {Color.FromArgb(134, 179, 209)}
        pthGrBrush.SurroundColors = colors
        g.FillEllipse(pthGrBrush, New Rectangle(6, 0, btnVerticals.Width - 12, btnVerticals.Height - 5))

        btnVerticals.BackgroundImage = newbitmap
    End Sub

    Private Sub btnVerticals_Click(sender As System.Object, e As System.EventArgs) Handles btnVerticals.Click
        ''Dim ssql As String = "SELECT T0.""GroupCode"",T0.""GroupName"" FROM " & """" & sCompanyName & """" & " .OCRG T0 WHERE T0.""GroupType"" = 'C'"
        Dim ssql As String = "SELECT T0.[PrjCode], T0.[PrjName] FROM " & sCompanyName & " ..OPRJ T0"
        Dim oCFL = New CFL(ssql, "1")
        oCFL.ShowDialog()
        txtverticals.Text = sCFL
        ''txtGroupNo.Text = sCFL1
    End Sub

    Private Sub btnRegions_Click(sender As System.Object, e As System.EventArgs) Handles btnRegions.Click
        ''  Dim ssql As String = "SELECT T0.[ItemCode], T0.[ItemName] FROM " & sCompanyName & " ..OITM T0"
        Dim ssql As String = "SELECT *  FROM " & sCompanyName & " ..[@REGION]  T0 WHERE Code IS NOT NULL"
        Dim oCFL = New CFL(ssql, "2")
        oCFL.ShowDialog()
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        txtregions.Text = sCFL
    End Sub

    Private Sub btnLocations_Click(sender As System.Object, e As System.EventArgs) Handles btnLocations.Click
        ''Dim ssql As String = "SELECT T0.[ItemCode], T0.[ItemName] FROM " & sCompanyName & " ..OITM T0"

        Dim ssql As String = "SELECT T0.[Code], T0.[Location], T0.[County] FROM " & sCompanyName & " ..OLCT T0 where county ='" & txtregions.Text.Trim() & "'"
        Dim oCFL = New CFL(ssql, "3")
        oCFL.ShowDialog()
        txtlocations.Text = sCFL
    End Sub

    Private Sub btnProgrammes_Click(sender As System.Object, e As System.EventArgs) Handles btnProgrammes.Click
        ''  Dim ssql As String = "SELECT T0.[ItemCode], T0.[ItemName] FROM " & sCompanyName & " ..OITM T0"
        Dim ssql As String = "SELECT T0.[Code], T0.[Name], T0.[U_PROGNAM], T0.[U_Regcode], T0.[U_Regname] FROM " & sCompanyName & " ..[@PROGRAM]  T0 where t0.U_regcode ='" & txtregions.Text.Trim() & "' "
        Dim oCFL = New CFL(ssql, "4")
        oCFL.ShowDialog()
        txtprogrammes.Text = sCFL
    End Sub

    Private Sub btnDebitAcct_Click(sender As System.Object, e As System.EventArgs) Handles btnDebitAcct.Click
        Dim scondition = String.Empty
        If cmb_Paymentmode.Text.ToLower.Trim() = "bank" Then
            scondition = "AND U_Acctype <> 'Cash'"
        Else
            scondition = "AND  U_Acctype = 'Cash'"
        End If
        Dim ssql As String = "SELECT T0.[AcctCode], T0.[AcctName] FROM " & sCompanyName & " ..OACT T0 WHERE T0.[Postable] = 'Y' and T0.[FrozenFor] = 'N'   " & scondition & " and T0.U_Region = '" & txtregions.Text.Trim() & "' "
        Dim oCFL = New CFL(ssql, "6")
        oCFL.ShowDialog()
        TextBox5.Text = sCFL
    End Sub

    Private Sub btnCreditAcct_Click(sender As System.Object, e As System.EventArgs) Handles btnCreditAcct.Click
        ''Dim ssql As String = "SELECT T0.[AcctCode], T0.[AcctName] FROM " & sCompanyName & " ..OACT T0 WHERE T0.[Postable] = 'Y' and T0.[FrozenFor] = 'N' and lower(T0.U_Acctype) = '" & Me.cmb_Paymentmode.Text.ToLower.Trim() & "' and T0.U_Region = '" & txtregions.Text.Trim() & "' "
        Dim ssql As String = "SELECT T0.[AcctCode], T0.[AcctName] FROM " & sCompanyName & " ..OACT T0 WHERE T0.[Postable] = 'Y' and T0.[FrozenFor] = 'N'   And GroupMask = 4 " ' and T0.U_Region = '" & txtregions.Text.Trim() & "' "
        Dim oCFL = New CFL(ssql, "7")
        oCFL.ShowDialog()
        TextBox6.Text = sCFL
    End Sub

    Private Sub cmb_Paymentmode_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_Paymentmode.SelectedIndexChanged
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
    End Sub
End Class
