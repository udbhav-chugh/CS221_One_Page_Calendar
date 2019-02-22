Public Class Form_Main_Calendar
    'Made year and monInt public property as required in other forms as well
    Public Property year As Integer = System.DateTime.Now.Year 'year stores current year
    Public Property monInt As Integer = 1 ' monInt stores current month

    'Function returns remainder corresponding to day of input date(0 ->sunday , 1->monday and so on)
    'Used Tomohiko Sakamoto’s Algorithm - calculates remainder based on number of leap years from the beginning
    Public Function dayNum(ByVal day As Integer, ByVal month As Integer, ByVal year As Integer) As Integer

        Dim code() As Integer = {0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4} 'predefined code used in the algorithm
        Dim a, b, c As Integer
        If month < 3 Then
            year = year - 1
        End If

        Dim tem, remain As Integer ' remain generates final remainder corresponing to day of the week
        a = year \ 4
        b = year \ 100
        c = year \ 400
        'a-b+c will give total leap years
        tem = (year + a - b + c + code(month - 1) + day)
        remain = tem Mod 7
        Return remain

    End Function

    'function to return number of days in a particular month(takes care of leap years as well)
    Public Function numberOfDays(ByVal month As Integer, ByVal year As Integer) As Integer
        If month = 1 Or month = 3 Or month = 5 Or month = 7 Or month = 8 Or month = 10 Or month = 12 Then 'Jan,Mar,May,July,Aug,Oct,Dec
            Return 31
        End If
        If month = 4 Or month = 6 Or month = 9 Or month = 11 Then 'April,June,September,November
            Return 30
        End If
        If year Mod 400 = 0 Or (year Mod 4 = 0 And year Mod 100 <> 0) Then 'February
            Return 29
        End If
        Return 28
    End Function

    'Function to print calendar of a particular month
    'takes in month number as num, year, button where the text needs to be added and tempstr stores the month name
    Private Function printMonth(ByVal num As Integer, ByVal year As Integer, ByRef outp As String, ByVal tempstr As String)
        Dim start, nn As Integer

        start = dayNum(1, num, year) 'start contains day of first of month num
        nn = numberOfDays(num, year) 'nn contains number of days in month num
        outp = tempstr 'intialsie first line with month name
        outp = outp & vbLf & "S   M   T    W   T    F    S   " & vbLf

        'following 20 lines to adjust start spacing for every month before the starting date
        Dim i As Integer
        For i = 1 To start
            outp = outp & "     "
        Next
        If start = 2 Or start = 1 Then
            outp = outp & " "
        End If
        If start = 3 Then
            outp = outp & "  "
        End If
        If start = 4 Then
            outp = outp & "   "
        End If
        If start = 5 Then
            outp = outp & "    "
        End If
        If start = 6 Then
            outp = outp & "     "
        End If

        'to print dates from 1 to days in the particular month
        For i = 1 To nn
            outp = outp & i & "  "
            If i < 10 Then
                outp = outp & "  "
            End If
            start = start + 1
            If start Mod 7 = 0 Then
                outp = outp & vbLf
            End If

        Next
    End Function


    'Main form function -takes month and year input and displays corresponding month and year calendar
    'option of grid view to view calendar in grid form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set default drop down value as January
        If Combo_Month_Select.Items.Count > 0 Then
            Combo_Month_Select.SelectedIndex = 0    ' The first item has index 0 '
        End If
        Dim Tyear As Integer = System.DateTime.Now.Year
        Btn_Main_title.Text = "Welcome To Calendar " & CStr(Tyear)
        'print call for all months of current year(set as default year)
        printMonth(1, Tyear, Btn_Jan.Text, "               January")
        printMonth(2, Tyear, Btn_Feb.Text, "               February")
        printMonth(3, Tyear, Btn_Mar.Text, "                March")
        printMonth(4, Tyear, Btn_Apr.Text, "                April")
        printMonth(5, Tyear, But_May.Text, "                  May")
        printMonth(6, Tyear, But_Jun.Text, "                 June")
        printMonth(7, Tyear, But_Jul.Text, "                 July")
        printMonth(8, Tyear, But_Aug.Text, "               August")
        printMonth(9, Tyear, But_Sep.Text, "             September")
        printMonth(10, Tyear, But_Oct.Text, "             October")
        printMonth(11, Tyear, But_Nov.Text, "             November")
        printMonth(12, Tyear, But_Dec.Text, "             December")
    End Sub

    'returns daycode for each month(January->1,February->2, and so on)
    'takes parameter i denoting month name
    Private Function daycode(ByVal i As String) As Integer
        If i = "January" Then
            Return 1
        ElseIf i = "February" Then
            Return 2
        ElseIf i = "March" Then
            Return 3
        ElseIf i = "April" Then
            Return 4
        ElseIf i = "May" Then
            Return 5
        ElseIf i = "June" Then
            Return 6
        ElseIf i = "July" Then
            Return 7
        ElseIf i = "August" Then
            Return 8
        ElseIf i = "September" Then
            Return 9
        ElseIf i = "October" Then
            Return 10
        ElseIf i = "November" Then
            Return 11
        ElseIf i = "December" Then
            Return 12
        End If
        Return -1
    End Function

    'Button to display month calendar where month is chosen from the drop down
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Btn_Month_calendar.Click
        
        Dim dayC As Integer 'stores month number for each month
        dayC = daycode(Combo_Month_Select.Text) 'daycode gets month number corresponding to month input by user
        'error handling in next 2 lines
        If dayC = -1 Then
            MessageBox.Show("Sorry! Invalid Input. Please choose an option from the drop down menu")
        Else
            monInt = dayC
            Form_Month_Calendar.Show() 'call to month calander form

        End If

    End Sub
    'Reads text input and generates calender for corresponding year
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Btn_Year_Calendar.Click
        Dim yearstr, yearstr2 As String
        'Use the next line if want to take input using input box
        'yearstr2 = InputBox("Enter Year (between 1583 and 99999) ", "Calandar Input", CStr(System.DateTime.Now.Year), , )

        yearstr2 = TextBox_Year_Input.Text 'reads text input given by user
        yearstr = Trim(yearstr2) 'removes extra spaces from beginning and the end
        'error handling-next 6 lines
        If IsNumeric(yearstr) = 0 Then 'check for input being numeric else display error
            MessageBox.Show("Sorry! Invalid Input. Try any year between 1583 and 99999 without any white spaces")
            TextBox_Year_Input.Text = year
        ElseIf yearstr.Contains(".") Then
            MessageBox.Show("Sorry! Invalid Input. Try any year between 1583 and 99999 without any white spaces")
            TextBox_Year_Input.Text = year
        ElseIf yearstr < 1583 Or yearstr > 99999 Then 'check for year inrange of limits
            MessageBox.Show("Sorry! Invalid Input. Try any year between 1583 and 99999 without any white spaces")
            TextBox_Year_Input.Text = year
        Else
            'print call for all months of corresponding year
            year = yearstr
            Btn_Main_title.Text = "Welcome To Calendar " & CStr(year)
            printMonth(1, year, Btn_Jan.Text, "               January")
            printMonth(2, year, Btn_Feb.Text, "               February")
            printMonth(3, year, Btn_Mar.Text, "                March")
            printMonth(4, year, Btn_Apr.Text, "                April")
            printMonth(5, year, But_May.Text, "                  May")
            printMonth(6, year, But_Jun.Text, "                 June")
            printMonth(7, year, But_Jul.Text, "                 July")
            printMonth(8, year, But_Aug.Text, "               August")
            printMonth(9, year, But_Sep.Text, "             September")
            printMonth(10, year, But_Oct.Text, "             October")
            printMonth(11, year, But_Nov.Text, "             November")
            printMonth(12, year, But_Dec.Text, "             December")
        End If
    End Sub

    'Button for grid view. Form2 contains grid View code
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Btn_Grid_View.Click
        Form_Grid_View.Show()
    End Sub
    
    'Exit button-to exit software
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub


    'next 12 buttons add additional functionality of viewing month by clicking on any month button-next 60 lines
    'All buttons call month_calendar with corresponding month . Form 3 prints individual month
    'Each button updates month number and calls month calendar for that particular month
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Jan.Click
        monInt = 1
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Feb.Click
        monInt = 2
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Mar.Click
        monInt = 3
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Apr.Click
        monInt = 4
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles But_May.Click
        monInt = 5
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles But_Jun.Click
        monInt = 6
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles But_Jul.Click
        monInt = 7
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles But_Aug.Click
        monInt = 8
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles But_Sep.Click
        monInt = 9
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles But_Oct.Click
        monInt = 10
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles But_Nov.Click
        monInt = 11
        Form_Month_Calendar.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles But_Dec.Click
        monInt = 12
        Form_Month_Calendar.Show()
    End Sub

    'Help icon to navigate to user Documentation
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Help_User.Click
        System.Diagnostics.Process.Start("https://drive.google.com/file/d/18okRbNwS_l82lgvwNlf6aZzNoKyOzYYv/view?usp=sharing")
    End Sub
    'End of form 1(Main Calendar page
End Class
