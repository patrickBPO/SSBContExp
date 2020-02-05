Imports SSBContExp.GlobalVar
Public Class WorkRegistry
    '* --Note...to manually create ODBC datasources you have to create Registry Values in:
    '   \HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\ODBC Data Sources
    '      - "ITS" Value = (MySQL ODBC 3.51 Driver)
    '   \HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\ITS
    '      - DATABASE Value = (dbkolbe)
    '      - Driver Value = (C:\Windows\SysWOW64\myodbc3.dll) or 64Bit="(C:\Windows\system32\myodbc3.dll)"
    '      - PORT Value = (3308)
    '      - PWD Value = (K0lb3@xs4db)
    '      - SERVER Value = (web) or (192.168.2.14)
    '      - UID Value = (kolbe)
    Shared Function CreateRegODBC() As Boolean
        Dim SubKyName As String
        Dim SubKyName1 As String
        'Dim kyVal As String
        Dim dbValNme As String
        Dim drvValNme As String
        Dim portValNme As String
        Dim pwdValNme As String
        Dim servValNme As String
        Dim uidValNme As String
        Dim odbcValNme As String
        Dim dbVal As String
        Dim drvVal As String
        Dim portVal As String
        Dim pwdVal As String
        Dim servVal As String
        Dim uidVal As String
        Dim odbcVal As String
        Dim regVersion As Microsoft.Win32.RegistryKey
        Dim regKey As Microsoft.Win32.RegistryKey

        'Dim getVal As String

        'SubKyName = "HKEY_CURRENT_USER\Software\Reg\" & cpuId
        'SubKyName = "HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\MYSQL_REG"
        'SubKyName1 = "HKEY_CURRENT_USER\Software\ODBC\ODBC.INI\ODBC Data Sources"
        SubKyName = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\ODBC\ODBC.INI\SSBCE"
        SubKyName1 = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\ODBC\ODBC.INI\ODBC Data Sources"
        dbValNme = "DATABASE"
        drvValNme = "Driver"
        portValNme = "PORT"
        pwdValNme = "PWD"
        servValNme = "SERVER"
        uidValNme = "UID"
        odbcValNme = "SSBCE" '- ODBC Name Parameter
        dbVal = "ssb_profile" '- Database Name Parameter *
        drvVal = "C:\Windows\sysWOW64\myodbc3.dll" '- 32-Bit Architecture
        portVal = "3306" '- Port Parameter *
        pwdVal = "SSBCE@xs4db" '- Password Parameter *
        servVal = "127.0.0.1" '- Server Name Parameter *
        uidVal = "SSBCE" '- User Name Parameter *
        odbcVal = "MySQL ODBC 3.51 Driver" '- ODBC Driver Parameter *

        Try
            'regVersion =
            'Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Reg", True)
            regVersion =
                Microsoft.Win32.Registry.LocalMachine.OpenSubKey(SubKyName, True)
            If regVersion Is Nothing Then
                'My.Computer.Registry.CurrentUser.CreateSubKey("Software\Reg\" & cpuId)
                My.Computer.Registry.CurrentUser.CreateSubKey(SubKyName)
                My.Computer.Registry.SetValue(SubKyName, dbValNme, dbVal)
                My.Computer.Registry.SetValue(SubKyName, drvValNme, drvVal)
                My.Computer.Registry.SetValue(SubKyName, portValNme, portVal)
                My.Computer.Registry.SetValue(SubKyName, pwdValNme, pwdVal)
                My.Computer.Registry.SetValue(SubKyName, servValNme, servVal)
                My.Computer.Registry.SetValue(SubKyName, uidValNme, uidVal)
                'My.Computer.Registry.CurrentUser.CreateSubKey(SubKyName1)
                regKey =
                    Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubKyName1, True)
                If regKey Is Nothing Then
                    My.Computer.Registry.CurrentUser.CreateSubKey(SubKyName1)
                    My.Computer.Registry.SetValue(SubKyName1, odbcValNme, odbcVal)
                    Return True
                Else
                    My.Computer.Registry.SetValue(SubKyName1, odbcValNme, odbcVal)
                    glbODBC = odbcValNme
                    regKey.Close()
                    Return True
                End If
                regVersion.Close()
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
