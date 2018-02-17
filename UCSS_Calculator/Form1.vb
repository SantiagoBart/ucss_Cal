Public Class Form1
    Dim c As Integer = 1
    Dim t As New ArrayList()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        vacioP()
        Dim ec, ep1, ep2, ep3, exF, prom As Double
        ec = Double.Parse(txtContinuas.Text())
        ep1 = Double.Parse(txtEP1.Text())
        ep2 = Double.Parse(txtEP2.Text())
        ep3 = Double.Parse(txtEP3.Text())
        exF = Double.Parse(txtExF.Text())
        prom = 0.2 * ec + 0.1 * ep1 + 0.2 * ep2 + 0.2 * ep3 + 0.3 * exF
        txtProm.Text = prom
        FormatoProm("s")
    End Sub
    Private Sub FormatoProm(m As Char)
        Dim p As Double
        p = Double.Parse(txtProm.Text())
        If m = "s" Then
            If p < 10.5 Then
                lblMen.Text = "You Lose!"
                lblRes.Text = ""
                lblRes.ForeColor = Color.Red
                lblMen.ForeColor = Color.Red
                txtProm.ForeColor = Color.Red
                txtExF.ForeColor = Color.Black
            Else
                lblMen.Text = "You Win!"
                lblRes.Text = ""
                lblRes.ForeColor = Color.Black
                lblMen.ForeColor = Color.Black
                txtProm.ForeColor = Color.Black
                txtExF.ForeColor = Color.Black
            End If
        ElseIf m = "n"
            If p < 10.5 Then
                lblMen.Text = "You Lose!!"
                lblRes.Text = ""
                lblRes.ForeColor = Color.Red
                lblMen.ForeColor = Color.Red
                txtProm.ForeColor = Color.Green
                txtExF.ForeColor = Color.Blue
            Else
                lblMen.Text = "You Win!!"
                lblRes.Text = ""
                lblRes.ForeColor = Color.Gold
                lblMen.ForeColor = Color.Gold
                txtProm.ForeColor = Color.Green
                txtExF.ForeColor = Color.Blue
            End If
        End If


    End Sub

    Private Sub vacioP()

        If txtContinuas.Text().Equals("") Then
            txtContinuas.Text() = 0
        Else
            If Double.Parse(txtContinuas.Text()) > 20 Then
                txtContinuas.Text() = 0
            End If
        End If
        If txtEP1.Text().Equals("") Then
            txtEP1.Text() = 0
        Else
            If Double.Parse(txtEP1.Text()) > 20 Then
                txtEP1.Text() = 0
            End If
        End If
        If txtEP2.Text().Equals("") Then
            txtEP2.Text() = 0
        Else
            If Double.Parse(txtEP2.Text()) > 20 Then
                txtEP2.Text() = 0
            End If
        End If
        If txtEP3.Text().Equals("") Then
            txtEP3.Text() = 0
        Else
            If Double.Parse(txtEP3.Text()) > 20 Then
                txtEP3.Text() = 0
            End If
        End If
        If txtExF.Text().Equals("") Then
            txtExF.Text() = 0
        Else
            If Double.Parse(txtExF.Text()) > 20 Then
                txtExF.Text() = 0
            End If
        End If

    End Sub

    Private Sub txtContinuas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinuas.KeyPress
        validar(txtContinuas, e)
        If Asc(e.KeyChar) = 13 Then
            txtEP1.Focus()
        End If
    End Sub

    Private Sub txtEP1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEP1.KeyPress
        validar(txtEP1, e)
        If Asc(e.KeyChar) = 13 Then
            txtEP2.Focus()
        End If
    End Sub

    Private Sub txtEP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEP2.KeyPress
        validar(txtEP2, e)
        If Asc(e.KeyChar) = 13 Then
            txtEP3.Focus()
        End If
    End Sub

    Private Sub txtEP3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEP3.KeyPress
        validar(txtEP3, e)
        If Asc(e.KeyChar) = 13 Then
            txtExF.Focus()
        End If
    End Sub

    Private Sub txtExF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExF.KeyPress
        validar(txtExF, e)
        If Asc(e.KeyChar) = 13 Then
            txtContinuas.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumCont.Text = c
        txtNumCont.ReadOnly = True
        t.Add(txtContinua1)
        t.Add(txtContinua2)
        t.Add(txtContinua3)
        t.Add(txtContinua4)
        t.Add(txtContinua5)
        t.Add(txtContinua6)
        t.Add(txtContinua7)
        t.Add(txtContinua8)
        txtContinua2.Enabled = vbFalse
        txtContinua3.Enabled = False
        txtContinua4.Enabled = False
        txtContinua5.Enabled = False
        txtContinua6.Enabled = False
        txtContinua7.Enabled = False
        txtContinua8.Enabled = False

    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        If c = 8 Then
            c = 8
        Else
            c = c + 1
        End If
        txtNumCont.Text = c
        Continuas(c)
    End Sub


    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        If c = 1 Then
            c = 1
        Else
            c = c - 1
        End If
        txtNumCont.Text = c
        Continuas(c)
    End Sub
    Private Sub Continuas(x As Integer)
        Dim tex As TextBox
        Dim y As Integer = 0
        While y < 8
            If y < x Then
                tex = t.Item(y)
                tex.Enabled = True
            Else
                tex = t.Item(y)
                tex.Enabled = False
            End If
            y += 1
        End While

    End Sub

    Private Sub btnContinuas_Click(sender As Object, e As EventArgs) Handles btnContinuas.Click
        promCont()
    End Sub
    Private Sub promCont()
        Dim tex As TextBox
        Dim x As Integer = 0
        Dim c As Integer = 0
        Dim p As Double = 0
        Dim res As String = ""
        For index = 0 To t.Count() - 1
            tex = t.Item(index)
            If tex.Enabled = True Then
                res = tex.Text()
                If res = "" Then
                    tex.Text = 0
                End If
                c = c + 1
                p = p + Double.Parse(tex.Text())
            End If
        Next
        txtContinuas.Text = p / c
    End Sub
    Private Sub txtContinua1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua1.KeyPress
        validar(txtContinua1, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua2.Enabled = True Then
                txtContinua2.Focus()
            Else
                txtContinua1.Focus()
            End If
        End If
    End Sub

    Private Sub txtContinua2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua2.KeyPress
        validar(txtContinua2, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua3.Enabled = True Then
                txtContinua3.Focus()
            Else
                txtContinua2.Focus()
            End If
        End If
    End Sub

    Private Sub txtContinua3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua3.KeyPress
        validar(txtContinua3, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua4.Enabled = True Then
                txtContinua4.Focus()
            Else
                txtContinua3.Focus()
            End If
        End If
    End Sub

    Private Sub txtContinua4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua4.KeyPress
        validar(txtContinua4, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua5.Enabled = True Then
                txtContinua5.Focus()
            Else
                txtContinua4.Focus()
            End If
        End If
    End Sub

    Private Sub txtContinua5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua5.KeyPress
        validar(txtContinua5, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua6.Enabled = True Then
                txtContinua6.Focus()
            Else
                txtContinua5.Focus()
            End If
        End If
    End Sub

    Private Sub txtContinua6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua6.KeyPress
        validar(txtContinua6, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua7.Enabled = True Then
                txtContinua7.Focus()
            Else
                txtContinua6.Focus()
            End If
        End If
    End Sub

    Private Sub txtContinua7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua7.KeyPress
        validar(txtContinua7, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua8.Enabled = True Then
                txtContinua8.Focus()
            Else
                txtContinua7.Focus()
            End If
        End If
    End Sub

    Private Sub txtContinua8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContinua8.KeyPress
        validar(txtContinua8, e)
        If Asc(e.KeyChar) = 13 Then
            If txtContinua1.Enabled = True Then
                txtContinua1.Focus()
            Else
                txtContinua8.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPromedio.Click
        vacioP()
        Dim ec, ep1, ep2, ep3, exF, prom As Double
        Dim aux As Double = 0
        Dim x As Double

        ec = Double.Parse(txtContinuas.Text())
        ep1 = Double.Parse(txtEP1.Text())
        ep2 = Double.Parse(txtEP2.Text())
        ep3 = Double.Parse(txtEP3.Text())
        exF = Double.Parse(txtExF.Text())
        prom = 0
        x = 0
        While prom < 10.5 And aux <= 20
            x = aux
            aux += 1
            prom = ec * 0.2 + ep1 * 0.1 + ep2 * 0.2 + ep3 * 0.2 + x * 0.3
        End While
        txtExF.Text = x
        txtProm.Text = prom
        FormatoProm("n")
    End Sub
    Private Sub validar(ByVal tex As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not tex.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
