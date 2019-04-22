<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainInterface
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim STT_NOLabel As System.Windows.Forms.Label
        Dim Archive_NoLabel As System.Windows.Forms.Label
        Dim HBLLabel As System.Windows.Forms.Label
        Dim MBLLabel As System.Windows.Forms.Label
        Dim POLLabel As System.Windows.Forms.Label
        Dim PODLabel As System.Windows.Forms.Label
        Dim OriginLabel As System.Windows.Forms.Label
        Dim ETDLabel As System.Windows.Forms.Label
        Dim ETALabel As System.Windows.Forms.Label
        Dim PiecesLabel As System.Windows.Forms.Label
        Dim VolumeLabel As System.Windows.Forms.Label
        Dim PrincipalLabel As System.Windows.Forms.Label
        Dim ShipperLabel As System.Windows.Forms.Label
        Dim ConsigneeLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Me.DsGrohe = New Grohe_Phyto.dsGrohe()
        Me.DsShipmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsShipmentsTableAdapter = New Grohe_Phyto.dsGroheTableAdapters.dsShipmentsTableAdapter()
        Me.TableAdapterManager = New Grohe_Phyto.dsGroheTableAdapters.TableAdapterManager()
        Me.DsContainerTableAdapter = New Grohe_Phyto.dsGroheTableAdapters.dsContainerTableAdapter()
        Me.DsMaterialTableAdapter = New Grohe_Phyto.dsGroheTableAdapters.dsMaterialTableAdapter()
        Me.DsPhytoTableAdapter = New Grohe_Phyto.dsGroheTableAdapters.dsPhytoTableAdapter()
        Me.DtHSCodeTableAdapter = New Grohe_Phyto.dsGroheTableAdapters.dtHSCodeTableAdapter()
        Me.DtMatCodeTableAdapter = New Grohe_Phyto.dsGroheTableAdapters.dtMatCodeTableAdapter()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabOverview = New System.Windows.Forms.TabPage()
        Me.txtSearch = New Grohe_Phyto.Watermark()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.STTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArchiveNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HBLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MBLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PiecesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsigneeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChkPhytoDoneDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tabShipment = New System.Windows.Forms.TabPage()
        Me.btnWispexMail = New System.Windows.Forms.Button()
        Me.TotalDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.STT_NOTextBox = New System.Windows.Forms.TextBox()
        Me.Archive_NoTextBox = New System.Windows.Forms.TextBox()
        Me.HBLTextBox = New System.Windows.Forms.TextBox()
        Me.MBLTextBox = New System.Windows.Forms.TextBox()
        Me.POLTextBox = New System.Windows.Forms.TextBox()
        Me.PODTextBox = New System.Windows.Forms.TextBox()
        Me.OriginTextBox = New System.Windows.Forms.TextBox()
        Me.PiecesTextBox = New System.Windows.Forms.TextBox()
        Me.VolumeTextBox = New System.Windows.Forms.TextBox()
        Me.PrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.ShipperTextBox = New System.Windows.Forms.TextBox()
        Me.ConsigneeTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.ETDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ETADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReqPhytoDECheckBox = New System.Windows.Forms.CheckBox()
        Me.ChkModel99DoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.ChkPhytoDeCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReqModel99CheckBox = New System.Windows.Forms.CheckBox()
        Me.btnShipmentsSave = New System.Windows.Forms.Button()
        Me.tabImport = New System.Windows.Forms.TabPage()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.chkDelete = New System.Windows.Forms.CheckBox()
        Me.txtSheetHsCodes = New System.Windows.Forms.TextBox()
        Me.txtSheetTango = New System.Windows.Forms.TextBox()
        Me.txtGroheInfo = New System.Windows.Forms.TextBox()
        Me.txtHSCodes = New System.Windows.Forms.TextBox()
        Me.txtTango = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTango = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHSCodes = New System.Windows.Forms.Button()
        Me.btnGrohexls = New System.Windows.Forms.Button()
        Me.btnImportxls = New System.Windows.Forms.Button()
        Me.txtSheetMaterial = New Grohe_Phyto.Watermark()
        Me.txtSheetDelivery = New Grohe_Phyto.Watermark()
        Me.tabSetting = New System.Windows.Forms.TabPage()
        Me.TotalDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtMatCodeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtMatCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtHSCodeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtHSCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPhytoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsPhytoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMaterialDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContainerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsContainerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSignaturePath = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtSignature = New Grohe_Phyto.Watermark()
        Me.TotalTableAdapter = New Grohe_Phyto.dsGroheTableAdapters.TotalTableAdapter()
        Me.dlgFileDialog = New System.Windows.Forms.OpenFileDialog()
        STT_NOLabel = New System.Windows.Forms.Label()
        Archive_NoLabel = New System.Windows.Forms.Label()
        HBLLabel = New System.Windows.Forms.Label()
        MBLLabel = New System.Windows.Forms.Label()
        POLLabel = New System.Windows.Forms.Label()
        PODLabel = New System.Windows.Forms.Label()
        OriginLabel = New System.Windows.Forms.Label()
        ETDLabel = New System.Windows.Forms.Label()
        ETALabel = New System.Windows.Forms.Label()
        PiecesLabel = New System.Windows.Forms.Label()
        VolumeLabel = New System.Windows.Forms.Label()
        PrincipalLabel = New System.Windows.Forms.Label()
        ShipperLabel = New System.Windows.Forms.Label()
        ConsigneeLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        CType(Me.DsGrohe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tabOverview.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabShipment.SuspendLayout()
        CType(Me.TotalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImport.SuspendLayout()
        Me.tabSetting.SuspendLayout()
        CType(Me.TotalDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtMatCodeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtMatCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtHSCodeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtHSCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPhytoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPhytoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContainerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContainerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'STT_NOLabel
        '
        STT_NOLabel.AutoSize = True
        STT_NOLabel.Location = New System.Drawing.Point(12, 9)
        STT_NOLabel.Name = "STT_NOLabel"
        STT_NOLabel.Size = New System.Drawing.Size(50, 13)
        STT_NOLabel.TabIndex = 0
        STT_NOLabel.Text = "STT NO:"
        '
        'Archive_NoLabel
        '
        Archive_NoLabel.AutoSize = True
        Archive_NoLabel.Location = New System.Drawing.Point(12, 35)
        Archive_NoLabel.Name = "Archive_NoLabel"
        Archive_NoLabel.Size = New System.Drawing.Size(63, 13)
        Archive_NoLabel.TabIndex = 4
        Archive_NoLabel.Text = "Archive No:"
        '
        'HBLLabel
        '
        HBLLabel.AutoSize = True
        HBLLabel.Location = New System.Drawing.Point(12, 61)
        HBLLabel.Name = "HBLLabel"
        HBLLabel.Size = New System.Drawing.Size(31, 13)
        HBLLabel.TabIndex = 6
        HBLLabel.Text = "HBL:"
        '
        'MBLLabel
        '
        MBLLabel.AutoSize = True
        MBLLabel.Location = New System.Drawing.Point(12, 87)
        MBLLabel.Name = "MBLLabel"
        MBLLabel.Size = New System.Drawing.Size(32, 13)
        MBLLabel.TabIndex = 8
        MBLLabel.Text = "MBL:"
        '
        'POLLabel
        '
        POLLabel.AutoSize = True
        POLLabel.Location = New System.Drawing.Point(12, 140)
        POLLabel.Name = "POLLabel"
        POLLabel.Size = New System.Drawing.Size(31, 13)
        POLLabel.TabIndex = 10
        POLLabel.Text = "POL:"
        '
        'PODLabel
        '
        PODLabel.AutoSize = True
        PODLabel.Location = New System.Drawing.Point(12, 166)
        PODLabel.Name = "PODLabel"
        PODLabel.Size = New System.Drawing.Size(33, 13)
        PODLabel.TabIndex = 12
        PODLabel.Text = "POD:"
        '
        'OriginLabel
        '
        OriginLabel.AutoSize = True
        OriginLabel.Location = New System.Drawing.Point(12, 114)
        OriginLabel.Name = "OriginLabel"
        OriginLabel.Size = New System.Drawing.Size(37, 13)
        OriginLabel.TabIndex = 14
        OriginLabel.Text = "Origin:"
        '
        'ETDLabel
        '
        ETDLabel.AutoSize = True
        ETDLabel.Location = New System.Drawing.Point(174, 140)
        ETDLabel.Name = "ETDLabel"
        ETDLabel.Size = New System.Drawing.Size(32, 13)
        ETDLabel.TabIndex = 16
        ETDLabel.Text = "ETD:"
        '
        'ETALabel
        '
        ETALabel.AutoSize = True
        ETALabel.Location = New System.Drawing.Point(174, 166)
        ETALabel.Name = "ETALabel"
        ETALabel.Size = New System.Drawing.Size(31, 13)
        ETALabel.TabIndex = 18
        ETALabel.Text = "ETA:"
        '
        'PiecesLabel
        '
        PiecesLabel.AutoSize = True
        PiecesLabel.Location = New System.Drawing.Point(322, 110)
        PiecesLabel.Name = "PiecesLabel"
        PiecesLabel.Size = New System.Drawing.Size(42, 13)
        PiecesLabel.TabIndex = 20
        PiecesLabel.Text = "Pieces:"
        '
        'VolumeLabel
        '
        VolumeLabel.AutoSize = True
        VolumeLabel.Location = New System.Drawing.Point(322, 136)
        VolumeLabel.Name = "VolumeLabel"
        VolumeLabel.Size = New System.Drawing.Size(45, 13)
        VolumeLabel.TabIndex = 22
        VolumeLabel.Text = "Volume:"
        '
        'PrincipalLabel
        '
        PrincipalLabel.AutoSize = True
        PrincipalLabel.Location = New System.Drawing.Point(322, 9)
        PrincipalLabel.Name = "PrincipalLabel"
        PrincipalLabel.Size = New System.Drawing.Size(50, 13)
        PrincipalLabel.TabIndex = 24
        PrincipalLabel.Text = "Principal:"
        '
        'ShipperLabel
        '
        ShipperLabel.AutoSize = True
        ShipperLabel.Location = New System.Drawing.Point(322, 35)
        ShipperLabel.Name = "ShipperLabel"
        ShipperLabel.Size = New System.Drawing.Size(46, 13)
        ShipperLabel.TabIndex = 26
        ShipperLabel.Text = "Shipper:"
        '
        'ConsigneeLabel
        '
        ConsigneeLabel.AutoSize = True
        ConsigneeLabel.Location = New System.Drawing.Point(322, 61)
        ConsigneeLabel.Name = "ConsigneeLabel"
        ConsigneeLabel.Size = New System.Drawing.Size(60, 13)
        ConsigneeLabel.TabIndex = 28
        ConsigneeLabel.Text = "Consignee:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(322, 162)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 30
        WeightLabel.Text = "Weight:"
        '
        'DsGrohe
        '
        Me.DsGrohe.DataSetName = "dsGrohe"
        Me.DsGrohe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsShipmentsBindingSource
        '
        Me.DsShipmentsBindingSource.DataMember = "dsShipments"
        Me.DsShipmentsBindingSource.DataSource = Me.DsGrohe
        '
        'DsShipmentsTableAdapter
        '
        Me.DsShipmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dsContainerTableAdapter = Me.DsContainerTableAdapter
        Me.TableAdapterManager.dsMaterialTableAdapter = Me.DsMaterialTableAdapter
        Me.TableAdapterManager.dsPhytoTableAdapter = Me.DsPhytoTableAdapter
        Me.TableAdapterManager.dsShipmentsTableAdapter = Me.DsShipmentsTableAdapter
        Me.TableAdapterManager.dtHSCodeTableAdapter = Me.DtHSCodeTableAdapter
        Me.TableAdapterManager.dtMatCodeTableAdapter = Me.DtMatCodeTableAdapter
        Me.TableAdapterManager.sqlite_sequenceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Grohe_Phyto.dsGroheTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsContainerTableAdapter
        '
        Me.DsContainerTableAdapter.ClearBeforeFill = True
        '
        'DsMaterialTableAdapter
        '
        Me.DsMaterialTableAdapter.ClearBeforeFill = True
        '
        'DsPhytoTableAdapter
        '
        Me.DsPhytoTableAdapter.ClearBeforeFill = True
        '
        'DtHSCodeTableAdapter
        '
        Me.DtHSCodeTableAdapter.ClearBeforeFill = True
        '
        'DtMatCodeTableAdapter
        '
        Me.DtMatCodeTableAdapter.ClearBeforeFill = True
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.tabOverview)
        Me.tabControl.Controls.Add(Me.tabShipment)
        Me.tabControl.Controls.Add(Me.tabImport)
        Me.tabControl.Controls.Add(Me.tabSetting)
        Me.tabControl.Location = New System.Drawing.Point(12, 12)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(776, 426)
        Me.tabControl.TabIndex = 3
        Me.tabControl.TabStop = False
        '
        'tabOverview
        '
        Me.tabOverview.Controls.Add(Me.txtSearch)
        Me.tabOverview.Controls.Add(Me.cmbFilter)
        Me.tabOverview.Controls.Add(Me.btnSearch)
        Me.tabOverview.Controls.Add(Me.dgvMain)
        Me.tabOverview.Location = New System.Drawing.Point(4, 22)
        Me.tabOverview.Name = "tabOverview"
        Me.tabOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOverview.Size = New System.Drawing.Size(768, 400)
        Me.tabOverview.TabIndex = 0
        Me.tabOverview.Text = "Overview"
        Me.tabOverview.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(7, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(185, 20)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSearch.WatermarkText = "Search...."
        '
        'cmbFilter
        '
        Me.cmbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Standard", "Phyto benötigt"})
        Me.cmbFilter.Location = New System.Drawing.Point(546, 8)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(216, 21)
        Me.cmbFilter.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(198, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(69, 27)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMain.AutoGenerateColumns = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STTNODataGridViewTextBoxColumn, Me.CreatedDataGridViewTextBoxColumn, Me.ArchiveNoDataGridViewTextBoxColumn, Me.HBLDataGridViewTextBoxColumn, Me.MBLDataGridViewTextBoxColumn, Me.POLDataGridViewTextBoxColumn, Me.PODDataGridViewTextBoxColumn, Me.OriginDataGridViewTextBoxColumn, Me.ETDDataGridViewTextBoxColumn, Me.ETADataGridViewTextBoxColumn, Me.PiecesDataGridViewTextBoxColumn, Me.VolumeDataGridViewTextBoxColumn, Me.PrincipalDataGridViewTextBoxColumn, Me.ShipperDataGridViewTextBoxColumn, Me.ConsigneeDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.ChkPhytoDoneDataGridViewCheckBoxColumn})
        Me.dgvMain.DataSource = Me.DsShipmentsBindingSource
        Me.dgvMain.Location = New System.Drawing.Point(6, 38)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.Size = New System.Drawing.Size(756, 356)
        Me.dgvMain.TabIndex = 0
        '
        'STTNODataGridViewTextBoxColumn
        '
        Me.STTNODataGridViewTextBoxColumn.DataPropertyName = "STT_NO"
        Me.STTNODataGridViewTextBoxColumn.HeaderText = "STT_NO"
        Me.STTNODataGridViewTextBoxColumn.Name = "STTNODataGridViewTextBoxColumn"
        Me.STTNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedDataGridViewTextBoxColumn
        '
        Me.CreatedDataGridViewTextBoxColumn.DataPropertyName = "Created"
        Me.CreatedDataGridViewTextBoxColumn.HeaderText = "Created"
        Me.CreatedDataGridViewTextBoxColumn.Name = "CreatedDataGridViewTextBoxColumn"
        Me.CreatedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArchiveNoDataGridViewTextBoxColumn
        '
        Me.ArchiveNoDataGridViewTextBoxColumn.DataPropertyName = "Archive_No"
        Me.ArchiveNoDataGridViewTextBoxColumn.HeaderText = "Archive_No"
        Me.ArchiveNoDataGridViewTextBoxColumn.Name = "ArchiveNoDataGridViewTextBoxColumn"
        Me.ArchiveNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HBLDataGridViewTextBoxColumn
        '
        Me.HBLDataGridViewTextBoxColumn.DataPropertyName = "HBL"
        Me.HBLDataGridViewTextBoxColumn.HeaderText = "HBL"
        Me.HBLDataGridViewTextBoxColumn.Name = "HBLDataGridViewTextBoxColumn"
        Me.HBLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MBLDataGridViewTextBoxColumn
        '
        Me.MBLDataGridViewTextBoxColumn.DataPropertyName = "MBL"
        Me.MBLDataGridViewTextBoxColumn.HeaderText = "MBL"
        Me.MBLDataGridViewTextBoxColumn.Name = "MBLDataGridViewTextBoxColumn"
        Me.MBLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POLDataGridViewTextBoxColumn
        '
        Me.POLDataGridViewTextBoxColumn.DataPropertyName = "POL"
        Me.POLDataGridViewTextBoxColumn.HeaderText = "POL"
        Me.POLDataGridViewTextBoxColumn.Name = "POLDataGridViewTextBoxColumn"
        Me.POLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PODDataGridViewTextBoxColumn
        '
        Me.PODDataGridViewTextBoxColumn.DataPropertyName = "POD"
        Me.PODDataGridViewTextBoxColumn.HeaderText = "POD"
        Me.PODDataGridViewTextBoxColumn.Name = "PODDataGridViewTextBoxColumn"
        Me.PODDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OriginDataGridViewTextBoxColumn
        '
        Me.OriginDataGridViewTextBoxColumn.DataPropertyName = "Origin"
        Me.OriginDataGridViewTextBoxColumn.HeaderText = "Origin"
        Me.OriginDataGridViewTextBoxColumn.Name = "OriginDataGridViewTextBoxColumn"
        Me.OriginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ETDDataGridViewTextBoxColumn
        '
        Me.ETDDataGridViewTextBoxColumn.DataPropertyName = "ETD"
        Me.ETDDataGridViewTextBoxColumn.HeaderText = "ETD"
        Me.ETDDataGridViewTextBoxColumn.Name = "ETDDataGridViewTextBoxColumn"
        Me.ETDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ETADataGridViewTextBoxColumn
        '
        Me.ETADataGridViewTextBoxColumn.DataPropertyName = "ETA"
        Me.ETADataGridViewTextBoxColumn.HeaderText = "ETA"
        Me.ETADataGridViewTextBoxColumn.Name = "ETADataGridViewTextBoxColumn"
        Me.ETADataGridViewTextBoxColumn.ReadOnly = True
        '
        'PiecesDataGridViewTextBoxColumn
        '
        Me.PiecesDataGridViewTextBoxColumn.DataPropertyName = "Pieces"
        Me.PiecesDataGridViewTextBoxColumn.HeaderText = "Pieces"
        Me.PiecesDataGridViewTextBoxColumn.Name = "PiecesDataGridViewTextBoxColumn"
        Me.PiecesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VolumeDataGridViewTextBoxColumn
        '
        Me.VolumeDataGridViewTextBoxColumn.DataPropertyName = "Volume"
        Me.VolumeDataGridViewTextBoxColumn.HeaderText = "Volume"
        Me.VolumeDataGridViewTextBoxColumn.Name = "VolumeDataGridViewTextBoxColumn"
        Me.VolumeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrincipalDataGridViewTextBoxColumn
        '
        Me.PrincipalDataGridViewTextBoxColumn.DataPropertyName = "Principal"
        Me.PrincipalDataGridViewTextBoxColumn.HeaderText = "Principal"
        Me.PrincipalDataGridViewTextBoxColumn.Name = "PrincipalDataGridViewTextBoxColumn"
        Me.PrincipalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipperDataGridViewTextBoxColumn
        '
        Me.ShipperDataGridViewTextBoxColumn.DataPropertyName = "Shipper"
        Me.ShipperDataGridViewTextBoxColumn.HeaderText = "Shipper"
        Me.ShipperDataGridViewTextBoxColumn.Name = "ShipperDataGridViewTextBoxColumn"
        Me.ShipperDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsigneeDataGridViewTextBoxColumn
        '
        Me.ConsigneeDataGridViewTextBoxColumn.DataPropertyName = "Consignee"
        Me.ConsigneeDataGridViewTextBoxColumn.HeaderText = "Consignee"
        Me.ConsigneeDataGridViewTextBoxColumn.Name = "ConsigneeDataGridViewTextBoxColumn"
        Me.ConsigneeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChkPhytoDoneDataGridViewCheckBoxColumn
        '
        Me.ChkPhytoDoneDataGridViewCheckBoxColumn.DataPropertyName = "chkPhytoDone"
        Me.ChkPhytoDoneDataGridViewCheckBoxColumn.HeaderText = "chkPhytoDone"
        Me.ChkPhytoDoneDataGridViewCheckBoxColumn.Name = "ChkPhytoDoneDataGridViewCheckBoxColumn"
        Me.ChkPhytoDoneDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'tabShipment
        '
        Me.tabShipment.AutoScroll = True
        Me.tabShipment.Controls.Add(Me.btnWispexMail)
        Me.tabShipment.Controls.Add(Me.TotalDataGridView)
        Me.tabShipment.Controls.Add(Me.Label3)
        Me.tabShipment.Controls.Add(Me.DataGridView1)
        Me.tabShipment.Controls.Add(STT_NOLabel)
        Me.tabShipment.Controls.Add(Me.STT_NOTextBox)
        Me.tabShipment.Controls.Add(Me.Archive_NoTextBox)
        Me.tabShipment.Controls.Add(Me.HBLTextBox)
        Me.tabShipment.Controls.Add(Me.MBLTextBox)
        Me.tabShipment.Controls.Add(Me.POLTextBox)
        Me.tabShipment.Controls.Add(Me.PODTextBox)
        Me.tabShipment.Controls.Add(Me.OriginTextBox)
        Me.tabShipment.Controls.Add(Me.PiecesTextBox)
        Me.tabShipment.Controls.Add(Me.VolumeTextBox)
        Me.tabShipment.Controls.Add(Me.PrincipalTextBox)
        Me.tabShipment.Controls.Add(Me.ShipperTextBox)
        Me.tabShipment.Controls.Add(Me.ConsigneeTextBox)
        Me.tabShipment.Controls.Add(Me.WeightTextBox)
        Me.tabShipment.Controls.Add(Archive_NoLabel)
        Me.tabShipment.Controls.Add(HBLLabel)
        Me.tabShipment.Controls.Add(MBLLabel)
        Me.tabShipment.Controls.Add(POLLabel)
        Me.tabShipment.Controls.Add(PODLabel)
        Me.tabShipment.Controls.Add(OriginLabel)
        Me.tabShipment.Controls.Add(ETDLabel)
        Me.tabShipment.Controls.Add(Me.ETDDateTimePicker)
        Me.tabShipment.Controls.Add(ETALabel)
        Me.tabShipment.Controls.Add(Me.ETADateTimePicker)
        Me.tabShipment.Controls.Add(PiecesLabel)
        Me.tabShipment.Controls.Add(VolumeLabel)
        Me.tabShipment.Controls.Add(PrincipalLabel)
        Me.tabShipment.Controls.Add(ShipperLabel)
        Me.tabShipment.Controls.Add(ConsigneeLabel)
        Me.tabShipment.Controls.Add(WeightLabel)
        Me.tabShipment.Controls.Add(Me.ReqPhytoDECheckBox)
        Me.tabShipment.Controls.Add(Me.ChkModel99DoneCheckBox)
        Me.tabShipment.Controls.Add(Me.ChkPhytoDeCheckBox)
        Me.tabShipment.Controls.Add(Me.ReqModel99CheckBox)
        Me.tabShipment.Controls.Add(Me.btnShipmentsSave)
        Me.tabShipment.Location = New System.Drawing.Point(4, 22)
        Me.tabShipment.Name = "tabShipment"
        Me.tabShipment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShipment.Size = New System.Drawing.Size(768, 400)
        Me.tabShipment.TabIndex = 3
        Me.tabShipment.Text = "Shipment"
        Me.tabShipment.UseVisualStyleBackColor = True
        '
        'btnWispexMail
        '
        Me.btnWispexMail.Location = New System.Drawing.Point(779, 61)
        Me.btnWispexMail.Name = "btnWispexMail"
        Me.btnWispexMail.Size = New System.Drawing.Size(123, 39)
        Me.btnWispexMail.TabIndex = 45
        Me.btnWispexMail.Text = "Wispex"
        Me.btnWispexMail.UseVisualStyleBackColor = True
        '
        'TotalDataGridView
        '
        Me.TotalDataGridView.AllowUserToAddRows = False
        Me.TotalDataGridView.AllowUserToDeleteRows = False
        Me.TotalDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotalDataGridView.Location = New System.Drawing.Point(6, 197)
        Me.TotalDataGridView.Name = "TotalDataGridView"
        Me.TotalDataGridView.ReadOnly = True
        Me.TotalDataGridView.Size = New System.Drawing.Size(971, 25)
        Me.TotalDataGridView.TabIndex = 44
        Me.TotalDataGridView.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Documents"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(494, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(132, 72)
        Me.DataGridView1.TabIndex = 43
        Me.DataGridView1.TabStop = False
        '
        'STT_NOTextBox
        '
        Me.STT_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "STT_NO", True))
        Me.STT_NOTextBox.Enabled = False
        Me.STT_NOTextBox.Location = New System.Drawing.Point(116, 6)
        Me.STT_NOTextBox.Name = "STT_NOTextBox"
        Me.STT_NOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.STT_NOTextBox.TabIndex = 1
        '
        'Archive_NoTextBox
        '
        Me.Archive_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Archive_No", True))
        Me.Archive_NoTextBox.Location = New System.Drawing.Point(116, 32)
        Me.Archive_NoTextBox.Name = "Archive_NoTextBox"
        Me.Archive_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Archive_NoTextBox.TabIndex = 2
        '
        'HBLTextBox
        '
        Me.HBLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "HBL", True))
        Me.HBLTextBox.Location = New System.Drawing.Point(116, 58)
        Me.HBLTextBox.Name = "HBLTextBox"
        Me.HBLTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HBLTextBox.TabIndex = 3
        '
        'MBLTextBox
        '
        Me.MBLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "MBL", True))
        Me.MBLTextBox.Location = New System.Drawing.Point(116, 84)
        Me.MBLTextBox.Name = "MBLTextBox"
        Me.MBLTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MBLTextBox.TabIndex = 4
        '
        'POLTextBox
        '
        Me.POLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POL", True))
        Me.POLTextBox.Location = New System.Drawing.Point(116, 136)
        Me.POLTextBox.Name = "POLTextBox"
        Me.POLTextBox.Size = New System.Drawing.Size(52, 20)
        Me.POLTextBox.TabIndex = 6
        '
        'PODTextBox
        '
        Me.PODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POD", True))
        Me.PODTextBox.Location = New System.Drawing.Point(116, 162)
        Me.PODTextBox.Name = "PODTextBox"
        Me.PODTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PODTextBox.TabIndex = 7
        '
        'OriginTextBox
        '
        Me.OriginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Origin", True))
        Me.OriginTextBox.Location = New System.Drawing.Point(116, 110)
        Me.OriginTextBox.Name = "OriginTextBox"
        Me.OriginTextBox.Size = New System.Drawing.Size(34, 20)
        Me.OriginTextBox.TabIndex = 5
        '
        'PiecesTextBox
        '
        Me.PiecesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Pieces", True))
        Me.PiecesTextBox.Location = New System.Drawing.Point(426, 107)
        Me.PiecesTextBox.Name = "PiecesTextBox"
        Me.PiecesTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PiecesTextBox.TabIndex = 13
        '
        'VolumeTextBox
        '
        Me.VolumeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Volume", True))
        Me.VolumeTextBox.Location = New System.Drawing.Point(426, 133)
        Me.VolumeTextBox.Name = "VolumeTextBox"
        Me.VolumeTextBox.Size = New System.Drawing.Size(52, 20)
        Me.VolumeTextBox.TabIndex = 14
        '
        'PrincipalTextBox
        '
        Me.PrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Principal", True))
        Me.PrincipalTextBox.Location = New System.Drawing.Point(426, 6)
        Me.PrincipalTextBox.Name = "PrincipalTextBox"
        Me.PrincipalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrincipalTextBox.TabIndex = 10
        '
        'ShipperTextBox
        '
        Me.ShipperTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Shipper", True))
        Me.ShipperTextBox.Location = New System.Drawing.Point(426, 32)
        Me.ShipperTextBox.Name = "ShipperTextBox"
        Me.ShipperTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipperTextBox.TabIndex = 11
        '
        'ConsigneeTextBox
        '
        Me.ConsigneeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Consignee", True))
        Me.ConsigneeTextBox.Location = New System.Drawing.Point(426, 58)
        Me.ConsigneeTextBox.Name = "ConsigneeTextBox"
        Me.ConsigneeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ConsigneeTextBox.TabIndex = 12
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(426, 159)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(52, 20)
        Me.WeightTextBox.TabIndex = 15
        '
        'ETDDateTimePicker
        '
        Me.ETDDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsShipmentsBindingSource, "ETD", True))
        Me.ETDDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ETDDateTimePicker.Location = New System.Drawing.Point(212, 136)
        Me.ETDDateTimePicker.Name = "ETDDateTimePicker"
        Me.ETDDateTimePicker.Size = New System.Drawing.Size(79, 20)
        Me.ETDDateTimePicker.TabIndex = 8
        '
        'ETADateTimePicker
        '
        Me.ETADateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsShipmentsBindingSource, "ETA", True))
        Me.ETADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ETADateTimePicker.Location = New System.Drawing.Point(212, 162)
        Me.ETADateTimePicker.Name = "ETADateTimePicker"
        Me.ETADateTimePicker.Size = New System.Drawing.Size(79, 20)
        Me.ETADateTimePicker.TabIndex = 9
        '
        'ReqPhytoDECheckBox
        '
        Me.ReqPhytoDECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DsShipmentsBindingSource, "reqPhytoDE", True))
        Me.ReqPhytoDECheckBox.Location = New System.Drawing.Point(632, 4)
        Me.ReqPhytoDECheckBox.Name = "ReqPhytoDECheckBox"
        Me.ReqPhytoDECheckBox.Size = New System.Drawing.Size(123, 24)
        Me.ReqPhytoDECheckBox.TabIndex = 35
        Me.ReqPhytoDECheckBox.TabStop = False
        Me.ReqPhytoDECheckBox.Text = "Pflanze DE benötigt"
        Me.ReqPhytoDECheckBox.UseVisualStyleBackColor = True
        '
        'ChkModel99DoneCheckBox
        '
        Me.ChkModel99DoneCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DsShipmentsBindingSource, "chkModel99Done", True))
        Me.ChkModel99DoneCheckBox.Location = New System.Drawing.Point(779, 30)
        Me.ChkModel99DoneCheckBox.Name = "ChkModel99DoneCheckBox"
        Me.ChkModel99DoneCheckBox.Size = New System.Drawing.Size(123, 24)
        Me.ChkModel99DoneCheckBox.TabIndex = 37
        Me.ChkModel99DoneCheckBox.TabStop = False
        Me.ChkModel99DoneCheckBox.Text = "Pflanze NL erledigt"
        Me.ChkModel99DoneCheckBox.UseVisualStyleBackColor = True
        '
        'ChkPhytoDeCheckBox
        '
        Me.ChkPhytoDeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DsShipmentsBindingSource, "chkPhytoDe", True))
        Me.ChkPhytoDeCheckBox.Location = New System.Drawing.Point(632, 30)
        Me.ChkPhytoDeCheckBox.Name = "ChkPhytoDeCheckBox"
        Me.ChkPhytoDeCheckBox.Size = New System.Drawing.Size(123, 24)
        Me.ChkPhytoDeCheckBox.TabIndex = 39
        Me.ChkPhytoDeCheckBox.TabStop = False
        Me.ChkPhytoDeCheckBox.Text = "Pflanze DE erledigt"
        Me.ChkPhytoDeCheckBox.UseVisualStyleBackColor = True
        '
        'ReqModel99CheckBox
        '
        Me.ReqModel99CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DsShipmentsBindingSource, "reqModel99", True))
        Me.ReqModel99CheckBox.Location = New System.Drawing.Point(779, 4)
        Me.ReqModel99CheckBox.Name = "ReqModel99CheckBox"
        Me.ReqModel99CheckBox.Size = New System.Drawing.Size(123, 24)
        Me.ReqModel99CheckBox.TabIndex = 41
        Me.ReqModel99CheckBox.TabStop = False
        Me.ReqModel99CheckBox.Text = "Pflanze NL benötigt"
        Me.ReqModel99CheckBox.UseVisualStyleBackColor = True
        '
        'btnShipmentsSave
        '
        Me.btnShipmentsSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShipmentsSave.Location = New System.Drawing.Point(924, -118)
        Me.btnShipmentsSave.Name = "btnShipmentsSave"
        Me.btnShipmentsSave.Size = New System.Drawing.Size(50, 48)
        Me.btnShipmentsSave.TabIndex = 42
        Me.btnShipmentsSave.TabStop = False
        Me.btnShipmentsSave.UseVisualStyleBackColor = True
        '
        'tabImport
        '
        Me.tabImport.AllowDrop = True
        Me.tabImport.Controls.Add(Me.ProgressBar)
        Me.tabImport.Controls.Add(Me.chkDelete)
        Me.tabImport.Controls.Add(Me.txtSheetHsCodes)
        Me.tabImport.Controls.Add(Me.txtSheetTango)
        Me.tabImport.Controls.Add(Me.txtGroheInfo)
        Me.tabImport.Controls.Add(Me.txtHSCodes)
        Me.tabImport.Controls.Add(Me.txtTango)
        Me.tabImport.Controls.Add(Me.Button1)
        Me.tabImport.Controls.Add(Me.btnTango)
        Me.tabImport.Controls.Add(Me.Label1)
        Me.tabImport.Controls.Add(Me.btnHSCodes)
        Me.tabImport.Controls.Add(Me.btnGrohexls)
        Me.tabImport.Controls.Add(Me.btnImportxls)
        Me.tabImport.Controls.Add(Me.txtSheetMaterial)
        Me.tabImport.Controls.Add(Me.txtSheetDelivery)
        Me.tabImport.Location = New System.Drawing.Point(4, 22)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabImport.Size = New System.Drawing.Size(768, 400)
        Me.tabImport.TabIndex = 2
        Me.tabImport.Text = "Import"
        Me.tabImport.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(209, -69)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(284, 23)
        Me.ProgressBar.TabIndex = 6
        '
        'chkDelete
        '
        Me.chkDelete.AutoSize = True
        Me.chkDelete.Location = New System.Drawing.Point(75, 161)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.Size = New System.Drawing.Size(128, 17)
        Me.chkDelete.TabIndex = 20
        Me.chkDelete.Text = "Delete file after import"
        Me.chkDelete.UseVisualStyleBackColor = True
        '
        'txtSheetHsCodes
        '
        Me.txtSheetHsCodes.AllowDrop = True
        Me.txtSheetHsCodes.Location = New System.Drawing.Point(376, 74)
        Me.txtSheetHsCodes.Name = "txtSheetHsCodes"
        Me.txtSheetHsCodes.Size = New System.Drawing.Size(117, 20)
        Me.txtSheetHsCodes.TabIndex = 15
        Me.txtSheetHsCodes.Text = "Sheet1"
        '
        'txtSheetTango
        '
        Me.txtSheetTango.AllowDrop = True
        Me.txtSheetTango.Location = New System.Drawing.Point(376, 45)
        Me.txtSheetTango.Name = "txtSheetTango"
        Me.txtSheetTango.Size = New System.Drawing.Size(117, 20)
        Me.txtSheetTango.TabIndex = 14
        Me.txtSheetTango.Text = "Excel Export1"
        '
        'txtGroheInfo
        '
        Me.txtGroheInfo.AllowDrop = True
        Me.txtGroheInfo.Location = New System.Drawing.Point(87, 103)
        Me.txtGroheInfo.Name = "txtGroheInfo"
        Me.txtGroheInfo.Size = New System.Drawing.Size(283, 20)
        Me.txtGroheInfo.TabIndex = 12
        '
        'txtHSCodes
        '
        Me.txtHSCodes.AllowDrop = True
        Me.txtHSCodes.Location = New System.Drawing.Point(87, 74)
        Me.txtHSCodes.Name = "txtHSCodes"
        Me.txtHSCodes.Size = New System.Drawing.Size(283, 20)
        Me.txtHSCodes.TabIndex = 11
        '
        'txtTango
        '
        Me.txtTango.AllowDrop = True
        Me.txtTango.Location = New System.Drawing.Point(87, 45)
        Me.txtTango.Name = "txtTango"
        Me.txtTango.Size = New System.Drawing.Size(283, 20)
        Me.txtTango.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Phyto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTango
        '
        Me.btnTango.Location = New System.Drawing.Point(6, 43)
        Me.btnTango.Name = "btnTango"
        Me.btnTango.Size = New System.Drawing.Size(75, 23)
        Me.btnTango.TabIndex = 3
        Me.btnTango.Text = "Tango"
        Me.btnTango.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Import Sequence"
        '
        'btnHSCodes
        '
        Me.btnHSCodes.Location = New System.Drawing.Point(6, 72)
        Me.btnHSCodes.Name = "btnHSCodes"
        Me.btnHSCodes.Size = New System.Drawing.Size(75, 23)
        Me.btnHSCodes.TabIndex = 1
        Me.btnHSCodes.Text = "HS Codes"
        Me.btnHSCodes.UseVisualStyleBackColor = True
        '
        'btnGrohexls
        '
        Me.btnGrohexls.Location = New System.Drawing.Point(6, 101)
        Me.btnGrohexls.Name = "btnGrohexls"
        Me.btnGrohexls.Size = New System.Drawing.Size(75, 23)
        Me.btnGrohexls.TabIndex = 2
        Me.btnGrohexls.Text = "Grohe xls"
        Me.btnGrohexls.UseVisualStyleBackColor = True
        '
        'btnImportxls
        '
        Me.btnImportxls.Location = New System.Drawing.Point(6, 135)
        Me.btnImportxls.Name = "btnImportxls"
        Me.btnImportxls.Size = New System.Drawing.Size(63, 43)
        Me.btnImportxls.TabIndex = 13
        Me.btnImportxls.UseVisualStyleBackColor = True
        '
        'txtSheetMaterial
        '
        Me.txtSheetMaterial.Location = New System.Drawing.Point(376, 129)
        Me.txtSheetMaterial.Name = "txtSheetMaterial"
        Me.txtSheetMaterial.Size = New System.Drawing.Size(117, 20)
        Me.txtSheetMaterial.TabIndex = 19
        Me.txtSheetMaterial.Text = "Tabelle2"
        Me.txtSheetMaterial.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSheetMaterial.WatermarkText = "Material"
        '
        'txtSheetDelivery
        '
        Me.txtSheetDelivery.Location = New System.Drawing.Point(376, 103)
        Me.txtSheetDelivery.Name = "txtSheetDelivery"
        Me.txtSheetDelivery.Size = New System.Drawing.Size(117, 20)
        Me.txtSheetDelivery.TabIndex = 18
        Me.txtSheetDelivery.Text = "Tabelle3"
        Me.txtSheetDelivery.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSheetDelivery.WatermarkText = "Delivery"
        '
        'tabSetting
        '
        Me.tabSetting.AutoScroll = True
        Me.tabSetting.Controls.Add(Me.TotalDataGridView1)
        Me.tabSetting.Controls.Add(Me.DtMatCodeDataGridView)
        Me.tabSetting.Controls.Add(Me.DtHSCodeDataGridView)
        Me.tabSetting.Controls.Add(Me.DsPhytoDataGridView)
        Me.tabSetting.Controls.Add(Me.DsMaterialDataGridView)
        Me.tabSetting.Controls.Add(Me.DsContainerDataGridView)
        Me.tabSetting.Controls.Add(Me.btnSignaturePath)
        Me.tabSetting.Controls.Add(Me.LinkLabel2)
        Me.tabSetting.Controls.Add(Me.LinkLabel1)
        Me.tabSetting.Controls.Add(Me.txtSignature)
        Me.tabSetting.Location = New System.Drawing.Point(4, 22)
        Me.tabSetting.Name = "tabSetting"
        Me.tabSetting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabSetting.Size = New System.Drawing.Size(768, 400)
        Me.tabSetting.TabIndex = 4
        Me.tabSetting.Text = "Settings"
        Me.tabSetting.UseVisualStyleBackColor = True
        '
        'TotalDataGridView1
        '
        Me.TotalDataGridView1.AutoGenerateColumns = False
        Me.TotalDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TotalDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewCheckBoxColumn3})
        Me.TotalDataGridView1.DataSource = Me.TotalBindingSource
        Me.TotalDataGridView1.Location = New System.Drawing.Point(101, 120)
        Me.TotalDataGridView1.Name = "TotalDataGridView1"
        Me.TotalDataGridView1.Size = New System.Drawing.Size(300, 220)
        Me.TotalDataGridView1.TabIndex = 9
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "STT_NO"
        Me.DataGridViewTextBoxColumn20.HeaderText = "STT_NO"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Archive_No"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Archive_No"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Origin"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Origin"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Material_ID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Material_ID"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Material_No"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Material_No"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "HS_Code"
        Me.DataGridViewTextBoxColumn25.HeaderText = "HS_Code"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Container_No"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Container_No"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "chkPhytoDone"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "chkPhytoDone"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'TotalBindingSource
        '
        Me.TotalBindingSource.DataMember = "Total"
        Me.TotalBindingSource.DataSource = Me.DsGrohe
        '
        'DtMatCodeDataGridView
        '
        Me.DtMatCodeDataGridView.AutoGenerateColumns = False
        Me.DtMatCodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtMatCodeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.DtMatCodeDataGridView.DataSource = Me.DtMatCodeBindingSource
        Me.DtMatCodeDataGridView.Location = New System.Drawing.Point(451, 95)
        Me.DtMatCodeDataGridView.Name = "DtMatCodeDataGridView"
        Me.DtMatCodeDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DtMatCodeDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Material_ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Material_ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "HS_Code"
        Me.DataGridViewTextBoxColumn18.HeaderText = "HS_Code"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DtMatCodeBindingSource
        '
        Me.DtMatCodeBindingSource.DataMember = "dtMatCode"
        Me.DtMatCodeBindingSource.DataSource = Me.DsGrohe
        '
        'DtHSCodeDataGridView
        '
        Me.DtHSCodeDataGridView.AutoGenerateColumns = False
        Me.DtHSCodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtHSCodeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.DtHSCodeDataGridView.DataSource = Me.DtHSCodeBindingSource
        Me.DtHSCodeDataGridView.Location = New System.Drawing.Point(125, 154)
        Me.DtHSCodeDataGridView.Name = "DtHSCodeDataGridView"
        Me.DtHSCodeDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DtHSCodeDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "HS_Code"
        Me.DataGridViewTextBoxColumn14.HeaderText = "HS_Code"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DtHSCodeBindingSource
        '
        Me.DtHSCodeBindingSource.DataMember = "dtHSCode"
        Me.DtHSCodeBindingSource.DataSource = Me.DsGrohe
        '
        'DsPhytoDataGridView
        '
        Me.DsPhytoDataGridView.AutoGenerateColumns = False
        Me.DsPhytoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsPhytoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn13})
        Me.DsPhytoDataGridView.DataSource = Me.DsPhytoBindingSource
        Me.DsPhytoDataGridView.Location = New System.Drawing.Point(203, 177)
        Me.DsPhytoDataGridView.Name = "DsPhytoDataGridView"
        Me.DsPhytoDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DsPhytoDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Phyto_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Phyto_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "HS_Code"
        Me.DataGridViewTextBoxColumn11.HeaderText = "HS_Code"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Origin"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Origin"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "reqModel99"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "reqModel99"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "reqPhytoDE"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "reqPhytoDE"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "chklatest"
        Me.DataGridViewTextBoxColumn13.HeaderText = "chklatest"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DsPhytoBindingSource
        '
        Me.DsPhytoBindingSource.DataMember = "dsPhyto"
        Me.DsPhytoBindingSource.DataSource = Me.DsGrohe
        '
        'DsMaterialDataGridView
        '
        Me.DsMaterialDataGridView.AutoGenerateColumns = False
        Me.DsMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsMaterialDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DsMaterialDataGridView.DataSource = Me.DsMaterialBindingSource
        Me.DsMaterialDataGridView.Location = New System.Drawing.Point(269, 178)
        Me.DsMaterialDataGridView.Name = "DsMaterialDataGridView"
        Me.DsMaterialDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DsMaterialDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Material_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Material_ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Container_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Container_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Material_No"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Material_No"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DsMaterialBindingSource
        '
        Me.DsMaterialBindingSource.DataMember = "dsMaterial"
        Me.DsMaterialBindingSource.DataSource = Me.DsGrohe
        '
        'DsContainerDataGridView
        '
        Me.DsContainerDataGridView.AutoGenerateColumns = False
        Me.DsContainerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsContainerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DsContainerDataGridView.DataSource = Me.DsContainerBindingSource
        Me.DsContainerDataGridView.Location = New System.Drawing.Point(344, 203)
        Me.DsContainerDataGridView.Name = "DsContainerDataGridView"
        Me.DsContainerDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DsContainerDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Container_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Container_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Container_No"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Container_No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "STT_No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "STT_No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DsContainerBindingSource
        '
        Me.DsContainerBindingSource.DataMember = "dsContainer"
        Me.DsContainerBindingSource.DataSource = Me.DsGrohe
        '
        'btnSignaturePath
        '
        Me.btnSignaturePath.Location = New System.Drawing.Point(299, 22)
        Me.btnSignaturePath.Name = "btnSignaturePath"
        Me.btnSignaturePath.Size = New System.Drawing.Size(27, 20)
        Me.btnSignaturePath.TabIndex = 5
        Me.btnSignaturePath.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 59)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(241, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Icon made by Smashicons from www.flaticon.com"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(219, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Icon made by Freepik from www.flaticon.com"
        '
        'txtSignature
        '
        Me.txtSignature.Location = New System.Drawing.Point(3, 23)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Size = New System.Drawing.Size(290, 20)
        Me.txtSignature.TabIndex = 4
        Me.txtSignature.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSignature.WatermarkText = "Signature Path"
        '
        'TotalTableAdapter
        '
        Me.TotalTableAdapter.ClearBeforeFill = True
        '
        'dlgFileDialog
        '
        Me.dlgFileDialog.FileName = "x"
        '
        'frmMainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "frmMainInterface"
        Me.Text = "Grohe Phyto"
        CType(Me.DsGrohe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tabOverview.ResumeLayout(False)
        Me.tabOverview.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabShipment.ResumeLayout(False)
        Me.tabShipment.PerformLayout()
        CType(Me.TotalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImport.ResumeLayout(False)
        Me.tabImport.PerformLayout()
        Me.tabSetting.ResumeLayout(False)
        Me.tabSetting.PerformLayout()
        CType(Me.TotalDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtMatCodeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtMatCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtHSCodeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtHSCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPhytoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPhytoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContainerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContainerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsGrohe As dsGrohe
    Friend WithEvents DsShipmentsBindingSource As BindingSource
    Friend WithEvents DsShipmentsTableAdapter As dsGroheTableAdapters.dsShipmentsTableAdapter
    Friend WithEvents TableAdapterManager As dsGroheTableAdapters.TableAdapterManager
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabOverview As TabPage
    Friend WithEvents txtSearch As Watermark
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents STTNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArchiveNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HBLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MBLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OriginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ETDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ETADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PiecesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VolumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrincipalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipperDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsigneeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChkPhytoDoneDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents tabShipment As TabPage
    Friend WithEvents btnWispexMail As Button
    Friend WithEvents TotalDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents STT_NOTextBox As TextBox
    Friend WithEvents Archive_NoTextBox As TextBox
    Friend WithEvents HBLTextBox As TextBox
    Friend WithEvents MBLTextBox As TextBox
    Friend WithEvents POLTextBox As TextBox
    Friend WithEvents PODTextBox As TextBox
    Friend WithEvents OriginTextBox As TextBox
    Friend WithEvents PiecesTextBox As TextBox
    Friend WithEvents VolumeTextBox As TextBox
    Friend WithEvents PrincipalTextBox As TextBox
    Friend WithEvents ShipperTextBox As TextBox
    Friend WithEvents ConsigneeTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents ETDDateTimePicker As DateTimePicker
    Friend WithEvents ETADateTimePicker As DateTimePicker
    Friend WithEvents ReqPhytoDECheckBox As CheckBox
    Friend WithEvents ChkModel99DoneCheckBox As CheckBox
    Friend WithEvents ChkPhytoDeCheckBox As CheckBox
    Friend WithEvents ReqModel99CheckBox As CheckBox
    Friend WithEvents btnShipmentsSave As Button
    Friend WithEvents tabImport As TabPage
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents chkDelete As CheckBox
    Friend WithEvents txtSheetHsCodes As TextBox
    Friend WithEvents txtSheetTango As TextBox
    Friend WithEvents txtGroheInfo As TextBox
    Friend WithEvents txtHSCodes As TextBox
    Friend WithEvents txtTango As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnTango As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHSCodes As Button
    Friend WithEvents btnGrohexls As Button
    Friend WithEvents btnImportxls As Button
    Friend WithEvents txtSheetMaterial As Watermark
    Friend WithEvents txtSheetDelivery As Watermark
    Friend WithEvents tabSetting As TabPage
    Friend WithEvents btnSignaturePath As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtSignature As Watermark
    Friend WithEvents DsContainerTableAdapter As dsGroheTableAdapters.dsContainerTableAdapter
    Friend WithEvents DsContainerBindingSource As BindingSource
    Friend WithEvents DsMaterialTableAdapter As dsGroheTableAdapters.dsMaterialTableAdapter
    Friend WithEvents DsContainerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DsMaterialBindingSource As BindingSource
    Friend WithEvents DsPhytoTableAdapter As dsGroheTableAdapters.dsPhytoTableAdapter
    Friend WithEvents DsMaterialDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DsPhytoBindingSource As BindingSource
    Friend WithEvents DtHSCodeTableAdapter As dsGroheTableAdapters.dtHSCodeTableAdapter
    Friend WithEvents DsPhytoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DtHSCodeBindingSource As BindingSource
    Friend WithEvents DtMatCodeTableAdapter As dsGroheTableAdapters.dtMatCodeTableAdapter
    Friend WithEvents DtHSCodeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DtMatCodeBindingSource As BindingSource
    Friend WithEvents DtMatCodeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents TotalBindingSource As BindingSource
    Friend WithEvents TotalTableAdapter As dsGroheTableAdapters.TotalTableAdapter
    Friend WithEvents TotalDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents dlgFileDialog As OpenFileDialog
End Class
