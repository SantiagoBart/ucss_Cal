<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.lblMen = New System.Windows.Forms.Label()
        Me.btnPromedio = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtProm = New System.Windows.Forms.TextBox()
        Me.txtExF = New System.Windows.Forms.TextBox()
        Me.txtEP3 = New System.Windows.Forms.TextBox()
        Me.txtEP2 = New System.Windows.Forms.TextBox()
        Me.txtEP1 = New System.Windows.Forms.TextBox()
        Me.txtContinuas = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnContinuas = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.txtNumCont = New System.Windows.Forms.TextBox()
        Me.txtContinua2 = New System.Windows.Forms.TextBox()
        Me.txtContinua3 = New System.Windows.Forms.TextBox()
        Me.txtContinua4 = New System.Windows.Forms.TextBox()
        Me.txtContinua8 = New System.Windows.Forms.TextBox()
        Me.txtContinua7 = New System.Windows.Forms.TextBox()
        Me.txtContinua6 = New System.Windows.Forms.TextBox()
        Me.txtContinua5 = New System.Windows.Forms.TextBox()
        Me.txtContinua1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Silver
        Me.Label24.Location = New System.Drawing.Point(20, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 13)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "2013100403"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UCSS_Calculator.My.Resources.Resources.cree
        Me.PictureBox1.Location = New System.Drawing.Point(280, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora UCSS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 82)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(380, 170)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblRes)
        Me.TabPage1.Controls.Add(Me.lblMen)
        Me.TabPage1.Controls.Add(Me.btnPromedio)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnCalcular)
        Me.TabPage1.Controls.Add(Me.txtProm)
        Me.TabPage1.Controls.Add(Me.txtExF)
        Me.TabPage1.Controls.Add(Me.txtEP3)
        Me.TabPage1.Controls.Add(Me.txtEP2)
        Me.TabPage1.Controls.Add(Me.txtEP1)
        Me.TabPage1.Controls.Add(Me.txtContinuas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(372, 144)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Promedio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblRes.Location = New System.Drawing.Point(304, 64)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(0, 26)
        Me.lblRes.TabIndex = 21
        Me.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMen
        '
        Me.lblMen.AutoSize = True
        Me.lblMen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMen.Location = New System.Drawing.Point(266, 28)
        Me.lblMen.Name = "lblMen"
        Me.lblMen.Size = New System.Drawing.Size(0, 24)
        Me.lblMen.TabIndex = 20
        Me.lblMen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPromedio
        '
        Me.btnPromedio.AutoSize = True
        Me.btnPromedio.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnPromedio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPromedio.Location = New System.Drawing.Point(323, 109)
        Me.btnPromedio.Name = "btnPromedio"
        Me.btnPromedio.Size = New System.Drawing.Size(44, 30)
        Me.btnPromedio.TabIndex = 19
        Me.btnPromedio.Text = ""
        Me.btnPromedio.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(190, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "30%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(108, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "20%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(149, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "20%"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(67, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "10%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(220, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "P F"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "20%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(179, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Ex F"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(138, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "EP 3"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(97, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "EP 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(56, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "EP 1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(15, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "EC"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "* Ingrese aqui sus notas de examenes"
        '
        'btnCalcular
        '
        Me.btnCalcular.AutoSize = True
        Me.btnCalcular.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnCalcular.Location = New System.Drawing.Point(276, 108)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(44, 30)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = ""
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtProm
        '
        Me.txtProm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProm.Location = New System.Drawing.Point(223, 61)
        Me.txtProm.MaxLength = 5
        Me.txtProm.Name = "txtProm"
        Me.txtProm.ReadOnly = True
        Me.txtProm.Size = New System.Drawing.Size(35, 22)
        Me.txtProm.TabIndex = 5
        Me.txtProm.Text = "0"
        Me.txtProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExF
        '
        Me.txtExF.Location = New System.Drawing.Point(182, 61)
        Me.txtExF.MaxLength = 5
        Me.txtExF.Name = "txtExF"
        Me.txtExF.Size = New System.Drawing.Size(35, 20)
        Me.txtExF.TabIndex = 4
        Me.txtExF.Text = "0"
        Me.txtExF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEP3
        '
        Me.txtEP3.Location = New System.Drawing.Point(141, 61)
        Me.txtEP3.MaxLength = 5
        Me.txtEP3.Name = "txtEP3"
        Me.txtEP3.Size = New System.Drawing.Size(35, 20)
        Me.txtEP3.TabIndex = 3
        Me.txtEP3.Text = "0"
        Me.txtEP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEP2
        '
        Me.txtEP2.Location = New System.Drawing.Point(100, 61)
        Me.txtEP2.MaxLength = 5
        Me.txtEP2.Name = "txtEP2"
        Me.txtEP2.Size = New System.Drawing.Size(35, 20)
        Me.txtEP2.TabIndex = 2
        Me.txtEP2.Text = "0"
        Me.txtEP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEP1
        '
        Me.txtEP1.Location = New System.Drawing.Point(59, 61)
        Me.txtEP1.MaxLength = 5
        Me.txtEP1.Name = "txtEP1"
        Me.txtEP1.Size = New System.Drawing.Size(35, 20)
        Me.txtEP1.TabIndex = 1
        Me.txtEP1.Text = "0"
        Me.txtEP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinuas
        '
        Me.txtContinuas.Location = New System.Drawing.Point(18, 61)
        Me.txtContinuas.MaxLength = 5
        Me.txtContinuas.Name = "txtContinuas"
        Me.txtContinuas.Size = New System.Drawing.Size(35, 20)
        Me.txtContinuas.TabIndex = 0
        Me.txtContinuas.Text = "0"
        Me.txtContinuas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnContinuas)
        Me.TabPage2.Controls.Add(Me.btnMenos)
        Me.TabPage2.Controls.Add(Me.btnMas)
        Me.TabPage2.Controls.Add(Me.txtNumCont)
        Me.TabPage2.Controls.Add(Me.txtContinua2)
        Me.TabPage2.Controls.Add(Me.txtContinua3)
        Me.TabPage2.Controls.Add(Me.txtContinua4)
        Me.TabPage2.Controls.Add(Me.txtContinua8)
        Me.TabPage2.Controls.Add(Me.txtContinua7)
        Me.TabPage2.Controls.Add(Me.txtContinua6)
        Me.TabPage2.Controls.Add(Me.txtContinua5)
        Me.TabPage2.Controls.Add(Me.txtContinua1)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(372, 144)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ev. Continuas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnContinuas
        '
        Me.btnContinuas.AutoSize = True
        Me.btnContinuas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnContinuas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinuas.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnContinuas.Location = New System.Drawing.Point(291, 104)
        Me.btnContinuas.Name = "btnContinuas"
        Me.btnContinuas.Size = New System.Drawing.Size(35, 29)
        Me.btnContinuas.TabIndex = 29
        Me.btnContinuas.Text = ""
        Me.btnContinuas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContinuas.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.AutoSize = True
        Me.btnMenos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnMenos.Location = New System.Drawing.Point(236, 29)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(35, 23)
        Me.btnMenos.TabIndex = 28
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnMas
        '
        Me.btnMas.AutoSize = True
        Me.btnMas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnMas.Location = New System.Drawing.Point(201, 29)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(35, 23)
        Me.btnMas.TabIndex = 27
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'txtNumCont
        '
        Me.txtNumCont.Location = New System.Drawing.Point(140, 29)
        Me.txtNumCont.MaxLength = 1
        Me.txtNumCont.Name = "txtNumCont"
        Me.txtNumCont.Size = New System.Drawing.Size(30, 20)
        Me.txtNumCont.TabIndex = 26
        Me.txtNumCont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua2
        '
        Me.txtContinua2.Location = New System.Drawing.Point(51, 76)
        Me.txtContinua2.Name = "txtContinua2"
        Me.txtContinua2.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua2.TabIndex = 25
        Me.txtContinua2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua3
        '
        Me.txtContinua3.Location = New System.Drawing.Point(91, 76)
        Me.txtContinua3.Name = "txtContinua3"
        Me.txtContinua3.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua3.TabIndex = 24
        Me.txtContinua3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua4
        '
        Me.txtContinua4.Location = New System.Drawing.Point(131, 76)
        Me.txtContinua4.Name = "txtContinua4"
        Me.txtContinua4.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua4.TabIndex = 23
        Me.txtContinua4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua8
        '
        Me.txtContinua8.Location = New System.Drawing.Point(291, 76)
        Me.txtContinua8.Name = "txtContinua8"
        Me.txtContinua8.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua8.TabIndex = 22
        Me.txtContinua8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua7
        '
        Me.txtContinua7.Location = New System.Drawing.Point(251, 76)
        Me.txtContinua7.Name = "txtContinua7"
        Me.txtContinua7.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua7.TabIndex = 21
        Me.txtContinua7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua6
        '
        Me.txtContinua6.Location = New System.Drawing.Point(211, 76)
        Me.txtContinua6.Name = "txtContinua6"
        Me.txtContinua6.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua6.TabIndex = 20
        Me.txtContinua6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua5
        '
        Me.txtContinua5.Location = New System.Drawing.Point(171, 76)
        Me.txtContinua5.Name = "txtContinua5"
        Me.txtContinua5.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua5.TabIndex = 19
        Me.txtContinua5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContinua1
        '
        Me.txtContinua1.Location = New System.Drawing.Point(11, 76)
        Me.txtContinua1.Name = "txtContinua1"
        Me.txtContinua1.Size = New System.Drawing.Size(30, 20)
        Me.txtContinua1.TabIndex = 18
        Me.txtContinua1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(48, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 15)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "EC2"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(88, 57)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 15)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "EC3"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(128, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 15)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "EC4"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(288, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 15)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "EC8"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(248, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 15)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "EC7"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(208, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 15)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "EC6"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(168, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "EC5"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(8, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 15)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "EC1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Número de Evauaciones:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(206, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "* Ingrese aqui sus evaluaciones continuas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UCSS_Calculator.My.Resources.Resources.Sin_título
        Me.PictureBox2.Location = New System.Drawing.Point(329, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 256)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UCSS Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtProm As TextBox
    Friend WithEvents txtExF As TextBox
    Friend WithEvents txtEP3 As TextBox
    Friend WithEvents txtEP2 As TextBox
    Friend WithEvents txtEP1 As TextBox
    Friend WithEvents txtContinuas As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblRes As Label
    Friend WithEvents lblMen As Label
    Friend WithEvents btnPromedio As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnContinuas As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMas As Button
    Friend WithEvents txtNumCont As TextBox
    Friend WithEvents txtContinua2 As TextBox
    Friend WithEvents txtContinua3 As TextBox
    Friend WithEvents txtContinua4 As TextBox
    Friend WithEvents txtContinua8 As TextBox
    Friend WithEvents txtContinua7 As TextBox
    Friend WithEvents txtContinua6 As TextBox
    Friend WithEvents txtContinua5 As TextBox
    Friend WithEvents txtContinua1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label24 As Label
End Class
