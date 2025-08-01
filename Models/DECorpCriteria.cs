using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpCriteria")]
public class DECorpCriteria
{
    [XmlElement("DECorpSearchCriteria")]
    public DECorpSearchCriteria DECorpSearchCriteria { get; set; }

}
}