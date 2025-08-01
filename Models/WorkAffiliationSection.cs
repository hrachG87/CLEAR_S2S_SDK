using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorkAffiliationSection")]
public class WorkAffiliationSection
{
    [XmlElement("WorkAffiliationRecord")]
    public List<WorkAffiliationRecord> WorkAffiliationRecord { get; set; }

    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

}
}