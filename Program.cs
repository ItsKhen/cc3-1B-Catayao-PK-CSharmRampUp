using System;

class Program
{
    static void Main()
    {
        // Weight Conversion
        Console.Write("Enter Weight in Pounds(lbs): ");
        int pounds = int.Parse(Console.ReadLine());
        int startingValue = pounds;
        double kilograms = pounds * 0.45359237;

        Console.WriteLine($"Weight in Pounds: {startingValue}");
        Console.WriteLine($"Weight in Kilograms: {kilograms}");
        Console.WriteLine(new string('-', 40));

        // Distance Conversion
        Console.Write("Enter Distance in Miles: ");
        int miles = int.Parse(Console.ReadLine());
        double kilometers = miles * 1.60934;

        Console.WriteLine($"Distance in Miles: {miles}");
        Console.WriteLine($"Distance in Kilometers: {kilometers}");
        Console.WriteLine(new string('-', 40));

        // Temperature Conversion
        Console.Write("Enter Temperature in Fahrenheit: ");
        int fahrenheit = int.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"Temperature in Fahrenheit (°F): {fahrenheit}");
        Console.WriteLine($"Temperature in Celsius (°C): {celsius}");
        Console.WriteLine(new string('-', 40));

        // Average Age Calculation
        int[] studentAges = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            studentAges[i] = int.Parse(Console.ReadLine());
        }

        double averageAge = studentAges.Sum() / 10.0;
        Console.WriteLine($"Average Age: {averageAge}");
        Console.WriteLine(new string('-', 40));

        // Story
        string npc1 = "Aurelius DragonHeart";
        string npc2 = "Brax The Fallen Dark King";
        string npc3 = "Flames";
        string npc4 = "Krander Armorsteel";
        string npc5 = "Roman EldenWise";

        string item1 = "Executioner";
        string item2 = "Dragon Shield";
        string item3 = "Eye of Bakshi";
        string item4 = "Blood of Narzukul";
        string item5 = "Thalandor's Knowledge";
        string story =
            $"In the tranquil realm of Equalestral, {npc1}, from the esteemed DragonHeart lineage, was known for unmatched kindness and bravery. Everything remained serene until,\n" +

            $"A dark twist of fate emerged as {npc2} returned with an insatiable thirst for revenge against the Kingdom of Equalestral. " +
            $"Brax, summoned by former Generals, set intentions on the kingdom's destruction.\n" +

            $"In this dire hour, it fell upon {npc1}, joined by loyal allies {npc4} and companion {npc3}, to rise in the name of the DragonHeart and confront {npc2}.\n" +

            $"With permission from mentor {npc5}, {npc1} bravely embarked on this journey.\n" +

            $"Armed with the legendary {item1} and shielded by the indomitable {item2}, {npc1} and companions embarked on a perilous quest " +
            $"to retrieve lost, powerful artifacts to defeat the impending Army of darkness.\n" +

            $"Their initial task was to secure the {item3}, transformed into a legendary amulet bestowing temporary, boundless stamina. " +
            $"They also sought the {item4}, renowned for restoring energy and health. Lastly, they pursued {npc5}, enhancing Aurelius's combat knowledge.\n" +

            $"After overcoming trials and obtaining necessary items, the time had come to confront {npc2} and end this menace, achieving eternal peace throughout the kingdom.\n" +

            $"As they reached the lair of the Dark Lord, the battle commenced, intense and grueling. They utilized the {item4} to restore health and vitality, " +
            $"persevering in the relentless fight.\n" +

            $"Tragically, {npc4} sustained severe injuries and succumbed to them.\n" +

            $"This loss fueled {npc1}'s anger, compelling him to combine the {item3} and {item5}. In a remarkable transformation, " +
            $"the amulet and the spellbook merged within his mind, granting greater strength and knowledge, ultimately leading to the defeat of {npc2}. " +
            $"Equalestral could now bask in everlasting peace. The end.";

        Console.WriteLine(story);
        Console.WriteLine(new string('-', 40));

        // Number Pattern 1
        Console.Write("Enter a number for pattern 1: ");
        int pattern1Input = int.Parse(Console.ReadLine());

        if (pattern1Input <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            Console.WriteLine("Number Pattern 1:");
            for (int i = 1; i <= pattern1Input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine(new string('-', 40));

        // Number Pattern 2
        Console.Write("Enter a number for pattern 2: ");
        int pattern2Input = int.Parse(Console.ReadLine());

        if (pattern2Input <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            Console.WriteLine($"Number Pattern 2 (Sum of 1 to {pattern2Input}):");
            int sum = 0;
            for (int i = 1; i <= pattern2Input; i++)
            {
                Console.Write(i);
                sum += i;
                if (i < pattern2Input)
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.Write(" = " + sum);
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 40));

        
        Console.Write("Enter a number for pattern 3: ");
        int pattern3Input = int.Parse(Console.ReadLine());

        if (pattern3Input <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            Console.WriteLine("Number Pattern 3:");
            for (int i = pattern3Input; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
