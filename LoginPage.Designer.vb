﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Label1 = New Label()
        Label2 = New Label()
        loginemail = New TextBox()
        loginpassword = New TextBox()
        BtnLogin = New Button()
        Label3 = New Label()
        Label4 = New Label()
        LinkForgotPassword = New LinkLabel()
        Label5 = New Label()
        LinkRegister = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Brush Script MT", 120F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label1.Location = New Point(1143, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(518, 246)
        Label1.TabIndex = 0
        Label1.Text = "Hello,"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Showcard Gothic", 105F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label2.Location = New Point(889, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(1013, 218)
        Label2.TabIndex = 1
        Label2.Text = "WELCOME!"
        ' 
        ' loginemail
        ' 
        loginemail.BackColor = Color.YellowGreen
        loginemail.BorderStyle = BorderStyle.FixedSingle
        loginemail.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginemail.Location = New Point(217, 381)
        loginemail.Name = "loginemail"
        loginemail.Size = New Size(418, 53)
        loginemail.TabIndex = 2
        ' 
        ' loginpassword
        ' 
        loginpassword.BackColor = Color.YellowGreen
        loginpassword.BorderStyle = BorderStyle.FixedSingle
        loginpassword.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginpassword.Location = New Point(217, 497)
        loginpassword.Name = "loginpassword"
        loginpassword.Size = New Size(418, 53)
        loginpassword.TabIndex = 3
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.DarkGreen
        BtnLogin.FlatStyle = FlatStyle.Popup
        BtnLogin.Font = New Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(335, 621)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(165, 49)
        BtnLogin.TabIndex = 4
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label3.Location = New Point(201, 334)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 44)
        Label3.TabIndex = 5
        Label3.Text = "Email:" & vbCrLf
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label4.Location = New Point(201, 450)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 44)
        Label4.TabIndex = 6
        Label4.Text = "Password:"
        ' 
        ' LinkForgotPassword
        ' 
        LinkForgotPassword.ActiveLinkColor = Color.Green
        LinkForgotPassword.AutoSize = True
        LinkForgotPassword.BackColor = Color.Transparent
        LinkForgotPassword.Font = New Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkForgotPassword.LinkColor = Color.Blue
        LinkForgotPassword.Location = New Point(434, 562)
        LinkForgotPassword.Name = "LinkForgotPassword"
        LinkForgotPassword.Size = New Size(229, 26)
        LinkForgotPassword.TabIndex = 7
        LinkForgotPassword.TabStop = True
        LinkForgotPassword.Text = "Forgot Password?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(201, 683)
        Label5.Name = "Label5"
        Label5.Size = New Size(288, 31)
        Label5.TabIndex = 8
        Label5.Text = "Don't have an account yet?"
        ' 
        ' LinkRegister
        ' 
        LinkRegister.ActiveLinkColor = Color.Green
        LinkRegister.AutoSize = True
        LinkRegister.BackColor = Color.Transparent
        LinkRegister.Font = New Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkRegister.Location = New Point(488, 687)
        LinkRegister.Name = "LinkRegister"
        LinkRegister.Size = New Size(175, 26)
        LinkRegister.TabIndex = 9
        LinkRegister.TabStop = True
        LinkRegister.Text = "Register Here!"
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(LinkRegister)
        Controls.Add(Label5)
        Controls.Add(LinkForgotPassword)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(BtnLogin)
        Controls.Add(loginpassword)
        Controls.Add(loginemail)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "LoginPage"
        Text = "Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loginemail As TextBox
    Friend WithEvents loginpassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkForgotPassword As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkRegister As LinkLabel

End Class
