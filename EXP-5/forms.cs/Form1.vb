Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btn00.Click, btnDot.Click, btnAdd.Click, btnSub.Click, btnMul.Click, btnD.Click, btnSin.Click, btnCos.Click, btnTan.Click, btnLog.Click, btnLn.Click, btnInv.Click, btnDeg.Click, btnPer.Click, btnpi.Click, btnsqrt.Click, btnEqual.Click, btnRad.Click, btnBack.Click, btn6.Click, btnAC.Click, btnBack.Click
        Dim button = CType(sender, Button)
        If button.Name = "btn1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
        If button.Name = "btn2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
        If button.Name <> "btn3" Then
        Else
            TextBox1.Text = TextBox1.Text + "3"
        End If
        If button.Name = "btn4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
        If button.Name = "btn5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
        If button.Name = "btn6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
        If button.Name = "btn7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
        If button.Name = "btn8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
        If button.Name = "btn9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If button.Name = "btn0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
        If button.Name = "btn00" Then
            TextBox1.Text = TextBox1.Text + "00"
        End If
        If button.Name = "btnAdd" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If
        If button.Name = "btnDot" Then
            TextBox1.Text = TextBox1.Text + "."
        End If
        If button.Name = "btnSub" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If
        If button.Name = "btnMul" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If
        If button.Name = "btnD" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If
        If button.Name = "btnAC" Then
            TextBox1.Text = ""
        End If
        If button.Name = "btnEqual" Then
            Dim str As String = TextBox1.Text
            Dim result = New DataTable().Compute(str, Nothing)
            TextBox1.Text = result
        End If
        If button.Name = "btnSin" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = Math.Sin(value * Math.PI / 180).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnCos" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = Math.Cos(value * Math.PI / 180).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnTan" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = Math.Tan(value * Math.PI / 180).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnLog" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = Math.Log10(value).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnln" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = Math.Log(value).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnSqrt" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = Math.Sqrt(value).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnRad" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = (value * Math.PI / 180).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnDeg" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = (value * 180 / Math.PI).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnpi" Then
            Try
                TextBox1.Text = Math.PI.ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnPer" Then
            Try
                Dim value = CDbl(TextBox1.Text)
                TextBox1.Text = (value / 100).ToString
            Catch ex As Exception
                TextBox1.Text = "Error"
            End Try
        End If
        If button.Name = "btnBack" Then
            If TextBox1.Text.Length > 0 Then
                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
            End If
        End If

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnD.Click

    End Sub

    Private Sub RoundButton1_Click_1(sender As Object, e As EventArgs) Handles btnpi.Click

    End Sub
End Class