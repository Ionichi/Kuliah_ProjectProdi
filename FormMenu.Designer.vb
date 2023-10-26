<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnShowViewData = New System.Windows.Forms.Button()
        Me.btnShowFormBimbingan = New System.Windows.Forms.Button()
        Me.btnShowFormSidangOutline = New System.Windows.Forms.Button()
        Me.btnShowFormOutline = New System.Windows.Forms.Button()
        Me.btnShowFormDosen = New System.Windows.Forms.Button()
        Me.btnShowFormMahasiswa = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.copyRight = New System.Windows.Forms.ToolStripStatusLabel()
        Me.machineName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnShowViewData)
        Me.Panel1.Controls.Add(Me.btnShowFormBimbingan)
        Me.Panel1.Controls.Add(Me.btnShowFormSidangOutline)
        Me.Panel1.Controls.Add(Me.btnShowFormOutline)
        Me.Panel1.Controls.Add(Me.btnShowFormDosen)
        Me.Panel1.Controls.Add(Me.btnShowFormMahasiswa)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 682)
        Me.Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(79, 538)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnExit.Size = New System.Drawing.Size(92, 102)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnShowViewData
        '
        Me.btnShowViewData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowViewData.Image = CType(resources.GetObject("btnShowViewData.Image"), System.Drawing.Image)
        Me.btnShowViewData.Location = New System.Drawing.Point(127, 430)
        Me.btnShowViewData.Name = "btnShowViewData"
        Me.btnShowViewData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowViewData.Size = New System.Drawing.Size(92, 102)
        Me.btnShowViewData.TabIndex = 6
        Me.btnShowViewData.Text = "View Data"
        Me.btnShowViewData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShowViewData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShowViewData.UseVisualStyleBackColor = True
        '
        'btnShowFormBimbingan
        '
        Me.btnShowFormBimbingan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFormBimbingan.Image = CType(resources.GetObject("btnShowFormBimbingan.Image"), System.Drawing.Image)
        Me.btnShowFormBimbingan.Location = New System.Drawing.Point(24, 430)
        Me.btnShowFormBimbingan.Name = "btnShowFormBimbingan"
        Me.btnShowFormBimbingan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowFormBimbingan.Size = New System.Drawing.Size(97, 102)
        Me.btnShowFormBimbingan.TabIndex = 5
        Me.btnShowFormBimbingan.Text = "Form Bimbingan"
        Me.btnShowFormBimbingan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShowFormBimbingan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShowFormBimbingan.UseVisualStyleBackColor = True
        '
        'btnShowFormSidangOutline
        '
        Me.btnShowFormSidangOutline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFormSidangOutline.Image = CType(resources.GetObject("btnShowFormSidangOutline.Image"), System.Drawing.Image)
        Me.btnShowFormSidangOutline.Location = New System.Drawing.Point(127, 322)
        Me.btnShowFormSidangOutline.Name = "btnShowFormSidangOutline"
        Me.btnShowFormSidangOutline.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowFormSidangOutline.Size = New System.Drawing.Size(92, 102)
        Me.btnShowFormSidangOutline.TabIndex = 4
        Me.btnShowFormSidangOutline.Text = "Form Sidang Outline"
        Me.btnShowFormSidangOutline.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShowFormSidangOutline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShowFormSidangOutline.UseVisualStyleBackColor = True
        '
        'btnShowFormOutline
        '
        Me.btnShowFormOutline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFormOutline.Image = CType(resources.GetObject("btnShowFormOutline.Image"), System.Drawing.Image)
        Me.btnShowFormOutline.Location = New System.Drawing.Point(24, 322)
        Me.btnShowFormOutline.Name = "btnShowFormOutline"
        Me.btnShowFormOutline.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowFormOutline.Size = New System.Drawing.Size(97, 102)
        Me.btnShowFormOutline.TabIndex = 3
        Me.btnShowFormOutline.Text = "Form Outline"
        Me.btnShowFormOutline.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShowFormOutline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShowFormOutline.UseVisualStyleBackColor = True
        '
        'btnShowFormDosen
        '
        Me.btnShowFormDosen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFormDosen.Image = CType(resources.GetObject("btnShowFormDosen.Image"), System.Drawing.Image)
        Me.btnShowFormDosen.Location = New System.Drawing.Point(127, 214)
        Me.btnShowFormDosen.Name = "btnShowFormDosen"
        Me.btnShowFormDosen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowFormDosen.Size = New System.Drawing.Size(92, 102)
        Me.btnShowFormDosen.TabIndex = 2
        Me.btnShowFormDosen.Text = "Form Dosen"
        Me.btnShowFormDosen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShowFormDosen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShowFormDosen.UseVisualStyleBackColor = True
        '
        'btnShowFormMahasiswa
        '
        Me.btnShowFormMahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFormMahasiswa.Image = CType(resources.GetObject("btnShowFormMahasiswa.Image"), System.Drawing.Image)
        Me.btnShowFormMahasiswa.Location = New System.Drawing.Point(24, 214)
        Me.btnShowFormMahasiswa.Name = "btnShowFormMahasiswa"
        Me.btnShowFormMahasiswa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowFormMahasiswa.Size = New System.Drawing.Size(97, 102)
        Me.btnShowFormMahasiswa.TabIndex = 1
        Me.btnShowFormMahasiswa.Text = "Form Mahasiswa"
        Me.btnShowFormMahasiswa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnShowFormMahasiswa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnShowFormMahasiswa.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyRight, Me.machineName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 648)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(759, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'copyRight
        '
        Me.copyRight.Image = CType(resources.GetObject("copyRight.Image"), System.Drawing.Image)
        Me.copyRight.Name = "copyRight"
        Me.copyRight.Size = New System.Drawing.Size(16, 17)
        '
        'machineName
        '
        Me.machineName.Image = CType(resources.GetObject("machineName.Image"), System.Drawing.Image)
        Me.machineName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.machineName.Name = "machineName"
        Me.machineName.Size = New System.Drawing.Size(728, 17)
        Me.machineName.Spring = True
        Me.machineName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 670)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnShowFormMahasiswa As Button
    Friend WithEvents btnShowFormDosen As Button
    Friend WithEvents btnShowViewData As Button
    Friend WithEvents btnShowFormBimbingan As Button
    Friend WithEvents btnShowFormSidangOutline As Button
    Friend WithEvents btnShowFormOutline As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents copyRight As ToolStripStatusLabel
    Friend WithEvents machineName As ToolStripStatusLabel
End Class
