using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    class SeniorEnlisted : _717th
    {
        public override void MissionChange()
        {
            Console.WriteLine("Drive On");
        }
        public void JobFunctionsSenior(string job)
        {
            Console.WriteLine($"My job function is : {job} in support of mission requirements");
        }
  
    }
}
