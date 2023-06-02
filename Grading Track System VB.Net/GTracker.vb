Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class GTracker

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True"
        Dim queryString As String = "SELECT SUM(Score), SUM(Total) FROM GradeTracker"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(queryString, connection)

        connection.Open()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            ' Execute commands here

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Label5.Text = reader.GetInt32(0).ToString()
                Label11.Text = reader.GetInt32(1).ToString()
            End If

            reader.Close()

            AddHandler DataGridView1.RowsAdded, Sub(obj, args)
                                                    command.CommandText = queryString
                                                    command.CommandText = queryString
                                                    reader = command.ExecuteReader()

                                                    If reader.HasRows Then
                                                        reader.Read()
                                                        Label5.Text = reader.GetInt32(0).ToString()
                                                        Label11.Text = reader.GetInt32(1).ToString()
                                                    End If

                                                    reader.Close()
                                                End Sub
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Integer = TextBox1.Text
        Dim Subject As String = TextBox2.Text
        Dim Task As String = TextBox3.Text
        Dim Score As Integer = TextBox4.Text
        Dim Total As Integer = TextBox5.Text

        Dim query As String = "INSERT INTO GradeTracker VALUES (@ID,@Subject,@Task,@Score,@Total)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.Parameters.AddWithValue("@Subject", Subject)
                cmd.Parameters.AddWithValue("@Task", Task)
                cmd.Parameters.AddWithValue("@Score", Score)
                cmd.Parameters.AddWithValue("@Total", Total)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                MessageBox.Show("Successfully Inserted!")
                BindData()
            End Using
        End Using
    End Sub
    Public Sub BindData()
        Dim query As String = "SELECT * FROM GradeTracker"
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
        Dim query As String = "SELECT * FROM GradeTracker WHERE ID ='" & TextBox6.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeTracker.mdf;Integrated Security=TrueData Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
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
                        Else
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                            TextBox3.Text = ""
                            TextBox4.Text = ""
                            TextBox5.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ID As Integer = TextBox1.Text
        Dim Subject As String = TextBox2.Text
        Dim Task As String = TextBox3.Text
        Dim Score As Integer = TextBox4.Text
        Dim Total As Integer = TextBox5.Text

        Dim query As String = "UPDATE GradeTracker SET Subject =@Subject, Task =@Task, Score =@Score, Total =@Total WHERE ID=@ID"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jhasmine\source\repos\Joseph\GradeWise.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.Parameters.AddWithValue("@Subject", Subject)
                cmd.Parameters.AddWithValue("@Task", Task)
                cmd.Parameters.AddWithValue("@Score", Score)
                cmd.Parameters.AddWithValue("@Total", Total)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""

                MessageBox.Show("Successfully Updated!")
                BindData()
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ID As String = TextBox1.Text
        Dim query As String = "DELETE FROM GradeTracker WHERE ID=@ID"
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

                MessageBox.Show("Successfully Deleted!")
                BindData()
            End Using
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim scores As Integer = Label5.Text
        Dim total As Integer = Label11.Text
        Dim percentage As Double = (scores / total) * 100
        TextBox7.Text = String.Format("{0:0.##}%", percentage)
    End Sub
End Class
