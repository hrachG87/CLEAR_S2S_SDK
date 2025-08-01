using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("InquiriesRecord")]
public class InquiriesRecord
{
    [XmlElement("BusinessInquiries")]
    public BusinessInquiries BusinessInquiries { get; set; }
}
