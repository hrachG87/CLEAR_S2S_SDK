using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ListInfo")]
public class ListInfo
{
    [XmlElement("BusinessName")]
    public List<string> BusinessName { get; set; }

    [XmlElement("PhoneNumber")]
    public List<string> PhoneNumber { get; set; }

    [XmlElement("FileState")]
    public List<string> FileState { get; set; }

    [XmlElement("FEIN")]
    public List<string> FEIN { get; set; }

    [XmlElement("NPINumber")]
    public List<string> NPINumber { get; set; }

    [XmlElement("DUNSNumber")]
    public List<string> DUNSNumber { get; set; }

}