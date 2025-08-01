using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonDocumentAdvancedNamePersonSearch")]
public class PersonDocumentAdvancedNamePersonSearch
{
    [XmlElement("LastSecondaryNameSoundSimilarOption")]
    public bool LastSecondaryNameSoundSimilarOption { get; set; }

    [XmlElement("SecondaryLastNameOption")]
    public string SecondaryLastNameOption { get; set; }

    [XmlElement("FirstNameBeginsWithOption")]
    public bool FirstNameBeginsWithOption { get; set; }

    [XmlElement("FirstNameSoundSimilarOption")]
    public bool FirstNameSoundSimilarOption { get; set; }

    [XmlElement("FirstNameExactMatchOption")]
    public bool FirstNameExactMatchOption { get; set; }

}