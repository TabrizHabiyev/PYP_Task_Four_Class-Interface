
using PYP_Task_Four_Class_Abstract;

namespace PYP_Task_Four_Class_Model;

public class Piano : Instrument
{
    public int KeyBoard { get; set; }
    public override string Sound()
    {
        return "Piano";
    }
}
