using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StateCaseLawRecord")]
public class StateCaseLawRecord
{
    [XmlElement("StateCaseLawInfo")]
    public List<CaseLawInfo> StateCaseLawInfo { get; set; }

}