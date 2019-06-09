
using PlayCricket.Models;
using System.Collections.Generic;

namespace PlayCricket.Facade.interfaces
{
    public interface IPlayCricketFacade
    {
        DataRepository.IPlayCricketRepositoryFactory PlayCricketReaderFactory { get; }

        IEnumerable<PlayerTypeModel> PlayerTypes();
    }
}
