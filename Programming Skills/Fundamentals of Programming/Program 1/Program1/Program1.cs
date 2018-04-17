/* Grading ID: B6722
*  Assignment Due Date: September 18, 2016 11:59:00 PM
*  CIS 199-75
*  Program 1
*/
/// <summary>
/// This program accepts three inputs using textboxes. The inputs are Square Feet(double), coats(int), and Price Per Gallon(double).
/// The textboxes do not allow the user to copy/paste input(enforced by ShortcutsEnabled property).
/// The textboxes do not accept non-numeric characters, and will accept at most one decimal point IIF the input is a Floating Point(Enforced by _KeyPress events).
/// Submitting input("Estimate Paint Job") will display the results of the estimate in a readonly textbox to the right.
/// </summary>
using System;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }
        
        public const double SquareFeetPerGallonOfPaint = 275; //The amount of square feet that a single gallon of paint covers.
        public const double HoursOfLaborPerGallonOfPaint = 8; //The number of hours needed by labor per gallon of paint.
        public const double LaborCostPerHour = 12.5; //The cost of labor per hour.

        private void buttonSubmit_Click(object sender , EventArgs e)
        {
            double squareFeet = double.Parse(textboxSquareFeet.Text.Insert(0,"0")); // From input, Stores Square Feet
            long coats = long.Parse(textboxCoats.Text.Insert(0 , "0")); //From input, Stores the number of coats
            double pricePerGallon = double.Parse(textboxPricePerGallon.Text.Insert(0 , "0")); //From input, Stores the Price Per Gallon of Paint.

            double totalSquareFeet = squareFeet * coats; //Stores the Total Square Feet worth of paint required.
            double gallonsActual = totalSquareFeet / SquareFeetPerGallonOfPaint; //Stores the actual number of gallons of paint that would be used.
            long gallons = (long)Math.Ceiling(totalSquareFeet / SquareFeetPerGallonOfPaint); //Stores the number of gallons of paint required to be purchased.
            double hours = HoursOfLaborPerGallonOfPaint * gallonsActual; //Stores the number of hours required by labor to finish the paint job.
            double costOfPaint = gallons * pricePerGallon; //Stores the cost of the paint purchased, regardless if all the paint was used or not.
            double costOfLabor = hours * LaborCostPerHour; //Stores the cost of labor based on LaborCostPerhour and hours.
            double totalCost = costOfPaint + costOfLabor; //Stores the total cost of the paint job.

            textboxResults.ResetText();
            textboxResults.AppendText(totalSquareFeet.ToString("##0.0 Sq. Ft.\n"));
            textboxResults.AppendText(string.Format("{0} gal\n" , gallons));
            textboxResults.AppendText(string.Format("{0} hours\n" , hours.ToString("#0.0")));
            textboxResults.AppendText(string.Format("{0} paint\n" , costOfPaint.ToString("$###,##0.00")));
            textboxResults.AppendText(string.Format("{0} labor\n" , costOfLabor.ToString("$###,##0.00")));
            textboxResults.AppendText("\n".PadLeft(textboxResults.Width / 3 - 1 , '-'));
            textboxResults.AppendText(string.Format("{0} total\n" , totalCost.ToString("$###,##0.00")));
        }


        /// <summary>
        /// Causes input to be ignored if it would result in a non-Floating Point format.
        /// </summary>
        private void InputAsFloatingPoint_KeyPress(object sender , KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ( e.KeyChar != '.' ) )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ( ( e.KeyChar == '.' ) && ( ( sender as TextBox ).Text.IndexOf('.') > -1 ) )
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Causes input to be ignored if it would result in a non-Integral format.
        /// </summary>
        private void InputAsNumeric_KeyPress(object sender , KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
