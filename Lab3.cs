System.Console.WriteLine("Welcome to the College Football Intro application!");

        System.Console.WriteLine("Please enter your preferred level of enjoyment (1 for Boring, 2 for Average, 3 for Fun, or 4 for Epic).");
        int enjoymentLevel = int.Parse(Console.ReadLine());

        if (enjoymentLevel == 1) {
            System.Console.WriteLine("Attend Neyland Stadium for Tennesee's matchup vs Kent State!");
        }
        else if (enjoymentLevel == 2) {
            System.Console.WriteLine("Attend Jordan-Hare Stadium for Auburn's matchup vs Kentucky!");
        }
        else if (enjoymentLevel == 3) {
            System.Console.WriteLine("Attend Tiger Stadium for LSU's matchup versus Alabama!");
        }
        else if (enjoymentLevel == 4) {
            System.Console.WriteLine("Attend the amazing atmosphere at Saban Field at Bryant-Denny Stadium to watch the Crimson Tide take on the Auburn Tigers!");
        }
        else {
            System.Console.WriteLine("Please select an option 1-4. Restart the application and select a viable option.");
            return;
        }
        

System.Console.WriteLine("Enjoy your game!");