Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormPackingList

    Dim JmlRows As Integer

    Sub BersihkanInput()
        TextBoxPalet.Text = ""
        TextBoxKoli.Text = ""
        TextBoxBox.Text = ""
        TextBoxPetugas.Text = ""
        TextBoxMasukanISBN.Text = ""
        TextBoxMasukanQTY.Text = ""
        TextBoxKodeBuku.Text = ""
        TextBoxJudul.Text = ""
    End Sub

    Sub CountRow()
        JmlRows = DGVPL.Rows.Count - 1
        LabelItem.Text = JmlRows
    End Sub
    Sub RefreshDGVPL()
        Call KonekDbINV()
        Da = New SqlDataAdapter("SELECT * FROM Packing_List ", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DGVPL.DataSource = Ds.Tables(0)
        DGVPL.ReadOnly = True
    End Sub
    Private Sub FormPackingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'INVDataSet.Packing_List' table. You can move, or remove it, as needed.
        Me.Packing_ListTableAdapter.Fill(Me.INVDataSet.Packing_List)


        Call KonekDbBRDJKT()
        Call KonekDbINV()
        'Call QtyPl()
        Call CountRow()
        Call RefreshDGVPL()

        'ReadOnly DGVPL
        DGVPL.ReadOnly = True
        DGVPL.Enabled = False

        'Sembunyikan TextBox PL_ID
        TextBoxPL_ID.Visible = False

        'TextBoxMasukanISBN.Focus()
        TextBoxJudul.ReadOnly = True
        TextBoxKodeBuku.ReadOnly = True
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "yyyy/MM/dd"
        ButtonCetak.Enabled = True

        'Add Text ComboBox
        ComboBoxCari.Items.Add("Palet")
        ComboBoxCari.Items.Add("Koli")
        ComboBoxCari.Items.Add("Box")
        ComboBoxCari.Items.Add("Pl_Id")
        ComboBoxCari.Items.Add("Petugas")
        ComboBoxCari.Items.Add("ISBN")
        ComboBoxCari.Items.Add("KodeBuku")
        ComboBoxCari.Items.Add("Judul")
        ComboBoxCari.Items.Add("Qty")
        ComboBoxCari.Items.Add("Tanggal")

        'Disable Button
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
    End Sub

    'Sub QtyPl()

    '    Dim QtyBuku As Integer
    '    For Baris As Integer = 0 To DGVPL.Rows.Count - 1
    '        QtyBuku = QtyBuku + DGVPL.Rows(Baris).Cells(8).Value
    '    Next
    '    LabelQty.Text = QtyBuku

    'End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
        SplashScreenHellooFriend.Close()
    End Sub

    Private Sub TextBoxMasukanISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMasukanISBN.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KonekDbBRDJKT()
            Cmd = New SqlCommand("SELECT * FROM ICITEM WHERE ITEMNO LIKE '" & TextBoxMasukanISBN.Text & "' ", Conn)
            Dr = Cmd.ExecuteReader()
            Dr.Read()

            If Dr.HasRows Then
                TextBoxJudul.Text = Dr.Item("DESC")
                TextBoxKodeBuku.Text = Dr.Item("OPTFLD4")
            Else
                Call KonekDbBRDJKT()
                Cmd = New SqlCommand("SELECT * FROM ICITEM WHERE OPTFLD4 = '" & TextBoxMasukanISBN.Text & "' ", Conn)
                Dr = Cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    TextBoxJudul.Text = Dr.Item("DESC")
                    TextBoxKodeBuku.Text = Dr.Item("OPTFLD4")
                    TextBoxMasukanISBN.Text = Dr.Item("ITEMNO")
                Else
                    MsgBox("Data Tidak Ada")
                    Call BersihkanInput()

                End If

            End If
            TextBoxMasukanQTY.Focus()

        End If

    End Sub

    Private Sub TextBoxMasukanQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMasukanQTY.KeyPress
        If e.KeyChar = Chr(13) Then
            ButtonSave.PerformClick()
        End If

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs)
        'Call KonekDbINV()
        'Dim Simpan As String = "INSERT INTO Packing_List VALUES ('" & TextBoxMasukanISBN.Text & "','" & Replace(TextBoxJudul.Text, "'", "") & "','" & TextBoxKodeBuku.Text & "','" & TextBoxPalet.Text & "','" & TextBoxKoli.Text & "','" & TextBoxMasukanQTY.Text & "','" & DateTimePicker.Value & "')"
        'Cmd = New SqlCommand(Simpan, Conn)
        'Cmd.ExecuteNonQuery()
        ''Call RefreshDGV()
        'TextBoxMasukanISBN.Text = ""
        'TextBoxMasukanQTY.Text = ""
        'TextBoxMasukanISBN.Focus()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        'FormDGV.Show()
        'Me.Visible = False

        'Enabling Button
        ButtonEdit.Enabled = True
        ButtonDelete.Enabled = True

        'Enabling DGV
        DGVPL.Enabled = True


        TextBoxMasukanISBN.ReadOnly = True
        TextBoxJudul.ReadOnly = True
        TextBoxKodeBuku.ReadOnly = True
        TextBoxPL_ID.Visible = True
        TextBoxPL_ID.ReadOnly = True
        TextBoxPalet.ReadOnly = True
        TextBoxKoli.ReadOnly = True
        TextBoxBox.ReadOnly = True
        TextBoxPetugas.ReadOnly = True
        TextBoxMasukanQTY.ReadOnly = True

        If ComboBoxCari.Text = "" Or TextBoxCari.Text = "" Then
            If MsgBox("Pilih dahulu Kriteria pencarian, Pilih kriteria?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                If ComboBoxCari.Text = "" Then
                    ComboBoxCari.Focus()
                Else
                    TextBoxCari.Focus()
                End If
            Else
                ComboBoxCari.Text = ""
                TextBoxCari.Text = ""

            End If
        Else
            If ComboBoxCari.SelectedItem.ToString = "Judul" Then
                'Cmd.Parameters.Add("@Judul", SqlDbType.VarChar).Value = "%" & TextBoxCari.Text & "%"
                Call KonekDbINV()
                Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " Like '%" & TextBoxCari.Text & "%' ", Conn)
                Dr = Cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Call KonekDbINV()
                    Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " Like '%" & TextBoxCari.Text & "%' ", Conn)
                    Ds = New DataSet
                    Da.Fill(Ds)
                    DGVPL.DataSource = Ds.Tables(0)
                    DGVPL.ReadOnly = True

                    'Memasukan ke TextBox
                    TextBoxPalet.Text = Dr.Item("Palet")
                    TextBoxKoli.Text = Dr.Item("Koli")
                    TextBoxBox.Text = Dr.Item("Box")
                    TextBoxMasukanQTY.Text = Dr.Item("Qty")
                    TextBoxPL_ID.Text = Dr.Item("Pl_Id")
                    TextBoxMasukanISBN.Text = Dr.Item("ISBN")
                    TextBoxKodeBuku.Text = Dr.Item("KodeBuku")
                    TextBoxJudul.Text = Dr.Item("Judul")
                    TextBoxPetugas.Text = Dr.Item("Petugas")

                    Dim ObjRpt As New CrystalReportCetak
                    ObjRpt.SetDataSource(Ds.Tables(0))
                    FormCR.CrystalReportViewer1.ReportSource = ObjRpt
                    FormCR.CrystalReportViewer1.Refresh()





                Else
                    If MsgBox("Data Tidak Ada, Ulangi Pencarian?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        ComboBoxCari.Text = ""
                        TextBoxCari.Text = ""
                        ComboBoxCari.Focus()
                    Else
                        DGVPL.DataSource = Nothing
                    End If
                End If

            Else
                Call KonekDbINV()
                Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " = '" & TextBoxCari.Text & "' ", Conn)
                Dr = Cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Call KonekDbINV()
                    Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " = '" & TextBoxCari.Text & "' ", Conn)
                    Ds = New DataSet
                    Da.Fill(Ds)
                    DGVPL.DataSource = Ds.Tables(0)
                    DGVPL.ReadOnly = True

                    'Memasukan ke TextBox
                    TextBoxPalet.Text = Dr.Item("Palet")
                    TextBoxKoli.Text = Dr.Item("Koli")
                    TextBoxBox.Text = Dr.Item("Box")
                    TextBoxMasukanQTY.Text = Dr.Item("Qty")
                    TextBoxPL_ID.Text = Dr.Item("Pl_Id")
                    TextBoxMasukanISBN.Text = Dr.Item("ISBN")
                    TextBoxKodeBuku.Text = Dr.Item("KodeBuku")
                    TextBoxJudul.Text = Dr.Item("Judul")
                    TextBoxPetugas.Text = Dr.Item("Petugas")

                    Dim ObjRpt As New CrystalReportCetak
                    ObjRpt.SetDataSource(Ds.Tables(0))
                    FormCR.CrystalReportViewer1.ReportSource = ObjRpt
                    FormCR.CrystalReportViewer1.Refresh()


                Else
                    If MsgBox("Data Tidak Ada, Ulangi Pencarian?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        ComboBoxCari.Text = ""
                        TextBoxCari.Text = ""
                        ComboBoxCari.Focus()
                        Call RefreshDGVPL()
                    Else
                        DGVPL.DataSource = Nothing
                    End If

                End If


            End If
        End If





    End Sub


    Private Sub ButtonSave_Click_1(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If ButtonSave.Text = "Save" Then
            If TextBoxPetugas.Text = "" Then
                If MsgBox("Kolom nama petugas tidak boleh kosong, lengkapi?", MsgBoxStyle.YesNo, "Konfimasi") = MsgBoxResult.Yes Then
                    TextBoxPetugas.Focus()
                Else
                    Call BersihkanInput()
                End If
            Else
                Call KonekDbINV()
                Dim Simpan As String = "INSERT INTO Packing_List (Palet, Koli, Box, Petugas, ISBN, KodeBuku, Judul, Qty, Tanggal)VALUES ('" & TextBoxPalet.Text & "','" & TextBoxKoli.Text & "','" & TextBoxBox.Text & "','" & TextBoxPetugas.Text & "','" & TextBoxMasukanISBN.Text & "','" & TextBoxKodeBuku.Text & "','" & Replace(TextBoxJudul.Text, "'", "") & "','" & TextBoxMasukanQTY.Text & "','" & DateTimePicker.Value & "')"
                Cmd = New SqlCommand(Simpan, Conn)
                Cmd.ExecuteNonQuery()
                Call RefreshDGVPL()
                'Call QtyPl()
                Call CountRow()
                TextBoxMasukanISBN.Text = ""
                TextBoxMasukanQTY.Text = ""
                TextBoxMasukanISBN.Focus()
            End If
        Else
            If TextBoxPetugas.Text = "" Then
                MsgBox("Nama Petugas Tidak Boleh Kosong")
                TextBoxPetugas.Focus()
            Else
                Call KonekDbINV()
                Dim Update As String = "UPDATE Packing_List SET Palet = '" & TextBoxPalet.Text & "', Koli = '" & TextBoxKoli.Text & "', Box = '" & TextBoxBox.Text & "',
                Petugas = '" & TextBoxPetugas.Text & "' , Qty = '" & TextBoxMasukanQTY.Text & "', Tanggal = '" & DateTimePicker.Value & "' WHERE Pl_Id = '" & TextBoxPL_ID.Text & "'  AND ISBN = '" & TextBoxMasukanISBN.Text & "' "
                Cmd = New SqlCommand(Update, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Sudah Di Update")
                Call BersihkanInput()

            End If

        End If





    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If TextBoxCari.Text = "" Then
            MsgBox("Cari dahulu data yg akan di cari")
        Else
            ButtonSave.Text = "Update"
            TextBoxPalet.ReadOnly = False
            TextBoxKoli.ReadOnly = False
            TextBoxBox.ReadOnly = False
            TextBoxPetugas.ReadOnly = False
            TextBoxMasukanQTY.ReadOnly = False

        End If


    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If TextBoxCari.Text = "" Then
            MsgBox("Cari dahulu data yang akan di hapus")
        Else
            Call KonekDbINV()
            Dim Hapus As String = "DELETE FROM Packing_List WHERE Pl_Id = '" & TextBoxPL_ID.Text & "' AND ISBN = '" & TextBoxMasukanISBN.Text & "' "
            Cmd = New SqlCommand(Hapus, Conn)
            Cmd.ExecuteNonQuery()


        End If

    End Sub

    Private Sub ButtonNewPL_Click(sender As Object, e As EventArgs) Handles ButtonNewPL.Click
        Call BersihkanInput()

        TextBoxPalet.Enabled = True
        TextBoxPalet.ReadOnly = False
        TextBoxKoli.Enabled = True
        TextBoxKoli.ReadOnly = False
        TextBoxBox.Enabled = True
        TextBoxBox.ReadOnly = False
        TextBoxPetugas.Enabled = True
        TextBoxPetugas.ReadOnly = False
        TextBoxMasukanISBN.Enabled = True
        TextBoxMasukanISBN.ReadOnly = False

        TextBoxMasukanQTY.Enabled = True
        TextBoxMasukanQTY.ReadOnly = False



        ButtonSave.Text = "Save"
    End Sub

    Private Sub TextBoxCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCari.KeyPress
        If e.KeyChar = Chr(13) Then
            ButtonSearch.PerformClick()

        End If

    End Sub


    Private Sub DGVPL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPL.CellContentClick
        Dim Baris As Integer
        With DGVPL
            If e.RowIndex >= 0 Then
                Baris = .CurrentRow.Index
                TextBoxPalet.Text = .Rows(Baris).Cells(0).Value.ToString
                TextBoxKoli.Text = .Rows(Baris).Cells(1).Value.ToString
                TextBoxBox.Text = .Rows(Baris).Cells(2).Value.ToString
                TextBoxMasukanQTY.Text = .Rows(Baris).Cells(8).Value.ToString
                TextBoxMasukanISBN.Text = .Rows(Baris).Cells(5).Value.ToString
                TextBoxJudul.Text = .Rows(Baris).Cells(7).Value.ToString
                TextBoxKodeBuku.Text = .Rows(Baris).Cells(6).Value.ToString
                TextBoxPetugas.Text = .Rows(Baris).Cells(4).Value.ToString
                TextBoxPL_ID.Text = .Rows(Baris).Cells(3).Value.ToString

                DateTimePicker.Format = DateTimePickerFormat.Custom
                DateTimePicker.CustomFormat = "yyyy/MM/dd"
                DateTimePicker.Value = .Rows(Baris).Cells(9).Value.ToString

            End If

        End With
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        FormCR.Show()
    End Sub

    Private Sub ButtonCetakPL_Click(sender As Object, e As EventArgs) Handles ButtonCetakPL.Click
        'Call KonekDbINV()
        'Dim CmdBantu As String = "SELECT TOP 1 Pl_Id FROM Packing_list ORDER BY Tanggal DESC"
        'Cmd = New SqlCommand("SELECT * WHERE Pl_Id = '&CmdBantu'& ", Conn)


    End Sub

End Class
