class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        while (true)
        {
            Console.Clear();
            menu.DisplayMenu();
            string input = Console.ReadLine();
            Console.Clear();
            
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathingActivity.DoActivity();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                    reflectionActivity.DoActivity();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                    listingActivity.DoActivity();
                    break;
                case "4":
                    AffirmationsActivity affirmationsActivity = new AffirmationsActivity("Affirmations Activity", "This activitiy will help you remember that you have worth and are loved, valued, and appreciated.", 0);
                    affirmationsActivity.DoActivity();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}