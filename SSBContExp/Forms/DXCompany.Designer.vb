Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DXCompany
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DXCompany))
        Me.SscompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSCompanyDS = New SSBContExp.SSCompanyDS()
        Me.Ss_companyTableAdapter = New SSBContExp.SSCompanyDSTableAdapters.ss_companyTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SscompanyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompMaintDS = New SSBContExp.CompMaintDS()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcompany_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemployer_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colss_company_rec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CNav = New DevExpress.XtraEditors.ControlNavigator()
        Me.TableAdapterManager = New SSBContExp.SSCompanyDSTableAdapters.TableAdapterManager()
        Me.Ss_companyTableAdapter1 = New SSBContExp.CompMaintDSTableAdapters.ss_companyTableAdapter()
        CType(Me.SscompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSCompanyDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SscompanyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompMaintDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SscompanyBindingSource
        '
        Me.SscompanyBindingSource.DataMember = "ss_company"
        Me.SscompanyBindingSource.DataSource = Me.SSCompanyDS
        '
        'SSCompanyDS
        '
        Me.SSCompanyDS.DataSetName = "SSCompanyDS"
        Me.SSCompanyDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ss_companyTableAdapter
        '
        Me.Ss_companyTableAdapter.ClearBeforeFill = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Controls.Add(Me.CNav)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Lime
        Me.GroupControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.PaleGreen
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(341, 343)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Company Listing"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SscompanyBindingSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl1.Location = New System.Drawing.Point(2, 40)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(337, 298)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SscompanyBindingSource1
        '
        Me.SscompanyBindingSource1.DataMember = "ss_company"
        Me.SscompanyBindingSource1.DataSource = Me.CompMaintDS
        '
        'CompMaintDS
        '
        Me.CompMaintDS.DataSetName = "CompMaintDS"
        Me.CompMaintDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcompany_name, Me.colemployer_no, Me.colss_company_rec})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colcompany_name
        '
        Me.colcompany_name.Caption = "Company Name"
        Me.colcompany_name.FieldName = "company_name"
        Me.colcompany_name.Name = "colcompany_name"
        Me.colcompany_name.Visible = True
        Me.colcompany_name.VisibleIndex = 0
        '
        'colemployer_no
        '
        Me.colemployer_no.Caption = "SSB Employer #"
        Me.colemployer_no.FieldName = "employer_no"
        Me.colemployer_no.Name = "colemployer_no"
        Me.colemployer_no.Visible = True
        Me.colemployer_no.VisibleIndex = 1
        '
        'colss_company_rec
        '
        Me.colss_company_rec.FieldName = "ss_company_rec"
        Me.colss_company_rec.Name = "colss_company_rec"
        '
        'CNav
        '
        Me.CNav.Buttons.Append.Hint = "Add A Company"
        Me.CNav.Buttons.CancelEdit.Hint = "Undo"
        Me.CNav.Buttons.Edit.Hint = "Edit A Company"
        Me.CNav.Buttons.EndEdit.Hint = "Save Changes"
        Me.CNav.Buttons.First.Hint = "Go To First Record"
        Me.CNav.Buttons.Last.Hint = "Go To Last Record"
        Me.CNav.Buttons.Next.Hint = "Go To Next Record"
        Me.CNav.Buttons.NextPage.Hint = "Go Forward A Page"
        Me.CNav.Buttons.Prev.Hint = "Go To Previous Record"
        Me.CNav.Buttons.PrevPage.Hint = "Go Back A Page"
        Me.CNav.Buttons.Remove.Hint = "Delete A Company"
        Me.CNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.CNav.Location = New System.Drawing.Point(2, 21)
        Me.CNav.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.CNav.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CNav.Name = "CNav"
        Me.CNav.NavigatableControl = Me.GridControl1
        Me.CNav.ShowToolTips = True
        Me.CNav.Size = New System.Drawing.Size(337, 19)
        Me.CNav.TabIndex = 1
        Me.CNav.Text = "ControlNavigator1"
        Me.CNav.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ss_companyTableAdapter = Me.Ss_companyTableAdapter
        Me.TableAdapterManager.UpdateOrder = SSBContExp.SSCompanyDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Ss_companyTableAdapter1
        '
        Me.Ss_companyTableAdapter1.ClearBeforeFill = True
        '
        'DXCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 367)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.DarkSeaGreen
        Me.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "DXCompany"
        Me.Text = "Company Maintenance"
        CType(Me.SscompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSCompanyDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SscompanyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompMaintDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SSCompanyDS As SSCompanyDS
    Friend WithEvents SscompanyBindingSource As BindingSource
    Friend WithEvents Ss_companyTableAdapter As SSCompanyDSTableAdapters.ss_companyTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents CNav As ControlNavigator
    Friend WithEvents TableAdapterManager As SSCompanyDSTableAdapters.TableAdapterManager
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompMaintDS As CompMaintDS
    Friend WithEvents SscompanyBindingSource1 As BindingSource
    Friend WithEvents Ss_companyTableAdapter1 As CompMaintDSTableAdapters.ss_companyTableAdapter
    Friend WithEvents colcompany_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemployer_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colss_company_rec As DevExpress.XtraGrid.Columns.GridColumn
End Class
