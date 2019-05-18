using PlayCricket.Data.Model;
using PlayCricket.DataReaderBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCricket.DataReader
{
    public class PlayCricketReader : PlayCricketReaderBase
    {
        public PlayCricketReader()
           : base()
        {
        }

        public IEnumerable<string> PlayerTypes()
        {
            using (var context = new PlayCricketContext())
            {
                // context.Configuration.ProxyCreationEnabled = false;
                // context.Configuration.LazyLoadingEnabled = false;
                return context.PlayerType.Where(x => x.Id > 0).Select(x => x.Description).ToList();
            }
        }
    }
}
