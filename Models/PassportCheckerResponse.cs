using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PassportCheckerResponse")]
public class PassportCheckerResponse
{
    [XmlElement("UserSuppliedPassportInfo")]
    public UserSuppliedPassportInfo UserSuppliedPassportInfo { get; set; }

    [XmlElement("MRZ")]
    public MRZ MRZ { get; set; }
}
