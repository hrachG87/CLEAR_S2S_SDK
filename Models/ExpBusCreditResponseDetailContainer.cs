using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ExpBusCreditResponseDetailContainer")]
public class ExpBusCreditResponseDetailContainer
{
    [XmlElement("ExpBusCreditResponseDetail")]
    public ExpBusCreditResponseDetail ExpBusCreditResponseDetail { get; set; }

}