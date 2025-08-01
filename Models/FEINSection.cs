using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FEINSection")]
public class FEINSection
{
    [XmlElement("FederalEmployerIDRecord")]
    public List<FederalEmployerIDRecord> FederalEmployerIDRecord { get; set; }

}
}