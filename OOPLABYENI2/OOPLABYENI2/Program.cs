using System;

//Bu bir Composition ornegi
class Motor
{
    public string Model { get; set; }
    public int BeygirGucu { get; set; }
    public Motor(string model, int beygirGucu)
    {
        Model = model;
        BeygirGucu = beygirGucu;
    }

    public void Calistir()
    {
        Console.WriteLine($"{Model} motor calisti.");
    }
}

class Araba
{
    public string Marka { get; set; }
    public Motor Motor;

    public Araba(string marka, string model, int beygirGucu)
    {
        Marka = marka;
        Motor = new Motor(model, beygirGucu);
    }

    public void Calistir()
    {
        Console.WriteLine($"{Marka}'nin motoru calistiriliyor");
        Motor.Calistir();
    }
}

class Program
{
    static void Main()
    {
        Araba araba = new Araba("Porsche", "Taycan", 536);
        araba.Calistir();
    }
}