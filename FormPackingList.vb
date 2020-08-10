Imports System.Data.SqlClient
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
        'TODO: This line of code loads data into the 'INVDataSet1.Packing_List' table. You can move, or remove it, as needed.
        Me.Packing_ListTableAdapter.Fill(Me.INVDataSet1.Packing_List)
        'TODO: This line of code loads data into the 'INVDataSet2.Packing_List' table. You can move, or remove it, as needed.


        Call KonekDbBRDJKT()
        Call KonekDbINV()
        Call QtyPl()
        Call CountRow()
        Call RefreshDGVPL()
        'TextBoxMasukanISBN.Focus()
        TextBoxJudul.ReadOnly = True
        TextBoxKodeBuku.ReadOnly = True
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "yyyy/MM/dd"
        ButtonCetak.Enabled = False

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

    End Sub

    Sub QtyPl()

        Dim QtyBuku As Integer
        For Baris As Integer = 0 To DGVPL.Rows.Count - 1
            QtyBuku = QtyBuku + DGVPL.Rows(Baris).Cells(8).Value
        Next
        LabelQty.Text = QtyBuku

    End Sub

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
                MsgBox("Data Tidak Ada")
                Call BersihkanInput()
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
                If Dr.HasRows Then
                    Call KonekDbINV()
                    Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " Like '%" & TextBoxCari.Text & "%' ", Conn)
                    Ds = New DataSet
                    Da.Fill(Ds)
                    DGVPL.DataSource = Ds.Tables(0)
                    DGVPL.ReadOnly = True


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
                If Dr.HasRows Then
                    Call KonekDbINV()
                    Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE " & ComboBoxCari.SelectedItem.ToString & " = '" & TextBoxCari.Text & "' ", Conn)
                    Ds = New DataSet
                    Da.Fill(Ds)
                    DGVPL.DataSource = Ds.Tables(0)
                    DGVPL.ReadOnly = True
                Else
                    If MsgBox("Data Tidak Ada, Ulangi Pencarian?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                        ComboBoxCari.Text = ""
                        TextBoxCari.Text = ""
                        ComboBoxCari.Focus()
                    Else
                        DGVPL.DataSource = Nothing
                    End If

                End If


            End If
        End If





    End Sub


    Private Sub ButtonSave_Click_1(sender As Object, e As EventArgs) Handles ButtonSave.Click
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
            Call QtyPl()
            Call CountRow()
            TextBoxMasukanISBN.Text = ""
            TextBoxMasukanQTY.Text = ""
            TextBoxMasukanISBN.Focus()
        End If




    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

    End Sub

    Private Sub ButtonNewPL_Click(sender As Object, e As EventArgs) Handles ButtonNewPL.Click
        TextBoxPalet.Text = ""
        TextBoxKoli.Text = ""
        TextBoxBox.Text = ""
        TextBoxPetugas.Text = ""
    End Sub

    Private Sub TextBoxCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCari.KeyPress
        If e.KeyChar = Chr(13) Then
            ButtonSearch.PerformClick()

        End If

    End Sub

    Private Sub TextBoxMasukanQTY_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMasukanQTY.TextChanged

    End Sub

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim dataGridViewImage As New Bitmap(Me.DGV.Width, Me.DGV.Height)
    '    DGV.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.DGV.Width, Me.DGV.Height))
    '    e.Graphics.DrawImage(dataGridViewImage, 0, 0)
    'End Sub

    'Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
    '    PrintDocument1.Print()
    'End Sub
End Class
