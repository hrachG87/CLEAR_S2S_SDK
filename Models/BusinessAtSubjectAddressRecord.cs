using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessAtSubjectAddressRecord")]
public class BusinessAtSubjectAddressRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("DunBradstreetRecord")]
    public List<DunBradstreetRecord> DunBradstreetRecord { get; set; }

}