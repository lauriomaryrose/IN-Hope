Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Data.Common
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.IO
Imports EASendMail
Imports MySql.Data.MySqlClient



Module modCommon

    ' Company Default Structure
    Public Structure CompanyDefault

        Public sServer As String
        Public sLicenceServer As String
        Public iServerLanguage As Integer
        Public iServerType As Integer
        Public sSAPDBNameLC As String
        Public sSAPDBNameCON As String

        Public sSAPUser As String
        Public sSAPPwd As String
        Public sDBUser As String
        Public sDBPwd As String

        Public sMYSQLServer As String
        Public sMYSQLPort As String
        Public sMYSQLSAPDBName As String
        Public sMYSQLDBUser As String
        Public sMYSQLDBPwd As String


       
        Public sLogPath As String
        Public sDebug As String

    End Structure

    ' Return Value Variable Control
    Public Const RTN_SUCCESS As Int16 = 1
    Public Const RTN_ERROR As Int16 = 0
    ' Debug Value Variable Control
    Public Const DEBUG_ON As Int16 = 1
    Public Const DEBUG_OFF As Int16 = 0

    ' Global variables group
    Public p_iDebugMode As Int16 = DEBUG_ON
    Public p_iErrDispMethod As Int16
    Public p_iDeleteDebugLog As Int16
    Public p_oCompDef As CompanyDefault
    Public p_dProcessing As DateTime
    Public p_oDtSuccess As DataTable
    Public p_oDtError As DataTable
    Public p_oDtReport As DataTable
    Public p_SyncDateTime As String
    Public p_oCompanyLC As SAPbobsCOM.Company
    Public p_oCompanyCON As SAPbobsCOM.Company

    Public oCompList As New Dictionary(Of String, String)
    Public oCompListSOA As New Dictionary(Of String, String)

    Public SOA_F As New frmDonations
    Public Eadvice_F As New frmMenu
    '' Public CFL_F As New CFL
    Public sCFL As String = String.Empty
    Public sCFL1 As String = String.Empty
    Public sCompanyName As String = String.Empty
    'Public sServer As String = System.Configuration.AppSettingsSection
  


  

    Public Function GetSystemIntializeInfo(ByRef oCompDef As CompanyDefault, ByRef sErrDesc As String) As Long

        ' **********************************************************************************
        '   Function    :   GetSystemIntializeInfo()
        '   Purpose     :   This function will be providing to proceed the initializing 
        '                   variable control during the system start-up
        '               
        '   Parameters  :   ByRef oCompDef As CompanyDefault
        '                       oCompDef =  set the Company Default structure
        '                   ByRef sErrDesc AS String 
        '                       sErrDesc = Error Description to be returned to calling function
        '               
        '   Return      :   0 - FAILURE
        '                   1 - SUCCESS
        '   Author      :   JOHN

        ' **********************************************************************************

        Dim sFuncName As String = String.Empty
        Dim sConnection As String = String.Empty
        Try

            sFuncName = "GetSystemIntializeInfo()"
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function", sFuncName)

            oCompDef.sSAPDBNameLC = String.Empty
            oCompDef.sServer = String.Empty
            oCompDef.iServerLanguage = 3
            oCompDef.iServerType = 7            ' 6 = SQL 2008, 7 = 2012, 9 = HANA
            oCompDef.sSAPUser = String.Empty
            oCompDef.sSAPPwd = String.Empty

            oCompDef.sLogPath = String.Empty
            oCompDef.sDebug = String.Empty


            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("Server")) Then
                oCompDef.sServer = ConfigurationManager.AppSettings("Server")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("LicenceServer")) Then
                oCompDef.sLicenceServer = ConfigurationManager.AppSettings("LicenceServer")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("SAPDBNameLC")) Then
                oCompDef.sSAPDBNameLC = ConfigurationManager.AppSettings("SAPDBNameLC")
            End If
            sCompanyName = oCompDef.sSAPDBNameLC
            '' oCompDef.sSAPDBName = ""

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("SAPDBNameCON")) Then
                oCompDef.sSAPDBNameCON = ConfigurationManager.AppSettings("SAPDBNameCON")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("SAPUserName")) Then
                oCompDef.sSAPUser = ConfigurationManager.AppSettings("SAPUserName")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("SAPPassword")) Then
                oCompDef.sSAPPwd = ConfigurationManager.AppSettings("SAPPassword")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("DBUser")) Then
                oCompDef.sDBUser = ConfigurationManager.AppSettings("DBUser")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("DBPwd")) Then
                oCompDef.sDBPwd = ConfigurationManager.AppSettings("DBPwd")
            End If


            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("LogPath")) Then
                oCompDef.sLogPath = IO.Directory.GetCurrentDirectory
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("Debug")) Then
                oCompDef.sDebug = ConfigurationManager.AppSettings("Debug")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("ServerType")) Then
                oCompDef.iServerType = ConfigurationManager.AppSettings("ServerType")
            End If


            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("MSQLServer")) Then
                oCompDef.sMYSQLServer = ConfigurationManager.AppSettings("MSQLServer")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("MSQLPort")) Then
                oCompDef.sMYSQLPort = ConfigurationManager.AppSettings("MSQLPort")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("MSQLDBName")) Then
                oCompDef.sMYSQLSAPDBName = ConfigurationManager.AppSettings("MSQLDBName")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("MSQLDBUser")) Then
                oCompDef.sMYSQLDBUser = ConfigurationManager.AppSettings("MSQLDBUser")
            End If

            If Not String.IsNullOrEmpty(ConfigurationManager.AppSettings("MSQLDBPwd")) Then
                oCompDef.sMYSQLDBPwd = ConfigurationManager.AppSettings("MSQLDBPwd")
            End If

            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with SUCCESS", sFuncName)
            GetSystemIntializeInfo = RTN_SUCCESS

        Catch ex As Exception
            WriteToLogFile(ex.Message, sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR", sFuncName)
            GetSystemIntializeInfo = RTN_ERROR
        End Try
    End Function

    Public Function ExecuteSQLNonQuery(ByVal sQuery As String) As Integer

        '**************************************************************
        ' Function      : ExecuteQuery
        ' Purpose       : Execute SQL
        ' Parameters    : ByVal sSQL - string command Text
        ' Author        : Sri
        ' Date          : Nov 2013
        ' Change        :
        '**************************************************************

        Dim sFuncName As String = String.Empty
        ' Dim sConstr As String = "SERVERNODE={" & p_oCompDef.sServer & "};DSN=" & p_oCompDef.sDSN & ";UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & ";"
        Dim sConstr As String = "DRIVER={HDBODBC32};UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & ";SERVERNODE=" & p_oCompDef.sServer & ";CS=" & p_oCompDef.sSAPDBNameLC
        Dim oCon As New Odbc.OdbcConnection(sConstr)
        Dim oCmd As New Odbc.OdbcCommand
        Dim oDs As New DataSet
        Try
            sFuncName = "ExecuteSQLNonQuery()"
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Fucntion...", sFuncName)

            oCmd.CommandType = CommandType.Text
            oCmd.CommandText = sQuery
            oCmd.Connection = oCon
            If oCon.State = ConnectionState.Closed Then
                oCon.Open()
            End If
            oCmd.CommandTimeout = 0
            oCmd.ExecuteNonQuery()

            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Function Completed Successfully.", sFuncName)

        Catch ex As Exception
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function", sFuncName)
            Throw New Exception(ex.Message)
        Finally
            If Not oCon Is Nothing Then
                oCon.Close()
                oCon.Dispose()
            End If
        End Try

    End Function

    Public Sub FrmSOA_Show()
        Try
            Dim bCloseApp As Boolean = False
            SOA_F = New frmDonations
            SOA_F.MdiParent = frmMenu
            SOA_F.Show()
            bCloseApp = (SOA_F.DialogResult = DialogResult.Abort)
            SOA_F = Nothing

            If bCloseApp Then Application.Exit()

        Catch ex As Exception

        End Try
    End Sub

    Public Function ConnectToTargetCompany(ByRef oCompany As SAPbobsCOM.Company, ByVal sEntity As String, _
                                                                             ByRef sErrDesc As String) As Long

        ' **********************************************************************************
        '   Function    :   ConnectToTargetCompany()
        '   Purpose     :   This function will be providing to proceed the connectivity of 
        '                   using SAP DIAPI function
        '               
        '   Parameters  :   ByRef oCompany As SAPbobsCOM.Company
        '                       oCompany =  set the SAP DI Company Object
        '                   ByRef sErrDesc AS String 
        '                       sErrDesc = Error Description to be returned to calling function
        '               
        '   Return      :   0 - FAILURE
        '                   1 - SUCCESS
        '   Author      :   JOHN
        '  
        ' **********************************************************************************

        Dim sFuncName As String = String.Empty
        Dim iRetValue As Integer = -1
        Dim iErrCode As Integer = -1
        Dim sSQL As String = String.Empty
        Dim oDs As New DataSet

        Try
            sFuncName = "ConnectToTargetCompany()"
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting function", sFuncName)


            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Initializing the Company Object", sFuncName)

            oCompany = New SAPbobsCOM.Company

            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Assigning the representing database name", sFuncName)
            ''  Dim sConstr As String = "Data Source=" & p_oCompDef.sServer & ";Initial Catalog=" & p_oCompDef.sSAPDBName & ";User ID=" & p_oCompDef.sDBUser & "; Password=" & p_oCompDef.sDBPwd
            oCompany.Server = p_oCompDef.sServer
            Select Case p_oCompDef.iServerType
                Case "2008"
                    oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
                Case "2012"
                    oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012
                Case "2014"
                    oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2014
                    'Case "2016"
                    '    oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016
            End Select

            oCompany.LicenseServer = p_oCompDef.sLicenceServer  '"96B1" '
            oCompany.CompanyDB = sEntity '' p_oCompDef.sSAPDBNameLC
            oCompany.UserName = p_oCompDef.sSAPUser
            oCompany.Password = p_oCompDef.sSAPPwd
            oCompany.DbUserName = p_oCompDef.sDBUser
            oCompany.DbPassword = p_oCompDef.sDBPwd
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
            oCompany.UseTrusted = False
            ' oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Connecting to the Company Database. " & p_oCompDef.sSAPDBNameLC, sFuncName)
            iRetValue = oCompany.Connect()
            If iRetValue <> 0 Then
                oCompany.GetLastError(iErrCode, sErrDesc)

                sErrDesc = String.Format("Connection to Database ({0}) {1} {2} {3}", _
                    oCompany.CompanyDB, System.Environment.NewLine, _
                                vbTab, sErrDesc)

                Throw New ArgumentException(sErrDesc)
            End If


            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with SUCCESS", sFuncName)
            Console.WriteLine("Completed with SUCCESS ", sFuncName)
            ConnectToTargetCompany = RTN_SUCCESS
        Catch ex As Exception
            sErrDesc = ex.Message
            Call WriteToLogFile(ex.Message, sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR", sFuncName)
            Console.WriteLine("Completed with ERROR ", sFuncName)
            ConnectToTargetCompany = RTN_ERROR
        End Try
    End Function


    Public Function ExecuteMYSQLSQLQuery_DT(ByVal verticals As String, ByVal locations As String, ByVal regions As String, ByVal programm As String, ByVal FundType As String, ByVal PaymentMode As String, ByVal scondition As String) As DataTable

        '**************************************************************
        ' Function      : ExecuteMYSQLSQLQuery_DT
        ' Purpose       : Execute SQL
        ' Parameters    : ByVal sSQL - string command Text
        ' Author        : JOHN
        ' Change        :
        '**************************************************************

        Dim MysqlConn As New MySqlConnection()
        Dim MySqlDataAdapter As MySqlDataAdapter()
        Dim sFuncName
        Dim query As String = String.Empty



        Try
            sFuncName = "ExecuteMYSQLSQLQuery_DT()"
            ' Console.WriteLine("Starting Function.. ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function...", sFuncName)
            'oCon.ConnectionString = "DRIVER={HDBODBC};UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & " ;SERVERNODE=" & p_oCompDef.sServer & ";CS=" & p_oCompDef.sSAPDBName & ""
            ' oCon.ConnectionString = "DRIVER={HDBODBC32};UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & ";SERVERNODE=" & p_oCompDef.sServer & ";CS=" & p_oCompDef.sSAPDBName""

            MysqlConn.ConnectionString = "Server=" & p_oCompDef.sMYSQLServer & ";Database=" & p_oCompDef.sMYSQLSAPDBName & ";Uid=" & p_oCompDef.sMYSQLDBUser & ";Password=" & p_oCompDef.sMYSQLDBPwd & ";"


            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If
            MysqlConn.Open()

            ''query = "SELECT 'y' Choose, `id`,`receipt_no`,`receipt_date`,`payment_mode`,`donation_amount`,`payment_type_num`,`payment_type_date`,`bank_id` FROM `purple_employee_donation_receipts` WHERE `region` = '" & regions & "' AND `location` = '" & locations & "' AND `program`= '" & programm & "' AND `vertical` = '" & verticals & "' AND  `status` = 'OPEN' "
            query = "SELECT 'y' Choose, `id`,`receipt_no`,`receipt_date`,`payment_mode`,`donation_amount`,`payment_type_num`,`payment_type_date`,`bank_id` , `vertical`, `region`, `location`, `program`, `donor_code_individual`, `donor_name_individual` FROM `purple_employee_donation_receipts` WHERE `region` = '" & regions & "' AND `status` = 'OPEN'  AND lcase( `fcra_local`) = '" & FundType.ToLower().Trim() & "' " & scondition & " "
            Dim SqlCommand As New MySqlCommand(query, MysqlConn)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(SqlCommand)
            Dim dt As New DataTable("Donors")
            da.Fill(dt)
            '  Console.WriteLine("Completed Successfully. ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed Successfully.", sFuncName)
            MysqlConn.Close()
            ExecuteMYSQLSQLQuery_DT = dt
        Catch ex As Exception
            ExecuteMYSQLSQLQuery_DT = Nothing
            WriteToLogFile(ex.Message, sFuncName)
            Console.WriteLine("Completed with ERROR ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR", sFuncName)
            Throw New Exception(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Function

    Public Function ExecuteMYSQLNONEXEC(ByVal QUERY As String)

        '**************************************************************
        ' Function      : ExecuteMYSQLSQLQuery_DT
        ' Purpose       : Execute SQL
        ' Parameters    : ByVal sSQL - string command Text
        ' Author        : JOHN
        ' Change        :
        '**************************************************************

        Dim MysqlConn As New MySqlConnection()
        Dim MySqlDataAdapter As MySqlDataAdapter()
        Dim sFuncName

        Try
            sFuncName = "ExecuteMYSQLNONEXEC()"
            ' Console.WriteLine("Starting Function.. ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function...", sFuncName)
            'oCon.ConnectionString = "DRIVER={HDBODBC};UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & " ;SERVERNODE=" & p_oCompDef.sServer & ";CS=" & p_oCompDef.sSAPDBName & ""
            ' oCon.ConnectionString = "DRIVER={HDBODBC32};UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & ";SERVERNODE=" & p_oCompDef.sServer & ";CS=" & p_oCompDef.sSAPDBName""

            MysqlConn.ConnectionString = "Server=" & p_oCompDef.sMYSQLServer & ";Database=" & p_oCompDef.sMYSQLSAPDBName & ";Uid=" & p_oCompDef.sMYSQLDBUser & ";Password=" & p_oCompDef.sMYSQLDBPwd & ";"


            If MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If
            MysqlConn.Open()
            Dim SqlCommand As New MySqlCommand(QUERY, MysqlConn)
            SqlCommand.ExecuteNonQuery()

            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed Successfully.", sFuncName)
            MysqlConn.Close()

        Catch ex As Exception

            WriteToLogFile(ex.Message, sFuncName)
            Console.WriteLine("Completed with ERROR ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR", sFuncName)
            Throw New Exception(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Function


    Public Function ExecuteSQLQuery_DS(ByVal sQuery As String) As DataSet

        '**************************************************************
        ' Function      : ExecuteQuery
        ' Purpose       : Execute SQL
        ' Parameters    : ByVal sSQL - string command Text
        ' Author        : JOHN
        ' Change        :
        '**************************************************************

        Dim sConstr As String = "Data Source=" & p_oCompDef.sServer & ";Initial Catalog=" & p_oCompDef.sSAPDBNameLC & ";User ID=" & p_oCompDef.sDBUser & "; Password=" & p_oCompDef.sDBPwd

        Dim oCon As New SqlConnection(sConstr)
        Dim oCmd As New SqlCommand
        Dim oDs As New DataSet
        Dim sFuncName As String = String.Empty

        'Dim sConstr As String = "DRIVER={HDBODBC32};SERVERNODE={" & p_oCompDef.sServer & "};DSN=" & p_oCompDef.sDSN & ";UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & ";"

        Try
            sFuncName = "ExecExecuteSQLQuery_DT()"
            ' Console.WriteLine("Starting Function.. ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Starting Function...", sFuncName)
            'oCon.ConnectionString = "DRIVER={HDBODBC};UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & " ;SERVERNODE=" & p_oCompDef.sServer & ";CS=" & p_oCompDef.sSAPDBName & ""
            ' oCon.ConnectionString = "DRIVER={HDBODBC32};UID=" & p_oCompDef.sDBUser & ";PWD=" & p_oCompDef.sDBPwd & ";SERVERNODE=" & p_oCompDef.sServer & ";CS=" & p_oCompDef.sSAPDBName

            oCon.Open()
            oCmd.CommandType = CommandType.Text
            oCmd.CommandText = sQuery
            oCmd.Connection = oCon
            oCmd.CommandTimeout = 0
            Dim da As New SqlDataAdapter(oCmd)
            da.Fill(oDs)
            '  Console.WriteLine("Completed Successfully. ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed Successfully.", sFuncName)
            ExecuteSQLQuery_DS = oDs
        Catch ex As Exception
            ExecuteSQLQuery_DS = Nothing
            WriteToLogFile(ex.Message, sFuncName)
            Console.WriteLine("Completed with ERROR ", sFuncName)
            If p_iDebugMode = DEBUG_ON Then Call WriteToLogFile_Debug("Completed with ERROR", sFuncName)
            Throw New Exception(ex.Message)
        Finally
            oCon.Dispose()
        End Try

    End Function

    Public Sub ConnectDatabase()
        Dim conn As New MySqlConnection
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "DATABASE=" & p_oCompDef.sMYSQLSAPDBName & ";" _
                  & "SERVER=" & p_oCompDef.sMYSQLServer & ";user id=" & p_oCompDef.sMYSQLDBUser _
                 & ";password=" & p_oCompDef.sMYSQLDBPwd
                ''& ";port=" & _
                '        '          My.Settings.myPort &amp;amp;amp; ";charset=utf8"

                '        '        conn.ConnectionString = "server=" & txtServer.Text & ";" _

                '        '& "user id=" & txtUsername.Text & ";" _

                '        '& "password=" & txtPassword.Text & ";" _

                '        '& "database=test"


                conn.Open()
            End If

        Catch myerror As Exception
            MessageBox.Show("Error Connecting to the database", "Error Database Server", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

   



End Module
