
public class Car
	{
		private string _model { get; set; }
		private double _km  { get; set; }
		private int _topspeed { get; set; }
		private double _motor { get; set; }
		private int _hp { get; set; }

    

    public string Model
	{
		get
		{
			return _model;
		}
		set
		{
			if (value.Length >= 10 || string.IsNullOrWhiteSpace(value))
			{
				Console.WriteLine(" Model boş ola bilməz maksimum uzunluğu 10 ola bilər;");
			}
			else
			{
				_model = value;
			}
		}

	}

		public double Km
		{
			get
			{
				return _km;
			}

			set
			{
				if (value < 0)
				{
				Console.WriteLine("KM 0 dan kicik ola bilmez");
				}
				else
				{
					_km = value;
				}
				
			}

		}


		public int TopSpeed
		{
		get
		{
			return _topspeed;

		}
		set
		{
			if (value <10 || value >1000)
			{
				Console.WriteLine("Topspeed minimum 10 maksimum 1000 ola bilər");
			}
			else
			{
				_topspeed = value;
			}
		}
		}




	public double Motor
	{
		get
		{
			return _motor;
		}

		set
		{
			if (value<0.3 || value >10)
			{
				Console.WriteLine("Deyer Duzgun deyil!");
			}
			else
			{
				_motor = value;
			}

		}
		
	}
	public  int Hp
	{
		get
		{
			return _hp;
		}
		set
		{
			if (value<=50 || value >=1000)
			{
				Console.WriteLine("DUZGUN DEYIL");
			}
			else
			{
				_hp = value;
			}
		}
	}

    public Car(string Model, double Km, int TopSpeed, double Motor, int Hp)
    {
        this.Model = Model;
        this.Km = Km;
        this.TopSpeed = TopSpeed;
        this.Motor = Motor;
        this.Hp = Hp;

    }






}


