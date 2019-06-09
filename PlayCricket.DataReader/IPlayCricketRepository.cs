using PlayCricket.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.DataRepository
{
    public interface IPlayCricketRepository
    {
        IEnumerable<PlayerType> PlayerTypes();
        IEnumerable<BowlingType> BowlingTypes();
    }
}
