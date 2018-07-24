using System;

namespace CG_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Type the number of a Month (MM): ");
           
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "01")
                message = "January";
            else if (userValue == "02")
                message = "February";
            else if (userValue == "03")
                message = "March";
            else if (userValue == "04")
                message = "April";
            else if (userValue == "05")
                message = "May";
            else if (userValue == "06")
                message = "June";
            else if (userValue == "07")
                message = "July";
            else if (userValue == "08")
                message = "August";
            else if (userValue == "09")
                message = "September";
            else if (userValue == "10")
                message = "October";
            else if (userValue == "11")
                message = "November";
            else if (userValue == "12")
                message = "December";

            else
                message = "Invalid Entry";
        
            
            Console.WriteLine(message);
            Console.ReadLine();


        }
    }
}
