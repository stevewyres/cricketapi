using PlayCricket.Data.Model;
using PlayCricket.DataRepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCricket.DataRepository
{
    public class PlayCricketRepository : PlayCricketRepositoryBase, IPlayCricketRepository
    {
        private PlayCricketContext PlayCricketContext { get; set; }
        public PlayCricketRepository(PlayCricketContext context)
           : base()
        {
            PlayCricketContext = context;
        }

        public IEnumerable<PlayerType> PlayerTypes()
        {
            using (var context = PlayCricketContext)
            {
                // context.Configuration.ProxyCreationEnabled = false;
                // context.Configuration.LazyLoadingEnabled = false;
                return context.PlayerType.Where(x => x.Id > 0).ToList();
            }
        }
    }
}
