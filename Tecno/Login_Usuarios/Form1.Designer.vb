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
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Ingresar = New Guna.UI.WinForms.GunaButton()
        Me.txt_Registrarse = New Guna.UI.WinForms.GunaButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Contraseña.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contraseña.ForeColor = System.Drawing.Color.White
        Me.txt_Contraseña.Location = New System.Drawing.Point(125, 10)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.Size = New System.Drawing.Size(143, 26)
        Me.txt_Contraseña.TabIndex = 2
        '
        'txt_Usuario
        '
        Me.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Usuario.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.ForeColor = System.Drawing.Color.White
        Me.txt_Usuario.Location = New System.Drawing.Point(125, 11)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(143, 26)
        Me.txt_Usuario.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(141, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Ingresar)
        Me.Panel1.Controls.Add(Me.txt_Registrarse)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GunaElipsePanel2)
        Me.Panel1.Controls.Add(Me.GunaElipsePanel1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 468)
        Me.Panel1.TabIndex = 8
        '
        'btn_Ingresar
        '
        Me.btn_Ingresar.AnimationHoverSpeed = 0.07!
        Me.btn_Ingresar.AnimationSpeed = 0.03!
        Me.btn_Ingresar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Ingresar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Ingresar.BorderColor = System.Drawing.Color.Black
        Me.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Ingresar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_Ingresar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Ingresar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ingresar.ForeColor = System.Drawing.Color.Black
        Me.btn_Ingresar.Image = Nothing
        Me.btn_Ingresar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_Ingresar.ImageSize = New System.Drawing.Size(37, 37)
        Me.btn_Ingresar.Location = New System.Drawing.Point(104, 307)
        Me.btn_Ingresar.Name = "btn_Ingresar"
        Me.btn_Ingresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Ingresar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Ingresar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_Ingresar.OnHoverImage = Nothing
        Me.btn_Ingresar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Ingresar.Radius = 8
        Me.btn_Ingresar.Size = New System.Drawing.Size(160, 42)
        Me.btn_Ingresar.TabIndex = 10
        Me.btn_Ingresar.Text = "Ingresar"
        Me.btn_Ingresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Registrarse
        '
        Me.txt_Registrarse.AnimationHoverSpeed = 0.07!
        Me.txt_Registrarse.AnimationSpeed = 0.03!
        Me.txt_Registrarse.BaseColor = System.Drawing.Color.Transparent
        Me.txt_Registrarse.BorderColor = System.Drawing.Color.Transparent
        Me.txt_Registrarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_Registrarse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.txt_Registrarse.FocusedColor = System.Drawing.Color.Empty
        Me.txt_Registrarse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_Registrarse.ForeColor = System.Drawing.Color.Black
        Me.txt_Registrarse.Image = Nothing
        Me.txt_Registrarse.ImageSize = New System.Drawing.Size(20, 20)
        Me.txt_Registrarse.Location = New System.Drawing.Point(104, 447)
        Me.txt_Registrarse.Name = "txt_Registrarse"
        Me.txt_Registrarse.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.txt_Registrarse.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.txt_Registrarse.OnHoverForeColor = System.Drawing.Color.White
        Me.txt_Registrarse.OnHoverImage = Nothing
        Me.txt_Registrarse.OnPressedColor = System.Drawing.Color.Transparent
        Me.txt_Registrarse.Size = New System.Drawing.Size(145, 21)
        Me.txt_Registrarse.TabIndex = 12
        Me.txt_Registrarse.Text = "Registrarse "
        Me.txt_Registrarse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(101, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ingrese su usuario y contraseña"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.txt_Contraseña)
        Me.GunaElipsePanel2.Controls.Add(Me.Label2)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(22, 237)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 10
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(314, 46)
        Me.GunaElipsePanel2.TabIndex = 9
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.txt_Usuario)
        Me.GunaElipsePanel1.Controls.Add(Me.Label1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(22, 164)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(314, 46)
        Me.GunaElipsePanel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(22, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 355)
        Me.Panel2.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(348, 468)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Contraseña As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btn_Ingresar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Registrarse As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
End Class
