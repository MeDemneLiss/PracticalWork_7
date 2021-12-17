namespace PracticalWork_7
{
    class Lorry : Car
    {
        public double CarryingBody { get; set; }
        public Lorry() :base()
        {
            CarryingBody = 0;
        }
        public Lorry SetParams_(int carryingBody)
        {
            CarryingBody = carryingBody;
            return this;
        }
        public Lorry ReassignTredemark(string tredemark)
        {
            Tredemark = tredemark;
            return this;
        }
        public string ShowInformation()
        {
            string info;
            if (CarryingBody > 0)
            {
              info = "Торговая марка - " + Tredemark + "\n" + "Мощность - " + Power + " л.с.\n" + "Колличество цилиндров - " + NumberCylinders + "\n" + "Грузоподъемность - " + CarryingBody;
            }
            else info = "Торговая марка - " + Tredemark + "\n" + "Мощность - " + Power + " л.с.\n" + "Колличество цилиндров - " + NumberCylinders ;
            return info;
        }
    }

}
