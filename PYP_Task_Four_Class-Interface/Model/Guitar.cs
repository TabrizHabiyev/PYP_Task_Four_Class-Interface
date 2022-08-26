
using PYP_Task_Four_Class_Abstract;

namespace PYP_Task_Four_Class_Model;

public class Guitar : Instrument
{
    public bool IsElectro { get; set; }
    public override string Sound()
    {
        return "Guitar Sound";
    }
}
