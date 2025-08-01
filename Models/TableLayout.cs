using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TableLayout")]
public class TableLayout
{
    [XmlElement("Header1")]
    public HeaderInfo Header1 { get; set; }

    [XmlElement("Header2")]
    public HeaderInfo Header2 { get; set; }

    [XmlElement("Header3")]
    public HeaderInfo Header3 { get; set; }

    [XmlElement("Header4")]
    public HeaderInfo Header4 { get; set; }

    [XmlElement("Header5")]
    public HeaderInfo Header5 { get; set; }
}
