Module modJournalEntry

    Public Function JournalEntry_PostingLC(ByRef oCompany As SAPbobsCOM.Company, _
                                     ByVal sPostingDate As String, ByVal sReceiptno As String, ByVal dAmount As Double, ByVal sDate As String, _
                                     ByVal sNarration As String, ByVal sDebitAccount As String, ByVal sCreditAccount As String, ByVal sChequeno As String, _
                                     ByVal sLocation As String, ByVal sDName As String, _
                                     ByVal svertical As String, ByVal sregion As String, ByVal sprogram As String, ByVal sdonorcode As String, ByVal sdonorname As String, _
                                     ByRef sErrDesc As String) As Long

        Dim sFuncName As String = String.Empty
        Dim ival As Integer = 0
        Dim sErr As String = String.Empty
        Dim iErr As Integer = 0
        Dim oJournalEntry As SAPbobsCOM.JournalEntries = Nothing

        Try
            sFuncName = "JournalEntry_PostingLC"
            Console.WriteLine("Starting Function ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function ", sFuncName)

            oJournalEntry = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries)
            '' oJournalEntry.Series = iseries
            ''oJournalEntry.ReferenceDate = DateTime.ParseExact(sPostingDate, "yyyyMMdd", Nothing)
            oJournalEntry.ReferenceDate = DateTime.ParseExact(sPostingDate, "dd-MM-yyyy HH:mm:ss", Nothing)
            oJournalEntry.Memo = "Payment for Receipt no. " & sReceiptno
            If (Not String.IsNullOrEmpty(sChequeno)) Then
                oJournalEntry.UserFields.Fields.Item("U_Chqno").Value = sChequeno
            End If

            If (Not String.IsNullOrEmpty(sNarration)) Then
                oJournalEntry.UserFields.Fields.Item("U_Narration").Value = sNarration
            End If

            If (Not String.IsNullOrEmpty(sReceiptno)) Then
                oJournalEntry.UserFields.Fields.Item("U_InRef").Value = sReceiptno
            End If


            oJournalEntry.Lines.AccountCode = sDebitAccount
            oJournalEntry.Lines.Debit = CDbl(dAmount)
            oJournalEntry.Lines.Credit = 0

            If (Not String.IsNullOrEmpty(svertical)) Then
                oJournalEntry.Lines.ProjectCode = svertical
            End If

            If (Not String.IsNullOrEmpty(sregion)) Then
                oJournalEntry.Lines.Reference1 = sregion
            End If

            If (Not String.IsNullOrEmpty(sLocation)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Location").Value = sLocation
            End If

            If (Not String.IsNullOrEmpty(sprogram)) Then
                oJournalEntry.Lines.Reference2 = sprogram
            End If

            If (Not String.IsNullOrEmpty(sdonorcode)) Then
                oJournalEntry.Lines.AdditionalReference = sdonorcode
            End If

            If (Not String.IsNullOrEmpty(sDName)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Dname").Value = sdonorname
            End If

            If (Not String.IsNullOrEmpty(sReceiptno)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_InRef").Value = sReceiptno
            End If

            oJournalEntry.Lines.Add()
            oJournalEntry.Lines.AccountCode = sCreditAccount
            oJournalEntry.Lines.Debit = 0
            oJournalEntry.Lines.Credit = CDbl(dAmount)


            oJournalEntry.Lines.LineMemo = "Payment for Receipt no. " & sReceiptno
            ''  oJournalEntry.Lines.TaxDate = drv(1)
            '' If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Tax Date  " & Format(drv(1), "yyyyMMdd"), sFuncName)
         
            If (Not String.IsNullOrEmpty(svertical)) Then
                oJournalEntry.Lines.ProjectCode = svertical
            End If

            If (Not String.IsNullOrEmpty(sregion)) Then
                oJournalEntry.Lines.Reference1 = sregion
            End If

            If (Not String.IsNullOrEmpty(sLocation)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Location").Value = sLocation
            End If

            If (Not String.IsNullOrEmpty(sprogram)) Then
                oJournalEntry.Lines.Reference2 = sprogram
            End If

            If (Not String.IsNullOrEmpty(sdonorcode)) Then
                oJournalEntry.Lines.AdditionalReference = sdonorcode
            End If

            If (Not String.IsNullOrEmpty(sDName)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Dname").Value = sdonorname
            End If

            If (Not String.IsNullOrEmpty(sReceiptno)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_InRef").Value = sReceiptno
            End If


            '' oJournalEntry.Lines.UserFields.Fields.Item("U_LCFC").Value = ""
            oJournalEntry.Lines.Add()

            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Attempting to Add the Journal Entry", sFuncName)
            'oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
            'oJournalEntry.SaveXML(p_oCompDef.sLogPath & "\JE1.xml")
            ival = oJournalEntry.Add()

            If ival <> 0 Then

                oCompany.GetLastError(iErr, sErr)
                Call WriteToLogFile("Completed with ERROR ---" & sErr, sFuncName)
                Console.WriteLine("Completed with ERROR ", sFuncName)
                If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR " & sErr, sFuncName)
                JournalEntry_PostingLC = RTN_ERROR
                Exit Function
            End If

            Console.WriteLine("Completed with SUCCESS", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with SUCCESS ", sFuncName)


            JournalEntry_PostingLC = RTN_SUCCESS

        Catch ex As Exception

            Call WriteToLogFile(ex.Message, sFuncName)
            Console.WriteLine("Completed with ERROR ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR " & ex.Message, sFuncName)
            JournalEntry_PostingLC = RTN_ERROR
            Exit Function
        Finally
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oJournalEntry)
            oJournalEntry = Nothing
        End Try

    End Function


    Public Function JournalEntry_PostingCON(ByRef oCompany As SAPbobsCOM.Company, _
                                        ByVal sPostingDate As String, ByVal sReceiptno As String, ByVal dAmount As Double, ByVal sDate As String, _
                                        ByVal sNarration As String, ByVal sDebitAccount As String, ByVal sCreditAccount As String, ByVal sChequeno As String, _
                                        ByVal sLocation As String, ByVal sDName As String, _
                                          ByVal svertical As String, ByVal sregion As String, ByVal sprogram As String, ByVal sdonorcode As String, ByVal sdonorname As String, _
                                        ByRef sErrDesc As String) As Long

        Dim sFuncName As String = String.Empty
        Dim ival As Integer = 0
        Dim sErr As String = String.Empty
        Dim iErr As Integer = 0
        Dim oJournalEntry As SAPbobsCOM.JournalEntries = Nothing

        Try
            sFuncName = "JournalEntry_PostingCON"
            Console.WriteLine("Starting Function ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function ", sFuncName)

            oJournalEntry = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oJournalEntries)
            '' oJournalEntry.Series = iseries
            ''  oJournalEntry.ReferenceDate = DateTime.ParseExact(sPostingDate, "yyyyMMdd", Nothing)
            oJournalEntry.ReferenceDate = DateTime.ParseExact(sPostingDate, "dd-MM-yyyy HH:mm:ss", Nothing)
            oJournalEntry.Memo = "Payment for Receipt no. " & sReceiptno
            If (Not String.IsNullOrEmpty(sChequeno)) Then
                oJournalEntry.UserFields.Fields.Item("U_Chqno").Value = sChequeno
            End If

            If (Not String.IsNullOrEmpty(sNarration)) Then
                oJournalEntry.UserFields.Fields.Item("U_Narration").Value = sNarration
            End If

            If (Not String.IsNullOrEmpty(sReceiptno)) Then
                oJournalEntry.UserFields.Fields.Item("U_InRef").Value = sReceiptno
            End If


            oJournalEntry.Lines.AccountCode = sDebitAccount
            oJournalEntry.Lines.Debit = CDbl(dAmount)
            oJournalEntry.Lines.Credit = 0

            If (Not String.IsNullOrEmpty(svertical)) Then
                oJournalEntry.Lines.ProjectCode = svertical
            End If

            If (Not String.IsNullOrEmpty(sregion)) Then
                oJournalEntry.Lines.Reference1 = sregion
            End If

            If (Not String.IsNullOrEmpty(sLocation)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Location").Value = sLocation
            End If

            If (Not String.IsNullOrEmpty(sprogram)) Then
                oJournalEntry.Lines.Reference2 = sprogram
            End If


            If (Not String.IsNullOrEmpty(sdonorcode)) Then
                oJournalEntry.Lines.AdditionalReference = sdonorcode
            End If

            If (Not String.IsNullOrEmpty(sDName)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Dname").Value = sdonorname
            End If

            If (Not String.IsNullOrEmpty(sReceiptno)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_InRef").Value = sReceiptno
            End If


            oJournalEntry.Lines.Add()
            oJournalEntry.Lines.AccountCode = sCreditAccount
            oJournalEntry.Lines.Debit = 0
            oJournalEntry.Lines.Credit = CDbl(dAmount)

            oJournalEntry.Lines.LineMemo = "Payment for Receipt no. " & sReceiptno
            ''  oJournalEntry.Lines.TaxDate = drv(1)
            '' If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Tax Date  " & Format(drv(1), "yyyyMMdd"), sFuncName)



            If (Not String.IsNullOrEmpty(svertical)) Then
                oJournalEntry.Lines.ProjectCode = svertical
            End If

            If (Not String.IsNullOrEmpty(sregion)) Then
                oJournalEntry.Lines.Reference1 = sregion
            End If

            If (Not String.IsNullOrEmpty(sLocation)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Location").Value = sLocation
            End If

            If (Not String.IsNullOrEmpty(sprogram)) Then
                oJournalEntry.Lines.Reference2 = sprogram
            End If

            If (Not String.IsNullOrEmpty(sdonorcode)) Then
                oJournalEntry.Lines.AdditionalReference = sdonorcode
            End If

            If (Not String.IsNullOrEmpty(sDName)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_Dname").Value = sdonorname
            End If

            If (Not String.IsNullOrEmpty(sReceiptno)) Then
                oJournalEntry.Lines.UserFields.Fields.Item("U_InRef").Value = sReceiptno
            End If
            ''oJournalEntry.Lines.UserFields.Fields.Item("U_LCFC").Value = ""

            oJournalEntry.Lines.Add()

            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Attempting to Add the Journal Entry", sFuncName)
            'oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
            'oJournalEntry.SaveXML(p_oCompDef.sLogPath & "\JE1.xml")
            ival = oJournalEntry.Add()

            If ival <> 0 Then

                oCompany.GetLastError(iErr, sErr)
                Call WriteToLogFile("Completed with ERROR ---" & sErr, sFuncName)
                Console.WriteLine("Completed with ERROR ", sFuncName)
                If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR " & sErr, sFuncName)
                JournalEntry_PostingCON = RTN_ERROR
                Exit Function
            End If

            Console.WriteLine("Completed with SUCCESS", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with SUCCESS ", sFuncName)


            JournalEntry_PostingCON = RTN_SUCCESS

        Catch ex As Exception

            Call WriteToLogFile(ex.Message, sFuncName)
            Console.WriteLine("Completed with ERROR ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR " & ex.Message, sFuncName)
            JournalEntry_PostingCON = RTN_ERROR
            Exit Function
        Finally
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oJournalEntry)
            oJournalEntry = Nothing
        End Try

    End Function

End Module
