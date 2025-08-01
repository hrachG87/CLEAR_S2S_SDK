using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DriverLicensesDatasets")]
public class DriverLicensesDatasets
{
    [XmlElement("DriversLicenses")]
    public string DriversLicenses { get; set; }

    [XmlElement("UtilityListing")]
    public string UtilityListing { get; set; }

    [XmlElement("BankAccountHeader")]
    public string BankAccountHeader { get; set; }

}
}