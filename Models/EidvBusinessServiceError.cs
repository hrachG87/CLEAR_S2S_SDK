using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvBusinessServiceError")]
public class EidvBusinessServiceError
{
    [XmlElement("ErrorType")]
    public string ErrorType { get; set; }

    [XmlElement("ErrorMsg")]
    public string ErrorMsg { get; set; }
}
