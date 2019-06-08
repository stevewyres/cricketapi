using PlayCricket.Data.Model;
using PlayCricket.DataReaderBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCricket.DataReader
{
    public class PlayCricketReader : PlayCricketReaderBase, IPlayCricketReader
    {
        private PlayCricketContext playCricketContext { get; set; }
        public PlayCricketReader(PlayCricketContext context)
           : base()
        {
            playCricketContext = context;
        }

        public IEnumerable<PlayerType> PlayerTypes()
        {
            using (var context = playCricketContext)
            {
                // context.Configuration.ProxyCreationEnabled = false;
                // context.Configuration.LazyLoadingEnabled = false;
                return context.PlayerType.Where(x => x.Id > 0).ToList();
            }
        }
    }
}
