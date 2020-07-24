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
        movePanel(clickType.FOOD)
    End Sub

    Private Sub drinkButton_Click(sender As Object, e As EventArgs) Handles drinkButton.Click
        drinkButton.Height = drinkButton.Height
        drinkButton.Top = drinkButton.Top
        foodPanel.Visible = False
        drinkPanel.Visible = True
        dessertPanel.Visible = False
        aboutPanel.Visible = False
        cartPanel.Visible = False
        movePanel(clickType.DRINK)
    End Sub

    Private Sub dessertButton_Click(sender As Object, e As EventArgs) Handles dessertButton.Click
        dessertButton.Height = dessertButton.Height
        dessertButton.Top = dessertButton.Top
        foodPanel.Visible = False
        drinkPanel.Visible = False
        dessertPanel.Visible = True
        aboutPanel.Visible = False
        cartPanel.Visible = False
        movePanel(clickType.DESSERT)
    End Sub

    Private Sub cartButton_Click(sender As Object, e As EventArgs) Handles cartButton.Click

        foodPanel.Visible = False
        drinkPanel.Visible = False
        dessertPanel.Visible = False
        aboutPanel.Visible = False
        cartPanel.Visible = True
        movePanel(clickType.CART)
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click

        foodPanel.Visible = False
        drinkPanel.Visible = False
        dessertPanel.Visible = False
        aboutPanel.Visible = True
        cartPanel.Visible = False
        movePanel(clickType.ABOUT)
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
        Dim y As Integer
        y = selectionPanel.Location.Y
        Select Case click
            'Could've done this as a returnable method but I'm trying 
            'to fight time, next week I can refactor this easily
            'reminder to self about this
            Case clickType.FOOD
                While (y >= 84)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y - 1
                End While
                While (y <= 84)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y + 1
                End While
            Case clickType.DRINK
                While (y >= 136)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y - 1
                End While
                While (y <= 136)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y + 1
                End While
            Case clickType.DESSERT
                While (y >= 188)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y - 1
                End While
                While (y <= 188)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y + 1
                End While

            Case clickType.CART
                While (y >= 240)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y - 1
                End While
                While (y <= 240)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y + 1
                End While
            Case clickType.ABOUT
                While (y >= 292)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y - 1
                End While
                While (y <= 292)
                    selectionPanel.SetBounds(0, y, 16, 42)
                    y = y + 1
                End While
        End Select

    End Function
End Class
