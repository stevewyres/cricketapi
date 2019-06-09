using PlayCricket.Data.Model;

namespace PlayCricket.DataRepository
{
    public class PlayCricketRepositoryFactory : IPlayCricketRepositoryFactory
    {
        private IPlayCricketRepository _playCricketReader;
        public IPlayCricketRepository GetPlayCricketRepository()
        {
            return _playCricketReader;
        }

        public PlayCricketRepositoryFactory(IPlayCricketRepository playCricketReader)
        {
            _playCricketReader = playCricketReader;
        }

        public PlayCricketRepositoryFactory(PlayCricketContext context)
        {
            _playCricketReader = new PlayCricketRepository(context);
        }
    }
}
