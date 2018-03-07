<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.lblCourseTwo = New System.Windows.Forms.Label()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lbCourseOneLetter = New System.Windows.Forms.Label()
        Me.lbCourseTwoLetter = New System.Windows.Forms.Label()
        Me.lbCourseThreeLetter = New System.Windows.Forms.Label()
        Me.lbCourseFourLetter = New System.Windows.Forms.Label()
        Me.lbCourseFiveLetter = New System.Windows.Forms.Label()
        Me.lbCourseSixLetter = New System.Windows.Forms.Label()
        Me.lbSemesterLetter = New System.Windows.Forms.Label()
        Me.lbSemesterNumeric = New System.Windows.Forms.Label()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.tbCourseOne = New System.Windows.Forms.TextBox()
        Me.tbCourseTwo = New System.Windows.Forms.TextBox()
        Me.tbCourseThree = New System.Windows.Forms.TextBox()
        Me.tbCourseFour = New System.Windows.Forms.TextBox()
        Me.tbCourseFive = New System.Windows.Forms.TextBox()
        Me.tbCourseSix = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCourseOne
        '
        Me.lblCourseOne.AutoSize = True
        Me.lblCourseOne.Location = New System.Drawing.Point(13, 23)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course 1:"
        Me.lblCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseTwo
        '
        Me.lblCourseTwo.AutoSize = True
        Me.lblCourseTwo.Location = New System.Drawing.Point(13, 65)
        Me.lblCourseTwo.Name = "lblCourseTwo"
        Me.lblCourseTwo.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseTwo.TabIndex = 3
        Me.lblCourseTwo.Text = "Course 2:"
        Me.lblCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseThree
        '
        Me.lblCourseThree.AutoSize = True
        Me.lblCourseThree.Location = New System.Drawing.Point(13, 100)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseThree.TabIndex = 6
        Me.lblCourseThree.Text = "Course 3:"
        Me.lblCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFour
        '
        Me.lblCourseFour.AutoSize = True
        Me.lblCourseFour.Location = New System.Drawing.Point(13, 135)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseFour.TabIndex = 9
        Me.lblCourseFour.Text = "Course 4:"
        Me.lblCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFive
        '
        Me.lblCourseFive.AutoSize = True
        Me.lblCourseFive.Location = New System.Drawing.Point(13, 170)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseFive.TabIndex = 12
        Me.lblCourseFive.Text = "Course 5:"
        Me.lblCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseSix
        '
        Me.lblCourseSix.AutoSize = True
        Me.lblCourseSix.Location = New System.Drawing.Point(13, 205)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(69, 17)
        Me.lblCourseSix.TabIndex = 15
        Me.lblCourseSix.Text = "Course 6:"
        Me.lblCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(13, 246)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(72, 17)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseOneLetter
        '
        Me.lbCourseOneLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseOneLetter.Location = New System.Drawing.Point(251, 23)
        Me.lbCourseOneLetter.Name = "lbCourseOneLetter"
        Me.lbCourseOneLetter.Size = New System.Drawing.Size(127, 17)
        Me.lbCourseOneLetter.TabIndex = 2
        Me.lbCourseOneLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourseTwoLetter
        '
        Me.lbCourseTwoLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseTwoLetter.Location = New System.Drawing.Point(251, 65)
        Me.lbCourseTwoLetter.Name = "lbCourseTwoLetter"
        Me.lbCourseTwoLetter.Size = New System.Drawing.Size(127, 17)
        Me.lbCourseTwoLetter.TabIndex = 5
        Me.lbCourseTwoLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourseThreeLetter
        '
        Me.lbCourseThreeLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseThreeLetter.Location = New System.Drawing.Point(251, 99)
        Me.lbCourseThreeLetter.Name = "lbCourseThreeLetter"
        Me.lbCourseThreeLetter.Size = New System.Drawing.Size(127, 17)
        Me.lbCourseThreeLetter.TabIndex = 8
        Me.lbCourseThreeLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourseFourLetter
        '
        Me.lbCourseFourLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseFourLetter.Location = New System.Drawing.Point(251, 135)
        Me.lbCourseFourLetter.Name = "lbCourseFourLetter"
        Me.lbCourseFourLetter.Size = New System.Drawing.Size(127, 17)
        Me.lbCourseFourLetter.TabIndex = 11
        Me.lbCourseFourLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourseFiveLetter
        '
        Me.lbCourseFiveLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseFiveLetter.Location = New System.Drawing.Point(251, 173)
        Me.lbCourseFiveLetter.Name = "lbCourseFiveLetter"
        Me.lbCourseFiveLetter.Size = New System.Drawing.Size(127, 17)
        Me.lbCourseFiveLetter.TabIndex = 14
        Me.lbCourseFiveLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCourseSixLetter
        '
        Me.lbCourseSixLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseSixLetter.Location = New System.Drawing.Point(251, 205)
        Me.lbCourseSixLetter.Name = "lbCourseSixLetter"
        Me.lbCourseSixLetter.Size = New System.Drawing.Size(127, 17)
        Me.lbCourseSixLetter.TabIndex = 17
        Me.lbCourseSixLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSemesterLetter
        '
        Me.lbSemesterLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterLetter.Location = New System.Drawing.Point(251, 246)
        Me.lbSemesterLetter.Name = "lbSemesterLetter"
        Me.lbSemesterLetter.Size = New System.Drawing.Size(127, 17)
        Me.lbSemesterLetter.TabIndex = 20
        Me.lbSemesterLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSemesterNumeric
        '
        Me.lbSemesterNumeric.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterNumeric.Location = New System.Drawing.Point(127, 246)
        Me.lbSemesterNumeric.Name = "lbSemesterNumeric"
        Me.lbSemesterNumeric.Size = New System.Drawing.Size(100, 17)
        Me.lbSemesterNumeric.TabIndex = 19
        '
        'lbOutput
        '
        Me.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput.Location = New System.Drawing.Point(12, 286)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(374, 181)
        Me.lbOutput.TabIndex = 21
        '
        'tbCourseOne
        '
        Me.tbCourseOne.Location = New System.Drawing.Point(127, 20)
        Me.tbCourseOne.Name = "tbCourseOne"
        Me.tbCourseOne.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseOne.TabIndex = 1
        Me.tbCourseOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourseTwo
        '
        Me.tbCourseTwo.Location = New System.Drawing.Point(127, 62)
        Me.tbCourseTwo.Name = "tbCourseTwo"
        Me.tbCourseTwo.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseTwo.TabIndex = 4
        Me.tbCourseTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourseThree
        '
        Me.tbCourseThree.Location = New System.Drawing.Point(127, 99)
        Me.tbCourseThree.Name = "tbCourseThree"
        Me.tbCourseThree.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseThree.TabIndex = 7
        Me.tbCourseThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourseFour
        '
        Me.tbCourseFour.Location = New System.Drawing.Point(127, 132)
        Me.tbCourseFour.Name = "tbCourseFour"
        Me.tbCourseFour.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseFour.TabIndex = 10
        Me.tbCourseFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourseFive
        '
        Me.tbCourseFive.Location = New System.Drawing.Point(127, 167)
        Me.tbCourseFive.Name = "tbCourseFive"
        Me.tbCourseFive.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseFive.TabIndex = 13
        Me.tbCourseFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbCourseSix
        '
        Me.tbCourseSix.Location = New System.Drawing.Point(127, 202)
        Me.tbCourseSix.Name = "tbCourseSix"
        Me.tbCourseSix.Size = New System.Drawing.Size(100, 22)
        Me.tbCourseSix.TabIndex = 16
        Me.tbCourseSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalculate.Location = New System.Drawing.Point(24, 480)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(82, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(160, 480)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(296, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(398, 515)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbCourseSix)
        Me.Controls.Add(Me.tbCourseFive)
        Me.Controls.Add(Me.tbCourseFour)
        Me.Controls.Add(Me.tbCourseThree)
        Me.Controls.Add(Me.tbCourseTwo)
        Me.Controls.Add(Me.tbCourseOne)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.lbSemesterNumeric)
        Me.Controls.Add(Me.lbSemesterLetter)
        Me.Controls.Add(Me.lbCourseSixLetter)
        Me.Controls.Add(Me.lbCourseFiveLetter)
        Me.Controls.Add(Me.lbCourseFourLetter)
        Me.Controls.Add(Me.lbCourseThreeLetter)
        Me.Controls.Add(Me.lbCourseTwoLetter)
        Me.Controls.Add(Me.lbCourseOneLetter)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.lblCourseTwo)
        Me.Controls.Add(Me.lblCourseOne)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourseOne As Label
    Friend WithEvents lblCourseTwo As Label
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lbCourseOneLetter As Label
    Friend WithEvents lbCourseTwoLetter As Label
    Friend WithEvents lbCourseThreeLetter As Label
    Friend WithEvents lbCourseFourLetter As Label
    Friend WithEvents lbCourseFiveLetter As Label
    Friend WithEvents lbCourseSixLetter As Label
    Friend WithEvents lbSemesterLetter As Label
    Friend WithEvents lbSemesterNumeric As Label
    Friend WithEvents lbOutput As Label
    Friend WithEvents tbCourseOne As TextBox
    Friend WithEvents tbCourseTwo As TextBox
    Friend WithEvents tbCourseThree As TextBox
    Friend WithEvents tbCourseFour As TextBox
    Friend WithEvents tbCourseFive As TextBox
    Friend WithEvents tbCourseSix As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
