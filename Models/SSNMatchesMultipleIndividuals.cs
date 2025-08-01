using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SSNMatchesMultipleIndividuals")]
public class SSNMatchesMultipleIndividuals
{
    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("SSNMatchesMultipleIndividualsIndicator")]
    public string SSNMatchesMultipleIndividualsIndicator { get; set; }

    [XmlElement("SSNMatchesMultipleIndividualsDetails")]
    public List<SSNMatchesMultipleIndividualsDetails> SSNMatchesMultipleIndividualsDetails { get; set; }

}