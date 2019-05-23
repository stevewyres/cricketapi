using PlayCricket.DataReader;
using PlayCricket.Facade.interfaces;
using System;
using System.Collections.Generic;

namespace PlayCricket.Facade
{
    public class PlayCricketFacade : IPlayCricketFacade
    {
        public IPlayCricketReaderFactory PlayCricketReaderFactory { get; private set; }
        public PlayCricketFacade(IPlayCricketReaderFactory cricketReaderFactory)
        {
            PlayCricketReaderFactory = cricketReaderFactory;
        }
        public PlayCricketFacade() : this(new PlayCricketReaderFactory())
        {

        }

        private IPlayCricketReader _playCricketReader;
        public IPlayCricketReader PlayCricketReader
        {
            get { return _playCricketReader ?? (_playCricketReader = PlayCricketReaderFactory.GetPlayCricketReader()); }
        }
        public IEnumerable<string> PlayerTypes()
        {
            return _playCricketReader.PlayerTypes() ;
        }
    }
}
