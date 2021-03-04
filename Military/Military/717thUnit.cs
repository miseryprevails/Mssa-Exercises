using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    //parent class 
    class _717th
    {
        public string name;
        public string missionname;
        public int time;

        public void Identity(string name, string rank)
        {
            Console.WriteLine($"My name is {name} and my rank is : {rank}");
        }

        public void Mission(string missionname, int time)
        {
            this.missionname = missionname;
            this.time = time;
            Console.WriteLine($"My mission is{missionname} at {time}");
        }
        public virtual void MissionChange()
        {


            Console.WriteLine("Retreat to homebase");


        }
    }
}
