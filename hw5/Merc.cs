
    public class Merc : Car
    {
        public bool isAmg;

        public Merc(string Model, double Km, int TopSpeed, double Motor, int Hp, bool isAmg) : base(Model, Km, TopSpeed, Motor, Hp)
        {
            this.isAmg = isAmg;


        }

        public void GetMercInfo(string Model,double Km,int TopSpeed,double Motor,int Hp,bool isAmg)
        {
            Console.WriteLine($"{Model} ,{Km} , {TopSpeed}, {Motor}, {Hp} ");
            if (isAmg)
            {
                Console.WriteLine("Amg - dir");
            }
            else
            {
                Console.WriteLine("Amg - deyil");
            }
        }

        
       
    }


