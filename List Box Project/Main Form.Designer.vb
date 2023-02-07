<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstTeach = New System.Windows.Forms.ListBox()
        Me.picTeach = New System.Windows.Forms.PictureBox()
        Me.lblTeach = New System.Windows.Forms.Label()
        CType(Me.picTeach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTeach
        '
        Me.lstTeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTeach.FormattingEnabled = True
        Me.lstTeach.ItemHeight = 25
        Me.lstTeach.Items.AddRange(New Object() {"1. Mrs Arens", "2. Mr. Nipert", "3. Coach Armstrong", "4. Mr. VanPelt", "5. Mrs. Jones"})
        Me.lstTeach.Location = New System.Drawing.Point(12, 12)
        Me.lstTeach.Name = "lstTeach"
        Me.lstTeach.Size = New System.Drawing.Size(185, 129)
        Me.lstTeach.TabIndex = 0
        '
        'picTeach
        '
        Me.picTeach.Location = New System.Drawing.Point(258, 12)
        Me.picTeach.Name = "picTeach"
        Me.picTeach.Size = New System.Drawing.Size(166, 174)
        Me.picTeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeach.TabIndex = 1
        Me.picTeach.TabStop = False
        '
        'lblTeach
        '
        Me.lblTeach.AutoSize = True
        Me.lblTeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeach.Location = New System.Drawing.Point(277, 204)
        Me.lblTeach.Name = "lblTeach"
        Me.lblTeach.Size = New System.Drawing.Size(0, 20)
        Me.lblTeach.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 259)
        Me.Controls.Add(Me.lblTeach)
        Me.Controls.Add(Me.picTeach)
        Me.Controls.Add(Me.lstTeach)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picTeach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTeach As ListBox
    Friend WithEvents picTeach As PictureBox
    Friend WithEvents lblTeach As Label
End Class
