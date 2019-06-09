using PlayCricket.Data.Model;
using PlayCricket.DataRepository;
using PlayCricket.Facade.interfaces;
using PlayCricket.Mappings;
using PlayCricket.Models;
using System.Collections.Generic;

namespace PlayCricket.Facade
{
    public class PlayCricketFacade : IPlayCricketFacade
    {
        private IPlayCricketRepository _playCricketRepository;
        public IPlayCricketRepositoryFactory PlayCricketReaderFactory { get; private set; }
        public PlayCricketFacade(IPlayCricketRepositoryFactory cricketReaderFactory)
        {
            PlayCricketReaderFactory = cricketReaderFactory;
        }
        public PlayCricketFacade(PlayCricketContext context) : this(new PlayCricketRepositoryFactory(context)) {}
        
        public IPlayCricketRepository PlayCricketRepository
        {
            get { return _playCricketRepository ?? (_playCricketRepository = PlayCricketReaderFactory.GetPlayCricketRepository()); }
        }

        public IEnumerable<PlayerTypeModel> PlayerTypes() => PlayCricketRepository.PlayerTypes().FromDatabaseModel();

        public IEnumerable<BowlingTypeModel> BowlingTypes()
        {
            return PlayCricketRepository.BowlingTypes().FromDatabaseModel();
        }
    }
}
