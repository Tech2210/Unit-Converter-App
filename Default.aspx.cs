using System;
using System.Collections.Generic;

namespace UnitConverterApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlFromUnit.Items.Clear();
                ddlToUnit.Items.Clear();
            }
        }

        protected void ddlConversionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = ddlConversionType.SelectedValue;
            ddlFromUnit.Items.Clear();
            ddlToUnit.Items.Clear();

            List<string> units = new List<string>();

            switch (type)
            {
                case "Length":
                    units.AddRange(new[] { "Meter", "Kilometer", "Mile", "Foot" });
                    break;
                case "Weight":
                    units.AddRange(new[] { "Kilogram", "Gram", "Pound", "Ounce" });
                    break;
                case "Temperature":
                    units.AddRange(new[] { "Celsius", "Fahrenheit", "Kelvin" });
                    break;
            }

            foreach (var unit in units)
            {
                ddlFromUnit.Items.Add(unit);
                ddlToUnit.Items.Add(unit);
            }
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            double input;
            if (!double.TryParse(txtInputValue.Text, out input))
            {
                lblResult.Text = "Please enter a valid number.";
                return;
            }

            string fromUnit = ddlFromUnit.SelectedValue;
            string toUnit = ddlToUnit.SelectedValue;
            string type = ddlConversionType.SelectedValue;

            double result = 0;

            try
            {
                result = ConvertUnits(type, input, fromUnit, toUnit);
                lblResult.Text = $"{input} {fromUnit} = {result:F2} {toUnit}";

                // ✅ Save conversion after displaying the result
                DBHelper.SaveConversion(type, fromUnit, toUnit, input, result);
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }

        private double ConvertUnits(string type, double value, string from, string to)
        {
            if (type == "Length")
                return ConvertLength(value, from, to);
            if (type == "Weight")
                return ConvertWeight(value, from, to);
            if (type == "Temperature")
                return ConvertTemperature(value, from, to);

            throw new Exception("Unsupported conversion type.");
        }

        private double ConvertLength(double value, string from, string to)
        {
            // Convert from source to meters
            Dictionary<string, double> factors = new Dictionary<string, double>
            {
                { "Meter", 1 },
                { "Kilometer", 1000 },
                { "Mile", 1609.34 },
                { "Foot", 0.3048 }
            };

            return value * factors[from] / factors[to];
        }

        private double ConvertWeight(double value, string from, string to)
        {
            Dictionary<string, double> factors = new Dictionary<string, double>
            {
                { "Kilogram", 1 },
                { "Gram", 0.001 },
                { "Pound", 0.453592 },
                { "Ounce", 0.0283495 }
            };

            return value * factors[from] / factors[to];
        }

        private double ConvertTemperature(double value, string from, string to)
        {
            double celsius;

            // Convert from source to Celsius
            switch (from)
            {
                case "Celsius": celsius = value; break;
                case "Fahrenheit": celsius = (value - 32) * 5 / 9; break;
                case "Kelvin": celsius = value - 273.15; break;
                default: throw new Exception("Unknown unit.");
            }

            // Convert from Celsius to target
            switch (to)
            {
                case "Celsius": return celsius;
                case "Fahrenheit": return (celsius * 9 / 5) + 32;
                case "Kelvin": return celsius + 273.15;
                default: throw new Exception("Unknown unit.");
            }
        }
    }
}
