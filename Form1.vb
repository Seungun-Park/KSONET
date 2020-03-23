Public Class frmBrowser

    Public homepage As String

    Private Sub Browser_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        
        Me.Text = WebBrowser1.DocumentTitle & " - KSONET 1.0"

        TextBox1.Text = WebBrowser1.Url.ToString
        Label2.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub txtLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 13 Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub

    Private Sub btnLocate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocate.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub frmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        homepage = frmSettings.txtHomepage.Text
        WebBrowser1.Navigate(homepage)
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub Browser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub txtLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(homepage)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.Navigate("http://search.naver.com/search.naver?sm=tab_hty&where=nexearch&query=" + TextBox2.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.Navigate("http://search.daum.net/search?w=tot&t__nil_searchbox=suggest&q=" + TextBox2.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Navigate("http://search.nate.com/search/all.html?s=&sc=&afc=&j=&thr=sbma&nq=&q=" + TextBox2.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser1.Navigate("http://www.google.co.kr/#sclient=psy-ab&hl=ko&newwindow=1&source=hp&q=" + TextBox2.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        WebBrowser1.Navigate("http://blog.naver.com/pswsj1999")
    End Sub
End Class
