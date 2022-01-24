using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp56
{
    class Bonus : GameObject, IBonus
    {
        public Bonus(Coordinates coordinates, string icon) : base(coordinates, icon) { }
        public Bonus(string icon) : base(icon) { }

        public void Hello()
        {
            throw new NotImplementedException();
        }

        public void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
