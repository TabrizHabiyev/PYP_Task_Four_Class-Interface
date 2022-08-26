using PYP_Task_Four_Class_Abstract;
using PYP_Task_Four_Class_Model;

Guitar guitar = new Guitar
{
    Model = "Guitar Example Model",
    Brand = "Guitar Exmaple Brand",
    Price = 22,
    IsElectro = true,
};

Piano piano = new Piano
{
    Model = "Piano Example Model",
    Brand = "Piano Exmaple Brand",
    Price = 38,
    KeyBoard = 40
};

Timpani timpani = new Timpani
{
    Model = "Timpani Example Model",
    Brand = "Timpani Exmaple Brand",
    Price = 800,
    Caster = 4,
};

Flute flute = new Flute
{
    Brand = "Flute Example Model",
    Model = "Flute Exmaple Brand",
    Tonehole = 560,
    Price = 439
};

Instrument[] instruments = {guitar,piano,timpani,flute};
PrintAllInstruments(instruments);

static void PrintAllInstruments(Instrument[] instrument)
{


    foreach (var item in instrument)
    {
        Console.WriteLine($"Enstruman : {item.GetType().Name} \n ----------------------------------");
        Console.WriteLine("Ozellikler : ");
        Console.WriteLine($"          Sesi:{item.Sound()}");
        item.GetType().GetProperties().ToList().ForEach(x => 
        Console.WriteLine($"          {x.Name} : {x.GetValue(item)}"));
        Console.WriteLine("----------------------------------");
    }
}