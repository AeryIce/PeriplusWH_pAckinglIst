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
		Me.LabelStatusKoneksiBRDJKT = New System.Windows.Forms.Label()
		Me.GroupBoxInput = New System.Windows.Forms.GroupBox()
		Me.TextBoxKodeBuku = New System.Windows.Forms.TextBox()
		Me.LabelKodeBuku = New System.Windows.Forms.Label()
		Me.TextBoxJudul = New System.Windows.Forms.TextBox()
		Me.LabelJudul = New System.Windows.Forms.Label()
		Me.TextBoxPetugas = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBoxKodePacking = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBoxMasukanQTY = New System.Windows.Forms.TextBox()
		Me.TextBoxMasukanISBN = New System.Windows.Forms.TextBox()
		Me.LabelMasukanQTY = New System.Windows.Forms.Label()
		Me.LabelMasukanISBN = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.GroupBoxCRUD = New System.Windows.Forms.GroupBox()
		Me.ButtonSearch = New System.Windows.Forms.Button()
		Me.ButtonDelete = New System.Windows.Forms.Button()
		Me.ButtonEdit = New System.Windows.Forms.Button()
		Me.ButtonSave = New System.Windows.Forms.Button()
		Me.ButtonCetak = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.LabelStatusKoneksiINV = New System.Windows.Forms.Label()
		Me.GroupBoxInput.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxCRUD.SuspendLayout()
		Me.SuspendLayout()
		'
		'LabelStatusKoneksiBRDJKT
		'
		Me.LabelStatusKoneksiBRDJKT.AutoSize = True
		Me.LabelStatusKoneksiBRDJKT.Font = New System.Drawing.Font("Lucida Console", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusKoneksiBRDJKT.Location = New System.Drawing.Point(994, 412)
		Me.LabelStatusKoneksiBRDJKT.Name = "LabelStatusKoneksiBRDJKT"
		Me.LabelStatusKoneksiBRDJKT.Size = New System.Drawing.Size(11, 8)
		Me.LabelStatusKoneksiBRDJKT.TabIndex = 0
		Me.LabelStatusKoneksiBRDJKT.Text = "."
		'
		'GroupBoxInput
		'
		Me.GroupBoxInput.Controls.Add(Me.TextBoxKodeBuku)
		Me.GroupBoxInput.Controls.Add(Me.LabelKodeBuku)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxJudul)
		Me.GroupBoxInput.Controls.Add(Me.LabelJudul)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxPetugas)
		Me.GroupBoxInput.Controls.Add(Me.Label3)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxKodePacking)
		Me.GroupBoxInput.Controls.Add(Me.Label2)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxMasukanQTY)
		Me.GroupBoxInput.Controls.Add(Me.TextBoxMasukanISBN)
		Me.GroupBoxInput.Controls.Add(Me.LabelMasukanQTY)
		Me.GroupBoxInput.Controls.Add(Me.LabelMasukanISBN)
		Me.GroupBoxInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBoxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBoxInput.Location = New System.Drawing.Point(12, 116)
		Me.GroupBoxInput.Name = "GroupBoxInput"
		Me.GroupBoxInput.Size = New System.Drawing.Size(432, 292)
		Me.GroupBoxInput.TabIndex = 1
		Me.GroupBoxInput.TabStop = False
		Me.GroupBoxInput.Text = "Input "
		'
		'TextBoxKodeBuku
		'
		Me.TextBoxKodeBuku.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxKodeBuku.Location = New System.Drawing.Point(162, 209)
		Me.TextBoxKodeBuku.Name = "TextBoxKodeBuku"
		Me.TextBoxKodeBuku.Size = New System.Drawing.Size(90, 22)
		Me.TextBoxKodeBuku.TabIndex = 12
		'
		'LabelKodeBuku
		'
		Me.LabelKodeBuku.AutoSize = True
		Me.LabelKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelKodeBuku.Location = New System.Drawing.Point(20, 209)
		Me.LabelKodeBuku.Name = "LabelKodeBuku"
		Me.LabelKodeBuku.Size = New System.Drawing.Size(136, 20)
		Me.LabelKodeBuku.TabIndex = 11
		Me.LabelKodeBuku.Text = "Kode Buku       :"
		'
		'TextBoxJudul
		'
		Me.TextBoxJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxJudul.Location = New System.Drawing.Point(162, 174)
		Me.TextBoxJudul.Name = "TextBoxJudul"
		Me.TextBoxJudul.Size = New System.Drawing.Size(194, 22)
		Me.TextBoxJudul.TabIndex = 10
		'
		'LabelJudul
		'
		Me.LabelJudul.AutoSize = True
		Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelJudul.Location = New System.Drawing.Point(20, 177)
		Me.LabelJudul.Name = "LabelJudul"
		Me.LabelJudul.Size = New System.Drawing.Size(137, 20)
		Me.LabelJudul.TabIndex = 9
		Me.LabelJudul.Text = "Judul                :"
		'
		'TextBoxPetugas
		'
		Me.TextBoxPetugas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxPetugas.Location = New System.Drawing.Point(315, 53)
		Me.TextBoxPetugas.Name = "TextBoxPetugas"
		Me.TextBoxPetugas.Size = New System.Drawing.Size(111, 19)
		Me.TextBoxPetugas.TabIndex = 8
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(172, 53)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(134, 18)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Petugas            :"
		'
		'TextBoxKodePacking
		'
		Me.TextBoxKodePacking.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxKodePacking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxKodePacking.Location = New System.Drawing.Point(315, 28)
		Me.TextBoxKodePacking.Name = "TextBoxKodePacking"
		Me.TextBoxKodePacking.Size = New System.Drawing.Size(111, 19)
		Me.TextBoxKodePacking.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(172, 25)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(137, 18)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Kode Packing    :"
		'
		'TextBoxMasukanQTY
		'
		Me.TextBoxMasukanQTY.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxMasukanQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxMasukanQTY.Location = New System.Drawing.Point(162, 143)
		Me.TextBoxMasukanQTY.Name = "TextBoxMasukanQTY"
		Me.TextBoxMasukanQTY.Size = New System.Drawing.Size(39, 19)
		Me.TextBoxMasukanQTY.TabIndex = 3
		'
		'TextBoxMasukanISBN
		'
		Me.TextBoxMasukanISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxMasukanISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxMasukanISBN.Location = New System.Drawing.Point(162, 114)
		Me.TextBoxMasukanISBN.Name = "TextBoxMasukanISBN"
		Me.TextBoxMasukanISBN.Size = New System.Drawing.Size(194, 22)
		Me.TextBoxMasukanISBN.TabIndex = 2
		'
		'LabelMasukanQTY
		'
		Me.LabelMasukanQTY.AutoSize = True
		Me.LabelMasukanQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelMasukanQTY.Location = New System.Drawing.Point(19, 143)
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
		Me.LabelMasukanISBN.Location = New System.Drawing.Point(18, 114)
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
		'DateTimePicker
		'
		Me.DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker.CustomFormat = "yyyy/MM/dd"
		Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker.Location = New System.Drawing.Point(892, 57)
		Me.DateTimePicker.Name = "DateTimePicker"
		Me.DateTimePicker.Size = New System.Drawing.Size(222, 22)
		Me.DateTimePicker.TabIndex = 4
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 433)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(1115, 171)
		Me.DataGridView1.TabIndex = 5
		'
		'GroupBoxCRUD
		'
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonSearch)
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonDelete)
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonEdit)
		Me.GroupBoxCRUD.Controls.Add(Me.ButtonSave)
		Me.GroupBoxCRUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBoxCRUD.Location = New System.Drawing.Point(465, 116)
		Me.GroupBoxCRUD.Name = "GroupBoxCRUD"
		Me.GroupBoxCRUD.Size = New System.Drawing.Size(528, 110)
		Me.GroupBoxCRUD.TabIndex = 6
		Me.GroupBoxCRUD.TabStop = False
		Me.GroupBoxCRUD.Text = "CRUD Packing List"
		'
		'ButtonSearch
		'
		Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonSearch.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.search_32px
		Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonSearch.Location = New System.Drawing.Point(387, 41)
		Me.ButtonSearch.Name = "ButtonSearch"
		Me.ButtonSearch.Size = New System.Drawing.Size(117, 38)
		Me.ButtonSearch.TabIndex = 3
		Me.ButtonSearch.Text = "Search"
		Me.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonSearch.UseVisualStyleBackColor = True
		'
		'ButtonDelete
		'
		Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonDelete.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.delete_trash_32px
		Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonDelete.Location = New System.Drawing.Point(254, 42)
		Me.ButtonDelete.Name = "ButtonDelete"
		Me.ButtonDelete.Size = New System.Drawing.Size(114, 38)
		Me.ButtonDelete.TabIndex = 2
		Me.ButtonDelete.Text = "Delete"
		Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonDelete.UseVisualStyleBackColor = True
		'
		'ButtonEdit
		'
		Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonEdit.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.edit_32px
		Me.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonEdit.Location = New System.Drawing.Point(136, 42)
		Me.ButtonEdit.Name = "ButtonEdit"
		Me.ButtonEdit.Size = New System.Drawing.Size(100, 38)
		Me.ButtonEdit.TabIndex = 1
		Me.ButtonEdit.Text = "Edit"
		Me.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonEdit.UseVisualStyleBackColor = True
		'
		'ButtonSave
		'
		Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonSave.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.save_32px
		Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonSave.Location = New System.Drawing.Point(17, 42)
		Me.ButtonSave.Name = "ButtonSave"
		Me.ButtonSave.Size = New System.Drawing.Size(100, 38)
		Me.ButtonSave.TabIndex = 0
		Me.ButtonSave.Text = "Save"
		Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonSave.UseVisualStyleBackColor = True
		'
		'ButtonCetak
		'
		Me.ButtonCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ButtonCetak.Image = Global.PeriplusWH_pAckinglIst.My.Resources.Resources.print_32px
		Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonCetak.Location = New System.Drawing.Point(844, 370)
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
		Me.ButtonExit.Location = New System.Drawing.Point(989, 370)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(125, 38)
		Me.ButtonExit.TabIndex = 4
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'LabelStatusKoneksiINV
		'
		Me.LabelStatusKoneksiINV.AutoSize = True
		Me.LabelStatusKoneksiINV.Font = New System.Drawing.Font("Lucida Console", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusKoneksiINV.Location = New System.Drawing.Point(994, 422)
		Me.LabelStatusKoneksiINV.Name = "LabelStatusKoneksiINV"
		Me.LabelStatusKoneksiINV.Size = New System.Drawing.Size(11, 8)
		Me.LabelStatusKoneksiINV.TabIndex = 8
		Me.LabelStatusKoneksiINV.Text = "."
		'
		'FormPackingList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(1139, 646)
		Me.Controls.Add(Me.LabelStatusKoneksiINV)
		Me.Controls.Add(Me.ButtonCetak)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.GroupBoxCRUD)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBoxInput)
		Me.Controls.Add(Me.DateTimePicker)
		Me.Controls.Add(Me.LabelStatusKoneksiBRDJKT)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormPackingList"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form Packing List"
		Me.GroupBoxInput.ResumeLayout(False)
		Me.GroupBoxInput.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxCRUD.ResumeLayout(False)
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
	Friend WithEvents TextBoxKodePacking As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents DateTimePicker As DateTimePicker
	Friend WithEvents DataGridView1 As DataGridView
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
	Friend WithEvents TextBoxPetugas As TextBox
	Friend WithEvents Label3 As Label
	Public WithEvents LabelStatusKoneksiINV As Label
End Class
