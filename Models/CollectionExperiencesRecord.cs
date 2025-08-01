using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CollectionExperiencesRecord")]
public class CollectionExperiencesRecord
{
    [XmlElement("CollectionExperiences")]
    public CollectionExperiences CollectionExperiences { get; set; }

}