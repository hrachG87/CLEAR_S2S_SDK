using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyDocketRecord")]
public class CompanyDocketRecord
{
    [XmlElement("DocketInfo")]
    public List<DocketInfo> DocketInfo { get; set; }

}