namespace PracticalWork_7
{
    class Car
    {
        public string Tredemark { get; set; }
        public double Power { get; set; }
        public int NumberCylinders { get; set; }

        public Car()
        {
            Tredemark = "не указана";
            Power = 0;
            NumberCylinders = 0;
        }
        public Car(string tredemark, double power, int numberCylinders)
        {
            Tredemark = tredemark;
            Power = power;
            NumberCylinders = numberCylinders;

        }
        public Car SetParams(string tredemark)
        {
            Tredemark = tredemark;
            return this;
        }  
        public Car SetParams(double power)
        {
            Power = power;
            return this;
        }
        public Car SetParams(int numberCylinders)
        {
            NumberCylinders = numberCylinders;
            return this;
        }

        //public string ShowInformation()
        //{
        //    string info = "Торговая марка - " + Tredemark + "\n" + "Мощность - " + Power + " л.с.\n" + "Колличество цилиндров - " + NumberCylinders ;
        //    return info;
        //}

        //6 Практическая
        public static Car operator ++(Car value)
        {
            value.Power ++;
            return value;
        }

        public static bool operator >(Car carNumberOne, Car carNumberTwo)
        {
            bool result = (carNumberOne.Power > carNumberTwo.Power && carNumberOne.NumberCylinders > carNumberTwo.NumberCylinders) || (carNumberOne.Power > carNumberTwo.Power && carNumberOne.NumberCylinders == carNumberTwo.NumberCylinders) || (carNumberOne.Power == carNumberTwo.Power && carNumberOne.NumberCylinders > carNumberTwo.NumberCylinders);
            return result;
        }

        public static bool operator <(Car carNumberOne, Car carNumberTwo)
        {
            bool result = carNumberOne.Power < carNumberTwo.Power && carNumberOne.NumberCylinders < carNumberTwo.NumberCylinders || carNumberOne.Power < carNumberTwo.Power && carNumberOne.NumberCylinders == carNumberTwo.NumberCylinders || carNumberOne.Power == carNumberTwo.Power && carNumberOne.NumberCylinders < carNumberTwo.NumberCylinders;
            return result;
        }
    }

}

