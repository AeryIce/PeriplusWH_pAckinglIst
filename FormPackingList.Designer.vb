<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPackingList
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.LabelStatusKoneksiBRDJKT = New System.Windows.Forms.Label()
		Me.GroupBoxInput = New System.Windows.Forms.GroupBox()
		Me.ButtonNewPL = New System.Windows.Forms.Button()
		Me.ButtonDelete = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.ButtonEdit = New System.Windows.Forms.Button()
		Me.TextBoxPetugas = New System.Windows.Forms.TextBox()
		Me.ButtonSave = New System.Windows.Forms.Button()
		Me.TextBoxBox = New System.Windows.Forms.TextBox()
		Me.LabelBox = New System.Windows.Forms.Label()
		Me.Labelkoli = New System.Windows.Forms.Label()
		Me.TextBoxKodeBuku = New System.Windows.Forms.TextBox()
		Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.LabelKodeBuku = New System.Windows.Forms.Label()
		Me.TextBoxJudul = New System.Windows.Forms.TextBox()
		Me.LabelJudul = New System.Windows.Forms.Label()
		Me.TextBoxKoli = New System.Windows.Forms.TextBox()
		Me.LabelPetugas = New System.Windows.Forms.Label()
		Me.TextBoxPalet = New System.Windows.Forms.TextBox()
		Me.LabelPalet = New System.Windows.Forms.Label()
		Me.TextBoxMasukanQTY = New System.Windows.Forms.TextBox()
		Me.TextBoxMasukanISBN = New System.Windows.Forms.TextBox()
		Me.LabelMasukanQTY = New System.Windows.Forms.Label()
		Me.LabelMasukanISBN = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBoxCRUD = New System.Windows.Forms.GroupBox()
		Me.TextBoxCari = New System.Windows.Forms.TextBox()
		Me.ButtonSearch = New System.Windows.Forms.Button()
		Me.LabelStatusKoneksiINV = New System.Windows.Forms.Label()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ButtonCetak = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.INVDataSet = New PeriplusWH_pAckinglIst.INVDataSet()
		Me.PackingListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.Packing_ListTableAdapter = New PeriplusWH_pAckinglIst.INVDataSetTableAdapters.Packing_ListTableAdapter()
		Me.PaletDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.KoliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BoxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PlIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PetugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.KodeBukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GroupBoxInput.SuspendLayout()
		Me.GroupBoxCRUD.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PackingListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LabelStatusKoneksiBRDJKT
		'
		Me.LabelStatusKoneksiBRDJKT.AutoSize = True
		Me.LabelStatusKoneksiBRDJKT.Font = New System.Drawing.Font("Lucida Console", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusKoneksiBRDJKT.Location = New System.Drawing.Point(956, 452)
		Me.LabelStatusKoneksiBRDJKT.Name = "LabelStatusKoneksiBRDJKT"
		Me.LabelStatusKoneksiBRDJKT.Size = New System.Drawing.Size(11, 8)
		Me.LabelStatusKoneksiBRDJKT.TabIndex = 0
		Me.LabelStatusKoneksiBRDJKT.Text = "."
		'
		'GroupBoxInput
		'
		Me.GroupBoxInput.Controls.Add(Me.ButtonNewPL)
		Me.GroupBoxInput.Controls.Add(Me.ButtonDelete)
		Me.GroupBoxInput.Controls.Add(Me.Panel1)
		Me.GroupBoxInput.Controls.Add(Me.ButtonEdit)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxPetugas)
		Me.GroupBoxInput.Controls.Add(Me.ButtonSave)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxBox)
		Me.GroupBoxInput.Controls.Add(Me.LabelBox)
		Me.GroupBoxInput.Controls.Add(Me.Labelkoli)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxKodeBuku)
		Me.GroupBoxInput.Controls.Add(Me.DateTimePicker)
		Me.GroupBoxInput.Controls.Add(Me.LabelKodeBuku)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxJudul)
		Me.GroupBoxInput.Controls.Add(Me.LabelJudul)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxKoli)
		Me.GroupBoxInput.Controls.Add(Me.LabelPetugas)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxPalet)
		Me.GroupBoxInput.Controls.Add(Me.LabelPalet)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxMasukanQTY)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxMasukanISBN)
		Me.GroupBoxInput.Controls.Add(Me.LabelMasukanQTY)
		Me.GroupBoxInput.Controls.Add(Me.LabelMasukanISBN)
		Me.GroupBoxInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBoxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBoxInput.Location = New System.Drawing.Point(12, 51)
		Me.GroupBoxInput.Name = "GroupBoxInput"
		Me.GroupBoxInput.Size = New System.Drawing.Size(381, 419)
		Me.GroupBoxInput.TabIndex = 1
		Me.GroupBoxInput.TabStop = False
		Me.GroupBoxInput.Text = "Input "
		'
		'ButtonNewPL
		'
		Me.ButtonNewPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonNewPL.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.add_new_32px
		Me.ButtonNewPL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonNewPL.Location = New System.Drawing.Point(256, 24)
		Me.ButtonNewPL.Name = "ButtonNewPL"
		Me.ButtonNewPL.Size = New System.Drawing.Size(103, 30)
		Me.ButtonNewPL.TabIndex = 18
		Me.ButtonNewPL.Text = "NEW"
		Me.ButtonNewPL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonNewPL.UseVisualStyleBackColor = True
		'
		'ButtonDelete
		'
		Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonDelete.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.delete_trash_32px
		Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonDelete.Location = New System.Drawing.Point(256, 135)
		Me.ButtonDelete.Name = "ButtonDelete"
		Me.ButtonDelete.Size = New System.Drawing.Size(103, 32)
		Me.ButtonDelete.TabIndex = 2
		Me.ButtonDelete.Text = "Delete"
		Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonDelete.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.Panel1.Location = New System.Drawing.Point(0, 176)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(430, 10)
		Me.Panel1.TabIndex = 17
		'
		'ButtonEdit
		'
		Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonEdit.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.edit_32px
		Me.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonEdit.Location = New System.Drawing.Point(256, 97)
		Me.ButtonEdit.Name = "ButtonEdit"
		Me.ButtonEdit.Size = New System.Drawing.Size(103, 32)
		Me.ButtonEdit.TabIndex = 1
		Me.ButtonEdit.Text = "Edit"
		Me.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonEdit.UseVisualStyleBackColor = True
		'
		'TextBoxPetugas
		'
		Me.TextBoxPetugas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxPetugas.Location = New System.Drawing.Point(136, 135)
		Me.TextBoxPetugas.Name = "TextBoxPetugas"
		Me.TextBoxPetugas.Size = New System.Drawing.Size(111, 24)
		Me.TextBoxPetugas.TabIndex = 16
		'
		'ButtonSave
		'
		Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonSave.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.save_32px
		Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonSave.Location = New System.Drawing.Point(256, 60)
		Me.ButtonSave.Name = "ButtonSave"
		Me.ButtonSave.Size = New System.Drawing.Size(103, 31)
		Me.ButtonSave.TabIndex = 0
		Me.ButtonSave.Text = "Save"
		Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonSave.UseVisualStyleBackColor = True
		'
		'TextBoxBox
		'
		Me.TextBoxBox.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxBox.Location = New System.Drawing.Point(136, 100)
		Me.TextBoxBox.Name = "TextBoxBox"
		Me.TextBoxBox.Size = New System.Drawing.Size(111, 24)
		Me.TextBoxBox.TabIndex = 15
		'
		'LabelBox
		'
		Me.LabelBox.AutoSize = True
		Me.LabelBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelBox.Location = New System.Drawing.Point(3, 98)
		Me.LabelBox.Name = "LabelBox"
		Me.LabelBox.Size = New System.Drawing.Size(122, 25)
		Me.LabelBox.TabIndex = 14
		Me.LabelBox.Text = "Box         :"
		'
		'Labelkoli
		'
		Me.Labelkoli.AutoSize = True
		Me.Labelkoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Labelkoli.Location = New System.Drawing.Point(4, 62)
		Me.Labelkoli.Name = "Labelkoli"
		Me.Labelkoli.Size = New System.Drawing.Size(122, 25)
		Me.Labelkoli.TabIndex = 13
		Me.Labelkoli.Text = "Koli         :"
		'
		'TextBoxKodeBuku
		'
		Me.TextBoxKodeBuku.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxKodeBuku.Location = New System.Drawing.Point(175, 316)
		Me.TextBoxKodeBuku.Name = "TextBoxKodeBuku"
		Me.TextBoxKodeBuku.Size = New System.Drawing.Size(90, 22)
		Me.TextBoxKodeBuku.TabIndex = 12
		'
		'DateTimePicker
		'
		Me.DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker.CustomFormat = "yyyy/MM/dd"
		Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker.Location = New System.Drawing.Point(153, 191)
		Me.DateTimePicker.Name = "DateTimePicker"
		Me.DateTimePicker.Size = New System.Drawing.Size(222, 22)
		Me.DateTimePicker.TabIndex = 4
		'
		'LabelKodeBuku
		'
		Me.LabelKodeBuku.AutoSize = True
		Me.LabelKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelKodeBuku.Location = New System.Drawing.Point(35, 311)
		Me.LabelKodeBuku.Name = "LabelKodeBuku"
		Me.LabelKodeBuku.Size = New System.Drawing.Size(136, 20)
		Me.LabelKodeBuku.TabIndex = 11
		Me.LabelKodeBuku.Text = "Kode Buku       :"
		'
		'TextBoxJudul
		'
		Me.TextBoxJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxJudul.Location = New System.Drawing.Point(175, 344)
		Me.TextBoxJudul.Name = "TextBoxJudul"
		Me.TextBoxJudul.Size = New System.Drawing.Size(194, 22)
		Me.TextBoxJudul.TabIndex = 10
		'
		'LabelJudul
		'
		Me.LabelJudul.AutoSize = True
		Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelJudul.Location = New System.Drawing.Point(35, 344)
		Me.LabelJudul.Name = "LabelJudul"
		Me.LabelJudul.Size = New System.Drawing.Size(137, 20)
		Me.LabelJudul.TabIndex = 9
		Me.LabelJudul.Text = "Judul                :"
		'
		'TextBoxKoli
		'
		Me.TextBoxKoli.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxKoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxKoli.Location = New System.Drawing.Point(136, 63)
		Me.TextBoxKoli.Name = "TextBoxKoli"
		Me.TextBoxKoli.Size = New System.Drawing.Size(111, 24)
		Me.TextBoxKoli.TabIndex = 8
		'
		'LabelPetugas
		'
		Me.LabelPetugas.AutoSize = True
		Me.LabelPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelPetugas.Location = New System.Drawing.Point(0, 134)
		Me.LabelPetugas.Name = "LabelPetugas"
		Me.LabelPetugas.Size = New System.Drawing.Size(126, 25)
		Me.LabelPetugas.TabIndex = 7
		Me.LabelPetugas.Text = "Petugas   :"
		'
		'TextBoxPalet
		'
		Me.TextBoxPalet.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxPalet.Location = New System.Drawing.Point(136, 26)
		Me.TextBoxPalet.Name = "TextBoxPalet"
		Me.TextBoxPalet.Size = New System.Drawing.Size(111, 24)
		Me.TextBoxPalet.TabIndex = 6
		'
		'LabelPalet
		'
		Me.LabelPalet.AutoSize = True
		Me.LabelPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelPalet.Location = New System.Drawing.Point(4, 26)
		Me.LabelPalet.Name = "LabelPalet"
		Me.LabelPalet.Size = New System.Drawing.Size(122, 25)
		Me.LabelPalet.TabIndex = 5
		Me.LabelPalet.Text = "Palet       :"
		'
		'TextBoxMasukanQTY
		'
		Me.TextBoxMasukanQTY.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxMasukanQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxMasukanQTY.Location = New System.Drawing.Point(175, 264)
		Me.TextBoxMasukanQTY.Name = "TextBoxMasukanQTY"
		Me.TextBoxMasukanQTY.Size = New System.Drawing.Size(39, 19)
		Me.TextBoxMasukanQTY.TabIndex = 3
		'
		'TextBoxMasukanISBN
		'
		Me.TextBoxMasukanISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxMasukanISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxMasukanISBN.Location = New System.Drawing.Point(175, 235)
		Me.TextBoxMasukanISBN.Name = "TextBoxMasukanISBN"
		Me.TextBoxMasukanISBN.Size = New System.Drawing.Size(194, 22)
		Me.TextBoxMasukanISBN.TabIndex = 2
		'
		'LabelMasukanQTY
		'
		Me.LabelMasukanQTY.AutoSize = True
		Me.LabelMasukanQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelMasukanQTY.Location = New System.Drawing.Point(32, 264)
		Me.LabelMasukanQTY.Name = "LabelMasukanQTY"
		Me.LabelMasukanQTY.Size = New System.Drawing.Size(139, 20)
		Me.LabelMasukanQTY.TabIndex = 1
		Me.LabelMasukanQTY.Text = "QTY                  :"
		Me.LabelMasukanQTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelMasukanISBN
		'
		Me.LabelMasukanISBN.AutoSize = True
		Me.LabelMasukanISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelMasukanISBN.Location = New System.Drawing.Point(31, 235)
		Me.LabelMasukanISBN.Name = "LabelMasukanISBN"
		Me.LabelMasukanISBN.Size = New System.Drawing.Size(138, 20)
		Me.LabelMasukanISBN.TabIndex = 0
		Me.LabelMasukanISBN.Text = "Masukan ISBN :"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Lucida Console", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(384, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(318, 27)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Input Packing List"
		'
		'GroupBoxCRUD
		'
		Me.GroupBoxCRUD.Controls.Add(Me.TextBoxCari)
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonSearch)
		Me.GroupBoxCRUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBoxCRUD.Location = New System.Drawing.Point(399, 51)
		Me.GroupBoxCRUD.Name = "GroupBoxCRUD"
		Me.GroupBoxCRUD.Size = New System.Drawing.Size(684, 82)
		Me.GroupBoxCRUD.TabIndex = 6
		Me.GroupBoxCRUD.TabStop = False
		Me.GroupBoxCRUD.Text = "CRUD Packing List"
		'
		'TextBoxCari
		'
		Me.TextBoxCari.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxCari.Location = New System.Drawing.Point(16, 32)
		Me.TextBoxCari.Name = "TextBoxCari"
		Me.TextBoxCari.Size = New System.Drawing.Size(365, 28)
		Me.TextBoxCari.TabIndex = 7
		'
		'ButtonSearch
		'
		Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonSearch.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.search_32px
		Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonSearch.Location = New System.Drawing.Point(387, 26)
		Me.ButtonSearch.Name = "ButtonSearch"
		Me.ButtonSearch.Size = New System.Drawing.Size(117, 38)
		Me.ButtonSearch.TabIndex = 3
		Me.ButtonSearch.Text = "Search"
		Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonSearch.UseVisualStyleBackColor = True
		'
		'LabelStatusKoneksiINV
		'
		Me.LabelStatusKoneksiINV.AutoSize = True
		Me.LabelStatusKoneksiINV.Font = New System.Drawing.Font("Lucida Console", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusKoneksiINV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.LabelStatusKoneksiINV.Location = New System.Drawing.Point(956, 462)
		Me.LabelStatusKoneksiINV.Name = "LabelStatusKoneksiINV"
		Me.LabelStatusKoneksiINV.Size = New System.Drawing.Size(11, 8)
		Me.LabelStatusKoneksiINV.TabIndex = 8
		Me.LabelStatusKoneksiINV.Text = "."
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaletDataGridViewTextBoxColumn, Me.KoliDataGridViewTextBoxColumn, Me.BoxDataGridViewTextBoxColumn, Me.PlIdDataGridViewTextBoxColumn, Me.PetugasDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.KodeBukuDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.PackingListBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(399, 139)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(685, 260)
		Me.DataGridView1.TabIndex = 9
		'
		'ButtonCetak
		'
		Me.ButtonCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonCetak.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.print_32px
		Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonCetak.Location = New System.Drawing.Point(813, 408)
		Me.ButtonCetak.Name = "ButtonCetak"
		Me.ButtonCetak.Size = New System.Drawing.Size(125, 38)
		Me.ButtonCetak.TabIndex = 7
		Me.ButtonCetak.Text = "Cetak"
		Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonCetak.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonExit.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.exit_32px
		Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonExit.Location = New System.Drawing.Point(958, 408)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(125, 38)
		Me.ButtonExit.TabIndex = 4
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'INVDataSet
		'
		Me.INVDataSet.DataSetName = "INVDataSet"
		Me.INVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'PackingListBindingSource
		'
		Me.PackingListBindingSource.DataMember = "Packing_List"
		Me.PackingListBindingSource.DataSource = Me.INVDataSet
		'
		'Packing_ListTableAdapter
		'
		Me.Packing_ListTableAdapter.ClearBeforeFill = True
		'
		'PaletDataGridViewTextBoxColumn
		'
		Me.PaletDataGridViewTextBoxColumn.DataPropertyName = "Palet"
		Me.PaletDataGridViewTextBoxColumn.HeaderText = "Palet"
		Me.PaletDataGridViewTextBoxColumn.Name = "PaletDataGridViewTextBoxColumn"
		Me.PaletDataGridViewTextBoxColumn.Width = 35
		'
		'KoliDataGridViewTextBoxColumn
		'
		Me.KoliDataGridViewTextBoxColumn.DataPropertyName = "Koli"
		Me.KoliDataGridViewTextBoxColumn.HeaderText = "Koli"
		Me.KoliDataGridViewTextBoxColumn.Name = "KoliDataGridViewTextBoxColumn"
		Me.KoliDataGridViewTextBoxColumn.Width = 35
		'
		'BoxDataGridViewTextBoxColumn
		'
		Me.BoxDataGridViewTextBoxColumn.DataPropertyName = "Box"
		Me.BoxDataGridViewTextBoxColumn.HeaderText = "Box"
		Me.BoxDataGridViewTextBoxColumn.Name = "BoxDataGridViewTextBoxColumn"
		Me.BoxDataGridViewTextBoxColumn.Width = 35
		'
		'PlIdDataGridViewTextBoxColumn
		'
		Me.PlIdDataGridViewTextBoxColumn.DataPropertyName = "Pl_Id"
		Me.PlIdDataGridViewTextBoxColumn.HeaderText = "Pl_Id"
		Me.PlIdDataGridViewTextBoxColumn.Name = "PlIdDataGridViewTextBoxColumn"
		Me.PlIdDataGridViewTextBoxColumn.ReadOnly = True
		Me.PlIdDataGridViewTextBoxColumn.Width = 50
		'
		'PetugasDataGridViewTextBoxColumn
		'
		Me.PetugasDataGridViewTextBoxColumn.DataPropertyName = "Petugas"
		Me.PetugasDataGridViewTextBoxColumn.HeaderText = "Petugas"
		Me.PetugasDataGridViewTextBoxColumn.Name = "PetugasDataGridViewTextBoxColumn"
		Me.PetugasDataGridViewTextBoxColumn.Width = 75
		'
		'ISBNDataGridViewTextBoxColumn
		'
		Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
		Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
		Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
		'
		'KodeBukuDataGridViewTextBoxColumn
		'
		Me.KodeBukuDataGridViewTextBoxColumn.DataPropertyName = "KodeBuku"
		Me.KodeBukuDataGridViewTextBoxColumn.HeaderText = "KodeBuku"
		Me.KodeBukuDataGridViewTextBoxColumn.Name = "KodeBukuDataGridViewTextBoxColumn"
		Me.KodeBukuDataGridViewTextBoxColumn.Width = 65
		'
		'JudulDataGridViewTextBoxColumn
		'
		Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "Judul"
		Me.JudulDataGridViewTextBoxColumn.HeaderText = "Judul"
		Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
		Me.JudulDataGridViewTextBoxColumn.Width = 145
		'
		'QtyDataGridViewTextBoxColumn
		'
		Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
		Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
		Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
		Me.QtyDataGridViewTextBoxColumn.Width = 35
		'
		'TanggalDataGridViewTextBoxColumn
		'
		Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal"
		Me.TanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal"
		Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
		Me.TanggalDataGridViewTextBoxColumn.Width = 65
		'
		'FormPackingList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(1095, 480)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.LabelStatusKoneksiINV)
		Me.Controls.Add(Me.ButtonCetak)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.GroupBoxCRUD)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBoxInput)
		Me.Controls.Add(Me.LabelStatusKoneksiBRDJKT)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormPackingList"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form Packing List"
		Me.GroupBoxInput.ResumeLayout(False)
		Me.GroupBoxInput.PerformLayout()
		Me.GroupBoxCRUD.ResumeLayout(False)
		Me.GroupBoxCRUD.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.INVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PackingListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Public WithEvents LabelStatusKoneksiBRDJKT As Label
	Friend WithEvents GroupBoxInput As GroupBox
	Friend WithEvents TextBoxMasukanQTY As TextBox
	Friend WithEvents TextBoxMasukanISBN As TextBox
	Friend WithEvents LabelMasukanQTY As Label
	Friend WithEvents LabelMasukanISBN As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBoxPalet As TextBox
	Friend WithEvents LabelPalet As Label
	Friend WithEvents DateTimePicker As DateTimePicker
	Friend WithEvents GroupBoxCRUD As GroupBox
	Friend WithEvents ButtonSave As Button
	Friend WithEvents ButtonEdit As Button
	Friend WithEvents ButtonDelete As Button
	Friend WithEvents ButtonSearch As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonCetak As Button
	Friend WithEvents TextBoxKodeBuku As TextBox
	Friend WithEvents LabelKodeBuku As Label
	Friend WithEvents TextBoxJudul As TextBox
	Friend WithEvents LabelJudul As Label
	Friend WithEvents TextBoxKoli As TextBox
	Friend WithEvents LabelPetugas As Label
	Public WithEvents LabelStatusKoneksiINV As Label
	Friend WithEvents PrintDocument1 As Printing.PrintDocument
	Friend WithEvents LabelBox As Label
	Friend WithEvents Labelkoli As Label
	Friend WithEvents TextBoxBox As TextBox
	Friend WithEvents TextBoxPetugas As TextBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents ButtonNewPL As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents TextBoxCari As TextBox
	Friend WithEvents INVDataSet As INVDataSet
	Friend WithEvents PackingListBindingSource As BindingSource
	Friend WithEvents Packing_ListTableAdapter As INVDataSetTableAdapters.Packing_ListTableAdapter
	Friend WithEvents PaletDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents KoliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BoxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PlIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PetugasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents KodeBukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
