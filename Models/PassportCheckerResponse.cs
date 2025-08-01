using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PassportCheckerResponse")]
public class PassportCheckerResponse
{
    [XmlElement("UserSuppliedPassportInfo")]
    public UserSuppliedPassportInfo UserSuppliedPassportInfo { get; set; }

    [XmlElement("MRZ")]
    public MRZ MRZ { get; set; }

}
}