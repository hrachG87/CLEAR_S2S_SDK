using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UCCDetail")]
public class UCCDetail
{
    [XmlElement("FileDate")]
    public string FileDate { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

    [XmlElement("Jurisdiction")]
    public string Jurisdiction { get; set; }

    [XmlElement("SecuredParty")]
    public string SecuredParty { get; set; }

    [XmlElement("Collaterals")]
    public Collaterals Collaterals { get; set; }

}
}