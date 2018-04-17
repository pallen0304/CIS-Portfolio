// Program 2
// CIS 199-75
// Due: 11/20/2016
// By: B6722

// This application calculates the earliest registration date
// and time for an undergraduate student given their credit hours
// and last name.
// Decisions based on UofL Fall/Summer 2016 Priority Registration Schedule

// Solution 3
// This solution keeps the first letter of the last name as a char
// and uses if/else logic for the times.
// It uses defined strings for the dates and times to make it easier
// to maintain.
// This solution takes advantage of the fact that there really are
// only two different time patterns used. One for juniors and seniors
// and one for sophomores and freshmen. The pattern for sophomores
// and freshmen is complicated by the fact the certain letter ranges
// get one date and other letter ranges get another date.

using System;
using System.Windows.Forms;

namespace Program3
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        public static string[][] days =
        {
                new string[] { "14", "14", "14", "14", "11", "11", "11", "11", "11", "14",},//freshman
                new string[] { "10", "10", "10", "10",  "9",  "9",  "9",  "9",  "9", "10",},//sophomore
                new string[] { "7", "7", "7", "7", "7",}, //junior
                new string[] { "4", "4", "4", "4", "4",}, //senior
            };
        public static string[][] timeFrames =
        {
                new string[] { "10:00", "11:30", "14:00", "16:00", "08:30", "10:00", "11:30", "14:00", "16:00", "08:30",}, //freshman/sophomore
                new string[] { "14:00", "16:00", "08:30", "10:00", "11:30",}, //junior/senior
            };
        public static char[][] lastNames =
        {
                new char[]{ 'B', 'D', 'F', 'I', 'L',  'O', 'Q', 'S', 'V', 'Z',},//freshman/sophomore
                new char[]{ 'D', 'I', 'O', 'S', 'Z',},//junior/senior
            };

        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            string result = "Your earliest registration time is at {0} on {1}";//String format to be used for the output.
            string day = "November {0}, 2016";

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            decimal creditHours;        // Entered credit hours
            int grade;


            if(decimal.TryParse(creditHrTxt.Text, out creditHours) && creditHours >= 0) // Valid hours
            {
                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameLetterCh = lastNameStr[0];   // First char of last name
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        grade = (grade = (int)Math.Floor(creditHours / 30m)) > 3 ? 3 : grade;
                        for(int index = 0; index < lastNames[grade / 2].Length; index++)
                        {
                            if(lastNameLetterCh <= lastNames[grade / 2][index])
                            {
                                timeStr = timeFrames[grade / 2][index];
                                dateStr = string.Format(day, days[grade][index]);
                                break;
                            }
                        }

                        // Output results
                        dateTimeLbl.Text = string.Format(result, timeStr, dateStr);
                    }
                    else // First char not a letter
                        MessageBox.Show("Enter valid last name!");
                }
                else // Empty textbox
                    MessageBox.Show("Enter a last name!");
            }
            else // Can't parse credit hours
                MessageBox.Show("Please enter valid credit hours earned!");
        }
    }
}
