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

End Class
