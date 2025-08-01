using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NewsSearchCriteria")]
public class NewsSearchCriteria
{
    [XmlElement("Name")]
    public Name Name { get; set; }

    [XmlElement("AdditionalSubjects")]
    public Name AdditionalSubjects { get; set; }

    [XmlElement("RestrictByDate")]
    public DateOptions RestrictByDate { get; set; }

    [XmlElement("RestrictSearch")]
    public SearchOptions RestrictSearch { get; set; }

    [XmlElement("KeyWords")]
    public KeyWords KeyWords { get; set; }

    [XmlElement("PersonKeyTerms")]
    public PersonKeyTerms PersonKeyTerms { get; set; }

    [XmlElement("BusinessKeyTerms")]
    public BusinessKeyTerms BusinessKeyTerms { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

}
}