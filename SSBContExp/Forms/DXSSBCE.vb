Imports System.Globalization
Imports Microsoft.Office.Interop
Imports SSBContExp.WorkRegistry
Imports SSBContExp.GlobalVar
Public Class DXSSBCE
    Dim open As New OpenFileDialog
    Private Sub BtnFndFile_Click(sender As Object, e As EventArgs) Handles BtnFndFile.Click
        PBLoad.Hide()
        open.AutoUpgradeEnabled = False
        'open.Filter = "All Files|*.*"
        open.Filter = "Excel files(*.xlsx, *.xls)|*.xlsx;*.xls"
        open.ShowDialog()
        TxtFilePath.Text = open.FileName.ToString
    End Sub
    Private Function FindSSBWkNum(ByVal monthName As String, ByVal YrStr As String, ByVal WkPlace As Integer) As Integer
        'Find Week Number based on counting Mondays from the beginning
        'of the year to the specified end date
        'Monday=2 Parameters(begin date, day #)
        Dim dtCdate As String
        Dim dateNmeTmp As String
        Dim wks As Integer
        Dim wkPi As Integer ' Week place iterator
        Dim monthNum = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month

        wks = 0
        wkPi = 0

        dateNmeTmp = monthNum
        dtCdate = "01/01/" & YrStr
        Do Until Month(dtCdate) > dateNmeTmp

            If Weekday(dtCdate) = 2 Then '-- If is a Monday then add
                'dateNmeTmp = dtCdate
                wks += 1
                If Month(dtCdate) = dateNmeTmp Then
                    wkPi += 1
                    If wkPi = WkPlace Then
                        'Debug.Print(wks)
                        Return wks
                    End If
                End If
            End If
            dtCdate = DateAdd("d", 1, dtCdate) '-- Add 1 day to date
        Loop
        'MsgBox("weeks#" & wks)

        FindSSBWkNum = wks
    End Function
    Private Sub ProcExcelSheet(ByVal strSourceDoc As String)
        Dim oApp As New Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        Dim SSN As Excel.Range
        Dim SSNCnv As String
        Dim RowCnt As Excel.Range
        Dim RCnt As Integer
        Dim SSWkPay As Excel.Range
        Dim SSWkPayStr As String
        Dim SplitRCnt As String()
        Dim BusNum As Excel.Range
        Dim BusNumSpl As String()
        Dim BusNumStr As String
        Dim BusNam As Excel.Range
        Dim BusNamSpl As String()
        Dim BusNamStr As String
        Dim SSYr As Excel.Range
        Dim SSYrSpl As String()
        Dim SSYrStr As String
        Dim SSMth As Excel.Range
        Dim SSMthSpl As String()
        Dim SSMthStr As String
        Dim SSWeekNum As Integer
        Dim SSTContr As Excel.Range
        Dim SSTContrStr As String
        'Dim SSTContrStrI As String
        'Dim EmpNoR As Excel.Range
        Dim DBEmpNoStr As String
        Dim HireDteR As Excel.Range
        Dim HireDteStr As String
        Dim TermDteR As Excel.Range
        Dim TermDteStr As String
        Dim FNameR As Excel.Range
        Dim FNameStr As String
        Dim LNameR As Excel.Range
        Dim LNameStr As String
        Dim MainPath As String
        Dim TargetFile As String
        Dim PbIncFactor As Integer

        MainPath = Strings.Left(open.FileName.ToString, Len(open.FileName) - Len(open.SafeFileName))


        Dim MyFname As String = open.FileName

        oApp.Visible = False

        'oWB = oApp.Workbooks.Open(strSourceDoc,,,,, "password")
        'oSheet = oWB.ActiveSheet

        Try

            oWB = oApp.Workbooks.Open(strSourceDoc)
            oSheet = oWB.Worksheets(1)
            '{-- Get the Main Fillers
            RowCnt = oSheet.Range("A11") '- # of Employees
            SplitRCnt = Split(RowCnt.Text, ":") '- # of Employees
            RCnt = CInt(SplitRCnt(1)) '- # of Employees

            BusNum = oSheet.Range("A8") '- Business #
            BusNumSpl = Split(BusNum.Text, ":") '- Business #
            BusNumStr = BusNumSpl(1) '- Business #
            BusNam = oSheet.Range("A5") '- Business Name
            BusNamSpl = Split(BusNam.Text, "-") '- Business Name
            BusNamStr = BusNamSpl(1) '- Business Name
            'SSYr = oSheet.Range("G6") '- Year #
            SSYr = oSheet.Range("H6") '- Year # was changed from G6 to H6
            SSYrSpl = Split(SSYr.Text, "/") '- Year #
            SSYrStr = SSYrSpl(2) '- Year #

            SSMth = oSheet.Range("H6") '- Month #
            SSMthSpl = Split(SSMth.Text, "/") '- Month #
            SSMthStr = SSMthSpl(1) '- Month #
            SSMthSpl = Split(SSMthStr, ":") '- Month() #
            SSMthStr = SSMthSpl(1) '- Month #
            SSMthStr = Trim(SSMthStr.ToUpper) '- Month #

            '- Tag Business #,Month & Year as part of Converted filename
            TargetFile = BusNamStr & "_" & SSMthStr & "_" & SSYrStr & ".txt"
            Dim Myfile As System.IO.StreamWriter
            Myfile = My.Computer.FileSystem.OpenTextFileWriter(MainPath & TargetFile, True)

            PBLoad.Properties.Maximum = RCnt
            For i = 1 To RCnt ' Do for all Employees
                If i < RCnt Then

                    If i = 1 Then
                        PBLoad.Show()
                        PbIncFactor = ((i * 100) / RCnt)
                    End If
                    PBLoad.Increment(PbIncFactor)
                Else
                    PBLoad.EditValue = RCnt
                    'Timer1.Stop()
                End If

                SSN = oSheet.Rows(i).Range("B16") '-- SSN
                SSNCnv = Replace(SSN.Text, "-", "") '-- SSN

                HireDteR = oSheet.Rows(i).Range("P16") '-- Hire Date(DATE: 23-Aug-2018) -X-
                HireDteStr = HireDteR.Text

                TermDteR = oSheet.Rows(i).Range("Q16") '-- Termination Date(DATE: 23-Aug-2018) -X-
                TermDteStr = TermDteR.Text

                FNameR = oSheet.Rows(i).Range("D16") '-- First Name -X-
                FNameStr = FNameR.Text

                LNameR = oSheet.Rows(i).Range("C16") '-- Last Name -X-
                LNameStr = LNameR.Text

                For wi = 1 To 5 'Do for 5 Week iterations

                    SSWeekNum = FindSSBWkNum(SSMthStr, SSYrStr, wi)

                    SSWkPay = oSheet.Rows(i).Cells(wi).Range("E16") '-- SS Week Pay
                    SSWkPayStr = Trim(SSWkPay.Text)
                    SSTContr = oSheet.Rows(i).Cells(wi).Range("J16") '-- Total SSB Weekly Contribution
                    SSTContrStr = SSTContr.Text
                    'SSTContrStrI = SSTContrStr.Trim
                    'SSTContrStrI = Convert.ToDecimal(SSTContrStr)
                    '{----Don't forget Employer SSID Number function to query Database
                    DBEmpNoStr = CboCompany.SelectedValue
                    '------}

                    If Not (Len(SSWkPayStr) = 0) Then

                        'Debug.Print("EmpNo=" & CboCompany.SelectedValue)
                        'Debug.Print("SSN=" & SSNCnv & " Year#=" & SSYrStr & " Week#=" &
                        '  SSWeekNum & " WkPy=" & SSWkPayStr & " Mth=" & SSMthStr &
                        '  " TotCtr=" & SSTContrStr & " Hire=" & HireDteStr &
                        '  " Term=" & TermDteStr & " Fnme=" & FNameStr & " Lnme=" & LNameStr)
                        If i = RCnt And wi = 5 Then
                            Myfile.Write(SSNCnv.PadLeft(9, "0") & "|" & BusNumStr.Trim & "|" &
                                             SSYrStr.Trim & "|" & SSMthStr.Trim & "|" & SSWeekNum &
                                "|" & SSWkPayStr.Trim & "|" & SSTContrStr.Trim & "|" & DBEmpNoStr.Trim &
                                "|" & HireDteStr.Replace("/", "-").Trim & "|" & TermDteStr.Replace("/", "-").Trim &
                                "|" & FNameStr.Trim & "|" & LNameStr.Trim & "|" & "P")
                        Else
                            Myfile.WriteLine(SSNCnv.PadLeft(9, "0") & "|" & BusNumStr.Trim & "|" &
                                             SSYrStr.Trim & "|" & SSMthStr.Trim & "|" & SSWeekNum &
                                "|" & SSWkPayStr.Trim & "|" & SSTContrStr.Trim & "|" & DBEmpNoStr.Trim &
                                "|" & HireDteStr.Replace("/", "-").Trim & "|" & TermDteStr.Replace("/", "-").Trim &
                                "|" & FNameStr.Trim & "|" & LNameStr.Trim & "|" & "P")
                        End If
                        'Debug.Print("=(" & SSTContrStrI & ")")
                    End If
                Next wi
            Next i '-- Done
            Myfile.Close()
            MsgBox("File Conversion Complete", MsgBoxStyle.Information)
            oApp.Quit()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try
    End Sub

    Private Sub BtnProcFile_Click(sender As Object, e As EventArgs) Handles BtnProcFile.Click
        Call ProcExcelSheet(TxtFilePath.Text)
    End Sub

    Private Sub DXSSBCE_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Attempt to create the ODBC Connection
        'If Not CreateRegODBC() Then
        '    glbErrMesg = modErrMesg.ErrorMes(6, "F")
        '    MsgBox(glbErrMesg, vbCritical, "Connection Creation Failed")
        '    Application.Exit()
        'Else

        'TODO: This line of code loads data into the 'SSCompanyDS.ss_company' table. You can move, or remove it, as needed.
        'Me.Ss_companyTableAdapter.Fill(Me.SSCompanyDS.ss_company)
        'PBLoad.Hide()
        'End If
        'CboCompany.SelectedValue = 0
        Me.Ss_companyTableAdapter.Fill(Me.SSCompanyDS.ss_company)
        PBLoad.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CompanyMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyMaintenanceToolStripMenuItem.Click
        DXCompany.ShowDialog()
    End Sub

    Private Sub CboCompany_Click(sender As Object, e As EventArgs) Handles CboCompany.Click
        Ss_companyTableAdapter.Fill(SSCompanyDS.ss_company)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DXCompany.ShowDialog()
    End Sub
End Class