using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonHusband")]
public class PersonHusband
{
    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PersonAddress")]
    public CommonDataAddress PersonAddress { get; set; }

    [XmlElement("PreviousMaritalInfo")]
    public PreviousMaritalInfo PreviousMaritalInfo { get; set; }

    [XmlElement("EducationInfo")]
    public PeopleDataEducationInfo EducationInfo { get; set; }

    [XmlElement("IncomeInfo")]
    public IncomeInfo IncomeInfo { get; set; }

}
}