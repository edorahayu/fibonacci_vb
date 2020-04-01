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
        Me.tittleBatas = New System.Windows.Forms.Label()
        Me.title1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tittle = New System.Windows.Forms.Label()
        Me.txtHasil = New System.Windows.Forms.Label()
        Me.btnHasil = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tittleBatas
        '
        Me.tittleBatas.AutoSize = True
        Me.tittleBatas.Location = New System.Drawing.Point(13, 105)
        Me.tittleBatas.Name = "tittleBatas"
        Me.tittleBatas.Size = New System.Drawing.Size(93, 13)
        Me.tittleBatas.TabIndex = 15
        Me.tittleBatas.Text = "Masukkan Batas :"
        '
        'title1
        '
        Me.title1.AutoSize = True
        Me.title1.Location = New System.Drawing.Point(46, 82)
        Me.title1.Name = "title1"
        Me.title1.Size = New System.Drawing.Size(185, 13)
        Me.title1.TabIndex = 14
        Me.title1.Text = "Program Algoritma Bilangan Fibonacci"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NIM    : 1118100137"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nama : Edo Rahayu"
        '
        'tittle
        '
        Me.tittle.AutoSize = True
        Me.tittle.Location = New System.Drawing.Point(12, 20)
        Me.tittle.Name = "tittle"
        Me.tittle.Size = New System.Drawing.Size(123, 13)
        Me.tittle.TabIndex = 11
        Me.tittle.Text = "Pemrogramman Visual II "
        '
        'txtHasil
        '
        Me.txtHasil.AutoSize = True
        Me.txtHasil.Location = New System.Drawing.Point(13, 197)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(16, 13)
        Me.txtHasil.TabIndex = 10
        Me.txtHasil.Text = "..."
        '
        'btnHasil
        '
        Me.btnHasil.Location = New System.Drawing.Point(16, 147)
        Me.btnHasil.Name = "btnHasil"
        Me.btnHasil.Size = New System.Drawing.Size(90, 23)
        Me.btnHasil.TabIndex = 9
        Me.btnHasil.Text = "Hitung"
        Me.btnHasil.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 231)
        Me.Controls.Add(Me.tittleBatas)
        Me.Controls.Add(Me.title1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tittle)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.btnHasil)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tittleBatas As System.Windows.Forms.Label
    Friend WithEvents title1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tittle As System.Windows.Forms.Label
    Friend WithEvents txtHasil As System.Windows.Forms.Label
    Friend WithEvents btnHasil As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
