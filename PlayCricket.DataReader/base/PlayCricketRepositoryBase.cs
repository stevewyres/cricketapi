using PlayCricket.Data.Model;

namespace PlayCricket.DataRepositoryBase
{
    public class PlayCricketRepositoryBase
    {
        protected PlayCricketContext Context { get; private set; }
        protected PlayCricketRepositoryBase() : this(new PlayCricketContext())
        {
        }
        protected PlayCricketRepositoryBase(PlayCricketContext context)
        {
            Context = context;
            //Context.Configuration.ProxyCreationEnabled = false;
            //Context.Configuration.LazyLoadingEnabled = false;
        }

        public void Dispose()
        {
            if (Context == null) return;
            Context.Dispose();
            Context = null;
        }
    }
}
