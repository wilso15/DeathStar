using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSecretPlans;
using System.Media;


namespace DeathStar
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeathStar deathstar = new DeathStar();
            deathstar.BuildDeathStar();
            Console.Read();
            
        }
    }
}
