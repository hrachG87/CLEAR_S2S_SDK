using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ValueAndLabelSet")]
public class ValueAndLabelSet
{
    [XmlElement("FieldDateLabel")]
    public string FieldDateLabel { get; set; }

    [XmlElement("FieldDateValue")]
    public string FieldDateValue { get; set; }

    [XmlElement("FieldStringLabel")]
    public string FieldStringLabel { get; set; }

    [XmlElement("FieldStringValue")]
    public string FieldStringValue { get; set; }
}
