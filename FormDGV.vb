Imports System.Data.SqlClient
Public Class FormDGV
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dataGridViewImage As New Bitmap(Me.DGV.Width, Me.DGV.Height)
        DGV.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.DGV.Width, Me.DGV.Height))
        e.Graphics.DrawImage(dataGridViewImage, 0, 0)
    End Sub

    Private Sub ButtonCariPL_Click(sender As Object, e As EventArgs) Handles ButtonCariPL.Click
        Call KonekDbINV()
        Cmd = New SqlCommand("SELECT * FROM Packing_List WHERE Kode_Packing = '" & TextBoxCariPL.Text & "' ", Conn)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            Call KonekDbINV()
            Da = New SqlDataAdapter("SELECT * FROM Packing_List WHERE Kode_Packing = '" & TextBoxCariPL.Text & "' ", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DGV.DataSource = Ds.Tables(0)
            DGV.ReadOnly = True
        End If

    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        PrintDocument1.Print()
        Call KonekDbINV()
        Dim Hapus As String = "DELETE FROM  Packing_List WHERE Kode_Packing = '" & TextBoxCariPL.Text & "' "
        Cmd = New SqlCommand(Hapus, Conn)
        Cmd.ExecuteNonQuery()
        FormPackingList.Show()
        Me.Close()



    End Sub
End Class