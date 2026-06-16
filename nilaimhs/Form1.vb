Public Class Form1
    Dim nilaiAkhir, kehadiran, tugas, uts, uas As Integer
    Private Sub txtTugas_TextChanged(sender As Object, e As EventArgs) Handles txtTugas.TextChanged
        If txtTugas.Text <> "" Then
            tugas = Convert.ToDouble(txtTugas.Text)
            hitungNilai()
        End If
    End Sub
    Private Sub txtUts_TextChanged(sender As Object, e As EventArgs) Handles txtUts.TextChanged
        If txtUts.Text <> "" Then
            uts = Convert.ToDouble(txtUts.Text)
            hitungNilai()
        End If
    End Sub
    Private Sub txtUas_TextChanged(sender As Object, e As EventArgs) Handles txtUas.TextChanged
        If txtUas.Text <> "" Then
            uas = Convert.ToDouble(txtUas.Text)
            hitungNilai()
        End If
    End Sub
    Private Sub txtkehadiran_TextChanged(sender As Object, e As EventArgs) Handles txtkehadiran.TextChanged
        If txtkehadiran.Text <> "" Then
            kehadiran = Convert.ToDouble(txtkehadiran.Text)
            hitungNilai()
        End If
    End Sub
    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        If MsgBox("Yakin ingin keluar?", vbYesNo + vbQuestion, "Konfirmasi") = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txtNpm.Text = "" Or txtNama.Text = "" Or txtkodeMK.Text = "" Or txtkehadiran.Text = "" Or txtTugas.Text = "" Or txtUts.Text = "" Or txtUas.Text = "" Then
            MsgBox("Semua data harus diisi!", vbExclamation, "Peringatan")
            Exit Sub
        End If
        Dim cek As DataTable = Query($"SELECT * FROM tblNilaiMhs WHERE npm='{txtNpm.Text}' AND kodeMK='{txtkodeMK.Text}'")
        If cek.Rows.Count > 0 Then
            MsgBox("Data ini sudah ada!", MsgBoxStyle.Critical, "Duplikat Data")
        Else
            QueryEdit($"insert into tblNilaiMhs values ('{txtNpm.Text}','{txtNama.Text}','{txtkodeMK.Text}','{txtmatakuliah.Text}',{txtkehadiran.Text},{txtTugas.Text},{txtUts.Text},{txtUas.Text},{txtNilaiAkhir.Text},'{lblgrade.Text}')")
            MsgBox("Data berhasil ditambahkan!", MsgBoxStyle.Information, "Sukses")
            tampildata()
            cleardata()
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtNpm.Text = "" Then
            MsgBox("Pilih data pada tabel terlebih dahulu!", vbExclamation, "Peringatan")
            Exit Sub
        End If
        Dim cek As DataTable = Query($"SELECT * FROM tblNilaiMhs WHERE npm='{txtNpm.Text}' AND kodeMK='{txtkodeMK.Text}' AND nama='{txtNama.Text}' AND kehadiran={txtkehadiran.Text} AND tugas={txtTugas.Text} AND uts={txtUts.Text} AND uas={txtUas.Text}")
        If cek.Rows.Count > 0 Then
            MsgBox("Data masih sama dan tidak ada yang berubah!", vbExclamation, "Peringatan")
            Exit Sub
        End If
        If MsgBox("Yakin ingin mengupdate data ini?", vbYesNo + vbQuestion, "Konfirmasi") = vbYes Then
            QueryEdit($"UPDATE tblNilaiMhs SET nama='{txtNama.Text}',kodeMK='{txtkodeMK.Text}',namaMK='{txtmatakuliah.Text}',kehadiran={txtkehadiran.Text},tugas={txtTugas.Text},uts={txtUts.Text},uas={txtUas.Text},nilaiAkhir={txtNilaiAkhir.Text},grade='{lblgrade.Text}' WHERE npm='{txtNpm.Text}' AND kodeMK='{txtkodeMK.Text}'")
            MsgBox("Data berhasil diupdate!", vbInformation, "Sukses")
            tampildata()
            cleardata()
        End If
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtNpm.Text = "" Then
            MsgBox("Pilih data pada tabel terlebih dahulu!", vbExclamation, "Peringatan")
            Exit Sub
        End If
        If MsgBox($"Yakin ingin menghapus data ini?", vbYesNo + vbQuestion, "Konfirmasi") = MsgBoxResult.Yes Then
            QueryEdit($"DELETE FROM tblNilaiMhs WHERE npm='{txtNpm.Text}' AND kodeMK='{txtkodeMK.Text}'")
            MsgBox("Data berhasil dihapus!", vbInformation, "Sukses")
            tampildata()
            cleardata()
        End If
    End Sub
    Private Sub txtkehadiran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkehadiran.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTugas.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUts.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtUas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUas.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Sub tampildata()
        dgvnilai.DataSource = Query("SELECT * From tblNilaiMhs")
    End Sub
    Sub cleardata()
        Dim tempat As GroupBox = GroupBox1
        Dim input As Control
        For Each input In tempat.Controls
            If TypeOf input Is TextBox Then
                input.Text = ""
            End If
        Next
        lblgrade.Text = ""
        txtNpm.Focus()
    End Sub
    Private Sub dgvnilai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvnilai.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvnilai.Rows(e.RowIndex)
            txtNpm.Text = row.Cells("npm").Value.ToString()
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtkodeMK.Text = row.Cells("kodeMK").Value.ToString()
            txtmatakuliah.Text = row.Cells("namaMK").Value.ToString()
            txtkehadiran.Text = row.Cells("kehadiran").Value.ToString()
            txtTugas.Text = row.Cells("tugas").Value.ToString()
            txtUts.Text = row.Cells("uts").Value.ToString()
            txtUas.Text = row.Cells("uas").Value.ToString()
            txtNilaiAkhir.Text = row.Cells("nilaiAkhir").Value.ToString()
            lblgrade.Text = row.Cells("grade").Value.ToString()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        cleardata()
    End Sub

    Private Sub hitungNilai()
        nilaiAkhir = (kehadiran * 0.1) + (tugas * 0.2) + (uts * 0.3) + (uas * 0.4)
        txtNilaiAkhir.Text = nilaiAkhir.ToString
        If kehadiran < 75 Then
            lblgrade.Text = "X"
        ElseIf nilaiAkhir >= 80 Then
            lblgrade.Text = "A"
        ElseIf nilaiAkhir >= 70 Then
            lblgrade.Text = "B"
        ElseIf nilaiAkhir >= 60 Then
            lblgrade.Text = "C"
        ElseIf nilaiAkhir >= 50 Then
            lblgrade.Text = "D"
        Else
            lblgrade.Text = "E"
        End If
    End Sub

    Private Sub txtkodeMK_TextChanged(sender As Object, e As EventArgs) Handles txtkodeMK.TextChanged
        If txtkodeMK.Text.Length = txtkodeMK.MaxLength Then
            If txtkodeMK.Text = "SIKB407" Then
                txtmatakuliah.Text = "PEMROGRAMAN VISUAL II"
            ElseIf txtkodeMK.Text = "SIKB402" Then
                txtmatakuliah.Text = "JARINGAN KOMPUTER"
            ElseIf txtkodeMK.Text = "SIKB401" Then
                txtmatakuliah.Text = "PEMROGRAMAN BERBASIS OBJEK"
            ElseIf txtkodeMK.Text = "SIKB409" Then
                txtmatakuliah.Text = "INTERAKSI MANUSIA DAN KOMPUTER"
            Else
                MsgBox("KODE MATA KULIAH TIDAK TERDAFTAR", vbOKOnly + vbExclamation, "kesalahan Input")
            End If
        End If
    End Sub
End Class
