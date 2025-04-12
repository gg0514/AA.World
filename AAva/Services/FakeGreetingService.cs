using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAva.Services
{
    public class FakeGreetingService : IGreetingService
    {

        public string GetGreeting() => "[DesignTime] Hello from Fake Service!";
    }
}
