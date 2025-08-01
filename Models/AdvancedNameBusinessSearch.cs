using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdvancedNameBusinessSearch")]
public class AdvancedNameBusinessSearch
{
    [XmlElement("LastSecondaryNameSoundSimilarOption")]
    public bool LastSecondaryNameSoundSimilarOption { get; set; }

    [XmlElement("SecondaryLastNameOption")]
    public string SecondaryLastNameOption { get; set; }

    [XmlElement("FirstNameSoundSimilarOption")]
    public bool FirstNameSoundSimilarOption { get; set; }

    [XmlElement("FirstNameVariationsOption")]
    public bool FirstNameVariationsOption { get; set; }
}
