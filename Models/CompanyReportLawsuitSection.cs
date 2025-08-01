using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportLawsuitSection")]
public class CompanyReportLawsuitSection
{
    [XmlElement("LowerCourtLawsuitRecord")]
    public List<LowerCourtLawsuitRecord> LowerCourtLawsuitRecord { get; set; }

    [XmlElement("LawsuitRecord")]
    public List<LawsuitRecord> LawsuitRecord { get; set; }

}