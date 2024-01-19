namespace App
{
    public class Iphone : SmartPhone
    {
        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
        }

        public override void installApplication(string app)
        {
            Console.WriteLine($"Installing application: {app} on Iphone");
        }
    }
}