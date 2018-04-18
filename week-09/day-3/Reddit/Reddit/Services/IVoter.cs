using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public interface IVoter
    {
        object Up(int postid, int userid);
        object Down(int postid, int userid);
    }
}
