public interface IAbstractFactory
{
    IAbstractProductA CreateBloqueLadrillo();

    IAbstractProductB CreateBloqueInterrogacion();
}

class ConcreteFactoryMalo : IAbstractFactory
{
    public IAbstractProductA CreateBloqueLadrillo()
    {
        return new BloqueLadrilloSimple();
    }

    public IAbstractProductB CreateBloqueInterrogacion()
    {
        return new BloqueInterrogacionTrampa();
    }
}

class ConcreteFactoryPremios : IAbstractFactory
{
    public IAbstractProductA CreateBloqueLadrillo()
    {
        return new BloqueLadrilloMoneda();
    }

    public IAbstractProductB CreateBloqueInterrogacion()
    {
        return new BloqueInterrogacionEstrella();
    }
}

public interface IAbstractProductA
{
    string UsefulFunctionA();
}

class BloqueLadrilloSimple : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "Soy un ladrillo café simple, no hago nada.";
    }
}

class BloqueLadrilloMoneda : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "Me golpeaste y ha salido una moneda.";
    }
}

public interface IAbstractProductB
{
    string UsefulFunctionB();

   
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}

class BloqueInterrogacionTrampa : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Me golpeaste y salió un hongo morado.";
    }

    // The variant, Product B1, is only able to work correctly with the
    // variant, Product A1. Nevertheless, it accepts any instance of
    // AbstractProductA as an argument.
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"golpeaste un bloque de trampa y ocurrió lo siguiente: ({result})";
    }
}

class BloqueInterrogacionEstrella : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "Me golpeaste y salió una super estrella.";
    }

    // The variant, Product B2, is only able to work correctly with the
    // variant, Product A2. Nevertheless, it accepts any instance of
    // AbstractProductA as an argument.
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"Golpeaste el bloque de interrogación con estrella y ocurrió lo siguiente: ({result})";
    }
}

// The client code works with factories and products only through abstract
// types: AbstractFactory and AbstractProduct. This lets you pass any
// factory or product subclass to the client code without breaking it.
class Client
{
    public void Main()
    {
        // The client code can work with any concrete factory class.
        Console.WriteLine("Cliente: Quiero pedir bloques malos...");
        ClientMethod(new ConcreteFactoryMalo());
        Console.WriteLine();

        Console.WriteLine("Cliente: Quiero pedir bloques con premios...");
        ClientMethod(new ConcreteFactoryPremios());
    }

    public void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateBloqueLadrillo();
        var productB = factory.CreateBloqueInterrogacion();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}


class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
    }
}