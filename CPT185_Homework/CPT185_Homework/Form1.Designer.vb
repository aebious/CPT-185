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
        Me.LblApplicationTitle = New System.Windows.Forms.Label()
        Me.LblStudentsWelcome = New System.Windows.Forms.Label()
        Me.CmdJobDetails = New System.Windows.Forms.Button()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblLocation = New System.Windows.Forms.Label()
        Me.LblRoom101 = New System.Windows.Forms.Label()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.PnlImages = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LblApplicationTitle
        '
        Me.LblApplicationTitle.AutoSize = True
        Me.LblApplicationTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApplicationTitle.Location = New System.Drawing.Point(64, 23)
        Me.LblApplicationTitle.Name = "LblApplicationTitle"
        Me.LblApplicationTitle.Size = New System.Drawing.Size(209, 35)
        Me.LblApplicationTitle.TabIndex = 0
        Me.LblApplicationTitle.Text = "Tech Job Fair"
        '
        'LblStudentsWelcome
        '
        Me.LblStudentsWelcome.AutoSize = True
        Me.LblStudentsWelcome.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudentsWelcome.Location = New System.Drawing.Point(80, 74)
        Me.LblStudentsWelcome.Name = "LblStudentsWelcome"
        Me.LblStudentsWelcome.Size = New System.Drawing.Size(174, 18)
        Me.LblStudentsWelcome.TabIndex = 1
        Me.LblStudentsWelcome.Text = "All Students are Welcome"
        '
        'CmdJobDetails
        '
        Me.CmdJobDetails.Location = New System.Drawing.Point(95, 134)
        Me.CmdJobDetails.Name = "CmdJobDetails"
        Me.CmdJobDetails.Size = New System.Drawing.Size(137, 32)
        Me.CmdJobDetails.TabIndex = 2
        Me.CmdJobDetails.Text = "View Job Fair Details"
        Me.CmdJobDetails.UseVisualStyleBackColor = True
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(116, 200)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(91, 18)
        Me.LblDate.TabIndex = 3
        Me.LblDate.Text = "May 2, 2016"
        '
        'LblLocation
        '
        Me.LblLocation.AutoSize = True
        Me.LblLocation.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocation.Location = New System.Drawing.Point(80, 218)
        Me.LblLocation.Name = "LblLocation"
        Me.LblLocation.Size = New System.Drawing.Size(153, 18)
        Me.LblLocation.TabIndex = 4
        Me.LblLocation.Text = "Located in London Hall"
        '
        'LblRoom101
        '
        Me.LblRoom101.AutoSize = True
        Me.LblRoom101.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoom101.Location = New System.Drawing.Point(128, 236)
        Me.LblRoom101.Name = "LblRoom101"
        Me.LblRoom101.Size = New System.Drawing.Size(70, 18)
        Me.LblRoom101.TabIndex = 5
        Me.LblRoom101.Text = "Room101"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(95, 296)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(137, 31)
        Me.CmdExit.TabIndex = 6
        Me.CmdExit.Text = "Exit Window"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'PnlImages
        '
        Me.PnlImages.Location = New System.Drawing.Point(373, 23)
        Me.PnlImages.Name = "PnlImages"
        Me.PnlImages.Size = New System.Drawing.Size(200, 314)
        Me.PnlImages.TabIndex = 7
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 348)
        Me.Controls.Add(Me.PnlImages)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.LblRoom101)
        Me.Controls.Add(Me.LblLocation)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.CmdJobDetails)
        Me.Controls.Add(Me.LblStudentsWelcome)
        Me.Controls.Add(Me.LblApplicationTitle)
        Me.Name = "FrmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblApplicationTitle As Label
    Friend WithEvents LblStudentsWelcome As Label
    Friend WithEvents CmdJobDetails As Button
    Friend WithEvents LblDate As Label
    Friend WithEvents LblLocation As Label
    Friend WithEvents LblRoom101 As Label
    Friend WithEvents CmdExit As Button
    Friend WithEvents PnlImages As Panel
End Class
