namespace App
{
    public abstract class SmartPhone
    {
        string Number { get; set; }
        string Model { get; set; }
        string IMEI { get; set; }
        int Memory { get; set; }

        protected SmartPhone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
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
