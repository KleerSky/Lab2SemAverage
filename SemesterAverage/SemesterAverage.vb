
'
' Program: Semester Average
' Date: Feb 17, 2018
' Author: Benjamin Priebe - 100437762
' Description: This program accepts user input for 6 course grades
' and prints errors if the entry is not a number between 0 and 100.
' Calculates letter grade for the marks and prints.
' Once all six have been entered, calculates semester average and
' letter grade.
' Grade calculation is the sum of all divided by the number of objects. This is how you comment. 
'


Option Strict On    'turn on strict
Public Class frmSemesterAverage 'Namespace frmSemesterAverage

    Dim inputArray(5) As Double 'array of 6 as inputArray

    Dim userInputParsed As Double = 0.0 'used as returned double from parse

    Dim letterGrade As String = ""  'string to hold resulting letter grade
    Dim inputString As String = ""  'string to hold user input, whatever it may be

    Private Sub frmSemesterAverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load   'on form load

    End Sub 'end of form load

    Private Sub tbCourseOne_LostFocus(sender As Object, e As EventArgs) Handles tbCourseOne.LostFocus

        'inputString = tbCourseOne.Text

        'TextBoxCheck()
        '//////////////////////////
        inputString = tbCourseOne.Text  'Saves iput from first textbox to inputString

        Validation(inputString) 'passes inputString to Validation method

        If Validation(inputString) = True Then  'if valid ...

            GradeEvaluation(userInputParsed)    'send parsed (valid) input to GradeEvaluation method
            inputArray(0) = userInputParsed 'store valid input into array
            lbCourseOneLetter.Text = letterGrade    'set lettergrade label to letterGrade string from GradeEvaluation method
        Else                'if invalid ...
            lbOutput.Text &= vbCrLf & "Entry for Course 1 must be a number between 0 and 100" 'print error to label
            lbCourseOneLetter.Text = "Not Valid"    'print error in letterGrade label   
            '  tbCourseOne.Focus()
            tbCourseOne.SelectAll()     'select wrong text jh
        End If

    End Sub

    Private Sub tbCourseTwo_LostFocus(sender As Object, e As EventArgs) Handles tbCourseTwo.LostFocus

        'inputString = tbCourseTwo.Text

        'TextBoxCheck()         'THIS IS A CONCEPT FOR THE TEXTBOXCHECK METHOD - COMING SOON TO A LAPTOP NEAR YOU
        '//////////////////////////
        inputString = tbCourseTwo.Text  'save input to inputString

        Validation(inputString) 'send inputString to validation method

        If Validation(inputString) = True Then  'if valid ...

            GradeEvaluation(userInputParsed)    'send valid input to gradeevaluation method
            inputArray(1) = userInputParsed 'store to array
            lbCourseTwoLetter.Text = letterGrade    'print lettergrade to label
        Else    'if not valid ..
            lbOutput.Text &= vbCrLf & "Entry for Course 2 must be a number between 0 and 100"    'error message to output label
            lbCourseTwoLetter.Text = "ERROR"    'error in lettergrade label
            ' tbCourseTwo.Focus()
            tbCourseTwo.SelectAll() 'select wrong text

        End If
    End Sub

    Private Sub tbCourseThree_LostFocus(sender As Object, e As EventArgs) Handles tbCourseThree.LostFocus
        'inputString = tbCourseThree.Text
        'THIS IS A CONCEPT FOR THE TEXTBOXCHECK METHOD - COMING SOON TO A LAPTOP NEAR YOU
        'TextBoxCheck()
        '//////////////////////////
        inputString = tbCourseThree.Text    'save text to inputString
        Validation(inputString) 'pass value to validation method

        If Validation(inputString) = True Then  'if valid ...


            GradeEvaluation(userInputParsed)    'pass valid input to GradeEvaluation method
            inputArray(2) = userInputParsed     'store input to array
            lbCourseThreeLetter.Text = letterGrade  'set lettergrade result from gradeevaluation to lettergrade label
        Else    'if not valid
            lbOutput.Text &= vbCrLf & "Entry for Course 3 must be a number between 0 and 100"    'throw error to output label
            lbCourseThreeLetter.Text = "ERROR"  'print error in letergrade box
            tbCourseThree.SelectAll()   'select wrong text
            '    tbCourseThree.Focus()
        End If
    End Sub

    Private Sub tbCourseFour_LostFocus(sender As Object, e As EventArgs) Handles tbCourseFour.LostFocus

        'inputString = tbCourseFour.Text
        'THIS IS A CONCEPT FOR THE TEXTBOXCHECK METHOD - COMING SOON TO A LAPTOP NEAR YOU
        'TextBoxCheck()
        '//////////////////////////
        inputString = tbCourseFour.Text 'save input to inputstring

        Validation(inputString) 'check if inputstring valid with validtion method, return inputStringDouble

        If Validation(inputString) = True Then  'if valid ...

            GradeEvaluation(userInputParsed)    'pass valid input to GradeEvaluation method, returning letterGrade
            inputArray(3) = userInputParsed 'save to array
            lbCourseFourLetter.Text = letterGrade   'print letterGrade to label
        Else    'if not valid
            lbOutput.Text &= vbCrLf & "Entry for Course 4 must be a number between 0 and 100"    'throw error to output label
            lbCourseFourLetter.Text = "ERROR"   'print error in letterGrade label
            tbCourseFour.SelectAll()    'select offending text
            '  tbCourseFour.Focus()
        End If
    End Sub

    Private Sub tbCourseFive_LostFocus(sender As Object, e As EventArgs) Handles tbCourseFive.LostFocus

        'inputString = tbCourseFive.Text
        'THIS IS A CONCEPT FOR THE TEXTBOXCHECK METHOD - COMING SOON TO A LAPTOP NEAR YOU
        'TextBoxCheck()
        '//////////////////////////
        inputString = tbCourseFive.Text 'save input to inputString variable

        Validation(inputString) 'pass inputString to Validation

        If Validation(inputString) = True Then  'if valid ...

            GradeEvaluation(userInputParsed)    'pass valid input to GradeEvaluation method
            inputArray(4) = userInputParsed     'save to array
            lbCourseFiveLetter.Text = letterGrade   'print letterGrade to label
        Else    'if not valid ...
            lbOutput.Text &= vbNewLine & "Entry for Course 5 must be a number between 0 and 100" + vbCrLf   'throw error to output label
            lbCourseFiveLetter.Text = "ERROR"   'print error to letterGrade label
            tbCourseFive.SelectAll()    'select offending text
            '  tbCourseFive.Focus()
        End If
    End Sub

    Private Sub tbCourseSix_LostFocus(sender As Object, e As EventArgs) Handles tbCourseSix.LostFocus


        'inputString = tbCourseSix.Text
        'THIS IS A CONCEPT FOR THE TEXTBOXCHECK METHOD - COMING SOON TO A LAPTOP NEAR YOU
        'TextBoxCheck()
        '//////////////////////////
        inputString = tbCourseSix.Text  'save input to inputString variable

        Validation(inputString) 'send inputString to Validation method, return userInputParsed

        If Validation(inputString) = True Then  'if valid ...

            GradeEvaluation(userInputParsed)    'pass valid input to grade eval method, returning letterGrade
            inputArray(5) = userInputParsed 'save to array
            lbCourseSixLetter.Text = letterGrade    'print letterGrade to label

        Else    'if not valid ..
            lbOutput.Text &= vbCrLf & "Entry for Course 6 must be a number between 0 and 100" + vbCrLf   'print error to output label
            lbCourseSixLetter.Text = "ERROR"    'print error to letterGrade label
            tbCourseSix.SelectAll() 'select offending text
            ' tbCourseSix.Focus()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim semesterAverage As Double = 0   'semesterAverage as double, used to determine final average for semester
        Dim sum As Double = 0   'sum used to add up inputs
        For element As Integer = 0 To 5 'for 6 elements, 0, 1, 2, 3, 4, 5..
            sum += inputArray(element)  'add respective value of array at element to sum variable
        Next element    'go to next element ..

        semesterAverage = sum / (inputArray.Length) 'average is the result of sum divided by total elements in array

        semesterAverage = Math.Round(semesterAverage, 2)    'round average
        lbSemesterNumeric.Text = Convert.ToString(semesterAverage)  'convert semesterAverage to string, print to label

        GradeEvaluation(semesterAverage)    'send average to grade evaluation method, returning lettergrade

        lbSemesterLetter.Text = letterGrade 'print lettergrade to label


        tbCourseOne.Enabled = False 'disable text boxes ..
        tbCourseTwo.Enabled = False 'disable
        tbCourseThree.Enabled = False   'disable
        tbCourseFour.Enabled = False    'disable
        tbCourseFive.Enabled = False    'disable
        tbCourseSix.Enabled = False 'disable
        btnCalculate.Enabled = False    'disable

        btnReset.Focus()    'rocus on reset button

    End Sub



    Public Sub GradeEvaluation(ByRef userInputParsed As Double)

        Select Case userInputParsed 'check userInputParsed value against ,,,
            Case 0 To 49.99     '0 to 49.99
                letterGrade = "F"   'set letterGrade value to "F"
            Case 50 To 52.99    '0 to 52.99
                letterGrade = "D-"  'D-
            Case 53 To 56.99    '53 to 56.99
                letterGrade = "D"   'd
            Case 57 To 59.99    '57 to 59.99
                letterGrade = "D+"  'd+
            Case 60 To 62.99    '60 to 62.99
                letterGrade = "C-"  'c-
            Case 63 To 66.99    '63 to 66.99
                letterGrade = "C"   'c
            Case 67 To 69.99    'between
                letterGrade = "C+"  'c+
            Case 70 To 72.99    'between    
                letterGrade = "B-"  'b-
            Case 73 To 76.99    'between
                letterGrade = "B"   'b
            Case 77 To 79.99    'between
                letterGrade = "B+"  'b+
            Case 80 To 84.99    '80 to 84.99
                letterGrade = "A-"  'a-
            Case 85 To 89.99    '85 to 89.99
                letterGrade = "A"   'a
            Case 90 To 100  '90 to 100
                letterGrade = "A+"  'a+
                'Case Else
                '   letterGrade = "N/A"


                'end of select statement
        End Select




    End Sub



    Private Function Validation(ByVal inputString As String) As Boolean  'validation method
        Const inputLowerLimit As Integer = 0    'constant of lower limit, 0
        Const inputUpperLimit As Integer = 100  'constant of upper limit, 0
        Dim isValid As Boolean = False

        If Not (Double.TryParse(inputString, userInputParsed)) Then 'As isValid 'if it doesnt parse..

            isValid = False 'set bool to false

        ElseIf (userInputParsed < inputLowerLimit Or userInputParsed >= inputUpperLimit) Then   'otherwise if valid input is outside of range ..

            isValid = False 'set bool to false


        Else    'otherwise - if it IS valid

            isValid = True  'set bool to true
            'index = index + 1
            GradeEvaluation(userInputParsed)    'pass valid input to GradeEvaluation method

            'end if
        End If

        Return isValid

    End Function

    Private Sub ResetMethod()

        tbCourseOne.Text = ""   'blank textbox, disable textbox, and blank label
        tbCourseOne.Enabled = True    'blank textbox, disable textbox, and blank label
        lbCourseOneLetter.Text = String.Empty  'blank textbox, disable textbox, and blank label

        tbCourseTwo.Text = ""  'blank textbox, disable textbox, and blank label
        tbCourseTwo.Enabled = True  'blank textbox, disable textbox, and blank label
        lbCourseTwoLetter.Text = String.Empty  'blank textbox, disable textbox, and blank label

        tbCourseThree.Text = ""  'blank textbox, disable textbox, and blank label
        tbCourseThree.Enabled = True  'blank textbox, disable textbox, and blank label
        lbCourseThreeLetter.Text = String.Empty  'blank textbox, disable textbox, and blank label

        tbCourseFour.Text = ""  'blank textbox, disable textbox, and blank label
        tbCourseFour.Enabled = True  'blank textbox, disable textbox, and blank label
        lbCourseFourLetter.Text = String.Empty  'blank textbox, disable textbox, and blank label

        tbCourseFive.Text = ""  'blank textbox, disable textbox, and blank label
        tbCourseFive.Enabled = True  'blank textbox, disable textbox, and blank label
        lbCourseFiveLetter.Text = String.Empty  'blank textbox, disable textbox, and blank label

        tbCourseSix.Text = ""  'blank textbox, disable textbox, and blank label
        tbCourseSix.Enabled = True  'blank textbox, disable textbox, and blank label
        lbCourseSixLetter.Text = String.Empty  'blank textbox, disable textbox, and blank label

        lbSemesterLetter.Text = ""  'blank semester label
        lbSemesterNumeric.Text = String.Empty   'blank semester numeric label
        'blank semester label

        tbCourseOne.Focus() 'set focus to first input box

        lbOutput.Text = ""  'blank output label

        For element As Integer = 0 To 5 'for each element in the array .. 0, 1, 2, 3, 4
            inputArray(element) = 0 'save the value as 0
        Next element    'go to next element ..

        btnCalculate.Enabled = True 'enable calculate button again

        'For index As Integer = 0 To Array.Length - 1    'Instructions inside
        '    'loop through array by the index, using the 7th element (6)
        '    Array(index) = 0 'and set each to zero
        'Next index  'Go to next index, loop again
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()  'close the form

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ResetMethod()   'run reset method

    End Sub
End Class

