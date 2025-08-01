using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FederalCaseLawRecord")]
public class FederalCaseLawRecord
{
    [XmlElement("FederalCaseLawInfo")]
    public List<CaseLawInfo> FederalCaseLawInfo { get; set; }

}