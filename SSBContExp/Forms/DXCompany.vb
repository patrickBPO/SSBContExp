Imports System.Globalization
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Base
Imports Microsoft.Office.Interop
Public Class DXCompany

    Private Sub DXSSBCE_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'CompMaintDS.ss_company' table. You can move, or remove it, as needed.
        Me.Ss_companyTableAdapter1.Fill(Me.CompMaintDS.ss_company)
        'TODO: This line of code loads data into the 'SSCompanyDS.ss_company' table. You can move, or remove it, as needed.
        Me.Ss_companyTableAdapter.Fill(Me.SSCompanyDS.ss_company)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub CompanyMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    '{-- DevExpress Elegant way - Utilize Grid Control Gridview with Control Navigator Physically update Database Rows --}
    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Me.Ss_companyTableAdapter1.Update(Me.CompMaintDS.ss_company)
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As RowDeletedEventArgs) Handles GridView1.RowDeleted
        Me.Ss_companyTableAdapter1.Adapter.Update(CompMaintDS)
    End Sub
End Class