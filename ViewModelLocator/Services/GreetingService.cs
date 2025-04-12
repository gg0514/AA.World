using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLocator.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting()
        {
            return "Welcome to ViewModelLocator, World!";
        }
    }    
}
