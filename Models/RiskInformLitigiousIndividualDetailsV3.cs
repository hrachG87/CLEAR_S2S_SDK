using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformLitigiousIndividualDetailsV3")]
public class RiskInformLitigiousIndividualDetailsV3
{
    [XmlElement("litigiousIndividualRecord")]
    public CriminalRecordInfoV3 litigiousIndividualRecord { get; set; }

}
}