Imports DevExpress.XtraEditors

Public Class frmUpdateDatabase

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraMessageBox.Show("Are you sure continue execute query?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = txtQuery.Text : com.ExecuteNonQuery()
            XtraMessageBox.Show("Query successfully excute! Database updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class