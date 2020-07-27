Imports System.Data.SqlClient
Public Class FormPackingList
    Private Sub FormPackingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KonekDbBRDJKT()
        Call KonekDbINV()
        TextBoxMasukanISBN.Focus()
        TextBoxJudul.ReadOnly = True
        TextBoxKodeBuku.ReadOnly = True
        DateTimePicker.Format = DateTimePickerFormat.Custom
        DateTimePicker.CustomFormat = "yyyy/MM/dd"
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
End Class
