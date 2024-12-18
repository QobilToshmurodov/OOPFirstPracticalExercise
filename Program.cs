namespace OOPFirstPracticalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Toyota";
            car.FuelType = "Benzin";
            car.Speed = 180;
            car.DisplayInfo();
            car.Honk();

            Bicycle bike = new Bicycle();
            bike.Name = "BMX";
            bike.Speed = 20;
            bike.HasBell = true;
            bike.DisplayInfo();
            bike.RingBell();

            Airplane plane = new Airplane();
            plane.Name = "Boeing 747";
            plane.Speed = 900;
            plane.Altitude = 1000;
            plane.DisplayInfo();
            plane.TakeOff();
        }
    }
}
