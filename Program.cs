using App;

SmartPhone nokia = new Nokia(number: "123456", model: "Modelo 1", imei: "111111111", memory: 64);

nokia.CallToAnyone();
nokia.ReceiveCall();
nokia.installApplication("Github");

SmartPhone iphone = new Iphone(number: "123456", model: "Modelo 1", imei: "111111111", memory: 64);

iphone.CallToAnyone();
iphone.ReceiveCall();
iphone.installApplication("Github");