Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Load data from Form1 shared lists
        ISBN_list.Items.Clear()
        Title_list.Items.Clear()
        Author_list.Items.Clear()

        For i As Integer = 0 To Form1.BookISBNs.Count - 1
            ISBN_list.Items.Add(Form1.BookISBNs(i)) ' Add ISBNs
            Title_list.Items.Add(Form1.BookTitles(i)) ' Add Titles
            Author_list.Items.Add(Form1.BookAuthors(i)) ' Add Authors
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear all ListBoxes
        ISBN_list.Items.Clear()
        Title_list.Items.Clear()
        Author_list.Items.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Author_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Author_list.SelectedIndexChanged

    End Sub

    Private Sub Title_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Title_list.SelectedIndexChanged

    End Sub

    Private Sub ISBN_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ISBN_list.SelectedIndexChanged

    End Sub
End Class
