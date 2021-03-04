using System;

namespace Military
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            
             JuniorEnlisted junior1 = new JuniorEnlisted();
             junior1.Identity("Charles", "Private");
             junior1.JobFunctionsJunior("Rifleman");
            junior1.Mission(" Provide Fire Support" , 12);
            junior1.MissionChange();
            _717th base1 = new _717th();
            Console.WriteLine("Mission completed");
            base1.MissionChange();

            Console.WriteLine();

            SeniorEnlisted senior1 = new SeniorEnlisted();
            senior1.Identity("John", "SSG");
            senior1.JobFunctionsSenior("Rifleman");                    
            senior1.Mission(" kill the enemy" , 12);
            senior1.MissionChange();
            _717th base2 = new _717th();
            Console.WriteLine("Mission completed");
            base2.MissionChange();

        }
    }
}
