using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessContactRecordIndividualInfo")]
public class BusinessContactRecordIndividualInfo
{
    [XmlElement("Name")]
    public Name Name { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

}