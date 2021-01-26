<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnggota
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnggota))
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter()
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 24)
        Me.MenuStrip1.TabIndex = 34
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
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AnggotaToolStripMenuItem.Text = "Anggota"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PetugasToolStripMenuItem.Text = "Petugas"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanBukuToolStripMenuItem, Me.PengembalianBukuToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
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
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A001", "A002", "A003", "A004", "A005", "A006", "A007"})
        Me.ComboBox1.Location = New System.Drawing.Point(260, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 33
        '
        'keluar
        '
        Me.keluar.Font = New System.Drawing.Font("Century", 11.0!)
        Me.keluar.Location = New System.Drawing.Point(568, 265)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(74, 32)
        Me.keluar.TabIndex = 32
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Font = New System.Drawing.Font("Century", 11.0!)
        Me.hapus.Location = New System.Drawing.Point(428, 266)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(79, 32)
        Me.hapus.TabIndex = 31
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.ubah.Location = New System.Drawing.Point(310, 265)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(79, 32)
        Me.ubah.TabIndex = 30
        Me.ubah.Text = "Edit"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'batal
        '
        Me.batal.Font = New System.Drawing.Font("Century", 11.0!)
        Me.batal.Location = New System.Drawing.Point(202, 265)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(84, 32)
        Me.batal.TabIndex = 29
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.tambah.Location = New System.Drawing.Point(88, 265)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(78, 32)
        Me.tambah.TabIndex = 28
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Location = New System.Drawing.Point(541, 230)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(149, 20)
        Me.cari.TabIndex = 27
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.TextBox3.Location = New System.Drawing.Point(260, 190)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 23)
        Me.TextBox3.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(260, 155)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 23)
        Me.TextBox2.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(260, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 23)
        Me.TextBox1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(415, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Cari Anggota :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(85, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Telepon Anggota :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(85, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Alamat  Anggota :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(85, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama Anggota :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(85, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nomor Anggota :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(179, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 27)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "INPUT ANGGOTA PERPUSTAKAAN"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(88, 326)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(602, 173)
        Me.DataGridView1.TabIndex = 35
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nomor_Anggota", "Nomor_Anggota"), New System.Data.Common.DataColumnMapping("Nama_Anggota", "Nama_Anggota"), New System.Data.Common.DataColumnMapping("Alamat_Anggota", "Alamat_Anggota"), New System.Data.Common.DataColumnMapping("Telepon_Anggota", "Telepon_Anggota")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT        Nomor_Anggota, Nama_Anggota, Alamat_Anggota, Telepon_Anggota" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM " &
    "           anggota"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "Dsn=dbperpus"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'FormAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(781, 537)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ComboBox1)
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
        Me.Name = "FormAnggota"
        Me.Text = "FormAnggota"
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
    Friend WithEvents ComboBox1 As ComboBox
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OdbcDataAdapter1 As Odbc.OdbcDataAdapter
    Friend WithEvents OdbcSelectCommand1 As Odbc.OdbcCommand
    Friend WithEvents OdbcConnection1 As Odbc.OdbcConnection
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
End Class
