﻿using VpNet.Interfaces;

namespace VpNet.Abstract
{
    public class BaseJoinEventArgs : TimedEventArgs, IJoinEventArgs
    {
        public int Id
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        public int UserId
        {
            get;set;
        }
    }
}
