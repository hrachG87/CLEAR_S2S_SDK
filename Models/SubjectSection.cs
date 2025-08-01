using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SubjectSection")]
public class SubjectSection
{
    [XmlElement("SubjectRecord")]
    public List<SubjectRecord> SubjectRecord { get; set; }

}
}