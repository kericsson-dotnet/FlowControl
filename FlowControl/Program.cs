{
    Console.WriteLine("FlowControl v0.0.1");

    Price visitors = new Price();

    while (true)
    {
        Console.WriteLine("\nMain menu\nPlease select and press enter:\n0: Quit\n1: Ticket Price Check\n2: Add Visitors\n3: Repeat 10 times\n4: Third word");
        var selection = Console.ReadLine();
        switch (selection)
        {
            case "0":
                Environment.Exit(0);
                break;

            case "1":
                Console.Clear();
                Price.PrintPriceCategory(Price.CheckCategory(Util.GetInputToInt("Please enter age as a number:")));
                break;

            case "2":
                Console.Clear();
                uint visitorsAmount = Util.GetInputToInt("How many visitors to add? (Please enter a number):");

                for (int i = 0; i < visitorsAmount; i++)
                {
                    visitors.AddVisitor(Util.GetInputToInt($"Visitor {i + 1}: Please enter age as a number:"));
                }

                Console.WriteLine($"Visitors added: {visitorsAmount} Total sum: {visitors.VisitorsPriceSum()}kr");
                break;

            case "3":
                Console.Clear();
                Console.WriteLine(Util.Repeater(Util.GetInput("Phrase to repeat:")));
                break;

            case "4":
                Console.Clear();
                Console.WriteLine($"Third word: {Util.ThirdWord(Util.GetInput("Enter a phrase (3 words minimum):", 3))}");
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid choice\n");
                break;

        }
    }
}

