using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonSearchUserCriteria")]
public class PersonSearchUserCriteria
{
    [XmlElement("PersonCriteria")]
    public PersonCriteria PersonCriteria { get; set; }

}
}