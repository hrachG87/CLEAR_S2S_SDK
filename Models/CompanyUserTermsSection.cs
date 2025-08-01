using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyUserTermsSection")]
public class CompanyUserTermsSection
{
    [XmlElement("UserTermRecord")]
    public CompanyUserTermRecord UserTermRecord { get; set; }

}
}