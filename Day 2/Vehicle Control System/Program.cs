namespace Vehicle_Control_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Car();
            Vehicle v2 = new Truck();
            Vehicle v3 = new Motorcycle();

            v1.Start();
            v2.Stop();
            v3.Describe();
        }
    }
}