// See https://aka.ms/new-console-template for more information
using FactoryMethod.AbstractProduct;
using FactoryMethod.ConcreteFactory;
using FactoryMethod.Factory;
using System.Text.Json;

CartaoFactory factory = null;
Console.WriteLine("Escolha o cartão:");
string console = Console.ReadLine();

switch (console.ToLower())
{
	case "black":
		factory = new BlackFactory(5000,0);
		break;
    case "platinum":
        factory = new PlatinumFactory(10000, 500);
        break;
    case "infinity":
        factory = new InfinityFactory(50000, 3000);
        break;
    default:
		break;
}

CartaoCredito cartaoCredito = factory.BuscarCartaoCredito();
Console.WriteLine(JsonSerializer.Serialize(cartaoCredito));
Console.ReadKey(); 