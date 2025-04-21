'Alexis Villagran
'RCET
'Spring 2025

Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
	Sub SetDefaults()
		NameTextBox.Text = ""
		AddressTextBox.Text = ""
		CityTextBox.Text = ""
		StateTextBox.Text = ""
		ZipCodeTextBox.Text = ""
		BeginOdometerTextBox.Text = ""
		EndOdometerTextBox.Text = ""
		DaysTextBox.Text = ""
		TotalMilesTextBox.Text = ""
		MileageChargeTextBox.Text = ""
		DayChargeTextBox.Text = ""
		TotalDiscountTextBox.Text = ""
		TotalChargeTextBox.Text = ""
		AAAcheckbox.Checked = False
		Seniorcheckbox.Checked = False
		MilesradioButton.Checked = True
		NameTextBox.Focus()
	End Sub
	Function InputsAreValid() As Boolean
		Dim message As String = ""
		Dim valid As Boolean = True

		If NameTextBox.Text = "" Then
			message += "Customer Name is required." & vbCrLf
			valid = False
		End If
		If AddressTextBox.Text = "" Then
			message += "Address is required." & vbCrLf
			valid = False
		End If
		If CityTextBox.Text = "" Then
			message += "City is required." & vbCrLf
			valid = False
		End If
		If StateTextBox.Text = "" Then
			message += "State is required." & vbCrLf
			valid = False
		End If
		If ZipCodeTextBox.Text = "" Then
			message += "Zip Code is required." & vbCrLf
			valid = False
		End If

		Dim beginOdometer As Double
		If Not Double.TryParse(BeginOdometerTextBox.Text, beginOdometer) Then
			message += "Must be a number." & vbCrLf
			valid = False
		End If

		Dim endOdometer As Double
		If Not Double.TryParse(EndOdometerTextBox.Text, endOdometer) Then
			message += "Must be a number." & vbCrLf
			valid = False
		End If

		If valid AndAlso beginOdometer >= endOdometer Then
			message += "Beginning Odometer must be less than Ending Odometer." & vbCrLf
			valid = False
		End If

		Dim days As Integer
		If Not Integer.TryParse(DaysTextBox.Text, days) Then
			message += "Number of Days must be a whole number." & vbCrLf
			valid = False
		ElseIf days <= 0 OrElse days > 45 Then
			message += "Number of Days must be between 1 and 45." & vbCrLf
			valid = False
		End If

		If Not valid Then
			MsgBox(message)
		End If

		Return valid
	End Function


End Class
