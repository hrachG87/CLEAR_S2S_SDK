using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PropertyInfo")]
public class PropertyInfo
{
    [XmlElement("AssessorParcelNumInfo")]
    public AssessorParcelNumInfo AssessorParcelNumInfo { get; set; }

    [XmlElement("BuildingSquareFt")]
    public string BuildingSquareFt { get; set; }

    [XmlElement("LandUse")]
    public string LandUse { get; set; }

    [XmlElement("MunicipalityCode")]
    public string MunicipalityCode { get; set; }

    [XmlElement("MunicipalityName")]
    public string MunicipalityName { get; set; }

    [XmlElement("PropertyUse")]
    public string PropertyUse { get; set; }

    [XmlElement("FIPSCodeInfo")]
    public FIPSCodeInfo FIPSCodeInfo { get; set; }

}
}