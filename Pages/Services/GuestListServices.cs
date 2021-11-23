using halloweenParty.Models;
using System.Collections.Generic;


public static class GuestListFunctions
{
    static List <Guest> GuestList {  get;  }
    static int guestNum = 0;
    static GuestListFunctions()
    {
        GuestList = new List<Guest>
        {
            new Guest { ID = 1, 
                        name = "boogie", 
                        age = 20, 
                        arrivalTime = 2, 
                        parking = true}
        };
    }
    public static void add( Guest g )
    {
        // g.name = //name of person
        // g.age = // age of person
        // g.arrivalTime = //arrival time
        // g.parking = // parking preference
        
        // //currentRunningListOfPeople.add(p)
    }

    public static void delete( Guest g)
    {

    }

    public static void Update(Guest g)
    {

    }
}

