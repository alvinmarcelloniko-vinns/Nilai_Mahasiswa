<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.txtUas = New System.Windows.Forms.TextBox()
        Me.txtUts = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtkehadiran = New System.Windows.Forms.TextBox()
        Me.txtmatakuliah = New System.Windows.Forms.TextBox()
        Me.txtkodeMK = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNpm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dgvnilai = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvnilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblgrade)
        Me.GroupBox1.Controls.Add(Me.txtNilaiAkhir)
        Me.GroupBox1.Controls.Add(Me.txtUas)
        Me.GroupBox1.Controls.Add(Me.txtUts)
        Me.GroupBox1.Controls.Add(Me.txtTugas)
        Me.GroupBox1.Controls.Add(Me.txtkehadiran)
        Me.GroupBox1.Controls.Add(Me.txtmatakuliah)
        Me.GroupBox1.Controls.Add(Me.txtkodeMK)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtNpm)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 345)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrade.Location = New System.Drawing.Point(297, 209)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(0, 128)
        Me.lblgrade.TabIndex = 19
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.Enabled = False
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(91, 241)
        Me.txtNilaiAkhir.Multiline = True
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(100, 30)
        Me.txtNilaiAkhir.TabIndex = 18
        '
        'txtUas
        '
        Me.txtUas.Location = New System.Drawing.Point(91, 215)
        Me.txtUas.Name = "txtUas"
        Me.txtUas.Size = New System.Drawing.Size(100, 20)
        Me.txtUas.TabIndex = 17
        '
        'txtUts
        '
        Me.txtUts.Location = New System.Drawing.Point(91, 189)
        Me.txtUts.Name = "txtUts"
        Me.txtUts.Size = New System.Drawing.Size(100, 20)
        Me.txtUts.TabIndex = 16
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(91, 163)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(100, 20)
        Me.txtTugas.TabIndex = 15
        '
        'txtkehadiran
        '
        Me.txtkehadiran.Location = New System.Drawing.Point(91, 137)
        Me.txtkehadiran.Name = "txtkehadiran"
        Me.txtkehadiran.Size = New System.Drawing.Size(100, 20)
        Me.txtkehadiran.TabIndex = 14
        '
        'txtmatakuliah
        '
        Me.txtmatakuliah.Enabled = False
        Me.txtmatakuliah.Location = New System.Drawing.Point(91, 112)
        Me.txtmatakuliah.Name = "txtmatakuliah"
        Me.txtmatakuliah.Size = New System.Drawing.Size(235, 20)
        Me.txtmatakuliah.TabIndex = 13
        '
        'txtkodeMK
        '
        Me.txtkodeMK.Location = New System.Drawing.Point(91, 86)
        Me.txtkodeMK.MaxLength = 7
        Me.txtkodeMK.Name = "txtkodeMK"
        Me.txtkodeMK.Size = New System.Drawing.Size(100, 20)
        Me.txtkodeMK.TabIndex = 12
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(91, 59)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(137, 20)
        Me.txtNama.TabIndex = 11
        '
        'txtNpm
        '
        Me.txtNpm.Location = New System.Drawing.Point(91, 36)
        Me.txtNpm.Name = "txtNpm"
        Me.txtNpm.Size = New System.Drawing.Size(68, 20)
        Me.txtNpm.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(243, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Grade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nilai Akhir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "UAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "UTS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kehadiran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mata Kuliah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode MK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NPM"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnkeluar)
        Me.GroupBox2.Controls.Add(Me.btnhapus)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Controls.Add(Me.btntambah)
        Me.GroupBox2.Location = New System.Drawing.Point(527, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 336)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(0, 285)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(200, 45)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(0, 200)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(200, 45)
        Me.btnhapus.TabIndex = 2
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(0, 112)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(200, 45)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(0, 19)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(200, 45)
        Me.btntambah.TabIndex = 0
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dgvnilai
        '
        Me.dgvnilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnilai.Location = New System.Drawing.Point(13, 383)
        Me.dgvnilai.Name = "dgvnilai"
        Me.dgvnilai.Size = New System.Drawing.Size(714, 177)
        Me.dgvnilai.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 573)
        Me.Controls.Add(Me.dgvnilai)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nilai_Mahasiswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvnilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblgrade As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents txtUas As TextBox
    Friend WithEvents txtUts As TextBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtkehadiran As TextBox
    Friend WithEvents txtmatakuliah As TextBox
    Friend WithEvents txtkodeMK As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNpm As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents dgvnilai As DataGridView
End Class
