Public Class Form1
    Private Declare Sub mouse_event Lib "user32" (ByVal dwflags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cbutton As Long, ByVal dwExtraInfo As Long)
    Private Const mouseclickup = 4
    Private Const mouseclickdown = 2
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Dim bmpIMG = New Bitmap(My.Resources.xdefault)
    Dim isReady As Boolean = False
    Dim isPos1 As Boolean = True
    Dim twoState1 As Boolean = False
    Dim twoState2 As Boolean = False
    Dim lienzoH As Int32 = 0
    Dim lienzoW As Int32 = 0
    Dim poslx As Int32 = 0
    Dim posly As Int32 = 0
    Dim poslx2 As Int32 = 0
    Dim posly2 As Int32 = 0
    Dim xDraw As Int32 = 0
    Dim yDraw As Int32 = 0
    Dim velDraw As Int32 = 1
    Dim pixelColor As Color

    'Windows.Forms.Cursor.Position = New Point(164, 269)
    'mouse_event(mouseclickdown, 0, 0, 0, 0)
    'mouse_event(mouseclickup, 0, 0, 0, 0)

    Private Sub imgpath_btn_Click(sender As Object, e As EventArgs) Handles imgpath_btn.Click
        If OpenFile.ShowDialog = DialogResult.OK Then
            imgpath_txt.Text = OpenFile.FileName
            bmpIMG = New Bitmap(OpenFile.FileName)
            total_lbl.Text = "L: " & lienzoW & " x " & lienzoH & " | " & bmpIMG.Width & " x " & bmpIMG.Height
            isReady = True
        Else isReady = False
        End If
    End Sub

    Private Sub pos1_btn_Click(sender As Object, e As EventArgs) Handles pos1_btn.Click
        If Not twoState1 Then
            isPos1 = True
            pos_timer.Start()
            twoState1 = True
        Else
            pos_timer.Stop()
            twoState1 = False
        End If
    End Sub

    Private Sub pos2_btn_Click(sender As Object, e As EventArgs) Handles pos2_btn.Click
        If Not twoState2 Then
            isPos1 = False
            pos_timer.Start()
            twoState2 = True
        Else
            pos_timer.Stop()
            twoState2 = False
        End If
    End Sub

    Private Sub pos_timer_Tick(sender As Object, e As EventArgs) Handles pos_timer.Tick
        If isPos1 Then
            pos1x_txt.Text = Cursor.Position.X
            pos1y_txt.Text = Cursor.Position.Y
            Int32.TryParse(pos1x_txt.Text, poslx)
            Int32.TryParse(pos1y_txt.Text, posly)
        Else
            pos2x_txt.Text = Cursor.Position.X
            pos2y_txt.Text = Cursor.Position.Y
            Int32.TryParse(pos2x_txt.Text, poslx2)
            Int32.TryParse(pos2y_txt.Text, posly2)
        End If
    End Sub

    Function abs(num As Int32) As Int32
        If num < 0 Then
            Return -num
        Else
            Return num
        End If
    End Function

    Private Sub pos1x_txt_TextChanged(sender As Object, e As EventArgs) Handles pos1x_txt.TextChanged

        lienzoW = abs(poslx - poslx2)
        lienzoH = abs(posly - posly2)
        total_lbl.Text = "L: " & lienzoW & " x " & lienzoH & " | " & bmpIMG.Width & " x " & bmpIMG.Height
    End Sub

    Private Sub pos1y_txt_TextChanged(sender As Object, e As EventArgs) Handles pos1y_txt.TextChanged
        lienzoW = abs(poslx - poslx2)
        lienzoH = abs(posly - posly2)
        total_lbl.Text = "L: " & lienzoW & " x " & lienzoH & " | " & bmpIMG.Width & " x " & bmpIMG.Height
    End Sub

    Private Sub pos2x_txt_TextChanged(sender As Object, e As EventArgs) Handles pos2x_txt.TextChanged
        lienzoW = abs(poslx - poslx2)
        lienzoH = abs(posly - posly2)
        total_lbl.Text = "L: " & lienzoW & " x " & lienzoH & " | " & bmpIMG.Width & " x " & bmpIMG.Height
    End Sub

    Private Sub pos2y_txt_TextChanged(sender As Object, e As EventArgs) Handles pos2y_txt.TextChanged
        lienzoW = abs(poslx - poslx2)
        lienzoH = abs(posly - posly2)
        total_lbl.Text = "L: " & lienzoW & " x " & lienzoH & " | " & bmpIMG.Width & " x " & bmpIMG.Height
    End Sub

    Private Sub imgpath_txt_TextChanged(sender As Object, e As EventArgs) Handles imgpath_txt.TextChanged
        total_lbl.Text = "L: " & lienzoW & " x " & lienzoH & " | " & bmpIMG.Width & " x " & bmpIMG.Height
    End Sub

    Private Sub empzr_btn_Click(sender As Object, e As EventArgs) Handles empzr_btn.Click
        If isReady AndAlso lienzoH > 0 AndAlso lienzoW > 0 AndAlso lienzoH >= bmpIMG.Height AndAlso lienzoW >= bmpIMG.Width Then
            'Clickamos una vez para asegurar
            Windows.Forms.Cursor.Position = New Point(poslx, posly)
            mouse_event(mouseclickdown, 0, 0, 0, 0)
            '----
            xDraw = 0
            yDraw = 0
            draw_timer.Interval = velDraw
            draw_timer.Start()


        Else
            MsgBox("Error! Revisa la configuración!")
        End If
    End Sub

    Private Sub draw_timer_Tick(sender As Object, e As EventArgs) Handles draw_timer.Tick

        For i As Int32 = 0 To 15
            Windows.Forms.Cursor.Position = New Point(poslx + xDraw, posly + yDraw)
            If yDraw < bmpIMG.Height Then
                pixelColor = bmpIMG.GetPixel(xDraw, yDraw)
            End If
            If pixelColor.GetBrightness = 0 Then
                Console.WriteLine("black")
                mouse_event(mouseclickdown, 0, 0, 0, 0)
                mouse_event(mouseclickup, 0, 0, 0, 0)
            End If

            xDraw = xDraw + 1
            If xDraw = bmpIMG.Width Then
                yDraw = yDraw + 1
                xDraw = 0
            End If
        Next

        If yDraw >= bmpIMG.Height Then
            draw_timer.Stop()
        End If

        If GetAsyncKeyState(Keys.Escape) Then
            pbar.Value = 0
            p_txt.Text = pbar.Value
            draw_timer.Stop()
        End If
    End Sub

    Private Sub vel_num_ValueChanged(sender As Object, e As EventArgs) Handles vel_num.ValueChanged
        velDraw = vel_num.Value
        draw_timer.Interval = velDraw
    End Sub

    Private Sub parar_btn_Click(sender As Object, e As EventArgs) Handles parar_btn.Click
        draw_timer.Stop()
        pbar.Value = 0
        p_txt.Text = pbar.Value
    End Sub
End Class
