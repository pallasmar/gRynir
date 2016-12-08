Public Class Form1
    Private Sub GRynir_GrunnarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GRynir_GrunnarBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GRynir_GrunnarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBADataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBADataSet.gRynir_Grunnar' table. You can move, or remove it, as needed.
        Me.GRynir_GrunnarTableAdapter.Fill(Me.DBADataSet.gRynir_Grunnar)

    End Sub

    Private Sub StuttLysingTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StuttLysingLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.GRynir_GrunnarTableAdapter.FillBy(Me.DBADataSet.gRynir_Grunnar)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
