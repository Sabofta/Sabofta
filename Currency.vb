CURRENCY CONVERTER 
using visual basic programming language.
 how to create a Currency Converter using visual basic programming language. We have created a detailed step by step guide to help you create and debug a fully working currency converter app. This one will use a different GUI to achieve a similar result.
How to create a fully working currency tutorial in visual studio using visual basic
Enter custom currency conversion rates
Using double data type and click events
Using buttons, text boxes and labels
Using multiple Forms
Using Classes in visual basic
Following the complete code using Flow charts and Algorithms to enhance the understanding of code written
View in Full Screen
currency converter using Radio button
    Dim currency As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = currency * Convert.ToDouble(TextBox1.Text)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        currency = 1.29
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        currency = 95.75
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        currency = 1.42
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        currency = 160.11
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        currency = 1.9
    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        currency = 9.24
    End Sub
End Class
Full Code using IF in Currency Converter statement
currency converter if statement
    Dim currency As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then
            currency = 1.29
        End If
        If (RadioButton2.Checked = True) Then
            currency = 160.11
        End If
        If (RadioButton3.Checked = True) Then
            currency = 95.75
        EndIf
        If (RadioButton4.Checked = True) Then
            currency = 1.42
        End If
        If (RadioButton5.Checked = True) Then
            currency = 1.9
        End If
        If (RadioButton6.Checked = True) Then
            currency = 9.24
        End If
        Label1.Text = currency * Convert.ToDouble(TextBox1.Text)
