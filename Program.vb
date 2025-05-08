Imports System.Windows.Forms
Imports System.Drawing

Module Program
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub
End Module

Public Class MainForm
    Inherits Form

    Private txtWeight As TextBox
    Private txtHeight As TextBox
    Private lblResult As Label

    Public Sub New()

        Me.Text = "BMI Calculator"
        Me.Size = New Size(350, 320)
        Me.BackColor = Color.LightBlue
        Me.Font = New Font("Century Gothic", 10)


        Dim lblWeight As New Label()
        lblWeight.Text = "Weight (kg):"
        lblWeight.Location = New Point(30, 30)
        Me.Controls.Add(lblWeight)

        txtWeight = New TextBox()
        txtWeight.Location = New Point(150, 30)
        txtWeight.Width = 150
        txtWeight.BackColor = Color.White
        Me.Controls.Add(txtWeight)


        Dim lblHeight As New Label()
        lblHeight.Text = "Height (m):"
        lblHeight.Location = New Point(30, 70)
        Me.Controls.Add(lblHeight)

        txtHeight = New TextBox()
        txtHeight.Location = New Point(150, 70)
        txtHeight.Width = 150
        txtHeight.BackColor = Color.White
        Me.Controls.Add(txtHeight)


        Dim btnCalculate As New Button()
        btnCalculate.Text = "Calculate BMI"
        btnCalculate.Location = New Point(30, 120)
        btnCalculate.Size = New Size(130, 35)
        btnCalculate.BackColor = Color.LightGreen
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        AddHandler btnCalculate.Click, AddressOf CalculateBMI
        Me.Controls.Add(btnCalculate)


        Dim btnReset As New Button()
        btnReset.Text = "Reset"
        btnReset.Location = New Point(170, 120)
        btnReset.Size = New Size(130, 35)
        btnReset.BackColor = Color.LightCoral
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Century Gothic", 10, FontStyle.Bold)
        AddHandler btnReset.Click, AddressOf ResetFields
        Me.Controls.Add(btnReset)

        lblResult = New Label()
        lblResult.Location = New Point(30, 170)
        lblResult.Size = New Size(270, 100)
        lblResult.BackColor = Color.White
        lblResult.BorderStyle = BorderStyle.FixedSingle
        lblResult.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblResult)
    End Sub

    Private Sub CalculateBMI(sender As Object, e As EventArgs)
        Try
            Dim weight As Double = Double.Parse(txtWeight.Text)
            Dim height As Double = Double.Parse(txtHeight.Text)
            

            If height > 3 Then
                height = height / 100
            End If
            
            Dim bmi As Double = weight / (height * height)

            Dim status As String = If(bmi < 18.5, "Underweight",
                                  If(bmi < 25, "Normal weight",
                                  If(bmi < 30, "Overweight", "Obese")))

            lblResult.Text = $"BMI: {bmi:F2}" & Environment.NewLine & $"Status: {status}"
        Catch ex As Exception
            lblResult.Text = "Error: Please enter valid numbers!"
        End Try
    End Sub

    Private Sub ResetFields(sender As Object, e As EventArgs)
        txtWeight.Text = ""
        txtHeight.Text = ""
        lblResult.Text = ""
    End Sub
End Class