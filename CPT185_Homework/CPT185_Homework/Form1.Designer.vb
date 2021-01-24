<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.lblApplicationTitle = New System.Windows.Forms.Label()
        Me.lblStudentsWelcome = New System.Windows.Forms.Label()
        Me.btnJobDetails = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblRoom101 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlImages = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblApplicationTitle
        '
        Me.lblApplicationTitle.AutoSize = True
        Me.lblApplicationTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationTitle.Location = New System.Drawing.Point(64, 23)
        Me.lblApplicationTitle.Name = "lblApplicationTitle"
        Me.lblApplicationTitle.Size = New System.Drawing.Size(209, 35)
        Me.lblApplicationTitle.TabIndex = 0
        Me.lblApplicationTitle.Text = "Tech Job Fair"
        '
        'lblStudentsWelcome
        '
        Me.lblStudentsWelcome.AutoSize = True
        Me.lblStudentsWelcome.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentsWelcome.Location = New System.Drawing.Point(80, 74)
        Me.lblStudentsWelcome.Name = "lblStudentsWelcome"
        Me.lblStudentsWelcome.Size = New System.Drawing.Size(174, 18)
        Me.lblStudentsWelcome.TabIndex = 1
        Me.lblStudentsWelcome.Text = "All Students are Welcome"
        '
        'btnJobDetails
        '
        Me.btnJobDetails.Location = New System.Drawing.Point(95, 134)
        Me.btnJobDetails.Name = "btnJobDetails"
        Me.btnJobDetails.Size = New System.Drawing.Size(137, 32)
        Me.btnJobDetails.TabIndex = 2
        Me.btnJobDetails.Text = "View Job Fair Details"
        Me.btnJobDetails.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(116, 200)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 18)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "May 2, 2016"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(80, 218)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(153, 18)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Located in London Hall"
        '
        'lblRoom101
        '
        Me.lblRoom101.AutoSize = True
        Me.lblRoom101.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom101.Location = New System.Drawing.Point(128, 236)
        Me.lblRoom101.Name = "lblRoom101"
        Me.lblRoom101.Size = New System.Drawing.Size(70, 18)
        Me.lblRoom101.TabIndex = 5
        Me.lblRoom101.Text = "Room101"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(95, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 31)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlImages
        '
        Me.pnlImages.Location = New System.Drawing.Point(373, 23)
        Me.pnlImages.Name = "pnlImages"
        Me.pnlImages.Size = New System.Drawing.Size(200, 314)
        Me.pnlImages.TabIndex = 7
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 348)
        Me.Controls.Add(Me.pnlImages)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblRoom101)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnJobDetails)
        Me.Controls.Add(Me.lblStudentsWelcome)
        Me.Controls.Add(Me.lblApplicationTitle)
        Me.Name = "FrmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblApplicationTitle As Label
    Friend WithEvents lblStudentsWelcome As Label
    Friend WithEvents btnJobDetails As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblRoom101 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlImages As Panel
End Class
