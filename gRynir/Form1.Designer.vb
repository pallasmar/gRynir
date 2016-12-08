<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StuttLysingLabel As System.Windows.Forms.Label
        Dim KerfiLabel As System.Windows.Forms.Label
        Dim ServerNafnLabel As System.Windows.Forms.Label
        Dim GagnagrunnurLabel As System.Windows.Forms.Label
        Dim DagsStofnadurLabel As System.Windows.Forms.Label
        Dim AfritunarferliLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GRynir_GrunnarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GRynir_GrunnarBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AfritunarferliTextBox = New System.Windows.Forms.TextBox()
        Me.DagsStofnadurLabel1 = New System.Windows.Forms.Label()
        Me.GagnagrunnurLabel1 = New System.Windows.Forms.Label()
        Me.ServerNafnLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StuttLysingTextBox = New System.Windows.Forms.TextBox()
        Me.KerfiTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServerNafnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GagnagrunnurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecoveryModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpeglunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DagsStofnadurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DagsNyskradDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DagsUppfaertDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KerfiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuttLysingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AfritunarferliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRynir_GrunnarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBADataSet = New gRynir.DBADataSet()
        Me.GRynir_GrunnarTableAdapter = New gRynir.DBADataSetTableAdapters.gRynir_GrunnarTableAdapter()
        Me.TableAdapterManager = New gRynir.DBADataSetTableAdapters.TableAdapterManager()
        Me.DbaDataSet1 = New gRynir.DBADataSet()
        Me.DbaDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        StuttLysingLabel = New System.Windows.Forms.Label()
        KerfiLabel = New System.Windows.Forms.Label()
        ServerNafnLabel = New System.Windows.Forms.Label()
        GagnagrunnurLabel = New System.Windows.Forms.Label()
        DagsStofnadurLabel = New System.Windows.Forms.Label()
        AfritunarferliLabel = New System.Windows.Forms.Label()
        CType(Me.GRynir_GrunnarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRynir_GrunnarBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRynir_GrunnarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StuttLysingLabel
        '
        StuttLysingLabel.AutoSize = True
        StuttLysingLabel.Location = New System.Drawing.Point(38, 192)
        StuttLysingLabel.Name = "StuttLysingLabel"
        StuttLysingLabel.Size = New System.Drawing.Size(65, 13)
        StuttLysingLabel.TabIndex = 15
        StuttLysingLabel.Text = "Stutt Lysing:"
        '
        'KerfiLabel
        '
        KerfiLabel.AutoSize = True
        KerfiLabel.Location = New System.Drawing.Point(72, 139)
        KerfiLabel.Name = "KerfiLabel"
        KerfiLabel.Size = New System.Drawing.Size(31, 13)
        KerfiLabel.TabIndex = 13
        KerfiLabel.Text = "Kerfi:"
        '
        'ServerNafnLabel
        '
        ServerNafnLabel.AutoSize = True
        ServerNafnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ServerNafnLabel.Location = New System.Drawing.Point(36, 81)
        ServerNafnLabel.Name = "ServerNafnLabel"
        ServerNafnLabel.Size = New System.Drawing.Size(100, 17)
        ServerNafnLabel.TabIndex = 17
        ServerNafnLabel.Text = "Server Nafn:"
        '
        'GagnagrunnurLabel
        '
        GagnagrunnurLabel.AutoSize = True
        GagnagrunnurLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GagnagrunnurLabel.Location = New System.Drawing.Point(420, 81)
        GagnagrunnurLabel.Name = "GagnagrunnurLabel"
        GagnagrunnurLabel.Size = New System.Drawing.Size(118, 17)
        GagnagrunnurLabel.TabIndex = 18
        GagnagrunnurLabel.Text = "Gagnagrunnur:"
        '
        'DagsStofnadurLabel
        '
        DagsStofnadurLabel.AutoSize = True
        DagsStofnadurLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DagsStofnadurLabel.Location = New System.Drawing.Point(754, 81)
        DagsStofnadurLabel.Name = "DagsStofnadurLabel"
        DagsStofnadurLabel.Size = New System.Drawing.Size(126, 17)
        DagsStofnadurLabel.TabIndex = 19
        DagsStofnadurLabel.Text = "Dags Stofnadur:"
        '
        'AfritunarferliLabel
        '
        AfritunarferliLabel.AutoSize = True
        AfritunarferliLabel.Location = New System.Drawing.Point(263, 139)
        AfritunarferliLabel.Name = "AfritunarferliLabel"
        AfritunarferliLabel.Size = New System.Drawing.Size(65, 13)
        AfritunarferliLabel.TabIndex = 20
        AfritunarferliLabel.Text = "Afritunarferli:"
        '
        'GRynir_GrunnarBindingNavigator
        '
        Me.GRynir_GrunnarBindingNavigator.AddNewItem = Nothing
        Me.GRynir_GrunnarBindingNavigator.BindingSource = Me.GRynir_GrunnarBindingSource
        Me.GRynir_GrunnarBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GRynir_GrunnarBindingNavigator.DeleteItem = Nothing
        Me.GRynir_GrunnarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.GRynir_GrunnarBindingNavigatorSaveItem})
        Me.GRynir_GrunnarBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GRynir_GrunnarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GRynir_GrunnarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GRynir_GrunnarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GRynir_GrunnarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GRynir_GrunnarBindingNavigator.Name = "GRynir_GrunnarBindingNavigator"
        Me.GRynir_GrunnarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GRynir_GrunnarBindingNavigator.Size = New System.Drawing.Size(1249, 25)
        Me.GRynir_GrunnarBindingNavigator.TabIndex = 0
        Me.GRynir_GrunnarBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "0"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'GRynir_GrunnarBindingNavigatorSaveItem
        '
        Me.GRynir_GrunnarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GRynir_GrunnarBindingNavigatorSaveItem.Image = CType(resources.GetObject("GRynir_GrunnarBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GRynir_GrunnarBindingNavigatorSaveItem.Name = "GRynir_GrunnarBindingNavigatorSaveItem"
        Me.GRynir_GrunnarBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GRynir_GrunnarBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(AfritunarferliLabel)
        Me.Panel1.Controls.Add(Me.AfritunarferliTextBox)
        Me.Panel1.Controls.Add(DagsStofnadurLabel)
        Me.Panel1.Controls.Add(Me.DagsStofnadurLabel1)
        Me.Panel1.Controls.Add(GagnagrunnurLabel)
        Me.Panel1.Controls.Add(Me.GagnagrunnurLabel1)
        Me.Panel1.Controls.Add(ServerNafnLabel)
        Me.Panel1.Controls.Add(Me.ServerNafnLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(StuttLysingLabel)
        Me.Panel1.Controls.Add(Me.StuttLysingTextBox)
        Me.Panel1.Controls.Add(KerfiLabel)
        Me.Panel1.Controls.Add(Me.KerfiTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1225, 355)
        Me.Panel1.TabIndex = 9
        '
        'AfritunarferliTextBox
        '
        Me.AfritunarferliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GRynir_GrunnarBindingSource, "Afritunarferli", True))
        Me.AfritunarferliTextBox.Location = New System.Drawing.Point(334, 136)
        Me.AfritunarferliTextBox.Name = "AfritunarferliTextBox"
        Me.AfritunarferliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AfritunarferliTextBox.TabIndex = 21
        '
        'DagsStofnadurLabel1
        '
        Me.DagsStofnadurLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DagsStofnadurLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GRynir_GrunnarBindingSource, "DagsStofnadur", True))
        Me.DagsStofnadurLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DagsStofnadurLabel1.Location = New System.Drawing.Point(886, 81)
        Me.DagsStofnadurLabel1.Name = "DagsStofnadurLabel1"
        Me.DagsStofnadurLabel1.Size = New System.Drawing.Size(139, 23)
        Me.DagsStofnadurLabel1.TabIndex = 20
        Me.DagsStofnadurLabel1.Text = "Label2"
        '
        'GagnagrunnurLabel1
        '
        Me.GagnagrunnurLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GagnagrunnurLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GRynir_GrunnarBindingSource, "Gagnagrunnur", True))
        Me.GagnagrunnurLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GagnagrunnurLabel1.Location = New System.Drawing.Point(544, 81)
        Me.GagnagrunnurLabel1.Name = "GagnagrunnurLabel1"
        Me.GagnagrunnurLabel1.Size = New System.Drawing.Size(204, 23)
        Me.GagnagrunnurLabel1.TabIndex = 19
        Me.GagnagrunnurLabel1.Text = "Label2"
        '
        'ServerNafnLabel1
        '
        Me.ServerNafnLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ServerNafnLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GRynir_GrunnarBindingSource, "ServerNafn", True))
        Me.ServerNafnLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerNafnLabel1.Location = New System.Drawing.Point(142, 81)
        Me.ServerNafnLabel1.Name = "ServerNafnLabel1"
        Me.ServerNafnLabel1.Size = New System.Drawing.Size(272, 23)
        Me.ServerNafnLabel1.TabIndex = 18
        Me.ServerNafnLabel1.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Tag = ""
        Me.Label1.Text = "Gagnagrunnsrýnir"
        '
        'StuttLysingTextBox
        '
        Me.StuttLysingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GRynir_GrunnarBindingSource, "StuttLysing", True))
        Me.StuttLysingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("ScrollBars", Global.gRynir.My.MySettings.Default, "vScrollBar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.StuttLysingTextBox.Location = New System.Drawing.Point(109, 189)
        Me.StuttLysingTextBox.Multiline = True
        Me.StuttLysingTextBox.Name = "StuttLysingTextBox"
        Me.StuttLysingTextBox.ScrollBars = Global.gRynir.My.MySettings.Default.vScrollBar
        Me.StuttLysingTextBox.Size = New System.Drawing.Size(1088, 138)
        Me.StuttLysingTextBox.TabIndex = 16
        '
        'KerfiTextBox
        '
        Me.KerfiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GRynir_GrunnarBindingSource, "Kerfi", True))
        Me.KerfiTextBox.Location = New System.Drawing.Point(109, 136)
        Me.KerfiTextBox.Name = "KerfiTextBox"
        Me.KerfiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KerfiTextBox.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServerNafnDataGridViewTextBoxColumn, Me.GagnagrunnurDataGridViewTextBoxColumn, Me.StadaDataGridViewTextBoxColumn, Me.RecoveryModelDataGridViewTextBoxColumn, Me.SpeglunDataGridViewTextBoxColumn, Me.DagsStofnadurDataGridViewTextBoxColumn, Me.DagsNyskradDataGridViewTextBoxColumn, Me.DagsUppfaertDataGridViewTextBoxColumn, Me.KerfiDataGridViewTextBoxColumn, Me.StuttLysingDataGridViewTextBoxColumn, Me.AfritunarferliDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GRynir_GrunnarBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 399)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1225, 328)
        Me.DataGridView1.TabIndex = 10
        '
        'ServerNafnDataGridViewTextBoxColumn
        '
        Me.ServerNafnDataGridViewTextBoxColumn.DataPropertyName = "ServerNafn"
        Me.ServerNafnDataGridViewTextBoxColumn.HeaderText = "ServerNafn"
        Me.ServerNafnDataGridViewTextBoxColumn.Name = "ServerNafnDataGridViewTextBoxColumn"
        Me.ServerNafnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GagnagrunnurDataGridViewTextBoxColumn
        '
        Me.GagnagrunnurDataGridViewTextBoxColumn.DataPropertyName = "Gagnagrunnur"
        Me.GagnagrunnurDataGridViewTextBoxColumn.HeaderText = "Gagnagrunnur"
        Me.GagnagrunnurDataGridViewTextBoxColumn.Name = "GagnagrunnurDataGridViewTextBoxColumn"
        Me.GagnagrunnurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StadaDataGridViewTextBoxColumn
        '
        Me.StadaDataGridViewTextBoxColumn.DataPropertyName = "Stada"
        Me.StadaDataGridViewTextBoxColumn.HeaderText = "Stada"
        Me.StadaDataGridViewTextBoxColumn.Name = "StadaDataGridViewTextBoxColumn"
        Me.StadaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecoveryModelDataGridViewTextBoxColumn
        '
        Me.RecoveryModelDataGridViewTextBoxColumn.DataPropertyName = "RecoveryModel"
        Me.RecoveryModelDataGridViewTextBoxColumn.HeaderText = "RecoveryModel"
        Me.RecoveryModelDataGridViewTextBoxColumn.Name = "RecoveryModelDataGridViewTextBoxColumn"
        Me.RecoveryModelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpeglunDataGridViewTextBoxColumn
        '
        Me.SpeglunDataGridViewTextBoxColumn.DataPropertyName = "Speglun"
        Me.SpeglunDataGridViewTextBoxColumn.HeaderText = "Speglun"
        Me.SpeglunDataGridViewTextBoxColumn.Name = "SpeglunDataGridViewTextBoxColumn"
        Me.SpeglunDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DagsStofnadurDataGridViewTextBoxColumn
        '
        Me.DagsStofnadurDataGridViewTextBoxColumn.DataPropertyName = "DagsStofnadur"
        Me.DagsStofnadurDataGridViewTextBoxColumn.HeaderText = "DagsStofnadur"
        Me.DagsStofnadurDataGridViewTextBoxColumn.Name = "DagsStofnadurDataGridViewTextBoxColumn"
        Me.DagsStofnadurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DagsNyskradDataGridViewTextBoxColumn
        '
        Me.DagsNyskradDataGridViewTextBoxColumn.DataPropertyName = "DagsNyskrad"
        Me.DagsNyskradDataGridViewTextBoxColumn.HeaderText = "DagsNyskrad"
        Me.DagsNyskradDataGridViewTextBoxColumn.Name = "DagsNyskradDataGridViewTextBoxColumn"
        Me.DagsNyskradDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DagsUppfaertDataGridViewTextBoxColumn
        '
        Me.DagsUppfaertDataGridViewTextBoxColumn.DataPropertyName = "DagsUppfaert"
        Me.DagsUppfaertDataGridViewTextBoxColumn.HeaderText = "DagsUppfaert"
        Me.DagsUppfaertDataGridViewTextBoxColumn.Name = "DagsUppfaertDataGridViewTextBoxColumn"
        Me.DagsUppfaertDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KerfiDataGridViewTextBoxColumn
        '
        Me.KerfiDataGridViewTextBoxColumn.DataPropertyName = "Kerfi"
        Me.KerfiDataGridViewTextBoxColumn.HeaderText = "Kerfi"
        Me.KerfiDataGridViewTextBoxColumn.Name = "KerfiDataGridViewTextBoxColumn"
        Me.KerfiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StuttLysingDataGridViewTextBoxColumn
        '
        Me.StuttLysingDataGridViewTextBoxColumn.DataPropertyName = "StuttLysing"
        Me.StuttLysingDataGridViewTextBoxColumn.HeaderText = "StuttLysing"
        Me.StuttLysingDataGridViewTextBoxColumn.Name = "StuttLysingDataGridViewTextBoxColumn"
        Me.StuttLysingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AfritunarferliDataGridViewTextBoxColumn
        '
        Me.AfritunarferliDataGridViewTextBoxColumn.DataPropertyName = "Afritunarferli"
        Me.AfritunarferliDataGridViewTextBoxColumn.HeaderText = "Afritunarferli"
        Me.AfritunarferliDataGridViewTextBoxColumn.Name = "AfritunarferliDataGridViewTextBoxColumn"
        Me.AfritunarferliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GRynir_GrunnarBindingSource
        '
        Me.GRynir_GrunnarBindingSource.DataMember = "gRynir_Grunnar"
        Me.GRynir_GrunnarBindingSource.DataSource = Me.DBADataSet
        '
        'DBADataSet
        '
        Me.DBADataSet.DataSetName = "DBADataSet"
        Me.DBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GRynir_GrunnarTableAdapter
        '
        Me.GRynir_GrunnarTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.gRynir_GrunnarTableAdapter = Me.GRynir_GrunnarTableAdapter
        Me.TableAdapterManager.UpdateOrder = gRynir.DBADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DbaDataSet1
        '
        Me.DbaDataSet1.DataSetName = "DBADataSet"
        Me.DbaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbaDataSet1BindingSource
        '
        Me.DbaDataSet1BindingSource.DataSource = Me.DbaDataSet1
        Me.DbaDataSet1BindingSource.Position = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 739)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GRynir_GrunnarBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GRynir_GrunnarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRynir_GrunnarBindingNavigator.ResumeLayout(False)
        Me.GRynir_GrunnarBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRynir_GrunnarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBADataSet As DBADataSet
    Friend WithEvents GRynir_GrunnarBindingSource As BindingSource
    Friend WithEvents GRynir_GrunnarTableAdapter As DBADataSetTableAdapters.gRynir_GrunnarTableAdapter
    Friend WithEvents TableAdapterManager As DBADataSetTableAdapters.TableAdapterManager
    Friend WithEvents GRynir_GrunnarBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GRynir_GrunnarBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StuttLysingTextBox As TextBox
    Friend WithEvents KerfiTextBox As TextBox
    Friend WithEvents AfritunarferliTextBox As TextBox
    Friend WithEvents DagsStofnadurLabel1 As Label
    Friend WithEvents GagnagrunnurLabel1 As Label
    Friend WithEvents ServerNafnLabel1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ServerNafnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GagnagrunnurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecoveryModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpeglunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DagsStofnadurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DagsNyskradDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DagsUppfaertDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KerfiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StuttLysingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AfritunarferliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DbaDataSet1 As DBADataSet
    Friend WithEvents DbaDataSet1BindingSource As BindingSource
End Class
