namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Year = 2020;
            car1.Make = "Toyota";
            car1.Model = "Corolla";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep";
            car1.IsDriveable = true;

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            Car car2 = new Car();
            car2.Year = 2022;
            car2.Make = "Ford";
            car2.Model = "F-150";
            car2.EngineNoise = "Rumble";
            car2.HonkNoise = "Honk Honk";
            car2.IsDriveable = true;

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Car car3 = new Car();
            car3.Year = 2018;
            car3.Make = "Honda";
            car3.Model = "Civic";
            car3.EngineNoise = "Brrrr";
            car3.HonkNoise = "Meep";
            car3.IsDriveable = false;

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
        }
    }
}