using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.DataReader
{
    public interface IPlayCricketReader
    {
        IEnumerable<string> PlayerTypes();
    }
}
