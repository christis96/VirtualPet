namespace Virtual_pet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Velg kjæledyr");
        Console.WriteLine("Hund");
        Console.WriteLine("Katt");
        
        string valg = Console.ReadLine();
        switch (valg)
        {
            case "Hund":
                Hund hund = new Hund();
                SelectedPet(hund);
                break;         
            case "Katt":
                Katt katt = new Katt();
                Console.WriteLine(katt.GetStatus());
                SelectedPet(katt);
                break;
            default: 
                Console.WriteLine("Ikke gjylding");
                break;
        }
        
    }
    
    static void SelectedPet(object pet)
    {
        Console.WriteLine("Hva vil du gjøre? (Feed, Pet, GoToToilet)");
        string command = Console.ReadLine();
        if (pet is Katt katt)
        {
            switch (command)
            {
                case "Feed":
                    katt.Feed();
                    Console.WriteLine(katt.GetStatus());
                    break;
                case "Pet":
                    katt.Pet();
                    break;
                case "GoToToilet":
                    katt.GoToToilet();
                    break;
                default: 
                    Console.WriteLine("Ikke gjylding");
                    break;
            }
        }
        else if (pet is Hund hund)
        {
            switch (command)
            {
                case "Feed":
                    hund.Feed();
                    break;
                case "Pet":
                    hund.Pet();
                    break;
                case "GoToToilet":
                    hund.GoToToilet();
                    break;
                default: 
                    Console.WriteLine("Ikke gjylding");
                    break;
            }
        }
    }
}