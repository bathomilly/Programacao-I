using Aula_05.Models;

Customer c1 = new Customer();

c1.FirstName = "Camilly";
c1.LastName = "Volk";
c1.BirthDate = new DateTime();
c1.EmailAdress = "camillyvolk.k@gmail.com";

Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName}");
Console.WriteLine($"Email: {c1.EmailAdress}");

Address address1 = new Address();
address1.AddressId = 1;
address1.Street = "Margareth Volk";
address1.District = "Portal";
address1.City = "Treze Tílias";
address1.Number = 62;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89650-000";

Console.WriteLine("-------------");
c1.Addresses.Add(address1);

Console.WriteLine("Endereços:");
foreach(var ad in c1.Addresses)
{
    Console.WriteLine("-------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Número: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"País: {ad.Country}");
    Console.WriteLine($"CEP: {ad.ZipCode}");
}

