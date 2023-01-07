Namespace m0c_dpi_killer
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.lblStatus = New System.Windows.Forms.Label()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.btnMin = New System.Windows.Forms.Button()
			Me.btnExit = New System.Windows.Forms.Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.label3 = New System.Windows.Forms.Label()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.progressBar1 = New System.Windows.Forms.ProgressBarEx()
			Me.panel2.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.panel3.SuspendLayout()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblStatus
			' 
			Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblStatus.ForeColor = System.Drawing.Color.SteelBlue
			Me.lblStatus.Location = New System.Drawing.Point(12, 151)
			Me.lblStatus.Name = "lblStatus"
			Me.lblStatus.Size = New System.Drawing.Size(364, 28)
			Me.lblStatus.TabIndex = 2
			Me.lblStatus.Text = "Please wait... Setting up..."
			Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.lblStatus.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.lblStatus_MouseDown)
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 500
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.btnMin)
			Me.panel2.Controls.Add(Me.btnExit)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(389, 29)
			Me.panel2.TabIndex = 5
'			Me.panel2.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.panel2_MouseDown)
			' 
			' btnMin
			' 
			Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnMin.Font = New System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold)
			Me.btnMin.Location = New System.Drawing.Point(326, 1)
			Me.btnMin.Margin = New System.Windows.Forms.Padding(0)
			Me.btnMin.Name = "btnMin"
			Me.btnMin.Size = New System.Drawing.Size(30, 26)
			Me.btnMin.TabIndex = 1
			Me.btnMin.Text = "_"
			Me.btnMin.UseVisualStyleBackColor = True
'			Me.btnMin.Click += New System.EventHandler(Me.btnMin_Click)
			' 
			' btnExit
			' 
			Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnExit.Font = New System.Drawing.Font("Arial Black", 7F, System.Drawing.FontStyle.Bold)
			Me.btnExit.Location = New System.Drawing.Point(358, 1)
			Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
			Me.btnExit.Name = "btnExit"
			Me.btnExit.Size = New System.Drawing.Size(30, 26)
			Me.btnExit.TabIndex = 0
			Me.btnExit.Text = "X"
			Me.btnExit.UseVisualStyleBackColor = True
'			Me.btnExit.Click += New System.EventHandler(Me.btnExit_Click)
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 29)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(389, 63)
			Me.panel1.TabIndex = 6
'			Me.panel1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.panel1_MouseDown)
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(12, 31)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(364, 31)
			Me.label2.TabIndex = 7
			Me.label2.Text = "Surf HTTPS websites freely!"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.label2.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.label2_MouseDown)
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(12, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(364, 31)
			Me.label1.TabIndex = 6
			Me.label1.Text = "m0c dpi killer 1.01"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.label1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.label1_MouseDown)
			' 
			' panel3
			' 
			Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel3.Controls.Add(Me.pictureBox1)
			Me.panel3.Controls.Add(Me.label3)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel3.Location = New System.Drawing.Point(0, 197)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(389, 46)
			Me.panel3.TabIndex = 7
'			Me.panel3.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.panel3_MouseDown)
			' 
			' label3
			' 
			Me.label3.Cursor = System.Windows.Forms.Cursors.Hand
			Me.label3.Font = New System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(137, 6)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(144, 31)
			Me.label3.TabIndex = 8
			Me.label3.Text = "@m0c_dpi_killer"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.label3.Click += New System.EventHandler(Me.label3_Click)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox1.Image = (DirectCast(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(111, 6)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox1.TabIndex = 8
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.Click += New System.EventHandler(Me.pictureBox1_Click)
			' 
			' progressBar1
			' 
			Me.progressBar1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(56)))), (CInt((CByte(105)))), (CInt((CByte(129)))))
			Me.progressBar1.Location = New System.Drawing.Point(12, 114)
			Me.progressBar1.Name = "progressBar1"
			Me.progressBar1.Size = New System.Drawing.Size(364, 23)
			Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
			Me.progressBar1.TabIndex = 4
'			Me.progressBar1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.progressBar1_MouseDown)
			' 
			' Form1
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(41)))), (CInt((CByte(44)))), (CInt((CByte(51)))))
			Me.ClientSize = New System.Drawing.Size(389, 243)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.progressBar1)
			Me.Controls.Add(Me.lblStatus)
			Me.Font = New System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(62)))), (CInt((CByte(120)))), (CInt((CByte(138)))))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "m0c dpi killer"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Form1_FormClosing)
'			Me.Load += New System.EventHandler(Me.Form1_Load)
'			Me.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.Form1_MouseDown)
			Me.panel2.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel3.ResumeLayout(False)
			Me.panel3.PerformLayout()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents lblStatus As System.Windows.Forms.Label
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents progressBar1 As System.Windows.Forms.ProgressBarEx
		Private WithEvents panel2 As System.Windows.Forms.Panel
		Private WithEvents btnMin As System.Windows.Forms.Button
		Private WithEvents btnExit As System.Windows.Forms.Button
		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private WithEvents label2 As System.Windows.Forms.Label
		Private WithEvents label1 As System.Windows.Forms.Label
		Private WithEvents panel3 As System.Windows.Forms.Panel
		Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents label3 As System.Windows.Forms.Label
	End Class
End Namespace

