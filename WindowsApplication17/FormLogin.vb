Imports System.Data.Odbc
Public Class FormLogin
    Dim CMD As New OdbcCommand
    Dim RD As OdbcDataReader

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 6
        TextBox2.PasswordChar = "X"
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("username & password kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Call bukaDB()
            CMD = New OdbcCommand("select * from petugas where nama_petugas='" & TextBox1.Text & "' and password_petugas='" & TextBox2.Text & "'", konek)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                Me.Close()
                MessageBox.Show("LOGIN Berhasil :)!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormMenuUtama.Show()
                FormMenuUtama.LoginToolStripMenuItem.Enabled = False
                FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
                FormMenuUtama.MasterToolStripMenuItem.Enabled = True
                FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
            Else
                MessageBox.Show("LOGIN GAGAL! username/password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
        End If
    End Sub
    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        MessageBox.Show("Batal login?", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "X"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Anda akan mendaftarkan diri", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Question)
        FormPetugas.Show()
        Me.Hide()
    End Sub
End Class