using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalDataBusinessInfo")]
public class CriminalDataBusinessInfo
{
    [XmlElement("BusinessName")]
    public List<string> BusinessName { get; set; }

    [XmlElement("TaxID")]
    public string TaxID { get; set; }

    [XmlElement("FederalEmpID")]
    public string FederalEmpID { get; set; }

}
}