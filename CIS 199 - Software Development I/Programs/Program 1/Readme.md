Purpose: This assignment explores the use of variables and simple arithmetic.

This assignment is inspired by Programming Project 3-12 (p. 197) from your text but is different in several keys aspects, so follow the directions here carefully.

A painting company has determined that for every 275 square feet of wall space, 1 gallon of paint and 8 hours of labor will be required. The company charges $12.50 per hour for labor. Create a Windows Forms application that allows the user to enter the square feet of wall space to be painted (a floating point type number), the number of coats of paint desired (an integer type number), and the price of the paint per gallon (a floating point type number). The program should display the following data:

Total square feet to be painted, including all coats of paint desired. For example, 250 square feet with 2 coats is a total of 500 square feet to be painted, displayed to 1 decimal of precision.
The number of gallons of paint required. Since you can't buy partial gallons of paint, this will be an integer amount rounded up to the next gallon if necessary. You will find the Math.Ceiling method helpful in this calculation. Remember, every 275 square feet to be painted requires a gallon of paint, so 500 square feet will require 2 gallons of paint be purchased (not 1.8).
The hours of labor required, displayed to 1 decimal of precision. For example, the 500 square feet will require 14.5 hours of labor.
The cost of the paint, displayed using currency formatting.
The cost of the labor, displayed using currecny formatting.
The total cost of the paint job, displayed using currency formatting.
Be sure to add appropriate comments in your code, including your Grading ID (not name nor student ID), program number, due date, and course section. Each variable used in your program needs a comment describing its purpose. Remember to create named constants instead of using magic numbers. Here, you'll want to avoid using the numbers 275, 8, and 12.50. Instead create named constants to represent the square feet per gallon of paint, etc.. These requirements are expected for every program and are listed in the syllabus. Preconditions and postconditions are not expected yet, as we've not covered them in class.






Sample Test Data
Input

500.0 Sq. Ft.
2 coats
$12.99 per gallon

Output

1000.0 Total sq. ft.
4 gal
29.1 hours
$51.96 paint
$363.64 labor
----------------------
$415.60 total