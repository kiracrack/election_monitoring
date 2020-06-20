Imports System.IO

Public Class frmAbout
    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        Dim fversion As Date = System.IO.File.GetLastWriteTime(My.Application.Info.DirectoryPath).ToShortDateString()
        Dim img As Image = My.Resources.ResourceManager.GetObject("ico")
        Dim Original As New Bitmap(img)
        img = Original

        Dim m As Int32 = 80
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        img = Thumb
        PanelControl1.ContentImage = img
        LabelControl3.Text = "Build Version " & Format(fversion, "yy.M.d")
    End Sub
End Class