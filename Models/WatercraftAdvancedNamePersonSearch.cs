using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WatercraftAdvancedNamePersonSearch")]
public class WatercraftAdvancedNamePersonSearch
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
}