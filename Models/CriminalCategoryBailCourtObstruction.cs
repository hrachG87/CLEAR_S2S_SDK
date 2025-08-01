using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryBailCourtObstruction")]
public class CriminalCategoryBailCourtObstruction
{
    [XmlElement("Bail")]
    public CriminalSubcategoryBail Bail { get; set; }

    [XmlElement("ContemptOfCourt")]
    public CriminalSubcategoryContemptOfCourt ContemptOfCourt { get; set; }

    [XmlElement("ObstructionOfJustice")]
    public CriminalSubcategoryObstructionOfJustice ObstructionOfJustice { get; set; }

    [XmlElement("ParoleProbationViolation")]
    public CriminalSubcategoryParoleProbationViolation ParoleProbationViolation { get; set; }

    [XmlElement("FailureToAppear")]
    public CriminalSubcategoryFailureToAppear FailureToAppear { get; set; }

    [XmlElement("ViolationOfCourtOrder")]
    public CriminalSubcategoryViolationOfCourtOrder ViolationOfCourtOrder { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}