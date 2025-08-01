using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformLitigiousIndividualDetails")]
public class RiskInformLitigiousIndividualDetails
{
    [XmlElement("litigiousIndividualRecord")]
    public CriminalRecordInfo litigiousIndividualRecord { get; set; }

}
}