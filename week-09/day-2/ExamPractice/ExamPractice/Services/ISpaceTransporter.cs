using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractice.Services
{
    interface ISpaceTransporter
    {
        void moveHere();
        void ToShip();
        void ToPlanet();
    }
}
