using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseDatasources")]
public class LicenseDatasources
{
    [XmlElement("PublicRecordDriverLicenses")]
    public string PublicRecordDriverLicenses { get; set; }

    [XmlElement("PublicRecordLicenses")]
    public string PublicRecordLicenses { get; set; }

    [XmlElement("MarijuanaRelatedBusinesses")]
    public string MarijuanaRelatedBusinesses { get; set; }

    [XmlElement("NPIRecord")]
    public string NPIRecord { get; set; }

}
}