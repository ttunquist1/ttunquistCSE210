using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("1320 W Schaumburg Rd", "Schaumburg", "Illinois", "60194", "USA");
        string lectureAddress = address1.GetStreetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with members of the Schaumburg Stake.", "August 2, 2025", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Peterson", 560);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.displayShortDescription();
        Console.WriteLine();
        lecture.displayStandardDetails();
        Console.WriteLine();
        lecture.displayLectureDetails();


        Address address2 = new Address ("2100 California Cir", "Rancho Cordova", "California", "95742", "USA");
        string receptionAddress = address2.GetStreetAddress();
        Receptions reception = new Receptions("Chris Munoz", "Baptism of Chris Munoz", "May 21, 2025", "6:00 pm - 8:00pm", $"{receptionAddress}", "Reception", "email@email.com");
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        reception.displayShortDescription();
        Console.WriteLine();
        reception.displayStandardDetails();
        Console.WriteLine();
        reception.displayReceptionDetails();


        Address address3 = new Address ("S 2nd W & 3rd W", "Rexburg", "Idaho", "83440", "USA");
        string outdoorAddress = address3.GetStreetAddress();
        Outdoor outdoor = new Outdoor("Elders Quorum", "Sports Night", "May 28, 2025", "6:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.displayShortDescription();
        Console.WriteLine();
        outdoor.displayStandardDetails();
        Console.WriteLine();
        outdoor.displayOutdoorDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}