using PlayCricket.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.DataReader
{
    public interface IPlayCricketReader
    {
        IEnumerable<PlayerType> PlayerTypes();
    }
}
