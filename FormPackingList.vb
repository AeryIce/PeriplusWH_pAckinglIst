Imports System.Data.SqlClient
Public Class FormPackingList
    'Sub RefreshDGV()
    '    Call KonekDbINV()
    '    Da = New SqlDataAdapter("SELECT * FROM Packing_List ", Conn)
    '    Ds = New DataSet
    '    Da.Fill(Ds)
    '    DGV.DataSource = Ds.Tables(0)
    '    DGV.ReadOnly = True
    'End Sub
    Private Sub FormPackingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'INVDataSet.Packing_List' table. You can move, or remove it, as needed.
        Me.Packing_ListTableAdapter.Fill(Me.INVDataSet.Packing_List)
        Call KonekDbBRDJKT()
        Call KonekDbINV()
        'Call RefreshDGV()
        TextBoxMasukanISBN.Focus()
        TextBoxJudul.ReadOnly = True
        TextBoxKodeBuku.ReadOnly = True
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "yyyy/MM/dd"
        ButtonCetak.Enabled = False

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()

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
            End If
            TextBoxMasukanQTY.Focus()

        End If

    End Sub

    Private Sub TextBoxMasukanQTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMasukanQTY.KeyPress
        If e.KeyChar = Chr(13) Then
            ButtonSave.Focus()
        End If

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Call KonekDbINV()
        Dim Simpan As String = "INSERT INTO Packing_List VALUES ('" & TextBoxMasukanISBN.Text & "','" & Replace(TextBoxJudul.Text, "'", "") & "','" & TextBoxKodeBuku.Text & "','" & TextBoxPalet.Text & "','" & TextBoxKoli.Text & "','" & TextBoxMasukanQTY.Text & "','" & DateTimePicker.Value & "')"
        Cmd = New SqlCommand(Simpan, Conn)
        Cmd.ExecuteNonQuery()
        'Call RefreshDGV()
        TextBoxMasukanISBN.Text = ""
        TextBoxMasukanQTY.Text = ""
        TextBoxMasukanISBN.Focus()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        FormDGV.Show()
        Me.Visible = False
    End Sub

    Private Sub GroupBoxCRUD_Enter(sender As Object, e As EventArgs) Handles GroupBoxCRUD.Enter

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
