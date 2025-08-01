using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryChildPornography")]
public class CriminalCategoryChildPornography
{
    [XmlElement("ProvideMinorObsceneMaterial")]
    public CriminalChargetypes ProvideMinorObsceneMaterial { get; set; }

    [XmlElement("PossessChildPorn")]
    public CriminalChargetypes PossessChildPorn { get; set; }

    [XmlElement("ProduceChildPorn")]
    public CriminalChargetypes ProduceChildPorn { get; set; }

    [XmlElement("DistributeSellChildPorn")]
    public CriminalChargetypes DistributeSellChildPorn { get; set; }

    [XmlElement("ChildPornRemarks")]
    public CriminalChargetypes ChildPornRemarks { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
