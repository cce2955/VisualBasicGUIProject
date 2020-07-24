Public Class mainForm

    Private Enum clickType
        FOOD
        DRINK
        DESSERT
        ABOUT
        CART
    End Enum
    Private clickEnum As clickType

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles foodButton.Click
        panelOnButton.Height = foodButton.Height
        panelOnButton.Top = foodButton.Top
        foodPanel.Visible = True
        drinkPanel.Visible = False
        dessertPanel.Visible = False
        aboutPanel.Visible = False
        cartPanel.Visible = False

        selectionPanel.AutoScroll = True
        clickEnum = clickType.FOOD
        movePanel(clickEnum)


    End Sub

    Private Sub drinkButton_Click(sender As Object, e As EventArgs) Handles drinkButton.Click
        drinkButton.Height = drinkButton.Height
        drinkButton.Top = drinkButton.Top
        foodPanel.Visible = False
        drinkPanel.Visible = True
        dessertPanel.Visible = False
        aboutPanel.Visible = False
        cartPanel.Visible = False
        clickEnum = clickType.DRINK
        movePanel(clickEnum)
    End Sub

    Private Sub dessertButton_Click(sender As Object, e As EventArgs) Handles dessertButton.Click
        dessertButton.Height = dessertButton.Height
        dessertButton.Top = dessertButton.Top
        foodPanel.Visible = False
        drinkPanel.Visible = False
        dessertPanel.Visible = True
        aboutPanel.Visible = False
        cartPanel.Visible = False
        clickEnum = clickType.DESSERT
        movePanel(clickEnum)
    End Sub

    Private Sub cartButton_Click(sender As Object, e As EventArgs) Handles cartButton.Click
        cartPanel.Height = cartButton.Height
        cartPanel.Top = cartButton.Top
        foodPanel.Visible = False
        drinkPanel.Visible = False
        dessertPanel.Visible = False
        aboutPanel.Visible = False
        cartPanel.Visible = True
        clickEnum = clickType.CART
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        aboutPanel.Height = aboutButton.Height
        aboutPanel.Top = aboutButton.Top
        foodPanel.Visible = True
        drinkPanel.Visible = False
        dessertPanel.Visible = False
        aboutPanel.Visible = False
        cartPanel.Visible = False
        clickEnum = clickType.ABOUT
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()
    End Sub

    Private Sub maxButton_Click(sender As Object, e As EventArgs) Handles maxButton.Click
        Me.WindowState = WindowState.Maximized
    End Sub

    Private Sub minButton_Click(sender As Object, e As EventArgs) Handles minButton.Click
        Me.WindowState = WindowState.Minimized

    End Sub



    Private Function movePanel(click As clickType)
        selectionPanel.BringToFront()
        Select Case clickEnum
            Case clickType.FOOD
                selectionPanel.SetBounds(0, 84, 16, 42)
            Case clickType.DRINK
                selectionPanel.SetBounds(0, 136, 16, 42)
            Case clickType.DESSERT
                selectionPanel.SetBounds(1, 1, 16, 42)
        End Select
    End Function



End Class
