Public Class Form1
    '   Copyright Morc 17
    '   Uses very simple number generator for LOOOOVE Test
    '   Nothing really hard....

    Dim lo = New Random
    Dim res = lo.Next(100)
    Dim counter As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter = 0
        Label1.Text = 0
        res = lo.Next(100)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter + 1
        Label1.Text = counter.ToString + "%"
        If counter = res Then
            Timer1.Stop()
        End If
    End Sub
End Class
