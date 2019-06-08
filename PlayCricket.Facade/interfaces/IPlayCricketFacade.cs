
using PlayCricket.Models;
using System.Collections.Generic;

namespace PlayCricket.Facade.interfaces
{
    public interface IPlayCricketFacade
    {
        IEnumerable<PlayerTypeModel> PlayerTypes();
    }
}
