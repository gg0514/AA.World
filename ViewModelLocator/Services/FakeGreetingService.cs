using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLocator.Services
{
    public class FakeGreetingService : IGreetingService
    {

        public string GetGreeting() => "[DesignTime] Hello from Fake Service!";
    }
}
