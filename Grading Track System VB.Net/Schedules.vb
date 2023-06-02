Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Schedules
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Integer = TextBox1.Text
        Dim Time As Char = TextBox2.Text
        Dim Monday As String = TextBox3.Text
        Dim Tuesday As String = TextBox4.Text
        Dim Wednesday As String = TextBox5.Text
        Dim Thursday As String = TextBox6.Text
        Dim Friday As String = TextBox7.Text
        Dim Saturday As String = TextBox8.Text
        Dim Sunday As String = TextBox9.Text



        Dim query As String = "INSERT INTO Schedules VALUES (@ID,@Time,@Monday,@Tuesday,@Wednesday,@Thursday,@Friday,@Saturday,@Sunday)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.Parameters.AddWithValue("@Time", Time)
                cmd.Parameters.AddWithValue("@Monday", Monday)
                cmd.Parameters.AddWithValue("@Tuesday", Tuesday)
                cmd.Parameters.AddWithValue("@Wednesday", Wednesday)
                cmd.Parameters.AddWithValue("@Thursday", Thursday)
                cmd.Parameters.AddWithValue("@Friday", Friday)
                cmd.Parameters.AddWithValue("@Saturday", Saturday)
                cmd.Parameters.AddWithValue("Sunday", Sunday)



                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                MessageBox.Show("Successfully Inserted!")
                BindData()
            End Using
        End Using
    End Sub
    Public Sub BindData()
        Dim query As String = "SELECT * FROM Schedules"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "SELECT * FROM Schedules WHERE ID ='" & TextBox10.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TextBox1.Text = dt.Rows(0)(0).ToString()
                            TextBox2.Text = dt.Rows(0)(1).ToString()
                            TextBox3.Text = dt.Rows(0)(2).ToString()
                            TextBox4.Text = dt.Rows(0)(3).ToString()
                            TextBox5.Text = dt.Rows(0)(4).ToString()
                            TextBox6.Text = dt.Rows(0)(5).ToString()
                            TextBox7.Text = dt.Rows(0)(6).ToString()
                            TextBox8.Text = dt.Rows(0)(7).ToString()
                            TextBox9.Text = dt.Rows(0)(8).ToString()

                        Else
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                            TextBox3.Text = ""
                            TextBox4.Text = ""
                            TextBox5.Text = ""
                            TextBox6.Text = ""
                            TextBox7.Text = ""
                            TextBox8.Text = ""
                            TextBox9.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ID As Integer = TextBox1.Text
        Dim Time As Char = TextBox2.Text
        Dim Monday As String = TextBox3.Text
        Dim Tuesday As String = TextBox4.Text
        Dim Wednesday As String = TextBox5.Text
        Dim Thursday As String = TextBox6.Text
        Dim Friday As String = TextBox7.Text
        Dim Saturday As String = TextBox8.Text
        Dim Sunday As String = TextBox9.Text


        Dim query As String = "UPDATE Schedules SET Time =@Time, Monday =@Monday, Tuesday =@Tuesday, Wednesday =@Wednesday, Thursday =@Thursday, Friday =@Friday, Saturday= @Saturday, Sunday =@Sunday WHERE ID=@ID"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.Parameters.AddWithValue("@Time", Time)
                cmd.Parameters.AddWithValue("@Monday", Monday)
                cmd.Parameters.AddWithValue("@Tuesday", Tuesday)
                cmd.Parameters.AddWithValue("@Wednesday", Wednesday)
                cmd.Parameters.AddWithValue("@Thursday", Thursday)
                cmd.Parameters.AddWithValue("@Friday", Friday)
                cmd.Parameters.AddWithValue("@Saturday", Saturday)
                cmd.Parameters.AddWithValue("Sunday", Sunday)



                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""


                MessageBox.Show("Successfully Updated!")
                BindData()
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ID As String = TextBox1.Text
        Dim query As String = "DELETE FROM Schedules WHERE ID=@ID"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", ID)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                MessageBox.Show("Successfully Deleted!")
                BindData()
            End Using
        End Using
    End Sub

    Private Sub Schedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
