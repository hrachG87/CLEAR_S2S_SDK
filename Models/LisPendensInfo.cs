using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LisPendensInfo")]
public class LisPendensInfo
{
    [XmlElement("AttorneyInfo")]
    public AttorneyInfo AttorneyInfo { get; set; }

    [XmlElement("Plaintiff")]
    public PersonName Plaintiff { get; set; }

    [XmlElement("TypeOfLisPendens")]
    public string TypeOfLisPendens { get; set; }

    [XmlElement("CaseFiling")]
    public PropertyDataCaseFiling CaseFiling { get; set; }

}