using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Exercise_3.Errors
{
    public class ErrorManager
    {
        private List<SystemError> errors;
        public ErrorManager() 
        {
        }

        private void Initialize()
        {
            errors = new List<SystemError>(){
                new BrakeFailureError(),
                new EngineFailureError(),
                new TransmissionError()
            };
        }

        public void Run()
        {
            Initialize();
            errors.ForEach(error => Console.WriteLine(error.ErrorMessage()));
        }
    }
}
