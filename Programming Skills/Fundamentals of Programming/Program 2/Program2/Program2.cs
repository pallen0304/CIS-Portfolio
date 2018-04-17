using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Program2
{



    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }



        public static readonly NumberStyles UnsignedFloatingPoint = NumberStyles.Float ^ NumberStyles.AllowLeadingSign;

        private void btnSubmit_Click(object sender , EventArgs e)
        {
            //Stores the number of credits acquired prior to the current semester.
            decimal creditHours;
            //Stores the first character of the last name.
            char lastName;
            //setting lastName equal to the first character in the textbox or space if empty. Throwing an error if it is a space because last name must be provided.
            if ( ( lastName = ( textboxLastName.Text + " " )[0] ) == ' ' )
            {
                labelEarliestTimeOfRegistration.Text = "Last Name must be provided.";
                return;
            }
            if ( !decimal.TryParse(textboxCreditHours.Text , UnsignedFloatingPoint , CultureInfo.CurrentCulture.NumberFormat , out creditHours) )
            {
                labelEarliestTimeOfRegistration.Text = "Credit Hours must be an integer or floating point value. A value must be provided.";
                return;
            }

            //Stores the earliest date that the user will be able to register on.
            string day = "November {0}, 2016";
            //Stores the earliest time of day that the user will be able to register on.
            string timeFrame;
            //Divide credit hours by 30 and get Floor for grade level. 
            //0 for Freshman, 1 for Sophomore, 2 for Junior, 3 or greater for Senior
            int grade = (int)Math.Floor(creditHours / 30m);
            if ( grade > 1 )
            {
                if ( lastName < 'E' )
                    timeFrame = "14:00";//A - D
                else if ( lastName < 'J' )
                    timeFrame = "16:00"; //E - I
                else if ( lastName < 'P' )
                    timeFrame = "08:30";//J - O
                else if ( lastName < 'T' )
                    timeFrame = "10:00";//P - S
                else
                    timeFrame = "11:30";//T - Z

                if ( grade == 2 )
                    day = string.Format(day , 7);//Junior
                else
                    day = string.Format(day , 4);//Senior
            }
            else
            {
                //Is earliest registration on the second day of priority registrations for the user's grade level
                bool onSecondDay = false;
                //11/11/2016 Friday,
                //    08:30   J-L
                //    10:00   M-O
                //    11:30   P-Q
                //    14:00   R-S
                //    16:00   T-V
                //11/14/2016 Monday,
                //    08:30   W-Z
                //    10:00   A-B
                //    11:30   C-D
                //    14:00   E-F
                //    16:00   G-I
                if ( lastName < 'M' )
                    if ( lastName < 'C' )
                        timeFrame = "10:00";//A - B
                    else if ( lastName < 'E' )
                        timeFrame = "11:30";//C - D
                    else if ( lastName < 'G' )
                        timeFrame = "14:00";//E - F
                    else if ( !( onSecondDay = !( lastName < 'J' ) ) )
                        timeFrame = "16:00";//G - I
                    else
                        timeFrame = "08:30";//J - L
                else if ( onSecondDay = ( lastName < 'W' ) )
                    if ( lastName < 'P' )
                        timeFrame = "10:00";//M - O
                    else if ( lastName < 'R' )
                        timeFrame = "11:30";//P - Q
                    else if ( lastName < 'T' )
                        timeFrame = "14:00";//R - S
                    else
                        timeFrame = "16:00";//T - V
                else
                    timeFrame = "08:30";//W - Z

                if ( onSecondDay ) //0-4 is first day, 5-9 is second day
                    if ( grade == 0 )
                        day = string.Format(day , 11);//Freshman - First Day
                    else
                        day = string.Format(day , 9);//Sophomore - First Day
                else if ( grade == 0 )
                    day = string.Format(day , 14);//Freshman - Second Day
                else
                    day = string.Format(day , 10);//Sophomore - Second Day
            }


            labelEarliestTimeOfRegistration.Text =
                string.Format("Your earliest registration time is at {0} on {1}" ,
                    timeFrame ,
                    day
                    );
        }

        private void textboxCreditHours_KeyPress(object sender , KeyPressEventArgs e)
        {
            //When this resolves as true, input will not be processed.
            if ( !char.IsControl(e.KeyChar) && //The user presses a non-command-key(i.e. backspace, escape, delete, home, end, alt, shift, control...)
                !char.IsDigit(e.KeyChar) && //The user presses a key other than 0-9
                ( e.KeyChar != '.' || ( sender as TextBox ).Text.IndexOf('.') > -1 ) ) //The user enters a period(decimal point) and the textbox does not already contain a period(decimal point).
            {
                e.Handled = true;
            }
        }

        private void textboxLastName_KeyPress(object sender , KeyPressEventArgs e)
        {
            //When this resolves as true, input will not be processed.
            if ( !char.IsControl(e.KeyChar) && //The user presses a non-command-key(i.e. backspace, escape, delete, home, end, alt, shift, control...)
                 !Regex.IsMatch(e.KeyChar.ToString(),"[a-zA-Z]" )) //The user presses a key that is not A-Z or a-z
            {
                e.Handled = true;
            }
        }
    }


    /*
     *Rules:
       University does offer 1.5 credit hour courses
       Grade level is defined as:
           Freshmen     <  30
           Sophomores   <  60
           Juniors      <  90
           Seniors      >= 90 
       Last name:
           Ignore case
           [a-zA-Z] characters only
     
     *Inputs
     *  decimal: Credit hours completed prior to Fall 2016 
     *  char[]/string: User's last name
     *
     *Outputs
     * string: earliest registration time and date, or notification if parsing failed.
     
     Seniors:
        11/04/2016 Friday,
            08:30   J-O
            10:00   P-S
            11:30   T-Z
            14:00   A-D
            16:00   E-I
     Juniors:
        11/07/2016 Monday,
            08:30   J-O
            10:00   P-S
            11:30   T-Z
            14:00   A-D
            16:00   E-I
     Sophomores:
        11/09/2016 Wednesday,
            08:30   J-L
            10:00   M-O
            11:30   P-Q
            14:00   R-S
            16:00   T-V
        11/10/2016 Thursday,
            08:30   W-Z
            10:00   A-B
            11:30   C-D
            14:00   E-F
            16:00   G-I
     Freshmen
        11/11/2016 Friday,
            08:30   J-L
            10:00   M-O
            11:30   P-Q
            14:00   R-S
            16:00   T-V
        11/14/2016 Monday,
            08:30   W-Z
            10:00   A-B
            11:30   C-D
            14:00   E-F
            16:00   G-I
     */
}
