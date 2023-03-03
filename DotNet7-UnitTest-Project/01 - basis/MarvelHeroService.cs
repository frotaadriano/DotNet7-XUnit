using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet7_UnitTest_Project._01___basis
{
    public class MarvelHeroService
    {
        public bool CheckHeroIsAlive(string heroName)
        {
            if(heroName == "Thor")
            {
                return true;
            }
                 return false;
        }

        public int GetHeroAge(string heroName)
        {
            if (heroName == "Thor")
            {
                return 1500;
            }
            return 0;
        }

        public string GetHeroWeapon(string heroName)
        {
            if (heroName == "Thor")
            {
                return "Hammer";
            }
            return "IDK";
        }
    }
}
