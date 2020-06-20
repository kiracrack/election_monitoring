Public Class frmUploadedHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmUploadedLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        Filter()
    End Sub
    Public Sub Filter()
        LoadXgrid("SELECT date_format(concat(left(batchcode,4),'-',substr(batchcode,5,2),'-',substr(batchcode,7,2),' ',substr(batchcode,9,2),':',substr(batchcode,11,2),':',right(batchcode,2)), '%Y-%m-%d %r') as 'Date Upload',concat(FORMAT(CAST(count(*) AS CHAR(20)),0),' Total Records')  as 'Performed Queries' FROM settings.tblactionbackuplogs  group by batchcode order by batchcode desc;", "settings.tblactionbackuplogs", Em, GridView1, Me)
        GridView1.Columns("Date Upload").Width = 140
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Filter()
    End Sub
End Class