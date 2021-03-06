using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using VpNet.Interfaces;

namespace VpNet
{
    [XmlRoot("CellRangeQuery",Namespace=Global.XmlNsEvent)]
    public class CellRangeQueryCompletedArgs : EventArgs 
    {
        [XmlArray("VpObjects")]
        [XmlArrayItem("VpObject")]
        public List<IVpObject> VpObjects { get; set; }
        public CellRangeQueryCompletedArgs(){}

        public CellRangeQueryCompletedArgs(List<IVpObject> vpObjects)
        {
            VpObjects = vpObjects;
        }
    }
}