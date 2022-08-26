
using PYP_Task_Four_Class_Abstract;

namespace PYP_Task_Four_Class_Model;
public class Flute : Instrument
{
    public int Tonehole { get; set; }
    public override string Sound()
    {
        return "Flute Sound";
    }
}
