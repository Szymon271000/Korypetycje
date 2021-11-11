using System;
using System.Text;


interface ILitery
{
    public string CreateAlfa();
    public void ShowAlfa();
}

interface ICyfry{
public string CreateNum();
public void ShowNum();
}




class AlfabetFactory
{

    private SystemFactory systemFactory;

    private ILitery letters;
    private ICyfry numbers;

    public AlfabetFactory(SystemFactory systemFactory)
    {
        this.systemFactory = systemFactory;
    }

    public void Generate()
    {
        numbers = systemFactory.CreateNum();
        letters = systemFactory.CreateAlfa();
        Console.WriteLine(letters.CreateAlfa() + " " + numbers.CreateNum());
    }

}


abstract class SystemFactory
{
    public abstract ILitery CreateAlfa();
    public abstract ICyfry CreateNum();
}


class CyrylicaLetters : ILitery
{
    private string letters = "абвгд";
    public string CreateAlfa()
    {
        return letters;
    }

    public void ShowAlfa()
    {
        Console.WriteLine(letters);
    }
}

class CyrylicaNumbers : ICyfry
{
    private string numbers = "1 2 3";
    public string CreateNum()
    {
        return numbers;
    }

    public void ShowNum()
    {
        Console.WriteLine(numbers);
    }
}


class CyrylicaFactory : SystemFactory
{
    public override ILitery CreateAlfa()
    {
        return new CyrylicaLetters();
    }

    public override ICyfry CreateNum()
    {
        return new CyrylicaNumbers();
    }
}





class GrekaLetters : ILitery
{
    private string letters = "αβγδε";
    public string CreateAlfa()
    {
        return letters;
    }

    public void ShowAlfa()
    {
        Console.WriteLine(letters);
    }
}

class GrekaNumbers : ICyfry
{
    private string numbers = "αʹ βʹ γʹ";
    public string CreateNum()
    {
        return numbers;
    }

    public void ShowNum()
    {
        Console.WriteLine(numbers);
    }
}


class GrekaFactory : SystemFactory
{
    public override ILitery CreateAlfa()
    {
        return new GrekaLetters();
    }

    public override ICyfry CreateNum()
    {
        return new GrekaNumbers();
    }
}





//
// ...
//
class LacinkaLetters : ILitery
{
    private string letters = "abcde";
    public string CreateAlfa()
    {
        return letters;
    }

    public void ShowAlfa()
    {
        Console.WriteLine(letters);
    }
}

class LacinkaNumbers : ICyfry
{
    private string numbers = "I II III";
    public string CreateNum()
    {
        return numbers;
    }

    public void ShowNum()
    {
        Console.WriteLine(numbers);
    }
}


class LacinkaFactory : SystemFactory
{
    public override ILitery CreateAlfa()
    {
        return new LacinkaLetters();
    }

    public override ICyfry CreateNum()
    {
        return new LacinkaNumbers();
    }
}

/*class GrekaNumbers : ICyfry
{
    string numbers;

    //
    //
    //  

    public string ShowNum()
    {
        return numbers;
    }
}


class LacinkaLetters : ILitery
{
    string letters;

    public LacinkaLetters()
    {
        letters = "abcde";
    }

    public string ShowAlfa()
    {
        return letters;
    }
    //
    //
    //
}


//
// ...
//*/


public class Application
{
    public static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        AlfabetFactory cyrilica_factory = new AlfabetFactory(new CyrylicaFactory());
        AlfabetFactory lacinka_factory = new AlfabetFactory(new LacinkaFactory());
        AlfabetFactory greka_factory = new AlfabetFactory(new GrekaFactory());

        
        //
        lacinka_factory.Generate();
        //
        cyrilica_factory.Generate();
        greka_factory.Generate();
        //
        //

        // 
        //3x show ;)
        //
    }
}

