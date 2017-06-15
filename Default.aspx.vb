Imports HtmlAgilityPack

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim url = "https://github.com/EN10/KerasInception"
        Dim doc As HtmlDocument = New HtmlWeb().Load(url)

        Dim nodes = doc.DocumentNode.SelectNodes("//img")

        Dim size = nodes.Count
        Dim node = nodes.ElementAt(4)

        Dim src = node.GetAttributeValue("src", "")
        Label1.Text = src

    End Sub
End Class
