Imports System.Data.SqlClient
Public Class FormPackingListToys


	Sub RefreshDGV()
		Call KonekDbINV()
		Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE RETNUMBER IS NOT NULL ", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE RETNUMBER IS NOT NULL ", Conn)
			Ds = New DataSet
			Da.Fill(Ds)

			DGVPLTOYS.DataSource = Ds.Tables(0)
		End If
	End Sub
	Sub BersihkanTextBox()
		TextBoxCariInput.Text = ""
		TextBoxISBN.Text = ""
		TextBoxNamaBarang.Text = ""
		TextBoxCode.Text = ""
		TextBoxSuplier.Text = ""
		ComboBoxRT.Text = ""
		TextBoxQty.Text = ""
		TextBoxPetugas.Text = ""

	End Sub

	Sub DisabledText()
		TextBoxCariInput.Enabled = False
		TextBoxISBN.Enabled = False
		TextBoxNamaBarang.Enabled = False
		TextBoxCode.Enabled = False
		TextBoxSuplier.Enabled = False
		ComboBoxRT.Enabled = False
		TextBoxQty.Enabled = False
		TextBoxPetugas.Enabled = False
		DateTimePicker.Enabled = False
	End Sub
	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()

	End Sub

	Private Sub FormPackingListToys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'INVDataSet1.Packing_List' table. You can move, or remove it, as needed.
		Me.Packing_ListTableAdapter.Fill(Me.INVDataSet1.Packing_List)
		'TODO: This line of code loads data into the 'INVDataSet3.Packing_List' table. You can move, or remove it, as needed.


		Call KonekDbBRDJKT()
		Call KonekDbINV()
		Call RefreshDGV()

		TextBoxCariInput.Focus()

		DateTimePicker.Format = DateTimePickerFormat.Custom
		DateTimePicker.CustomFormat = "yyyy/MM/dd"


		'Adding Item on ComboBoxCari
		ComboBoxCari.Items.Add("RETNUMBER")
		ComboBoxCari.Items.Add("ISBN")
		ComboBoxCari.Items.Add("Kodebuku")
		ComboBoxCari.Items.Add("Suplier")
		ComboBoxCari.Items.Add("Petugas")
		ComboBoxCari.Items.Add("Judul")

	End Sub

	Private Sub TextBoxCariInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCariInput.KeyPress
		If e.KeyChar = Chr(13) Then
			TextBoxISBN.ReadOnly = True
			TextBoxCode.ReadOnly = True
			TextBoxNamaBarang.ReadOnly = True
			TextBoxSuplier.ReadOnly = True
			Call KonekDbBRDJKT()
			Cmd = New SqlCommand("SELECT  a.ITEMNO,a.OPTFLD4, a.[DESC],a.OPTFLD4, b.DATA ,d.RETNUMBER
                                  FROM icitem a 
                                  JOIN CSOPT b on a.OPTFLD5 = b.CODE 
                                  JOIN PORETL c on a.ITEMNO = c.ITEMNO
                                  JOIN PORETH1 d on d.RETHSEQ = c.RETHSEQ
                                  WHERE a.ITEMNO = '" & TextBoxCariInput.Text & "' OR a.OPTFLD4 = '" & TextBoxCariInput.Text & "'", Conn)
			Dr = Cmd.ExecuteReader()
			Dr.Read()
			If Dr.HasRows Then
				TextBoxISBN.Text = Dr.Item("ITEMNO")
				TextBoxCode.Text = Dr.Item("OPTFLD4")
				TextBoxNamaBarang.Text = Dr.Item("DESC")
				TextBoxSuplier.Text = Dr.Item("DATA")

				Dim Dt As DataTable = New DataTable
				Dt.Load(Dr)
				ComboBoxRT.ValueMember = "PORETH1"
				ComboBoxRT.DisplayMember = "RETNUMBER"
				ComboBoxRT.DataSource = Dt

				ComboBoxRT.Focus()
			Else
				If MsgBox("Maaf Data Tidak Ada,Ulangi Pencarian?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
					TextBoxCariInput.Text = ""
					TextBoxCariInput.Focus()
				Else
					If MsgBox("Batalkan Input?", MsgBoxStyle.YesNo, "Keluar Sistem") = MsgBoxResult.Yes Then
						Me.Close()
					Else
						TextBoxCariInput.Text = ""
						Me.Show()

					End If

				End If
			End If
		End If


	End Sub

	Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
		Call KonekDbINV()
		If ButtonSimpan.Text = "Simpan" Then
			If TextBoxQty.Text = "" Or TextBoxPetugas.Text = "" Then
				If TextBoxQty.Text = "" Then
					MsgBox("Jumlah barang masih kosong")
					TextBoxQty.Focus()

				Else
					MsgBox("Nama Petugas Masih kosong")
					TextBoxPetugas.Focus()

				End If
			Else
				Dim Simpan As String = "INSERT INTO Packing_List (ISBN,KodeBuku,Judul,Suplier,Qty,Petugas,Tanggal,RETNUMBER) 
				VALUES ('" & TextBoxISBN.Text & "','" & TextBoxCode.Text & "','" & TextBoxNamaBarang.Text & "','" & TextBoxSuplier.Text & "','" & TextBoxQty.Text & "',
				'" & TextBoxPetugas.Text & "','" & DateTimePicker.Value & "','" & ComboBoxRT.Text & "')"

				Cmd = New SqlCommand(Simpan, Conn)
				Cmd.ExecuteNonQuery()

				TextBoxCariInput.Text = ""
				TextBoxQty.Text = ""
				TextBoxPetugas.Text = ""
				TextBoxCariInput.Focus()


			End If
			'Else
			'	Dim update As String = "UPDATE Packing_List SET RETNUMBER = '" & ComboBoxRT.Text & "', Qty = '" & TextBoxQty.Text & "', Petugas = '" & TextBoxPetugas.Text & "' WHERE  "

		End If
	End Sub

	Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click
		Call BersihkanTextBox()
	End Sub

	Private Sub TextBoxPetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPetugas.KeyPress
		If e.KeyChar = Chr(13) Then
			ButtonSimpan.PerformClick()
		End If

	End Sub

	Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQty.KeyPress
		If e.KeyChar = Chr(13) Then
			TextBoxPetugas.Focus()
		End If

	End Sub

	Private Sub ButtonCariData_Click(sender As Object, e As EventArgs) Handles ButtonCariData.Click
		If ComboBoxCari.Text = "" Or TextBoxCariData.Text = "" Then
			If ComboBoxCari.Text = "" Then
				MsgBox("Masukan dahulu kriteria pencarian")
				ComboBoxCari.Focus()
			Else
				MsgBox("Masukan dahulu kata kunci pencarian")
				TextBoxCariData.Focus()
			End If

		Else
			If ComboBoxCari.Text = "KODE" Then
				Call KonekDbINV()
				Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE Kodebuku = '" & TextBoxCariData.Text & "' AND RETNUMBER IS NOT NULL", Conn)
				Dr = Cmd.ExecuteReader
				Dr.Read()
				If Dr.HasRows Then
					Call KonekDbINV()
					Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE kodebuku = '" & TextBoxCariData.Text & "' AND RETNUMBER IS NOT NULL ", Conn)
					Ds = New DataSet
					Da.Fill(Ds)
					DGVPLTOYS.DataSource = Ds.Tables(0)

					TextBoxISBN.Text = Dr.Item("ISBN")
					TextBoxCode.Text = Dr.Item("kodebuku")
					TextBoxNamaBarang.Text = Dr.Item("judul")
					TextBoxSuplier.Text = Dr.Item("suplier")
					ComboBoxRT.Text = Dr.Item("RETNUMBER")
					TextBoxQty.Text = Dr.Item("qty")
					TextBoxPetugas.Text = Dr.Item("petugas")



					Call DisabledText()

				Else

					MsgBox("Maaf Data Tidak Ada")

				End If

			ElseIf ComboBoxCari.Text = "NamaBarang" Then
				Call KonekDbINV()
				Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE judul like '%" & TextBoxCariData.Text & "%' ", Conn)
				Dr = Cmd.ExecuteReader
				Dr.Read()
				If Dr.HasRows Then
					Call KonekDbINV()
					Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE judul like '%" & TextBoxCariData.Text & "%' ", Conn)
					Ds = New DataSet
					Da.Fill(Ds)
					DGVPLTOYS.DataSource = Ds.Tables(0)

					TextBoxISBN.Text = Dr.Item("ISBN")
					TextBoxCode.Text = Dr.Item("kodebuku")
					TextBoxNamaBarang.Text = Dr.Item("judul")
					TextBoxSuplier.Text = Dr.Item("suplier")
					ComboBoxRT.Text = Dr.Item("RETNUMBER")
					TextBoxQty.Text = Dr.Item("qty")
					TextBoxPetugas.Text = Dr.Item("petugas")

					Call DisabledText()
				Else

					MsgBox("Maaf Data Tidak Ada")

				End If

			ElseIf ComboBoxCari.Text = "Suplier" Then
				Call KonekDbINV()
				Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE suplier like '%" & TextBoxCariData.Text & "%' ", Conn)
				Dr = Cmd.ExecuteReader
				Dr.Read()
				If Dr.HasRows Then
					Call KonekDbINV()
					Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE suplier like '%" & TextBoxCariData.Text & "%' ", Conn)
					Ds = New DataSet
					Da.Fill(Ds)
					DGVPLTOYS.DataSource = Ds.Tables(0)

					TextBoxISBN.Text = Dr.Item("ISBN")
					TextBoxCode.Text = Dr.Item("kodebuku")
					TextBoxNamaBarang.Text = Dr.Item("judul")
					TextBoxSuplier.Text = Dr.Item("suplier")
					ComboBoxRT.Text = Dr.Item("RETNUMBER")
					TextBoxQty.Text = Dr.Item("qty")
					TextBoxPetugas.Text = Dr.Item("petugas")

					Call DisabledText()
				Else

					MsgBox("Maaf Data Tidak Ada")

				End If



			Else
				Call KonekDbINV()
				Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " = '" & TextBoxCariData.Text & "' AND RETNUMBER IS NOT NULL ", Conn)
				Dr = Cmd.ExecuteReader
				Dr.Read()
				If Dr.HasRows Then
					Call KonekDbINV()
					Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " = '" & TextBoxCariData.Text & "'AND RETNUMBER IS NOT NULL ", Conn)
					Ds = New DataSet
					Da.Fill(Ds)
					DGVPLTOYS.DataSource = Ds.Tables(0)

					TextBoxISBN.Text = Dr.Item("ISBN")
					TextBoxCode.Text = Dr.Item("kodebuku")
					TextBoxNamaBarang.Text = Dr.Item("judul")
					TextBoxSuplier.Text = Dr.Item("suplier")
					ComboBoxRT.Text = Dr.Item("RETNUMBER")
					TextBoxQty.Text = Dr.Item("qty")
					TextBoxPetugas.Text = Dr.Item("petugas")

					Call DisabledText()
				Else

					MsgBox("Maaf Data Tidak Ada")
				End If




			End If



		End If



	End Sub

	Private Sub TextBoxCariData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCariData.KeyPress
		If e.KeyChar = Chr(13) Then
			ButtonCariData.PerformClick()
		End If

	End Sub

	Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
		If TextBoxISBN.Text = "" Or ComboBoxRT.Text = "" Then
			MsgBox("Cari dulu barang yg akan diedit")
			ComboBoxCari.Focus()
		Else
			If ComboBoxCari.Text = "KODE" Then
				Call KonekDbBRDJKT()
				Cmd = New SqlCommand("SELECT d.RETNUMBER 
							FROM icitem a
							JOIN CSOPT b on a.OPTFLD5 = b.code
							JOIN PORETL c on c.ITEMNO = a.ITEMNO
							JOIN PORETH1 d on d.RETHSEQ = c.RETHSEQ 
							WHERE a.OPTFLD4 = '" & TextBoxCariData.Text & "'", Conn)
				Dr = Cmd.ExecuteReader
				Dr.Read()
				If Dr.HasRows Then
					Dim Dt As DataTable = New DataTable
					Dt.Load(Dr)

					ComboBoxRT.ValueMember = "PORETH1"
					ComboBoxRT.DisplayMember = "RETNUMBER"
					ComboBoxRT.DataSource = Dt

					ButtonSimpan.Text = "Update"
					TextBoxQty.Enabled = True
					ComboBoxRT.Enabled = True
					TextBoxPetugas.Enabled = True

				End If

			End If

		End If




	End Sub


End Class