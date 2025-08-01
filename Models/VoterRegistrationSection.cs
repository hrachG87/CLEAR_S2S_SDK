using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VoterRegistrationSection")]
public class VoterRegistrationSection
{
    [XmlElement("VoterRecord")]
    public List<VoterRecord> VoterRecord { get; set; }
}
