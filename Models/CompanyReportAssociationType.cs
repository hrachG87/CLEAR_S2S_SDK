using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportAssociationType")]
public class CompanyReportAssociationType
{
    [XmlElement("TypeOfAssociation")]
    public List<string> TypeOfAssociation { get; set; }

}