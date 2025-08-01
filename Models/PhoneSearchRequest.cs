using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PhoneSearchRequest")]
public class PhoneSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public PhoneUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public PhoneDatasources Datasources { get; set; }

    [XmlElement("PhonesDatasets")]
    public PhonesDatasets PhonesDatasets { get; set; }

}
}