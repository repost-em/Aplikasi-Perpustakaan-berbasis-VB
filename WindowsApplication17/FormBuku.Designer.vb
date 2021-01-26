<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuku))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPeminjamanBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPengembalianBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter()
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 24)
        Me.MenuStrip1.TabIndex = 64
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnggotaToolStripMenuItem, Me.PetugasToolStripMenuItem, Me.BukuToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AnggotaToolStripMenuItem.Text = "Anggota"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.PetugasToolStripMenuItem.Text = "Petugas"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanBukuToolStripMenuItem, Me.PengembalianBukuToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PeminjamanBukuToolStripMenuItem
        '
        Me.PeminjamanBukuToolStripMenuItem.Name = "PeminjamanBukuToolStripMenuItem"
        Me.PeminjamanBukuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PeminjamanBukuToolStripMenuItem.Text = "Peminjaman Buku"
        '
        'PengembalianBukuToolStripMenuItem
        '
        Me.PengembalianBukuToolStripMenuItem.Name = "PengembalianBukuToolStripMenuItem"
        Me.PengembalianBukuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PengembalianBukuToolStripMenuItem.Text = "Pengembalian Buku"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPeminjamanBukuToolStripMenuItem, Me.LaporanPengembalianBukuToolStripMenuItem, Me.LaporanAnggotaToolStripMenuItem, Me.LaporanPetugasToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPeminjamanBukuToolStripMenuItem
        '
        Me.LaporanPeminjamanBukuToolStripMenuItem.Name = "LaporanPeminjamanBukuToolStripMenuItem"
        Me.LaporanPeminjamanBukuToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.LaporanPeminjamanBukuToolStripMenuItem.Text = "Laporan Peminjaman Buku"
        '
        'LaporanPengembalianBukuToolStripMenuItem
        '
        Me.LaporanPengembalianBukuToolStripMenuItem.Name = "LaporanPengembalianBukuToolStripMenuItem"
        Me.LaporanPengembalianBukuToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.LaporanPengembalianBukuToolStripMenuItem.Text = "Laporan Pengembalian Buku"
        '
        'LaporanAnggotaToolStripMenuItem
        '
        Me.LaporanAnggotaToolStripMenuItem.Name = "LaporanAnggotaToolStripMenuItem"
        Me.LaporanAnggotaToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.LaporanAnggotaToolStripMenuItem.Text = "Laporan Anggota"
        '
        'LaporanPetugasToolStripMenuItem
        '
        Me.LaporanPetugasToolStripMenuItem.Name = "LaporanPetugasToolStripMenuItem"
        Me.LaporanPetugasToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.LaporanPetugasToolStripMenuItem.Text = "Laporan Petugas"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(198, 284)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(127, 22)
        Me.TextBox5.TabIndex = 63
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(198, 251)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(127, 22)
        Me.TextBox6.TabIndex = 62
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(198, 217)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(127, 22)
        Me.TextBox7.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(57, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Tahun :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(57, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Stok :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(412, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Cari Buku :"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"B001", "B002", "B003", "B004", "B005", "B006", "B007"})
        Me.ComboBox1.Location = New System.Drawing.Point(198, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 57
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(708, 160)
        Me.DataGridView1.TabIndex = 56
        '
        'keluar
        '
        Me.keluar.Font = New System.Drawing.Font("Century", 11.0!)
        Me.keluar.Location = New System.Drawing.Point(625, 327)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(82, 33)
        Me.keluar.TabIndex = 55
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Font = New System.Drawing.Font("Century", 11.0!)
        Me.hapus.Location = New System.Drawing.Point(477, 327)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(87, 33)
        Me.hapus.TabIndex = 54
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.ubah.Location = New System.Drawing.Point(335, 327)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(90, 33)
        Me.ubah.TabIndex = 53
        Me.ubah.Text = "Edit"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'batal
        '
        Me.batal.Font = New System.Drawing.Font("Century", 11.0!)
        Me.batal.Location = New System.Drawing.Point(177, 327)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(94, 33)
        Me.batal.TabIndex = 52
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.tambah.Location = New System.Drawing.Point(26, 327)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(98, 33)
        Me.tambah.TabIndex = 51
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Font = New System.Drawing.Font("Century", 10.0!)
        Me.cari.Location = New System.Drawing.Point(525, 287)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(156, 24)
        Me.cari.TabIndex = 50
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(198, 181)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 22)
        Me.TextBox3.TabIndex = 49
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(198, 146)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 22)
        Me.TextBox2.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(198, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 22)
        Me.TextBox1.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(57, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Penerbit :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Pengarang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(56, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Kategori :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Judul :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nomor Buku :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(274, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 30)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "INPUT DATA BUKU"
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("Expr3", "Expr3"), New System.Data.Common.DataColumnMapping("Expr4", "Expr4"), New System.Data.Common.DataColumnMapping("Expr5", "Expr5"), New System.Data.Common.DataColumnMapping("Expr6", "Expr6"), New System.Data.Common.DataColumnMapping("Expr7", "Expr7")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT        Nomor_Buku AS Expr1, Judul AS Expr2, Kategori AS Expr3, Pengarang A" &
    "S Expr4, Penerbit AS Expr5, Tahun AS Expr6, Stok AS Expr7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            buku"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "Dsn=dbperpus"
        '
        'FormBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(747, 588)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBuku"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPeminjamanBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPengembalianBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanAnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents keluar As Button
    Friend WithEvents hapus As Button
    Friend WithEvents ubah As Button
    Friend WithEvents batal As Button
    Friend WithEvents tambah As Button
    Friend WithEvents cari As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OdbcDataAdapter1 As Odbc.OdbcDataAdapter
    Friend WithEvents OdbcSelectCommand1 As Odbc.OdbcCommand
    Friend WithEvents OdbcConnection1 As Odbc.OdbcConnection
End Class
