<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardPage))
        BtnHistory = New Button()
        LinkLogout = New LinkLabel()
        LinkClients = New LinkLabel()
        LinkScan = New LinkLabel()
        LinkPetInfo = New LinkLabel()
        SuspendLayout()
        ' 
        ' BtnHistory
        ' 
        BtnHistory.BackColor = Color.DarkOliveGreen
        BtnHistory.FlatStyle = FlatStyle.Popup
        BtnHistory.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnHistory.ForeColor = Color.White
        BtnHistory.Location = New Point(1671, 913)
        BtnHistory.Name = "BtnHistory"
        BtnHistory.Size = New Size(166, 63)
        BtnHistory.TabIndex = 3
        BtnHistory.Text = "History"
        BtnHistory.UseVisualStyleBackColor = False
        ' 
        ' LinkLogout
        ' 
        LinkLogout.ActiveLinkColor = Color.Green
        LinkLogout.AutoSize = True
        LinkLogout.BackColor = Color.Transparent
        LinkLogout.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLogout.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        LinkLogout.Location = New Point(57, 939)
        LinkLogout.Name = "LinkLogout"
        LinkLogout.Size = New Size(180, 50)
        LinkLogout.TabIndex = 4
        LinkLogout.TabStop = True
        LinkLogout.Text = "Logout"
        LinkLogout.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' LinkClients
        ' 
        LinkClients.ActiveLinkColor = Color.Green
        LinkClients.AutoSize = True
        LinkClients.BackColor = Color.Transparent
        LinkClients.Font = New Font("Showcard Gothic", 60F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkClients.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkClients.Location = New Point(1061, 35)
        LinkClients.Name = "LinkClients"
        LinkClients.Size = New Size(437, 124)
        LinkClients.TabIndex = 5
        LinkClients.TabStop = True
        LinkClients.Text = "Clients"
        LinkClients.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' LinkScan
        ' 
        LinkScan.ActiveLinkColor = Color.Green
        LinkScan.AutoSize = True
        LinkScan.BackColor = Color.Transparent
        LinkScan.Font = New Font("Showcard Gothic", 60F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkScan.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkScan.Location = New Point(1559, 35)
        LinkScan.Name = "LinkScan"
        LinkScan.Size = New Size(289, 124)
        LinkScan.TabIndex = 6
        LinkScan.TabStop = True
        LinkScan.Text = "Scan"
        LinkScan.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' LinkPetInfo
        ' 
        LinkPetInfo.ActiveLinkColor = Color.Green
        LinkPetInfo.AutoSize = True
        LinkPetInfo.BackColor = Color.Transparent
        LinkPetInfo.Font = New Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkPetInfo.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkPetInfo.Location = New Point(520, 24)
        LinkPetInfo.Name = "LinkPetInfo"
        LinkPetInfo.Size = New Size(454, 148)
        LinkPetInfo.TabIndex = 7
        LinkPetInfo.TabStop = True
        LinkPetInfo.Text = "Client/Pet" & vbCrLf & "Registration" & vbCrLf
        LinkPetInfo.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' DashboardPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(LinkPetInfo)
        Controls.Add(LinkScan)
        Controls.Add(LinkClients)
        Controls.Add(LinkLogout)
        Controls.Add(BtnHistory)
        Name = "DashboardPage"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnHistory As Button
    Friend WithEvents LinkLogout As LinkLabel
    Friend WithEvents LinkClients As LinkLabel
    Friend WithEvents LinkScan As LinkLabel
    Friend WithEvents LinkPetInfo As LinkLabel
End Class
