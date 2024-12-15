Public Class Form1
    ' A shared list to store books (ISBN, title, author)
    Public Shared BookISBNs As New List(Of String)
    Public Shared BookTitles As New List(Of String)
    Public Shared BookAuthors As New List(Of String)

    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add the TextBox values to the shared lists
        BookISBNs.Add(TextBox1.Text)
        BookTitles.Add(TextBox2.Text)
        BookAuthors.Add(TextBox3.Text)

        ' Clear textboxes for new entry
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        ' Confirm the addition
        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonAfficher_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Open Form2
        Dim form2 As New Form2
        form2.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class