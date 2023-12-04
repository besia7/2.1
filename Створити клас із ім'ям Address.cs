using System;

class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Program
{
    static void Main()
    {
        // Створюємо екземпляр класу Address
        Address myAddress = new Address();

        // Заповнюємо поля адреси
        myAddress.Index = "12345";
        myAddress.Country = "Україна";
        myAddress.City = "Київ";
        myAddress.Street = "Вулиця Назва";
        myAddress.House = "42";
        myAddress.Apartment = "7";

        // Виводимо інформацію на екран
        Console.WriteLine("Поштова адреса:");
        Console.WriteLine($"Індекс: {myAddress.Index}");
        Console.WriteLine($"Країна: {myAddress.Country}");
        Console.WriteLine($"Місто: {myAddress.City}");
        Console.WriteLine($"Вулиця: {myAddress.Street}");
        Console.WriteLine($"Будинок: {myAddress.House}");
        Console.WriteLine($"Квартира: {myAddress.Apartment}");

        Console.ReadLine(); // Затримка, щоб консольне вікно не закрилося відразу
    }
}

