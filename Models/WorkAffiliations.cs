using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorkAffiliations")]
public class WorkAffiliations
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

}
}