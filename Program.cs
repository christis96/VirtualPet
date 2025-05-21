namespace Virtual_pet;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        while (programRunning)
        {
            Console.WriteLine("Velg kjæledyr");
            Console.WriteLine("Hund");
            Console.WriteLine("Katt");
            Console.WriteLine("Pappegøye");
            Console.WriteLine("Ørn");
            Console.WriteLine("For å avslutte skriv 'Avslutt'");
            string valg = Console.ReadLine();
            
            switch (valg)
            {
                case "Hund":
                    Hund hund = new Hund();
                    Console.WriteLine(hund.GetStatus());
                    SelectedPet(hund);
                    break;
                case "Katt":
                    Katt katt = new Katt();
                    Console.WriteLine(katt.GetStatus());
                    SelectedPet(katt);
                    break;
                case "Pappegøye":
                    Pappegøye pappegøye = new Pappegøye();
                    Console.WriteLine(pappegøye.GetStatus());
                    SelectedPet(pappegøye);
                    break;                
                case "Ørn":
                    Ørn ørn = new Ørn();
                    Console.WriteLine(ørn.GetStatus());
                    SelectedPet(ørn);
                    break;
                case "Avslutt":
                    programRunning = false;
                    break;
                default:
                    Console.WriteLine("Ikke gyldig");
                    break;
            }
        }

    }
    
    static void SelectedPet(object pet)
    {
        while (true)
        {
            Console.WriteLine("Hva vil du gjøre? (Feed, Pet, GoToToilet)");
            Console.WriteLine("Trykk 'e' for å gå tilbake til hovedmeny");
            string command = Console.ReadLine();
            
            if (command.ToLower() == "e")
            {
                Console.WriteLine("Avslutter kjæledyrmenyen.");
                break;
            } 
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
                        Console.WriteLine(katt.GetStatus());
                        break;
                    case "GoToToilet":
                        katt.GoToToilet();
                        Console.WriteLine(katt.GetStatus());
                        break;
                    default:
                        Console.WriteLine("Ikke gyldig");
                        break;
                }
            }
            else if (pet is Hund hund)
            {
                switch (command)
                {
                    case "Feed":
                        hund.Feed();
                        Console.WriteLine(hund.GetStatus());
                        break;
                    case "Pet":
                        hund.Pet();
                        Console.WriteLine(hund.GetStatus());
                        break;
                    case "GoToToilet":
                        hund.GoToToilet();
                        Console.WriteLine(hund.GetStatus());
                        break;
                    default:
                        Console.WriteLine("Ikke gyldig");
                        break;
                }
            }
            else if (pet is Pappegøye pappegøye)
            {
                switch (command)
                {
                    case "Feed":
                        pappegøye.Feed();
                        Console.WriteLine(pappegøye.GetStatus());
                        break;
                    case "Pet":
                        pappegøye.Pet();
                        Console.WriteLine(pappegøye.GetStatus());
                        break;
                    case "GoToToilet":
                        pappegøye.GoToToilet();
                        Console.WriteLine(pappegøye.GetStatus());
                        break;
                    default:
                        Console.WriteLine("Ikke gyldig");
                        break;
                }
                
            }
            else if (pet is Ørn ørn)
            {
                switch (command)
                {
                    case "Feed":
                        ørn.Feed();
                        Console.WriteLine(ørn.GetStatus());
                        break;
                    case "Pet":
                        ørn.Pet();
                        Console.WriteLine(ørn.GetStatus());
                        break;
                    case "GoToToilet":
                        ørn.GoToToilet();
                        Console.WriteLine(ørn.GetStatus());
                        break;
                    default:
                        Console.WriteLine("Ikke gyldig");
                        break;
                }
            }
        }
    }
}