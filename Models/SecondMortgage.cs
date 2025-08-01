using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SecondMortgage")]
public class SecondMortgage
{
    [XmlElement("MortgageBasicInfo")]
    public MortgageBasicInfo MortgageBasicInfo { get; set; }

}