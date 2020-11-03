<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPackingListToys
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
		Me.LabelReturSuplier = New System.Windows.Forms.Label()
		Me.GroupBoxHome = New System.Windows.Forms.GroupBox()
		Me.LabelStatusINV = New System.Windows.Forms.Label()
		Me.LabelStatusBRDJKT = New System.Windows.Forms.Label()
		Me.DGVPLTOYS = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PackingListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.INVDataSet1 = New PeriplusWH_pAckinglIst.INVDataSet1()
		Me.PanelBatas = New System.Windows.Forms.Panel()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ComboBoxCari = New System.Windows.Forms.ComboBox()
		Me.ButtonCariData = New System.Windows.Forms.Button()
		Me.TextBoxCariData = New System.Windows.Forms.TextBox()
		Me.GroupBoxOps = New System.Windows.Forms.GroupBox()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonReset = New System.Windows.Forms.Button()
		Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
		Me.GroupBoxInput = New System.Windows.Forms.GroupBox()
		Me.ComboBoxRT = New System.Windows.Forms.ComboBox()
		Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBoxPetugas = New System.Windows.Forms.TextBox()
		Me.LabelQTY = New System.Windows.Forms.Label()
		Me.TextBoxQty = New System.Windows.Forms.TextBox()
		Me.GroupBoxData = New System.Windows.Forms.GroupBox()
		Me.TextBoxSuplier = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBoxNamaBarang = New System.Windows.Forms.TextBox()
		Me.LabelNama = New System.Windows.Forms.Label()
		Me.TextBoxCode = New System.Windows.Forms.TextBox()
		Me.LabelCode = New System.Windows.Forms.Label()
		Me.TextBoxISBN = New System.Windows.Forms.TextBox()
		Me.LabelISBN = New System.Windows.Forms.Label()
		Me.GroupBoxCari = New System.Windows.Forms.GroupBox()
		Me.TextBoxCariInput = New System.Windows.Forms.TextBox()
		Me.LabelInputISBN = New System.Windows.Forms.Label()
		Me.GroupBoxCRUD = New System.Windows.Forms.GroupBox()
		Me.ButtonDelete = New System.Windows.Forms.Button()
		Me.ButtonEdit = New System.Windows.Forms.Button()
		Me.ButtonBaru = New System.Windows.Forms.Button()
		Me.ButtonSimpan = New System.Windows.Forms.Button()
		Me.LabelPeriplus = New System.Windows.Forms.Label()
		Me.Packing_ListTableAdapter = New PeriplusWH_pAckinglIst.INVDataSet1TableAdapters.Packing_ListTableAdapter()
		Me.GroupBoxHome.SuspendLayout()
		CType(Me.DGVPLTOYS, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PackingListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.INVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBoxOps.SuspendLayout()
		Me.GroupBoxInputData.SuspendLayout()
		Me.GroupBoxInput.SuspendLayout()
		Me.GroupBoxData.SuspendLayout()
		Me.GroupBoxCari.SuspendLayout()
		Me.GroupBoxCRUD.SuspendLayout()
		Me.SuspendLayout()
		'
		'LabelReturSuplier
		'
		Me.LabelReturSuplier.AutoSize = True
		Me.LabelReturSuplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelReturSuplier.Location = New System.Drawing.Point(179, 9)
		Me.LabelReturSuplier.Name = "LabelReturSuplier"
		Me.LabelReturSuplier.Size = New System.Drawing.Size(514, 42)
		Me.LabelReturSuplier.TabIndex = 0
		Me.LabelReturSuplier.Text = "PACKING RETUR SUPLIER"
		'
		'GroupBoxHome
		'
		Me.GroupBoxHome.Controls.Add(Me.LabelStatusINV)
		Me.GroupBoxHome.Controls.Add(Me.LabelStatusBRDJKT)
		Me.GroupBoxHome.Controls.Add(Me.DGVPLTOYS)
		Me.GroupBoxHome.Controls.Add(Me.PanelBatas)
		Me.GroupBoxHome.Controls.Add(Me.GroupBox1)
		Me.GroupBoxHome.Controls.Add(Me.GroupBoxOps)
		Me.GroupBoxHome.Controls.Add(Me.GroupBoxInputData)
		Me.GroupBoxHome.Controls.Add(Me.GroupBoxCRUD)
		Me.GroupBoxHome.Controls.Add(Me.LabelPeriplus)
		Me.GroupBoxHome.Location = New System.Drawing.Point(12, 54)
		Me.GroupBoxHome.Name = "GroupBoxHome"
		Me.GroupBoxHome.Size = New System.Drawing.Size(887, 507)
		Me.GroupBoxHome.TabIndex = 1
		Me.GroupBoxHome.TabStop = False
		'
		'LabelStatusINV
		'
		Me.LabelStatusINV.AutoSize = True
		Me.LabelStatusINV.Font = New System.Drawing.Font("Lucida Console", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusINV.Location = New System.Drawing.Point(786, 215)
		Me.LabelStatusINV.Name = "LabelStatusINV"
		Me.LabelStatusINV.Size = New System.Drawing.Size(10, 8)
		Me.LabelStatusINV.TabIndex = 18
		Me.LabelStatusINV.Text = "."
		'
		'LabelStatusBRDJKT
		'
		Me.LabelStatusBRDJKT.AutoSize = True
		Me.LabelStatusBRDJKT.Font = New System.Drawing.Font("Lucida Console", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusBRDJKT.Location = New System.Drawing.Point(722, 215)
		Me.LabelStatusBRDJKT.Name = "LabelStatusBRDJKT"
		Me.LabelStatusBRDJKT.Size = New System.Drawing.Size(10, 8)
		Me.LabelStatusBRDJKT.TabIndex = 17
		Me.LabelStatusBRDJKT.Text = "."
		'
		'DGVPLTOYS
		'
		Me.DGVPLTOYS.AllowUserToAddRows = False
		Me.DGVPLTOYS.AllowUserToDeleteRows = False
		Me.DGVPLTOYS.AutoGenerateColumns = False
		Me.DGVPLTOYS.BackgroundColor = System.Drawing.Color.GhostWhite
		Me.DGVPLTOYS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DGVPLTOYS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVPLTOYS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
		Me.DGVPLTOYS.DataSource = Me.PackingListBindingSource
		Me.DGVPLTOYS.GridColor = System.Drawing.Color.RosyBrown
		Me.DGVPLTOYS.Location = New System.Drawing.Point(9, 248)
		Me.DGVPLTOYS.Name = "DGVPLTOYS"
		Me.DGVPLTOYS.RowHeadersVisible = False
		Me.DGVPLTOYS.Size = New System.Drawing.Size(864, 239)
		Me.DGVPLTOYS.TabIndex = 16
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "ISBN"
		Me.DataGridViewTextBoxColumn2.HeaderText = "ISBN"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.Width = 110
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "KodeBuku"
		Me.DataGridViewTextBoxColumn3.HeaderText = "Kode Barang"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.Width = 65
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "Judul"
		Me.DataGridViewTextBoxColumn4.HeaderText = "Nama Barang"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		Me.DataGridViewTextBoxColumn4.Width = 165
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "Suplier"
		Me.DataGridViewTextBoxColumn7.HeaderText = "Suplier"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		Me.DataGridViewTextBoxColumn7.Width = 150
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "Qty"
		Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		Me.DataGridViewTextBoxColumn5.Width = 35
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "Petugas"
		Me.DataGridViewTextBoxColumn1.HeaderText = "Petugas"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.Width = 50
		'
		'DataGridViewTextBoxColumn9
		'
		Me.DataGridViewTextBoxColumn9.DataPropertyName = "RETNUMBER"
		Me.DataGridViewTextBoxColumn9.HeaderText = "RETNUMBER"
		Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tanggal"
		Me.DataGridViewTextBoxColumn6.HeaderText = "Tanggal"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		'
		'DataGridViewTextBoxColumn8
		'
		Me.DataGridViewTextBoxColumn8.DataPropertyName = "PL_Toys"
		Me.DataGridViewTextBoxColumn8.HeaderText = "PL_Toys"
		Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
		Me.DataGridViewTextBoxColumn8.ReadOnly = True
		Me.DataGridViewTextBoxColumn8.Width = 85
		'
		'PackingListBindingSource
		'
		Me.PackingListBindingSource.DataMember = "Packing_List"
		Me.PackingListBindingSource.DataSource = Me.INVDataSet1
		'
		'INVDataSet1
		'
		Me.INVDataSet1.DataSetName = "INVDataSet1"
		Me.INVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'PanelBatas
		'
		Me.PanelBatas.BackColor = System.Drawing.Color.Violet
		Me.PanelBatas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PanelBatas.Location = New System.Drawing.Point(6, 227)
		Me.PanelBatas.Name = "PanelBatas"
		Me.PanelBatas.Size = New System.Drawing.Size(875, 10)
		Me.PanelBatas.TabIndex = 14
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ComboBoxCari)
		Me.GroupBox1.Controls.Add(Me.ButtonCariData)
		Me.GroupBox1.Controls.Add(Me.TextBoxCariData)
		Me.GroupBox1.Location = New System.Drawing.Point(429, 8)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(421, 58)
		Me.GroupBox1.TabIndex = 12
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Cari Data"
		'
		'ComboBoxCari
		'
		Me.ComboBoxCari.FormattingEnabled = True
		Me.ComboBoxCari.Items.AddRange(New Object() {"ISBN", "KODE", "NamaBarang", "Suplier", "Petugas", "RETNUMBER"})
		Me.ComboBoxCari.Location = New System.Drawing.Point(13, 20)
		Me.ComboBoxCari.Name = "ComboBoxCari"
		Me.ComboBoxCari.Size = New System.Drawing.Size(160, 21)
		Me.ComboBoxCari.TabIndex = 17
		'
		'ButtonCariData
		'
		Me.ButtonCariData.BackgroundImage = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.add_new_32px
		Me.ButtonCariData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ButtonCariData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCariData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonCariData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonCariData.Location = New System.Drawing.Point(333, 15)
		Me.ButtonCariData.Name = "ButtonCariData"
		Me.ButtonCariData.Size = New System.Drawing.Size(81, 35)
		Me.ButtonCariData.TabIndex = 16
		Me.ButtonCariData.Text = "Cari"
		Me.ButtonCariData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonCariData.UseVisualStyleBackColor = True
		'
		'TextBoxCariData
		'
		Me.TextBoxCariData.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxCariData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxCariData.Location = New System.Drawing.Point(179, 19)
		Me.TextBoxCariData.Name = "TextBoxCariData"
		Me.TextBoxCariData.Size = New System.Drawing.Size(148, 22)
		Me.TextBoxCariData.TabIndex = 2
		'
		'GroupBoxOps
		'
		Me.GroupBoxOps.Controls.Add(Me.ButtonExit)
		Me.GroupBoxOps.Controls.Add(Me.ButtonReset)
		Me.GroupBoxOps.Location = New System.Drawing.Point(429, 133)
		Me.GroupBoxOps.Name = "GroupBoxOps"
		Me.GroupBoxOps.Size = New System.Drawing.Size(143, 90)
		Me.GroupBoxOps.TabIndex = 13
		Me.GroupBoxOps.TabStop = False
		Me.GroupBoxOps.Text = "Ops"
		'
		'ButtonExit
		'
		Me.ButtonExit.BackgroundImage = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.Emergency_Exit_32px
		Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonExit.Location = New System.Drawing.Point(21, 50)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(100, 34)
		Me.ButtonExit.TabIndex = 17
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonReset
		'
		Me.ButtonReset.BackgroundImage = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.available_updates_32px
		Me.ButtonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonReset.Location = New System.Drawing.Point(21, 14)
		Me.ButtonReset.Name = "ButtonReset"
		Me.ButtonReset.Size = New System.Drawing.Size(100, 30)
		Me.ButtonReset.TabIndex = 16
		Me.ButtonReset.Text = "Reset"
		Me.ButtonReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonReset.UseVisualStyleBackColor = True
		'
		'GroupBoxInputData
		'
		Me.GroupBoxInputData.Controls.Add(Me.GroupBoxInput)
		Me.GroupBoxInputData.Controls.Add(Me.GroupBoxData)
		Me.GroupBoxInputData.Controls.Add(Me.GroupBoxCari)
		Me.GroupBoxInputData.Location = New System.Drawing.Point(6, 8)
		Me.GroupBoxInputData.Name = "GroupBoxInputData"
		Me.GroupBoxInputData.Size = New System.Drawing.Size(417, 215)
		Me.GroupBoxInputData.TabIndex = 10
		Me.GroupBoxInputData.TabStop = False
		Me.GroupBoxInputData.Text = "Input Data"
		'
		'GroupBoxInput
		'
		Me.GroupBoxInput.Controls.Add(Me.ComboBoxRT)
		Me.GroupBoxInput.Controls.Add(Me.DateTimePicker)
		Me.GroupBoxInput.Controls.Add(Me.Label1)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxPetugas)
		Me.GroupBoxInput.Controls.Add(Me.LabelQTY)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxQty)
		Me.GroupBoxInput.Location = New System.Drawing.Point(255, 77)
		Me.GroupBoxInput.Name = "GroupBoxInput"
		Me.GroupBoxInput.Size = New System.Drawing.Size(155, 131)
		Me.GroupBoxInput.TabIndex = 2
		Me.GroupBoxInput.TabStop = False
		Me.GroupBoxInput.Text = "Input"
		'
		'ComboBoxRT
		'
		Me.ComboBoxRT.FormattingEnabled = True
		Me.ComboBoxRT.Location = New System.Drawing.Point(10, 40)
		Me.ComboBoxRT.Name = "ComboBoxRT"
		Me.ComboBoxRT.Size = New System.Drawing.Size(136, 21)
		Me.ComboBoxRT.TabIndex = 13
		'
		'DateTimePicker
		'
		Me.DateTimePicker.CustomFormat = "yyyy/MM/dd"
		Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker.Location = New System.Drawing.Point(56, 16)
		Me.DateTimePicker.Name = "DateTimePicker"
		Me.DateTimePicker.Size = New System.Drawing.Size(93, 20)
		Me.DateTimePicker.TabIndex = 12
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(6, 106)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(90, 20)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Petugas : "
		'
		'TextBoxPetugas
		'
		Me.TextBoxPetugas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxPetugas.Location = New System.Drawing.Point(98, 106)
		Me.TextBoxPetugas.Name = "TextBoxPetugas"
		Me.TextBoxPetugas.Size = New System.Drawing.Size(51, 19)
		Me.TextBoxPetugas.TabIndex = 11
		'
		'LabelQTY
		'
		Me.LabelQTY.AutoSize = True
		Me.LabelQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelQTY.Location = New System.Drawing.Point(6, 80)
		Me.LabelQTY.Name = "LabelQTY"
		Me.LabelQTY.Size = New System.Drawing.Size(84, 20)
		Me.LabelQTY.TabIndex = 8
		Me.LabelQTY.Text = "QTY       :"
		'
		'TextBoxQty
		'
		Me.TextBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxQty.Location = New System.Drawing.Point(98, 79)
		Me.TextBoxQty.Name = "TextBoxQty"
		Me.TextBoxQty.Size = New System.Drawing.Size(31, 19)
		Me.TextBoxQty.TabIndex = 9
		'
		'GroupBoxData
		'
		Me.GroupBoxData.Controls.Add(Me.TextBoxSuplier)
		Me.GroupBoxData.Controls.Add(Me.Label2)
		Me.GroupBoxData.Controls.Add(Me.TextBoxNamaBarang)
		Me.GroupBoxData.Controls.Add(Me.LabelNama)
		Me.GroupBoxData.Controls.Add(Me.TextBoxCode)
		Me.GroupBoxData.Controls.Add(Me.LabelCode)
		Me.GroupBoxData.Controls.Add(Me.TextBoxISBN)
		Me.GroupBoxData.Controls.Add(Me.LabelISBN)
		Me.GroupBoxData.Location = New System.Drawing.Point(6, 77)
		Me.GroupBoxData.Name = "GroupBoxData"
		Me.GroupBoxData.Size = New System.Drawing.Size(246, 131)
		Me.GroupBoxData.TabIndex = 1
		Me.GroupBoxData.TabStop = False
		Me.GroupBoxData.Text = "Data"
		'
		'TextBoxSuplier
		'
		Me.TextBoxSuplier.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxSuplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxSuplier.Location = New System.Drawing.Point(83, 101)
		Me.TextBoxSuplier.Name = "TextBoxSuplier"
		Me.TextBoxSuplier.Size = New System.Drawing.Size(151, 22)
		Me.TextBoxSuplier.TabIndex = 9
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(7, 103)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 20)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Suplier :"
		'
		'TextBoxNamaBarang
		'
		Me.TextBoxNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxNamaBarang.Location = New System.Drawing.Point(83, 72)
		Me.TextBoxNamaBarang.Name = "TextBoxNamaBarang"
		Me.TextBoxNamaBarang.Size = New System.Drawing.Size(151, 22)
		Me.TextBoxNamaBarang.TabIndex = 7
		'
		'LabelNama
		'
		Me.LabelNama.AutoSize = True
		Me.LabelNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelNama.Location = New System.Drawing.Point(7, 73)
		Me.LabelNama.Name = "LabelNama"
		Me.LabelNama.Size = New System.Drawing.Size(75, 20)
		Me.LabelNama.TabIndex = 6
		Me.LabelNama.Text = "Nama   :"
		'
		'TextBoxCode
		'
		Me.TextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxCode.Location = New System.Drawing.Point(83, 43)
		Me.TextBoxCode.Name = "TextBoxCode"
		Me.TextBoxCode.Size = New System.Drawing.Size(151, 22)
		Me.TextBoxCode.TabIndex = 5
		'
		'LabelCode
		'
		Me.LabelCode.AutoSize = True
		Me.LabelCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelCode.Location = New System.Drawing.Point(7, 45)
		Me.LabelCode.Name = "LabelCode"
		Me.LabelCode.Size = New System.Drawing.Size(75, 20)
		Me.LabelCode.TabIndex = 4
		Me.LabelCode.Text = "Kode    :"
		'
		'TextBoxISBN
		'
		Me.TextBoxISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxISBN.Location = New System.Drawing.Point(83, 14)
		Me.TextBoxISBN.Name = "TextBoxISBN"
		Me.TextBoxISBN.Size = New System.Drawing.Size(151, 22)
		Me.TextBoxISBN.TabIndex = 3
		'
		'LabelISBN
		'
		Me.LabelISBN.AutoSize = True
		Me.LabelISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelISBN.Location = New System.Drawing.Point(7, 17)
		Me.LabelISBN.Name = "LabelISBN"
		Me.LabelISBN.Size = New System.Drawing.Size(76, 20)
		Me.LabelISBN.TabIndex = 2
		Me.LabelISBN.Text = "ISBN    :"
		'
		'GroupBoxCari
		'
		Me.GroupBoxCari.Controls.Add(Me.TextBoxCariInput)
		Me.GroupBoxCari.Controls.Add(Me.LabelInputISBN)
		Me.GroupBoxCari.Location = New System.Drawing.Point(6, 19)
		Me.GroupBoxCari.Name = "GroupBoxCari"
		Me.GroupBoxCari.Size = New System.Drawing.Size(404, 52)
		Me.GroupBoxCari.TabIndex = 0
		Me.GroupBoxCari.TabStop = False
		Me.GroupBoxCari.Text = "Cari ISBN"
		'
		'TextBoxCariInput
		'
		Me.TextBoxCariInput.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxCariInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxCariInput.Location = New System.Drawing.Point(224, 17)
		Me.TextBoxCariInput.Name = "TextBoxCariInput"
		Me.TextBoxCariInput.Size = New System.Drawing.Size(174, 22)
		Me.TextBoxCariInput.TabIndex = 1
		'
		'LabelInputISBN
		'
		Me.LabelInputISBN.AutoSize = True
		Me.LabelInputISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelInputISBN.Location = New System.Drawing.Point(23, 20)
		Me.LabelInputISBN.Name = "LabelInputISBN"
		Me.LabelInputISBN.Size = New System.Drawing.Size(195, 20)
		Me.LabelInputISBN.TabIndex = 0
		Me.LabelInputISBN.Text = "Masukan ISBN / Code :"
		'
		'GroupBoxCRUD
		'
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonDelete)
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonEdit)
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonBaru)
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonSimpan)
		Me.GroupBoxCRUD.Location = New System.Drawing.Point(429, 64)
		Me.GroupBoxCRUD.Name = "GroupBoxCRUD"
		Me.GroupBoxCRUD.Size = New System.Drawing.Size(421, 66)
		Me.GroupBoxCRUD.TabIndex = 11
		Me.GroupBoxCRUD.TabStop = False
		Me.GroupBoxCRUD.Text = "CRUD"
		'
		'ButtonDelete
		'
		Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonDelete.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.delete_trash_32px
		Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonDelete.Location = New System.Drawing.Point(313, 19)
		Me.ButtonDelete.Name = "ButtonDelete"
		Me.ButtonDelete.Size = New System.Drawing.Size(101, 35)
		Me.ButtonDelete.TabIndex = 15
		Me.ButtonDelete.Text = "Delete"
		Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonDelete.UseVisualStyleBackColor = True
		'
		'ButtonEdit
		'
		Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonEdit.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.edit_32px
		Me.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonEdit.Location = New System.Drawing.Point(222, 19)
		Me.ButtonEdit.Name = "ButtonEdit"
		Me.ButtonEdit.Size = New System.Drawing.Size(81, 35)
		Me.ButtonEdit.TabIndex = 14
		Me.ButtonEdit.Text = "Edit"
		Me.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonEdit.UseVisualStyleBackColor = True
		'
		'ButtonBaru
		'
		Me.ButtonBaru.BackgroundImage = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.add_new_32px
		Me.ButtonBaru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ButtonBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonBaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonBaru.Location = New System.Drawing.Point(13, 19)
		Me.ButtonBaru.Name = "ButtonBaru"
		Me.ButtonBaru.Size = New System.Drawing.Size(81, 35)
		Me.ButtonBaru.TabIndex = 13
		Me.ButtonBaru.Text = "Baru"
		Me.ButtonBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonBaru.UseVisualStyleBackColor = True
		'
		'ButtonSimpan
		'
		Me.ButtonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonSimpan.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.save_32px
		Me.ButtonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonSimpan.Location = New System.Drawing.Point(104, 19)
		Me.ButtonSimpan.Name = "ButtonSimpan"
		Me.ButtonSimpan.Size = New System.Drawing.Size(108, 35)
		Me.ButtonSimpan.TabIndex = 12
		Me.ButtonSimpan.Text = "Simpan"
		Me.ButtonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonSimpan.UseVisualStyleBackColor = True
		'
		'LabelPeriplus
		'
		Me.LabelPeriplus.AutoSize = True
		Me.LabelPeriplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelPeriplus.Location = New System.Drawing.Point(587, 169)
		Me.LabelPeriplus.Name = "LabelPeriplus"
		Me.LabelPeriplus.Size = New System.Drawing.Size(276, 25)
		Me.LabelPeriplus.TabIndex = 15
		Me.LabelPeriplus.Text = "PERIPLUS WAREHOUSE"
		'
		'Packing_ListTableAdapter
		'
		Me.Packing_ListTableAdapter.ClearBeforeFill = True
		'
		'FormPackingListToys
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightPink
		Me.ClientSize = New System.Drawing.Size(902, 581)
		Me.Controls.Add(Me.GroupBoxHome)
		Me.Controls.Add(Me.LabelReturSuplier)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormPackingListToys"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormPackingListToys"
		Me.GroupBoxHome.ResumeLayout(False)
		Me.GroupBoxHome.PerformLayout()
		CType(Me.DGVPLTOYS, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PackingListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.INVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBoxOps.ResumeLayout(False)
		Me.GroupBoxInputData.ResumeLayout(False)
		Me.GroupBoxInput.ResumeLayout(False)
		Me.GroupBoxInput.PerformLayout()
		Me.GroupBoxData.ResumeLayout(False)
		Me.GroupBoxData.PerformLayout()
		Me.GroupBoxCari.ResumeLayout(False)
		Me.GroupBoxCari.PerformLayout()
		Me.GroupBoxCRUD.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelReturSuplier As Label
	Friend WithEvents GroupBoxHome As GroupBox
	Friend WithEvents GroupBoxCari As GroupBox
	Friend WithEvents TextBoxCariInput As TextBox
	Friend WithEvents LabelInputISBN As Label
	Friend WithEvents GroupBoxData As GroupBox
	Friend WithEvents TextBoxISBN As TextBox
	Friend WithEvents LabelISBN As Label
	Friend WithEvents TextBoxCode As TextBox
	Friend WithEvents LabelCode As Label
	Friend WithEvents GroupBoxInputData As GroupBox
	Friend WithEvents TextBoxNamaBarang As TextBox
	Friend WithEvents LabelNama As Label
	Friend WithEvents TextBoxQty As TextBox
	Friend WithEvents LabelQTY As Label
	Friend WithEvents GroupBoxInput As GroupBox
	Friend WithEvents DateTimePicker As DateTimePicker
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBoxPetugas As TextBox
	Friend WithEvents TextBoxSuplier As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents GroupBoxCRUD As GroupBox
	Friend WithEvents ButtonSimpan As Button
	Friend WithEvents ButtonBaru As Button
	Friend WithEvents ButtonEdit As Button
	Friend WithEvents ButtonDelete As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents TextBoxCariData As TextBox
	Friend WithEvents GroupBoxOps As GroupBox
	Friend WithEvents ButtonReset As Button
	Friend WithEvents ButtonCariData As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents PanelBatas As Panel
	Friend WithEvents LabelPeriplus As Label
	Friend WithEvents DGVPLTOYS As DataGridView
	Public WithEvents LabelStatusINV As Label
	Friend WithEvents LabelStatusBRDJKT As Label
	Friend WithEvents ComboBoxRT As ComboBox
	Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents KodeBukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents RETNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SuplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PetugasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PLToysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ComboBoxCari As ComboBox
	Friend WithEvents INVDataSet1 As INVDataSet1
	Friend WithEvents PackingListBindingSource As BindingSource
	Friend WithEvents Packing_ListTableAdapter As INVDataSet1TableAdapters.Packing_ListTableAdapter
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
