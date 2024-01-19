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
            Console.WriteLine("Calling...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving a call...");
        }

        public abstract void installApplication(string app);
    }
}
