using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherFlags")]
public class OtherFlags
{
    [XmlElement("Aircraft")]
    public Aircraft Aircraft { get; set; }

    [XmlElement("Arrests")]
    public Arrests Arrests { get; set; }

    [XmlElement("ArrestWarrants")]
    public ArrestWarrants ArrestWarrants { get; set; }

    [XmlElement("AssociatesRelatives")]
    public AssociatesRelatives AssociatesRelatives { get; set; }

    [XmlElement("Bankruptcy")]
    public Bankruptcy Bankruptcy { get; set; }

    [XmlElement("CriminalSubCategories")]
    public CriminalSubCategories CriminalSubCategories { get; set; }

    [XmlElement("ExcludedPartiesListSystem")]
    public ExcludedPartiesListSystem ExcludedPartiesListSystem { get; set; }

    [XmlElement("FinancialCivilJudgments")]
    public FinancialCivilJudgments FinancialCivilJudgments { get; set; }

    [XmlElement("HealthcareInformation")]
    public HealthcareInformation HealthcareInformation { get; set; }

    [XmlElement("Lawsuits")]
    public Lawsuits Lawsuits { get; set; }

    [XmlElement("Liens")]
    public Liens Liens { get; set; }

    [XmlElement("LitigiousIndividual")]
    public LitigiousIndividual LitigiousIndividual { get; set; }

    [XmlElement("MultipleItems")]
    public MultipleItems MultipleItems { get; set; }

    [XmlElement("CorporateFilings")]
    public CorporateFilings CorporateFilings { get; set; }

    [XmlElement("RealProperty")]
    public RealProperty RealProperty { get; set; }

    [XmlElement("Sanctions")]
    public Sanctions Sanctions { get; set; }

    [XmlElement("UnlawfulDetainer")]
    public UnlawfulDetainer UnlawfulDetainer { get; set; }

    [XmlElement("Watercraft")]
    public Watercraft Watercraft { get; set; }

    [XmlElement("UCCFilings")]
    public PersonUCCFilings UCCFilings { get; set; }

}