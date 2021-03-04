using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    class JuniorEnlisted : _717th
    {
        public void JobFunctionsJunior(string job)
        {
            Console.WriteLine($"My job function is : {job} in support of mission requirements");
        }

        public override void MissionChange()
        {
            Console.WriteLine("Drive On");
        }
    }
}
