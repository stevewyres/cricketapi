﻿using AutoMapper;
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
                            cfg.CreateMap<BowlingType, BowlingTypeModel>();
                            cfg.CreateMap<BowlingTypeModel, BowlingType>()
                                .ForMember(dest => dest.Player, opt => opt.Ignore());
                        });

                        Mapper = MapperConfig.CreateMapper();
                        _initialised = true;
                    }
                }
            }
        }

        public static PlayerType ToDatabaseModel(this PlayerTypeModel playerTypeModel)
        {
            EnsureInitialised();
            return Mapper.Map<PlayerTypeModel, PlayerType>(playerTypeModel);
        }

        public static IEnumerable<PlayerType> ToData(this IEnumerable<PlayerTypeModel> types)
        {
            EnsureInitialised();
            return Mapper.Map<IEnumerable<PlayerTypeModel>, IEnumerable<PlayerType>>(types);
        }

        public static PlayerTypeModel FromDatabaseModel(this PlayerType playerType)
        {
            EnsureInitialised();
            return Mapper.Map<PlayerType, PlayerTypeModel > (playerType);
        }

        public static IEnumerable<PlayerTypeModel> FromDatabaseModel(this IEnumerable<PlayerType> types)
        {
            EnsureInitialised();
            return Mapper.Map<IEnumerable<PlayerType>, IEnumerable<PlayerTypeModel>>(types);
        }

        public static BowlingType ToDatabaseModel(this BowlingTypeModel BowlingTypeModel)
        {
            EnsureInitialised();
            return Mapper.Map<BowlingTypeModel, BowlingType>(BowlingTypeModel);
        }

        public static IEnumerable<BowlingType> ToData(this IEnumerable<BowlingTypeModel> types)
        {
            EnsureInitialised();
            return Mapper.Map<IEnumerable<BowlingTypeModel>, IEnumerable<BowlingType>>(types);
        }

        public static BowlingTypeModel FromDatabaseModel(this BowlingType BowlingType)
        {
            EnsureInitialised();
            return Mapper.Map<BowlingType, BowlingTypeModel>(BowlingType);
        }

        public static IEnumerable<BowlingTypeModel> FromDatabaseModel(this IEnumerable<BowlingType> types)
        {
            EnsureInitialised();
            return Mapper.Map<IEnumerable<BowlingType>, IEnumerable<BowlingTypeModel>>(types);
        }
    }
}
