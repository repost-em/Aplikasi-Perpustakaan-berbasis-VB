<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPeminjaman))
        Me.cari = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(582, 342)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(115, 20)
        Me.cari.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(448, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 17)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Cari Pinjaman :"
        '
        'Tanggal
        '
        Me.Tanggal.Location = New System.Drawing.Point(203, 127)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(200, 20)
        Me.Tanggal.TabIndex = 79
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"A001", "A002", "A003", "A004", "A005", "A006", "A007"})
        Me.ComboBox2.Location = New System.Drawing.Point(203, 235)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox2.TabIndex = 77
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PM01", "PM02", "PM03", "PM04", "PM05", "PM06", "PM07"})
        Me.ComboBox1.Location = New System.Drawing.Point(203, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox1.TabIndex = 76
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(203, 324)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(232, 20)
        Me.TextBox6.TabIndex = 75
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(203, 262)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(232, 20)
        Me.TextBox4.TabIndex = 73
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(203, 154)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(111, 20)
        Me.TextBox3.TabIndex = 72
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(203, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(232, 20)
        Me.TextBox2.TabIndex = 71
        '
        'keluar
        '
        Me.keluar.Font = New System.Drawing.Font("Century", 11.0!)
        Me.keluar.Location = New System.Drawing.Point(588, 368)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(74, 25)
        Me.keluar.TabIndex = 69
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Font = New System.Drawing.Font("Century", 11.0!)
        Me.hapus.Location = New System.Drawing.Point(466, 368)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(79, 25)
        Me.hapus.TabIndex = 68
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.ubah.Location = New System.Drawing.Point(348, 368)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(79, 25)
        Me.ubah.TabIndex = 67
        Me.ubah.Text = "Edit"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'batal
        '
        Me.batal.Font = New System.Drawing.Font("Century", 11.0!)
        Me.batal.Location = New System.Drawing.Point(240, 368)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(84, 25)
        Me.batal.TabIndex = 66
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.tambah.Location = New System.Drawing.Point(126, 368)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(78, 25)
        Me.tambah.TabIndex = 65
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(86, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 17)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Nama Petugas :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(86, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 17)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Kode Petugas :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(86, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 17)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Nama Anggota :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(86, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Nomor Anggota :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(86, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Total Pinjam :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(86, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Judul :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(86, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Nomor Buku :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(86, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Tanggal Pinjam :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(86, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nomor Pinjam :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 26)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "INPUT DATA PEMINJAMAN BUKU"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(89, 404)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(608, 177)
        Me.DataGridView1.TabIndex = 82
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Pt01", "Pt02", "Pt03", "Pt04", "Pt05", "Pt06", "Pt07"})
        Me.ComboBox3.Location = New System.Drawing.Point(203, 293)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 83
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"B001", "B002", "B003", "B004", "B005", "B006", "B007"})
        Me.ComboBox4.Location = New System.Drawing.Point(203, 181)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 84
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT        Nomor_Pinjam, Tanggal_Pinjam, Total_Pinjam, Nomor_Buku, Judul, Nomo" &
    "r_Anggota, Nama_Anggota, Kode_Petugas, Nama_Petugas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            peminjaman"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "Dsn=dbperpus"
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nomor_Pinjam", "Nomor_Pinjam"), New System.Data.Common.DataColumnMapping("Tanggal_Pinjam", "Tanggal_Pinjam"), New System.Data.Common.DataColumnMapping("Total_Pinjam", "Total_Pinjam"), New System.Data.Common.DataColumnMapping("Nomor_Buku", "Nomor_Buku"), New System.Data.Common.DataColumnMapping("Judul", "Judul"), New System.Data.Common.DataColumnMapping("Nomor_Anggota", "Nomor_Anggota"), New System.Data.Common.DataColumnMapping("Nama_Anggota", "Nama_Anggota"), New System.Data.Common.DataColumnMapping("Kode_Petugas", "Kode_Petugas"), New System.Data.Common.DataColumnMapping("Nama_Petugas", "Nama_Petugas")})})
        '
        'FormPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(781, 602)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPeminjaman"
        Me.Text = "FormPeminjaman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cari As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Tanggal As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents keluar As Button
    Friend WithEvents hapus As Button
    Friend WithEvents ubah As Button
    Friend WithEvents batal As Button
    Friend WithEvents tambah As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents OdbcSelectCommand1 As Odbc.OdbcCommand
    Friend WithEvents OdbcConnection1 As Odbc.OdbcConnection
    Friend WithEvents OdbcDataAdapter1 As Odbc.OdbcDataAdapter
End Class
