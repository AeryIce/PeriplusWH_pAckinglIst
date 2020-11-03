Imports System.Data.SqlClient

Module ModuleKoneksi

	Public Conn As SqlConnection
	Public Da As SqlDataAdapter
	Public Dr As SqlDataReader
	Public Cmd As SqlCommand
	Public Ds As DataSet

	Sub KonekDbBRDJKT()
		Try
			Conn = New SqlConnection("Server = SRV4 ; initial Catalog = brdjkt ; User Id= sa ; password= ")
			Conn.Open()
			FormPackingList.LabelStatusKoneksiBRDJKT.Text = "Conn OK"
			FormPackingListToys.LabelStatusBRDJKT.Text = "Conn OK"

		Catch ex As Exception
			FormPackingList.LabelStatusKoneksiBRDJKT.Text = "BRDJKT Fail"
			FormPackingListToys.LabelStatusBRDJKT.Text = "BRDJKT FAIL"


		End Try

	End Sub

	Sub KonekDbINV()
		Try
			Conn = New SqlConnection("Server = SRV4; Initial Catalog = INV ; User Id = Sa ; Password = ")
			Conn.Open()
			FormPackingList.LabelStatusKoneksiINV.Text = "Conn OK"
			FormPackingListToys.LabelStatusINV.Text = "Conn OK"


		Catch ex As Exception
			FormPackingList.LabelStatusKoneksiINV.Text = "INV Fail"
			FormPackingListToys.LabelStatusINV.Text = "INV FAIL"

		End Try
	End Sub



End Module
