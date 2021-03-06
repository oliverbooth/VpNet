﻿using System;
using System.Xml.Serialization;
using VpNet.Interfaces;

namespace VpNet
{
    /// <summary>
    /// Default Event Arguments implementation mapping. You can define your own mappings when implementing VpNet.Abstract.BaseInstanceT
    /// </summary>
    [Serializable]
    [XmlRoot("OnQueryCellResult", Namespace = Global.XmlNsEvent)]
    public partial class QueryCellResultArgsT : Abstract.QueryCellResultArgs
    {
    
        public QueryCellResultArgsT(IVpObject vpObject) : base(vpObject)
        {
        }

        public QueryCellResultArgsT() { }
    }
}
