using AutoMapper;
using PlayCricket.Data.Model;
using PlayCricket.Models;
using System.Collections.Generic;

namespace PlayCricket.Mappings
{
    public static class CricketDataMappings
    {
        private static object _lockObj = new object();
        private static bool _initialised = false;

        public static IMapper Mapper = null;
        // use this configuration to allow unit testing of config
        public static MapperConfiguration MapperConfig = null;
        public static void EnsureInitialised()
        {
            if (!_initialised)
            {
                lock (_lockObj)
                {
                    if (!_initialised)
                    {
                        MapperConfig = new MapperConfiguration(cfg => {
                            cfg.CreateMap<PlayerType, PlayerTypeModel>();
                            cfg.CreateMap<PlayerTypeModel, PlayerType>()
                                .ForMember(dest => dest.Player, opt => opt.Ignore());
                        });

                        Mapper = MapperConfig.CreateMapper();
                        _initialised = true;
                    }
                }
            }
        }

        public static PlayerType ToData(this PlayerTypeModel playerTypeModel)
        {
            EnsureInitialised();
            return Mapper.Map<PlayerTypeModel, PlayerType>(playerTypeModel);
        }

        public static IEnumerable<PlayerType> ToData(this IEnumerable<PlayerTypeModel> types)
        {
            EnsureInitialised();
            return Mapper.Map<IEnumerable<PlayerTypeModel>, IEnumerable<PlayerType>>(types);
        }
    }
}
