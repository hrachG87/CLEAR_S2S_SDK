using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExpBusCreditCriteria")]
public class ExpBusCreditCriteria
{
    [XmlElement("ExpBusCreditSearchCriteria")]
    public ExpBusCreditSearchCriteria ExpBusCreditSearchCriteria { get; set; }

}
}