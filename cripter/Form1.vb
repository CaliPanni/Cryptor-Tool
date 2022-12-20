Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text.Replace("!", "a")
        TextBox1.Text = TextBox1.Text.Replace("|", "b")
        TextBox1.Text = TextBox1.Text.Replace("£", "c")
        TextBox1.Text = TextBox1.Text.Replace("$", "d")
        TextBox1.Text = TextBox1.Text.Replace("%", "e")
        TextBox1.Text = TextBox1.Text.Replace("&", "f")
        TextBox1.Text = TextBox1.Text.Replace("/", "g")
        TextBox1.Text = TextBox1.Text.Replace("(", "h")
        TextBox1.Text = TextBox1.Text.Replace(")", "i")
        TextBox1.Text = TextBox1.Text.Replace("=", "l")
        TextBox1.Text = TextBox1.Text.Replace("?", "m")
        TextBox1.Text = TextBox1.Text.Replace("ì", "n")
        TextBox1.Text = TextBox1.Text.Replace("^", "o")
        TextBox1.Text = TextBox1.Text.Replace("'", "p")
        TextBox1.Text = TextBox1.Text.Replace("+", "q")
        TextBox1.Text = TextBox1.Text.Replace("§", "r")
        TextBox1.Text = TextBox1.Text.Replace("-", "s")
        TextBox1.Text = TextBox1.Text.Replace(":", "t")
        TextBox1.Text = TextBox1.Text.Replace("ç", "u")
        TextBox1.Text = TextBox1.Text.Replace("@", "v")
        TextBox1.Text = TextBox1.Text.Replace("#", "z")
        TextBox1.Text = TextBox1.Text.Replace("ò", "w")
        TextBox1.Text = TextBox1.Text.Replace("°", "j")
        TextBox1.Text = TextBox1.Text.Replace("_", "k")
        TextBox1.Text = TextBox1.Text.Replace(",", "x")
        TextBox1.Text = TextBox1.Text.Replace(".", "y")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            TextBox1.Text = testo
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text.Replace("a", "!")
        TextBox1.Text = TextBox1.Text.Replace("b", "|")
        TextBox1.Text = TextBox1.Text.Replace("c", "£")
        TextBox1.Text = TextBox1.Text.Replace("d", "$")
        TextBox1.Text = TextBox1.Text.Replace("e", "%")
        TextBox1.Text = TextBox1.Text.Replace("f", "&")
        TextBox1.Text = TextBox1.Text.Replace("g", "/")
        TextBox1.Text = TextBox1.Text.Replace("h", "(")
        TextBox1.Text = TextBox1.Text.Replace("i", ")")
        TextBox1.Text = TextBox1.Text.Replace("l", "=")
        TextBox1.Text = TextBox1.Text.Replace("m", "?")
        TextBox1.Text = TextBox1.Text.Replace("n", "ì")
        TextBox1.Text = TextBox1.Text.Replace("o", "^")
        TextBox1.Text = TextBox1.Text.Replace("p", "'")
        TextBox1.Text = TextBox1.Text.Replace("q", "+")
        TextBox1.Text = TextBox1.Text.Replace("r", "§")
        TextBox1.Text = TextBox1.Text.Replace("s", "-")
        TextBox1.Text = TextBox1.Text.Replace("t", ":")
        TextBox1.Text = TextBox1.Text.Replace("u", "ç")
        TextBox1.Text = TextBox1.Text.Replace("v", "@")
        TextBox1.Text = TextBox1.Text.Replace("z", "#")
        TextBox1.Text = TextBox1.Text.Replace("w", "ò")
        TextBox1.Text = TextBox1.Text.Replace("j", "°")
        TextBox1.Text = TextBox1.Text.Replace("k", "_")
        TextBox1.Text = TextBox1.Text.Replace("x", ",")
        TextBox1.Text = TextBox1.Text.Replace("y", ".")
    End Sub
End Class
