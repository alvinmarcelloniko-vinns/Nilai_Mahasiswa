Imports System.Data.SqlClient 'diperlukan untuk menggunakan method pada class SqlClient
Module connection

    Dim Conn As SqlConnection 'akan digunakan untuk mengatur koneksi database
    Dim Da As SqlDataAdapter 'akan digunakan untuk mengeksekusi sebuah query
    Dim dt As DataTable 'akan digunakan untuk menyimpan hasil query ke dalam sebuah datatable

    Public Function Query(text As String)
        Conn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=dbMahasiswa;Integrated Security=True")
        Da = New SqlDataAdapter(text, Conn)
        dt = New DataTable
        Da.Fill(dt)
        Return dt
    End Function
    Public Sub QueryEdit(text As String)
        Conn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=dbMahasiswa;Integrated Security=True")
        Dim Cmd As New SqlCommand(text, Conn)
        Conn.Open()
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub

End Module
