using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonEducation")]
public class PersonEducation
{
    [XmlElement("Institution")]
    public string Institution { get; set; }

    [XmlElement("GraduationDate")]
    public string GraduationDate { get; set; }

}
}