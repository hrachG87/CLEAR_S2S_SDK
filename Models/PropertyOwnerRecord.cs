using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PropertyOwnerRecord")]
public class PropertyOwnerRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("PropertyTaxRecord")]
    public List<PropertyTaxRecord> PropertyTaxRecord { get; set; }

    [XmlElement("PropertDeedRecord")]
    public List<PropertyDeedRecord> PropertDeedRecord { get; set; }

    [XmlElement("ForeclosureRecord")]
    public List<ForeclosureRecord> ForeclosureRecord { get; set; }

}