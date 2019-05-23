﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.DataReader
{
    public class PlayCricketReaderFactory : IPlayCricketReaderFactory
    {
        private IPlayCricketReader _playCricketReader;
        public IPlayCricketReader GetPlayCricketReader()
        {
            return _playCricketReader;
        }

        public PlayCricketReaderFactory(IPlayCricketReader playCricketReader)
        {
            _playCricketReader = playCricketReader;
        }

        public PlayCricketReaderFactory()
        {
            _playCricketReader = new PlayCricketReader();
        }
    }
}
