Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DXSSBCE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DXSSBCE))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PBLoad = New DevExpress.XtraEditors.ProgressBarControl()
        Me.CboCompany = New System.Windows.Forms.ComboBox()
        Me.SscompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSCompanyDS = New SSBContExp.SSCompanyDS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFilePath = New DevExpress.XtraEditors.TextEdit()
        Me.BtnProcFile = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnFndFile = New DevExpress.XtraEditors.SimpleButton()
        Me.Ss_companyTableAdapter = New SSBContExp.SSCompanyDSTableAdapters.ss_companyTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PBLoad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SscompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSCompanyDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFilePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.ContentImage = Global.SSBContExp.My.Resources.Resources.SSB_LOGO1
        Me.GroupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopRight
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.PBLoad)
        Me.GroupControl1.Controls.Add(Me.CboCompany)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.TxtFilePath)
        Me.GroupControl1.Controls.Add(Me.BtnProcFile)
        Me.GroupControl1.Controls.Add(Me.BtnFndFile)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 28)
        Me.GroupControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Lime
        Me.GroupControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.PaleGreen
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(306, 179)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Company Selection"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Wide Latin", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.AppearanceHovered.Options.UseBackColor = True
        Me.SimpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.SimpleButton1.Location = New System.Drawing.Point(276, 46)
        Me.SimpleButton1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(25, 20)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "+"
        Me.SimpleButton1.ToolTip = "Add A Company"
        '
        'PBLoad
        '
        Me.PBLoad.Location = New System.Drawing.Point(17, 155)
        Me.PBLoad.Name = "PBLoad"
        Me.PBLoad.Properties.Appearance.BackColor = System.Drawing.Color.Lime
        Me.PBLoad.Properties.Appearance.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.PBLoad.Properties.ShowTitle = True
        Me.PBLoad.Size = New System.Drawing.Size(271, 18)
        Me.PBLoad.TabIndex = 8
        '
        'CboCompany
        '
        Me.CboCompany.BackColor = System.Drawing.Color.DarkKhaki
        Me.CboCompany.DataSource = Me.SscompanyBindingSource
        Me.CboCompany.DisplayMember = "company_name"
        Me.CboCompany.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CboCompany.ForeColor = System.Drawing.Color.White
        Me.CboCompany.FormattingEnabled = True
        Me.CboCompany.Location = New System.Drawing.Point(17, 46)
        Me.CboCompany.Name = "CboCompany"
        Me.CboCompany.Size = New System.Drawing.Size(253, 21)
        Me.CboCompany.TabIndex = 7
        Me.CboCompany.ValueMember = "employer_no"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(14, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select The Company Below"
        '
        'TxtFilePath
        '
        Me.TxtFilePath.Location = New System.Drawing.Point(17, 100)
        Me.TxtFilePath.Name = "TxtFilePath"
        Me.TxtFilePath.Size = New System.Drawing.Size(271, 20)
        Me.TxtFilePath.TabIndex = 3
        '
        'BtnProcFile
        '
        Me.BtnProcFile.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnProcFile.Appearance.Options.UseFont = True
        Me.BtnProcFile.AppearanceHovered.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnProcFile.AppearanceHovered.BackColor2 = System.Drawing.Color.LimeGreen
        Me.BtnProcFile.AppearanceHovered.Options.UseBackColor = True
        Me.BtnProcFile.AppearancePressed.BackColor = System.Drawing.Color.White
        Me.BtnProcFile.AppearancePressed.BackColor2 = System.Drawing.Color.LimeGreen
        Me.BtnProcFile.AppearancePressed.Options.UseBackColor = True
        Me.BtnProcFile.Location = New System.Drawing.Point(213, 126)
        Me.BtnProcFile.LookAndFeel.SkinMaskColor = System.Drawing.Color.DarkOliveGreen
        Me.BtnProcFile.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.LavenderBlush
        Me.BtnProcFile.Name = "BtnProcFile"
        Me.BtnProcFile.Size = New System.Drawing.Size(75, 23)
        Me.BtnProcFile.TabIndex = 2
        Me.BtnProcFile.Text = "&Convert File"
        '
        'BtnFndFile
        '
        Me.BtnFndFile.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFndFile.Appearance.Options.UseFont = True
        Me.BtnFndFile.AppearanceHovered.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnFndFile.AppearanceHovered.BackColor2 = System.Drawing.Color.SeaGreen
        Me.BtnFndFile.AppearanceHovered.Options.UseBackColor = True
        Me.BtnFndFile.AppearancePressed.BackColor = System.Drawing.Color.White
        Me.BtnFndFile.AppearancePressed.BackColor2 = System.Drawing.Color.SeaGreen
        Me.BtnFndFile.AppearancePressed.Options.UseBackColor = True
        Me.BtnFndFile.Location = New System.Drawing.Point(17, 126)
        Me.BtnFndFile.LookAndFeel.SkinMaskColor = System.Drawing.Color.DarkOliveGreen
        Me.BtnFndFile.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Lime
        Me.BtnFndFile.Name = "BtnFndFile"
        Me.BtnFndFile.Size = New System.Drawing.Size(75, 23)
        Me.BtnFndFile.TabIndex = 1
        Me.BtnFndFile.Text = "&Find File"
        '
        'Ss_companyTableAdapter
        '
        Me.Ss_companyTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(331, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReferenceToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyMaintenanceToolStripMenuItem})
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ReferenceToolStripMenuItem.Text = "&Reference"
        '
        'CompanyMaintenanceToolStripMenuItem
        '
        Me.CompanyMaintenanceToolStripMenuItem.Name = "CompanyMaintenanceToolStripMenuItem"
        Me.CompanyMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.CompanyMaintenanceToolStripMenuItem.Text = "Company Maintenance"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DXSSBCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 219)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinMaskColor = System.Drawing.Color.DarkSeaGreen
        Me.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DXSSBCE"
        Me.Text = "SSB Contribution Exporter"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PBLoad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SscompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSCompanyDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFilePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents TxtFilePath As TextEdit
    Friend WithEvents BtnProcFile As SimpleButton
    Friend WithEvents BtnFndFile As SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CboCompany As Windows.Forms.ComboBox
    Friend WithEvents SSCompanyDS As SSCompanyDS
    Friend WithEvents SscompanyBindingSource As BindingSource
    Friend WithEvents Ss_companyTableAdapter As SSCompanyDSTableAdapters.ss_companyTableAdapter
    Friend WithEvents PBLoad As ProgressBarControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleButton1 As SimpleButton
End Class
