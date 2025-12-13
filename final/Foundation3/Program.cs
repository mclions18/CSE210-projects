using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Event Program\n");
        Address lectureAddress = new Address("Coolplace","Idaho","Cool College Lecture Hall");
        Lecture lectureEvent = new Lecture("Awesome Lecture","Come listen to this awesome lecture by a cool guy!","December 22","7:00 PM",lectureAddress,"Lecture","Cool Guy",100);
        lectureEvent.StandardDetails();
        Console.WriteLine();
        lectureEvent.Fulldetails();
        Console.WriteLine();
        lectureEvent.ShortDescription();
        Console.WriteLine();
        Address receptionAddress = new Address("Pocatello","Idaho","Mountain View Event Center");
        Reception receptionEvent = new Reception("Wedding Reception","Join us to celebrate the newlyweds!","July 27","6:00 PM",receptionAddress,"Reception","emailtoRSVP@gmail.com");
        receptionEvent.StandardDetails();
        Console.WriteLine();
        receptionEvent.Fulldetails();
        Console.WriteLine();
        receptionEvent.ShortDescription();
        Console.WriteLine();
        Address outdoorAddress = new Address("Moscow","Idaho","Outdoor Event Complex");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Renaissance Fair","All-Day Renn Fair","June 6","10 AM",outdoorAddress,"Outdoor Gathering","Sunnny with clouds in the late afternoon");
        outdoorEvent.StandardDetails();
        Console.WriteLine();
        outdoorEvent.Fulldetails();
        Console.WriteLine();
        outdoorEvent.ShortDescription();
    }
}