using PlayCricket.Data.Model;
using PlayCricket.DataReader;
using PlayCricket.Facade.interfaces;
using PlayCricket.Mappings;
using PlayCricket.Models;
using System.Collections.Generic;

namespace PlayCricket.Facade
{
    public class PlayCricketFacade : IPlayCricketFacade
    {
        private IPlayCricketReader _playCricketReader;
        public IPlayCricketReaderFactory PlayCricketReaderFactory { get; private set; }
        public PlayCricketFacade(IPlayCricketReaderFactory cricketReaderFactory)
        {
            PlayCricketReaderFactory = cricketReaderFactory;
        }
        public PlayCricketFacade(PlayCricketContext context) : this(new PlayCricketReaderFactory(context)) {}
        
        public IPlayCricketReader PlayCricketReader
        {
            get { return _playCricketReader ?? (_playCricketReader = PlayCricketReaderFactory.GetPlayCricketReader()); }
        }

        public IEnumerable<PlayerTypeModel> PlayerTypes() => PlayCricketReader.PlayerTypes().FromDatabaseModel();
    }
}
