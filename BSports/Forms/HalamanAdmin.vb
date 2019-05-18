Public Class HalamanAdmin
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub JenisBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisBarangToolStripMenuItem.Click
        FormJenisBarang.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.Show()
    End Sub



    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        FormSupplier.Show()
    End Sub



    Private Sub HalamanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FormOperator.Show()
    End Sub
End Class