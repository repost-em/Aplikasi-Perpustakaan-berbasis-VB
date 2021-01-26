<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPetugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPetugas))
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand()
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection()
        Me.OdbcDataAdapter1 = New System.Data.Odbc.OdbcDataAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Admin", "Bendahara", "Sekertaris", "Kepala Perpustakaan", "Anggota"})
        Me.ComboBox2.Location = New System.Drawing.Point(250, 241)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 50
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pt01", "Pt02", "Pt03", "Pt04", "Pt05", "Pt06", "Pt07"})
        Me.ComboBox1.Location = New System.Drawing.Point(250, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 49
        '
        'keluar
        '
        Me.keluar.Font = New System.Drawing.Font("Century", 11.0!)
        Me.keluar.Location = New System.Drawing.Point(571, 297)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(74, 32)
        Me.keluar.TabIndex = 48
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Font = New System.Drawing.Font("Century", 11.0!)
        Me.hapus.Location = New System.Drawing.Point(449, 297)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(79, 32)
        Me.hapus.TabIndex = 47
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.ubah.Location = New System.Drawing.Point(331, 297)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(79, 32)
        Me.ubah.TabIndex = 46
        Me.ubah.Text = "Edit"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'batal
        '
        Me.batal.Font = New System.Drawing.Font("Century", 11.0!)
        Me.batal.Location = New System.Drawing.Point(223, 297)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(84, 32)
        Me.batal.TabIndex = 45
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Font = New System.Drawing.Font("Century", 11.0!)
        Me.tambah.Location = New System.Drawing.Point(109, 297)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(78, 32)
        Me.tambah.TabIndex = 44
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Location = New System.Drawing.Point(524, 265)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(149, 20)
        Me.cari.TabIndex = 43
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(250, 185)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 23)
        Me.TextBox2.TabIndex = 42
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(250, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 23)
        Me.TextBox1.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(398, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Cari Petugas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(108, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Level Petugas  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(108, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Password Admin :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(108, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nama Petugas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(108, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Kode Petugas  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(202, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 27)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "INPUT PETUGAS PERPUSTAKAAN"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(76, 335)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(609, 146)
        Me.DataGridView1.TabIndex = 51
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT        Kode_Petugas, Nama_Petugas, Password_Petugas, Status_Petugas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM " &
    "           petugas"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "Dsn=dbperpus;database=dbperpus;option=0;port=3306;server=localhost;uid=root"
        '
        'OdbcDataAdapter1
        '
        Me.OdbcDataAdapter1.SelectCommand = Me.OdbcSelectCommand1
        Me.OdbcDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Kode_Petugas", "Kode_Petugas"), New System.Data.Common.DataColumnMapping("Nama_Petugas", "Nama_Petugas"), New System.Data.Common.DataColumnMapping("Password_Petugas", "Password_Petugas"), New System.Data.Common.DataColumnMapping("Status_Petugas", "Status_Petugas")})})
        '
        'FormPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(773, 499)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPetugas"
        Me.Text = "FormPetugas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents keluar As Button
    Friend WithEvents hapus As Button
    Friend WithEvents ubah As Button
    Friend WithEvents batal As Button
    Friend WithEvents tambah As Button
    Friend WithEvents cari As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OdbcSelectCommand1 As Odbc.OdbcCommand
    Friend WithEvents OdbcConnection1 As Odbc.OdbcConnection
    Friend WithEvents OdbcDataAdapter1 As Odbc.OdbcDataAdapter
End Class
