Public Class Form1
    Dim result As Double
    Dim input As String = ""
    Dim operatorPressed As Boolean

    ' Form Load event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Simple Calculator"
        ' Enable form to capture key presses
        Me.KeyPreview = True
    End Sub

    ' Form KeyDown event to handle keyboard input
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D0, Keys.NumPad0
                btnNumber_Click(btn0, Nothing)
            Case Keys.D1, Keys.NumPad1
                btnNumber_Click(btn1, Nothing)
            Case Keys.D2, Keys.NumPad2
                btnNumber_Click(btn2, Nothing)
            Case Keys.D3, Keys.NumPad3
                btnNumber_Click(btn3, Nothing)
            Case Keys.D4, Keys.NumPad4
                btnNumber_Click(btn4, Nothing)
            Case Keys.D5, Keys.NumPad5
                btnNumber_Click(btn5, Nothing)
            Case Keys.D6, Keys.NumPad6
                btnNumber_Click(btn6, Nothing)
            Case Keys.D7, Keys.NumPad7
                btnNumber_Click(btn7, Nothing)
            Case Keys.D8, Keys.NumPad8
                btnNumber_Click(btn8, Nothing)
            Case Keys.D9, Keys.NumPad9
                btnNumber_Click(btn9, Nothing)
            Case Keys.Add, Keys.Oemplus
                btnOperation_Click(btnAdd, Nothing)
            Case Keys.Subtract, Keys.OemMinus
                btnOperation_Click(btnSubtract, Nothing)
            Case Keys.Multiply
                btnOperation_Click(btnMultiply, Nothing)
            Case Keys.Divide, Keys.OemQuestion
                btnOperation_Click(btnDivide, Nothing)
            Case Keys.Enter
                btnEquals_Click(btnEquals, Nothing)
            Case Keys.Delete, Keys.Back
                btnClear_Click(btnClear, Nothing)
        End Select
    End Sub

    ' Number button click event
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) _
        Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click,
                btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If operatorPressed Then
            txtDisplay.Text += " " + DirectCast(sender, Button).Text
        Else
            txtDisplay.Text += DirectCast(sender, Button).Text
        End If
        input += DirectCast(sender, Button).Text
        operatorPressed = False
    End Sub

    ' Operation button click event
    Private Sub btnOperation_Click(sender As Object, e As EventArgs) _
        Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        txtDisplay.Text += " " + DirectCast(sender, Button).Text + " "
        input += " " + DirectCast(sender, Button).Text + " "
        operatorPressed = True
    End Sub

    ' Equals button click event with division by zero check
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Try
            If input.Contains("/ 0") Then
                txtDisplay.Text = "Error: Can't divide by Zero"
                input = ""
            Else
                result = EvaluateExpression(input)
                txtDisplay.Text = result.ToString()
                input = result.ToString()
            End If
        Catch ex As Exception
            txtDisplay.Text = "Error"
            input = ""
        End Try
        operatorPressed = False
    End Sub

    ' Clear button click event
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
        input = ""
        result = 0
        operatorPressed = False
    End Sub

    ' Evaluate the mathematical expression
    Private Function EvaluateExpression(expression As String) As Double
        Dim table As New DataTable()
        Return Convert.ToDouble(table.Compute(expression, String.Empty))
    End Function
End Class
