namespace birhDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa doguldugu gunu qeyd edin");
            int dGun = int.Parse(Console.ReadLine());
            Console.WriteLine("zehmet olmasa doguldugu ayi qeyd edin");
            int dAy = int.Parse(Console.ReadLine());
            Console.WriteLine("zehmet olmasa doguldugu ili qeyd edin");
            int dIl = int.Parse(Console.ReadLine());
            Console.WriteLine("zehmet olmasa bugunki gunu qeyd edin");
            int bGun = int.Parse(Console.ReadLine());
            Console.WriteLine("zehmet olmasa bugunki ayi qeyd edin");
            int bAy=int.Parse(Console.ReadLine());
            Console.WriteLine("zehmet olmasa bugunki ili qeyd edin");
            int bIl=int.Parse(Console.ReadLine());
            int Yash = 0;
            
            
            if (dIl > bIl)
            {
                Console.WriteLine("doguldugu tarixi veya bugunki tarixi sehv daxil etmisininz");
                
            }


            else if( dAy >bAy)
            {
                Yash = bIl - dIl-1;
                Console.WriteLine(Yash + " Yash");
            }
            else if(dAy < bAy)
            {
                Yash = bIl-dIl;
                Console.WriteLine(Yash + " Yash");
            }
            else if (dAy == bAy) 
            { 
                if(dGun> bGun)
                {
                   Yash = bIl-dIl-1;
                    Console.WriteLine(Yash + " Yash");
                }
                else
                {
                    Yash = bIl-dIl;
                    Console.WriteLine(Yash + " Yash");
                }
            }
            
        }

    }
}