using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonUserTermsSection")]
public class PersonUserTermsSection
{
    [XmlElement("UserTermRecord")]
    public PersonUserTermRecord UserTermRecord { get; set; }

}
}