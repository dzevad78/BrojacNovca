Imports System.ComponentModel

Public Class Form1
    Inherits Form

    Private dvjesta As Double
    Private sto As Double
    Private pedeset As Double
    Private dvadeset As Double
    Private deset As Double
    Private pet As Double
    Private dva As Double
    Private jedan As Double
    Private polamarke As Double
    Private dvadesetfeninga As Double
    Private desetfeninga As Double
    Private petfeninga As Double
    Private rezultat As Double
    Private components As IContainer

    Public Sub New()
        Me.Load += New EventHandler(AddressOf Me.Form1_Load)
        Me.InitializeComponent()
    End Sub

    Private Sub txbSto_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not (Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then Return
        e.Handled = True
    End Sub

    Private Sub txbDvjesta_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbSto.Focus()
    End Sub

    Private Sub txbSto_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbPedeset.Focus()
    End Sub

    Private Sub txbPedeset_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbDvadeset.Focus()
    End Sub

    Private Sub txbDvadeset_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbDeset.Focus()
    End Sub

    Private Sub txbDeset_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbPet.Focus()
    End Sub

    Private Sub txbPet_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbDva.Focus()
    End Sub

    Private Sub txbDva_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbJednaMarka.Focus()
    End Sub

    Private Sub txbJednaMarka_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbPolaMarke.Focus()
    End Sub

    Private Sub txbPolaMarke_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbDvadesetPfeninga.Focus()
    End Sub

    Private Sub txbDvadesetPfeninga_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbDesetPfeninga.Focus()
    End Sub

    Private Sub txbDesetPfeninga_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.txbPetPfeninga.Focus()
    End Sub

    Private Sub txbPetPfeninga_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.[Return] Then Return
        Me.Button2.PerformClick()
    End Sub

    Private Sub txbPetPfeninga_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbDesetPfeninga.Focus()
    End Sub

    Private Sub txbDesetPfeninga_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbDvadesetPfeninga.Focus()
    End Sub

    Private Sub txbDvadesetPfeninga_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbPolaMarke.Focus()
    End Sub

    Private Sub txbPolaMarke_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbJednaMarka.Focus()
    End Sub

    Private Sub txbJednaMarka_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbDva.Focus()
    End Sub

    Private Sub txbDva_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbPet.Focus()
    End Sub

    Private Sub txbPet_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbDeset.Focus()
    End Sub

    Private Sub txbDeset_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbDvadeset.Focus()
    End Sub

    Private Sub txbDvadeset_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbPedeset.Focus()
    End Sub

    Private Sub txbPedeset_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbSto.Focus()
    End Sub

    Private Sub txbSto_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode <> Keys.Up Then Return
        Me.txbDvjesta.Focus()
    End Sub

    Private Sub txbDvjesta_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not (Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then Return
        e.Handled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.KeyPreview = True
        Me.txbDvjesta.Text = Conversions.ToString(0)
        Me.txbSto.Text = Conversions.ToString(0)
        Me.txbPedeset.Text = Conversions.ToString(0)
        Me.txbDvadeset.Text = Conversions.ToString(0)
        Me.txbDeset.Text = Conversions.ToString(0)
        Me.txbPet.Text = Conversions.ToString(0)
        Me.txbDva.Text = Conversions.ToString(0)
        Me.txbJednaMarka.Text = Conversions.ToString(0)
        Me.txbPolaMarke.Text = Conversions.ToString(0)
        Me.txbDvadesetPfeninga.Text = Conversions.ToString(0)
        Me.txbDesetPfeninga.Text = Conversions.ToString(0)
        Me.txbPetPfeninga.Text = Conversions.ToString(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.txbDvjesta.Text = Conversions.ToString(0)
        Me.txbSto.Text = Conversions.ToString(0)
        Me.txbPedeset.Text = Conversions.ToString(0)
        Me.txbDvadeset.Text = Conversions.ToString(0)
        Me.txbDeset.Text = Conversions.ToString(0)
        Me.txbPet.Text = Conversions.ToString(0)
        Me.txbDva.Text = Conversions.ToString(0)
        Me.txbJednaMarka.Text = Conversions.ToString(0)
        Me.txbPolaMarke.Text = Conversions.ToString(0)
        Me.txbDvadesetPfeninga.Text = Conversions.ToString(0)
        Me.txbDesetPfeninga.Text = Conversions.ToString(0)
        Me.txbPetPfeninga.Text = Conversions.ToString(0)
        Me.dvjesta = Conversions.ToDouble(Me.txbDvjesta.Text) * 200.0
        Me.sto = Conversions.ToDouble(Me.txbSto.Text) * 100.0
        Me.pedeset = Conversions.ToDouble(Me.txbPedeset.Text) * 50.0
        Me.dvadeset = Conversions.ToDouble(Me.txbDvadeset.Text) * 20.0
        Me.deset = Conversions.ToDouble(Me.txbDeset.Text) * 10.0
        Me.pet = Conversions.ToDouble(Me.txbPet.Text) * 5.0
        Me.dva = Conversions.ToDouble(Me.txbDva.Text) * 2.0
        Me.jedan = Conversions.ToDouble(Me.txbJednaMarka.Text) * 1.0
        Me.polamarke = Conversions.ToDouble(Me.txbPolaMarke.Text) * 0.5
        Me.dvadesetfeninga = Conversions.ToDouble(Me.txbDvadesetPfeninga.Text) * 0.2
        Me.desetfeninga = Conversions.ToDouble(Me.txbDesetPfeninga.Text) * 0.1
        Me.petfeninga = Conversions.ToDouble(Me.txbPetPfeninga.Text) * 0.05
        Me.rezultat = Me.dvjesta + Me.sto + Me.pedeset + Me.dvadeset + Me.deset + Me.pet + Me.dva + Me.jedan + Me.polamarke + Me.dvadesetfeninga + Me.desetfeninga + Me.petfeninga
        Me.lblUkupno.Text = Strings.Format(CObj(Me.rezultat), "Currency")
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Operators.CompareString(Me.txbDvjesta.Text, "", False) = 0 Then
            Dim num1 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbSto.Text, "", False) = 0 Then
            Dim num2 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbPedeset.Text, "", False) = 0 Then
            Dim num3 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbDvadeset.Text, "", False) = 0 Then
            Dim num4 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbDeset.Text, "", False) = 0 Then
            Dim num5 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbPet.Text, "", False) = 0 Then
            Dim num6 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbDva.Text, "", False) = 0 Then
            Dim num7 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbJednaMarka.Text, "", False) = 0 Then
            Dim num8 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbPolaMarke.Text, "", False) = 0 Then
            Dim num9 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbDvadesetPfeninga.Text, "", False) = 0 Then
            Dim num10 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbDesetPfeninga.Text, "", False) = 0 Then
            Dim num11 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        If Operators.CompareString(Me.txbPetPfeninga.Text, "", False) = 0 Then
            Dim num12 As Integer = CInt(MessageBox.Show("Polje ne može biti prazno !"))
        End If

        Me.dvjesta = Conversions.ToDouble(Me.txbDvjesta.Text) * 200.0
        Me.sto = Conversions.ToDouble(Me.txbSto.Text) * 100.0
        Me.pedeset = Conversions.ToDouble(Me.txbPedeset.Text) * 50.0
        Me.dvadeset = Conversions.ToDouble(Me.txbDvadeset.Text) * 20.0
        Me.deset = Conversions.ToDouble(Me.txbDeset.Text) * 10.0
        Me.pet = Conversions.ToDouble(Me.txbPet.Text) * 5.0
        Me.dva = Conversions.ToDouble(Me.txbDva.Text) * 2.0
        Me.jedan = Conversions.ToDouble(Me.txbJednaMarka.Text) * 1.0
        Me.polamarke = Conversions.ToDouble(Me.txbPolaMarke.Text) * 0.5
        Me.dvadesetfeninga = Conversions.ToDouble(Me.txbDvadesetPfeninga.Text) * 0.2
        Me.desetfeninga = Conversions.ToDouble(Me.txbDesetPfeninga.Text) * 0.1
        Me.petfeninga = Conversions.ToDouble(Me.txbPetPfeninga.Text) * 0.05
        Me.rezultat = Me.dvjesta + Me.sto + Me.pedeset + Me.dvadeset + Me.deset + Me.pet + Me.dva + Me.jedan + Me.polamarke + Me.dvadesetfeninga + Me.desetfeninga + Me.petfeninga
        Me.lblUkupno.Text = Strings.Format(CObj(Me.rezultat), "Currency")
    End Sub
End Class
