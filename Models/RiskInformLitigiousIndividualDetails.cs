using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformLitigiousIndividualDetails")]
public class RiskInformLitigiousIndividualDetails
{
    [XmlElement("litigiousIndividualRecord")]
    public CriminalRecordInfo litigiousIndividualRecord { get; set; }

}