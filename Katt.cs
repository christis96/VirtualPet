namespace Virtual_pet;

public class Katt
{
    private int age;
    private int hunger;
    private int happiness;
    private int bladder;

    public Katt()
    {
        Random rnd = new Random();
        age = rnd.Next(1, 16);
        hunger = rnd.Next(1, 11);
        happiness = rnd.Next(1, 11);
        bladder = rnd.Next(1, 11);
    }
    public string GetStatus()
    {
        return $"Alder: {age}, Sult: {hunger}, Lykke: {happiness}, Blære: {bladder}";
    }
    public void Feed()
    {
        hunger--;
    }

    public void Pet()
    {
        happiness++;
    }

    public void GoToToilet()
    {
        bladder--;
    }
}