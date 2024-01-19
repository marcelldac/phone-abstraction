namespace App
{
    public class Nokia : SmartPhone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void installApplication(string app)
        {
            Console.WriteLine($"Installing application: {app} on Nokia");
        }
    }
}