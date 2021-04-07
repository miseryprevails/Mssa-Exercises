using System;

namespace Cesar_Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(CesarEncrypt("helloworld", 10));
        }


		public static string CesarEncrypt(string input, int shift)

		{
			//helloworld shift 3 == eaitlloia 
			
			
			char[] newstring = input.ToCharArray();
			for (int i = 0; i < newstring.Length; i++)
			{
				char letter = newstring[i];
				letter = (char)(letter - shift);

				  
				if (letter > 'z') 
                {
					letter = (char)(letter - 26);
                }

				else if (letter < 'a') 
                {
					letter = (char)(letter + 26);
                }
				newstring[i] = letter;
			}

			return new string(newstring);
	}



	}
}
