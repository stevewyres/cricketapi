using PlayCricket.Data.Model;

namespace PlayCricket.DataReaderBase
{
    public class PlayCricketReaderBase
    {
        protected PlayCricketContext Context { get; private set; }
        protected PlayCricketReaderBase() : this(new PlayCricketContext())
        {
        }
        protected PlayCricketReaderBase(PlayCricketContext context)
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
