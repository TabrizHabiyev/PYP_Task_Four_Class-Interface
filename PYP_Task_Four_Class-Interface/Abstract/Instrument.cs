namespace PYP_Task_Four_Class_Abstract;

public  abstract class Instrument
{
    public string Model { get; set; } = null!;
    public double Price { get; set; }
    public string Brand { get; set; } = null!;
    public abstract string Sound();
}
