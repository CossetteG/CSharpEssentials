using System;


public class Laundry
{
    public int shirts = 20;
    public int pants = 7;
    public int dresses = 14;
    public long hangars = 50000000000L;

    public string comment= "Time to do laundry";

    public int clothesInTheWasher = 0;
    public int clothesInTheDryer = 0;

    public void Main()
    {
        Console.WriteLine(comment);

        //Laundry Switch 1
        clothesInTheWasher += shirts;
        shirts -= shirts;
        Console.WriteLine("Shirts are in the wash.");
		
        Console.WriteLine("   There are " + clothesInTheWasher+" items in the washer"); 
        Console.WriteLine("   There are "+ clothesInTheDryer+ " items in the dryer");
        
        //Laundry Switch 2
        clothesInTheDryer += clothesInTheWasher;
        clothesInTheWasher -= (clothesInTheWasher);
        clothesInTheWasher += (dresses);
        dresses -= dresses;
        Console.WriteLine("Shirts are drying, dresses are washing");

        Console.WriteLine("   There are " + clothesInTheWasher+" items in the washer"); 
        Console.WriteLine("   There are "+ clothesInTheDryer+ " items in the dryer");

        //Laundry Switch 3
        shirts += clothesInTheDryer;
        clothesInTheDryer -= clothesInTheDryer;
        clothesInTheDryer += clothesInTheWasher;
        clothesInTheWasher -= (clothesInTheWasher);
        clothesInTheWasher += pants;
        Console.WriteLine("Shirts are clean, dresses are drying, pants are washing");

        Console.WriteLine("   There are " + clothesInTheWasher+" items in the washer"); 
        Console.WriteLine("   There are "+ clothesInTheDryer+ " items in the dryer");

        //Laundry Switch 4
        dresses += clothesInTheDryer;
        clothesInTheDryer -= clothesInTheDryer;
        clothesInTheDryer += clothesInTheWasher;
        clothesInTheWasher -= (clothesInTheWasher);
        Console.WriteLine("Dresses are clean, pants are drying");
        Console.WriteLine("   There are " + clothesInTheWasher+" items in the washer"); 
        Console.WriteLine("   There are "+ clothesInTheDryer+ " items in the dryer");

        //Laundry Switch 5
        pants += clothesInTheDryer;
        clothesInTheDryer -= clothesInTheDryer;
        Console.WriteLine("Pants are clean");

        Console.WriteLine("   There are " + clothesInTheWasher+" items in the washer"); 
        Console.WriteLine("   There are "+ clothesInTheDryer+ " items in the dryer");

        Console.WriteLine("Now go fold your laundry");
    }
}