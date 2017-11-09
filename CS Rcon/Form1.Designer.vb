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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtRcon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdConnect = New System.Windows.Forms.Button()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.LblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TxtCmd = New System.Windows.Forms.TextBox()
        Me.TxtConsole = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtRcon)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CmdConnect)
        Me.Panel1.Controls.Add(Me.TxtIP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 100)
        Me.Panel1.TabIndex = 0
        '
        'TxtRcon
        '
        Me.TxtRcon.Location = New System.Drawing.Point(61, 34)
        Me.TxtRcon.Name = "TxtRcon"
        Me.TxtRcon.Size = New System.Drawing.Size(294, 20)
        Me.TxtRcon.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rcon"
        '
        'CmdConnect
        '
        Me.CmdConnect.Location = New System.Drawing.Point(61, 60)
        Me.CmdConnect.Name = "CmdConnect"
        Me.CmdConnect.Size = New System.Drawing.Size(75, 23)
        Me.CmdConnect.TabIndex = 2
        Me.CmdConnect.Text = "Connect"
        Me.CmdConnect.UseVisualStyleBackColor = True
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(61, 8)
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.Size = New System.Drawing.Size(294, 20)
        Me.TxtIP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP:Port"
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblStatus})
        Me.Status.Location = New System.Drawing.Point(2, 282)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(594, 22)
        Me.Status.TabIndex = 1
        Me.Status.Text = "StatusStrip1"
        '
        'LblStatus
        '
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'TxtCmd
        '
        Me.TxtCmd.BackColor = System.Drawing.Color.Black
        Me.TxtCmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCmd.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtCmd.ForeColor = System.Drawing.Color.White
        Me.TxtCmd.Location = New System.Drawing.Point(2, 102)
        Me.TxtCmd.Name = "TxtCmd"
        Me.TxtCmd.Size = New System.Drawing.Size(594, 20)
        Me.TxtCmd.TabIndex = 3
        '
        'TxtConsole
        '
        Me.TxtConsole.BackColor = System.Drawing.Color.Black
        Me.TxtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtConsole.ForeColor = System.Drawing.Color.Green
        Me.TxtConsole.Location = New System.Drawing.Point(2, 122)
        Me.TxtConsole.Multiline = True
        Me.TxtConsole.Name = "TxtConsole"
        Me.TxtConsole.ReadOnly = True
        Me.TxtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtConsole.Size = New System.Drawing.Size(594, 160)
        Me.TxtConsole.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 306)
        Me.Controls.Add(Me.TxtConsole)
        Me.Controls.Add(Me.TxtCmd)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "CS Rcon"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdConnect As Button
    Friend WithEvents TxtRcon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Status As StatusStrip
    Friend WithEvents TxtCmd As TextBox
    Friend WithEvents TxtConsole As TextBox
    Friend WithEvents LblStatus As ToolStripStatusLabel
End Class
