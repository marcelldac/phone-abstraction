using App;

SmartPhone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

nokia.CallToAnyone();
nokia.ReceiveCall();
nokia.installApplication("Github");

SmartPhone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

iphone.CallToAnyone();
iphone.ReceiveCall();
iphone.installApplication("Github");