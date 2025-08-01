using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TaxPropertyInfo")]
public class TaxPropertyInfo
{
    [XmlElement("BlockNumber")]
    public string BlockNumber { get; set; }

    [XmlElement("HomesteadExemption")]
    public string HomesteadExemption { get; set; }

    [XmlElement("LandSquareFt")]
    public string LandSquareFt { get; set; }

    [XmlElement("LocationInfluence")]
    public string LocationInfluence { get; set; }

    [XmlElement("LotDepth")]
    public string LotDepth { get; set; }

    [XmlElement("LotNumber")]
    public string LotNumber { get; set; }

    [XmlElement("LotWidth")]
    public string LotWidth { get; set; }

    [XmlElement("QuarterSection")]
    public string QuarterSection { get; set; }

    [XmlElement("Range")]
    public string Range { get; set; }

    [XmlElement("RecordingInfo")]
    public RecordingInfo RecordingInfo { get; set; }

    [XmlElement("Section")]
    public string Section { get; set; }

    [XmlElement("SubdivisionName")]
    public string SubdivisionName { get; set; }

    [XmlElement("SubdivisionPlatBook")]
    public string SubdivisionPlatBook { get; set; }

    [XmlElement("SubdivisionPlatPage")]
    public string SubdivisionPlatPage { get; set; }

    [XmlElement("SubdivisionTractNum")]
    public string SubdivisionTractNum { get; set; }

    [XmlElement("Township")]
    public string Township { get; set; }

    [XmlElement("ViewIndicator")]
    public string ViewIndicator { get; set; }

    [XmlElement("LocaleZoneName")]
    public string LocaleZoneName { get; set; }

    [XmlElement("RealEstateAcreageText")]
    public string RealEstateAcreageText { get; set; }

}