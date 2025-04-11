using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3
{
    public class BrakeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Bromsfel: Fordonet är osäkert att köra!";
        }
    }
}
