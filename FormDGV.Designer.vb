<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDGV
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
		Me.DGV = New System.Windows.Forms.DataGridView()
		Me.ButtonPrint = New System.Windows.Forms.Button()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.ButtonCariPL = New System.Windows.Forms.Button()
		Me.TextBoxCariPL = New System.Windows.Forms.TextBox()
		CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DGV
		'
		Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV.Location = New System.Drawing.Point(12, 69)
		Me.DGV.Name = "DGV"
		Me.DGV.Size = New System.Drawing.Size(995, 804)
		Me.DGV.TabIndex = 0
		'
		'ButtonPrint
		'
		Me.ButtonPrint.Location = New System.Drawing.Point(883, 24)
		Me.ButtonPrint.Name = "ButtonPrint"
		Me.ButtonPrint.Size = New System.Drawing.Size(75, 23)
		Me.ButtonPrint.TabIndex = 1
		Me.ButtonPrint.Text = "Print"
		Me.ButtonPrint.UseVisualStyleBackColor = True
		'
		'PrintDocument1
		'
		'
		'ButtonCariPL
		'
		Me.ButtonCariPL.Location = New System.Drawing.Point(788, 24)
		Me.ButtonCariPL.Name = "ButtonCariPL"
		Me.ButtonCariPL.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCariPL.TabIndex = 2
		Me.ButtonCariPL.Text = "Cari"
		Me.ButtonCariPL.UseVisualStyleBackColor = True
		'
		'TextBoxCariPL
		'
		Me.TextBoxCariPL.Location = New System.Drawing.Point(551, 24)
		Me.TextBoxCariPL.Name = "TextBoxCariPL"
		Me.TextBoxCariPL.Size = New System.Drawing.Size(218, 20)
		Me.TextBoxCariPL.TabIndex = 3
		'
		'FormDGV
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1019, 885)
		Me.Controls.Add(Me.TextBoxCariPL)
		Me.Controls.Add(Me.ButtonCariPL)
		Me.Controls.Add(Me.ButtonPrint)
		Me.Controls.Add(Me.DGV)
		Me.Name = "FormDGV"
		Me.Text = "FormDGV"
		CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DGV As DataGridView
	Friend WithEvents ButtonPrint As Button
	Friend WithEvents PrintDocument1 As Printing.PrintDocument
	Friend WithEvents ButtonCariPL As Button
	Friend WithEvents TextBoxCariPL As TextBox
End Class
