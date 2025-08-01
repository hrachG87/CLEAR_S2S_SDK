using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessUserCriteria")]
public class BusinessUserCriteria
{
    [XmlElement("BusinessCriteria")]
    public BusinessCriteria BusinessCriteria { get; set; }

}
}