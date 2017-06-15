Imports HtmlAgilityPack

Partial Class _Default
    Inherits System.Web.UI.Page

    Dim url As String = "https://en.wikipedia.org/wiki/Gallery_of_sovereign_state_flags"
    Dim doc As HtmlDocument = New HtmlWeb().Load(url)
    Dim nodes As HtmlNodeCollection = doc.DocumentNode.SelectNodes("//img")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Session("Flag") += 1
        Label1.Text = Session("Flag")

        Dim node = nodes.ElementAt(Session("Flag"))
        Dim src = node.GetAttributeValue("src", "")
        Image1.ImageUrl = src

    End Sub
End Class
