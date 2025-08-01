using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpSearchCriteria")]
public class DECorpSearchCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("DECorpFilingTypes")]
    public DECorpFilingTypes DECorpFilingTypes { get; set; }

}
}