
using PYP_Task_Four_Class_Abstract;

namespace PYP_Task_Four_Class_Model;

public class Timpani : Instrument
{
    public int Caster { get; set; }
    public override string Sound()
    {
        return " Timpani";
    }
}
