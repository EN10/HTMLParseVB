Imports HtmlAgilityPack

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc As HtmlDocument
        doc = New HtmlWeb().Load("https://github.com/EN10/KerasInception")

        Dim node = doc.DocumentNode.SelectNodes("//img").ElementAt(4)
        Dim src = node.GetAttributeValue("src", "")
        Label1.Text = src

    End Sub
End Class
