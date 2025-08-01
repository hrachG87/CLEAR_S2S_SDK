using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorldcheckDocumentUserCriteria")]
public class WorldcheckDocumentUserCriteria
{
    [XmlElement("WorldCheckDocumentCriteria")]
    public WorldCheckDocumentCriteria WorldCheckDocumentCriteria { get; set; }

}