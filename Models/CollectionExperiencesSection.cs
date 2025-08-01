using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CollectionExperiencesSection")]
public class CollectionExperiencesSection
{
    [XmlElement("CollectionExperiencesRecord")]
    public List<CollectionExperiencesRecord> CollectionExperiencesRecord { get; set; }

}