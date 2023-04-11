public class Bmw : Car
{

    public bool isMpower;

    public Bmw(string Model, double Km, int TopSpeed, double Motor, int Hp, bool isMpower) : base(Model, Km, TopSpeed, Motor, Hp)
    {
        this.isMpower = isMpower;

    }
    public void GetBmwInfo(string Model, double Km, int TopSpeed, double Motor, int Hp, bool isMpower)
    {
        Console.WriteLine($"{Model} ,{Km} , {TopSpeed}, {Motor}, {Hp} ");
        if (isMpower)
        {
            Console.WriteLine("Mpower - dir");
        }
        else
        {
            Console.WriteLine("Mpower - deyil");
        }
    }

}

