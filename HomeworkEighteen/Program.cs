using HomeworkEighteen;

Console.WriteLine("Homework Eighteen");
Console.WriteLine("-----------------");
Console.WriteLine();

AddressModel address1 = new AddressModel();
address1.Street = "Kahitsan";
address1.Address = "Ayayay";
address1.City = "Pasig";
address1.State = "Dono";
address1.ZipCode = "123";

AddressModel address2 = new AddressModel("456");
address2.Street = "Ayono";
address2.Address = "Tabi";
address2.City = "Marikina";
address2.State = "Dale";

Console.WriteLine(address1.FullAddress);
Console.WriteLine(address2.FullAddress);

Console.ReadLine();