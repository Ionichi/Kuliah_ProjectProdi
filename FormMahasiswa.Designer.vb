<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMahasiswa
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridViewMahasiswa = New System.Windows.Forms.DataGridView()
        Me.nim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_mahasiswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_telp_mahasiswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email_mahasiswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_kelamin_mahasiswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_mahasiswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioLainnya = New System.Windows.Forms.RadioButton()
        Me.radioPerempuan = New System.Windows.Forms.RadioButton()
        Me.radioLaki = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 67)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(256, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Mahasiswa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnUndo)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.DataGridViewMahasiswa)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtTelp)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtNIM)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 574)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(676, 218)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 55)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnUndo.Location = New System.Drawing.Point(610, 218)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(60, 55)
        Me.btnUndo.TabIndex = 14
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(544, 218)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 55)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(478, 218)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(60, 55)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAdd.Location = New System.Drawing.Point(412, 218)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 55)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'DataGridViewMahasiswa
        '
        Me.DataGridViewMahasiswa.AllowUserToAddRows = False
        Me.DataGridViewMahasiswa.AllowUserToDeleteRows = False
        Me.DataGridViewMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nim, Me.nama_mahasiswa, Me.no_telp_mahasiswa, Me.email_mahasiswa, Me.jenis_kelamin_mahasiswa, Me.alamat_mahasiswa})
        Me.DataGridViewMahasiswa.Location = New System.Drawing.Point(18, 279)
        Me.DataGridViewMahasiswa.Name = "DataGridViewMahasiswa"
        Me.DataGridViewMahasiswa.ReadOnly = True
        Me.DataGridViewMahasiswa.Size = New System.Drawing.Size(718, 279)
        Me.DataGridViewMahasiswa.TabIndex = 12
        '
        'nim
        '
        Me.nim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nim.HeaderText = "NIM"
        Me.nim.Name = "nim"
        Me.nim.ReadOnly = True
        Me.nim.Width = 52
        '
        'nama_mahasiswa
        '
        Me.nama_mahasiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nama_mahasiswa.HeaderText = "Nama"
        Me.nama_mahasiswa.Name = "nama_mahasiswa"
        Me.nama_mahasiswa.ReadOnly = True
        Me.nama_mahasiswa.Width = 60
        '
        'no_telp_mahasiswa
        '
        Me.no_telp_mahasiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.no_telp_mahasiswa.HeaderText = "No. Telp"
        Me.no_telp_mahasiswa.Name = "no_telp_mahasiswa"
        Me.no_telp_mahasiswa.ReadOnly = True
        Me.no_telp_mahasiswa.Width = 73
        '
        'email_mahasiswa
        '
        Me.email_mahasiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.email_mahasiswa.HeaderText = "Email"
        Me.email_mahasiswa.Name = "email_mahasiswa"
        Me.email_mahasiswa.ReadOnly = True
        Me.email_mahasiswa.Width = 57
        '
        'jenis_kelamin_mahasiswa
        '
        Me.jenis_kelamin_mahasiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.jenis_kelamin_mahasiswa.HeaderText = "Jenis Kelamin"
        Me.jenis_kelamin_mahasiswa.Name = "jenis_kelamin_mahasiswa"
        Me.jenis_kelamin_mahasiswa.ReadOnly = True
        Me.jenis_kelamin_mahasiswa.Width = 96
        '
        'alamat_mahasiswa
        '
        Me.alamat_mahasiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.alamat_mahasiswa.HeaderText = "Alamat"
        Me.alamat_mahasiswa.Name = "alamat_mahasiswa"
        Me.alamat_mahasiswa.ReadOnly = True
        Me.alamat_mahasiswa.Width = 64
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 60)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cari Data"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(149, 21)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(227, 23)
        Me.TextBox6.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Laki-Laki", "Perempuan", "Lainnya"})
        Me.ComboBox1.Location = New System.Drawing.Point(7, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(126, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(517, 40)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(219, 73)
        Me.txtAlamat.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(125, 169)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(162, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(125, 127)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(162, 20)
        Me.txtTelp.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(125, 83)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(162, 20)
        Me.txtNama.TabIndex = 7
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(125, 40)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(162, 20)
        Me.txtNIM.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioLainnya)
        Me.GroupBox2.Controls.Add(Me.radioPerempuan)
        Me.GroupBox2.Controls.Add(Me.radioLaki)
        Me.GroupBox2.Location = New System.Drawing.Point(465, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 64)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jenis Kelamin"
        '
        'radioLainnya
        '
        Me.radioLainnya.AutoSize = True
        Me.radioLainnya.Location = New System.Drawing.Point(183, 29)
        Me.radioLainnya.Name = "radioLainnya"
        Me.radioLainnya.Size = New System.Drawing.Size(62, 17)
        Me.radioLainnya.TabIndex = 2
        Me.radioLainnya.TabStop = True
        Me.radioLainnya.Text = "Lainnya"
        Me.radioLainnya.UseVisualStyleBackColor = True
        '
        'radioPerempuan
        '
        Me.radioPerempuan.AutoSize = True
        Me.radioPerempuan.Location = New System.Drawing.Point(92, 29)
        Me.radioPerempuan.Name = "radioPerempuan"
        Me.radioPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.radioPerempuan.TabIndex = 1
        Me.radioPerempuan.TabStop = True
        Me.radioPerempuan.Text = "Perempuan"
        Me.radioPerempuan.UseVisualStyleBackColor = True
        '
        'radioLaki
        '
        Me.radioLaki.AutoSize = True
        Me.radioLaki.Location = New System.Drawing.Point(10, 29)
        Me.radioLaki.Name = "radioLaki"
        Me.radioLaki.Size = New System.Drawing.Size(64, 17)
        Me.radioLaki.TabIndex = 0
        Me.radioLaki.TabStop = True
        Me.radioLaki.Text = "Laki-laki"
        Me.radioLaki.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(462, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "No. Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIM"
        '
        'FormMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 668)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMahasiswa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents radioLainnya As RadioButton
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents radioLaki As RadioButton
    Friend WithEvents DataGridViewMahasiswa As DataGridView
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents nim As DataGridViewTextBoxColumn
    Friend WithEvents nama_mahasiswa As DataGridViewTextBoxColumn
    Friend WithEvents no_telp_mahasiswa As DataGridViewTextBoxColumn
    Friend WithEvents email_mahasiswa As DataGridViewTextBoxColumn
    Friend WithEvents jenis_kelamin_mahasiswa As DataGridViewTextBoxColumn
    Friend WithEvents alamat_mahasiswa As DataGridViewTextBoxColumn
End Class
