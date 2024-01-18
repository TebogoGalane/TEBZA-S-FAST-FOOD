Public Class Form2
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        pnlonbuttonmenu.Height = menu.Height
        pnlonbuttonmenu.Top = menu.Top
        pnlmenu.Visible = True
        pnlbilling.Visible = False
    End Sub

    Private Sub Billing_Click(sender As Object, e As EventArgs) Handles Billing.Click
        pnlonbuttonbilling.Height = Billing.Height
        pnlonbuttonbilling.Top = Billing.Top
        pnlmenu.Visible = True
        pnlbilling.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mealprice, drinksprice, desertprice As Integer
        mealprice = Val(TextBox1.Text)
        drinksprice = Val(TextBox2.Text)
        desertprice = Val(TextBox3.Text)

        sum(mealprice, drinksprice, desertprice)

    End Sub
    Sub sum(a As Integer, b As Integer, c As Integer)
        Dim total As Integer

        total = a + b + c
        TextBox4.Text = total
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub
End Class