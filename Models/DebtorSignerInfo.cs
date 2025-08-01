using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DebtorSignerInfo")]
public class DebtorSignerInfo
{
    [XmlElement("Signer")]
    public string Signer { get; set; }

    [XmlElement("SignerBusiness")]
    public string SignerBusiness { get; set; }

    [XmlElement("SignerDescription")]
    public string SignerDescription { get; set; }

    [XmlElement("SignerTitle")]
    public string SignerTitle { get; set; }

}
}