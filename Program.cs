using ApartmentArea;

Apartment sharedObj = new Apartment();

var t1 = new Thread(sharedObj.ThreadProcess);
t1.Start();

Console.WriteLine(sharedObj.GetArea());
sharedObj.UpdateArea(3);
Console.WriteLine(sharedObj.GetArea());

var t2 = new Thread(sharedObj.ThreadProcess);
t2.Start();

Console.WriteLine(sharedObj.GetArea());
sharedObj.UpdateArea(8);
Console.WriteLine(sharedObj.GetArea());

