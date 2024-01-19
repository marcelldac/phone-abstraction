namespace App
{
    public abstract class SmartPhone
    {
        string Numero { get; set; }
        string Modelo { get; set; }
        string IMEI { get; set; }
        int Memoria { get; set; }

        protected SmartPhone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void CallToAnyone()
        {
        }

        public void ReceiveCall()
        {
        }

        public abstract void installApplication(string app);
    }

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

    public class Iphone : SmartPhone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void installApplication(string app)
        {
            Console.WriteLine($"Installing application: {app} on Iphone");
        }
    }
}
