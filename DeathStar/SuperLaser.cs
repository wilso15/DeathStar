using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using DeathStar;

namespace TopSecretPlans
{
    public class SuperLaser : IActivate
    {
        int laserPowerLevel;
        int laserDamage;
        int chargerPack;


        public SuperLaser(int laserPowerLevel, int laserDamage, int chargerPack)
        {
            this.laserPowerLevel = laserPowerLevel;
            this.laserDamage = laserDamage;
            this.chargerPack = chargerPack;

        }

        private void FireLaser()
      
        {
            laserPowerLevel -= 5;
            Console.WriteLine("Pew, pew, pew! The Super Laser loses 5 units of energy.");

            SoundPlayer pew = new SoundPlayer("peww1.wav");
            pew.PlaySync();
            //put into a while loop

            if (laserPowerLevel <= 0)
            {
                Recharge();
            }
        }
        private void Recharge()
        {
            laserPowerLevel = chargerPack;
            Console.WriteLine("The Super Laser is recharging... aaaaaaaaaand has recharged.");
        }
        private void TripleShot()
        {
            laserPowerLevel -= 15;
            Console.WriteLine("PEW PEW PEW... PEW PEW PEW... PEW PEW PEW!!!");
            if (laserPowerLevel <= 0)
            {
                Recharge();
            }

        }

        public void activate()
        {
            FireLaser();
        }

        public void refresh()
        {
            Recharge();
        }
    }
}
