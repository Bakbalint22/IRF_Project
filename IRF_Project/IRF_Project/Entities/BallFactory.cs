using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project.Entities
{
    public class BallFactory
    {
        public Ball CreateNew()
        {
            return new Ball();
        }
    }
}
