using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryFraudulentActivitiesBadChecksCreditCardsImpersonation")]
public class CriminalCategoryFraudulentActivitiesBadChecksCreditCardsImpersonation
{
    [XmlElement("BadChecks")]
    public CriminalSubcategoryBadChecks BadChecks { get; set; }

    [XmlElement("CreditCards")]
    public CriminalSubcategoryCreditCards CreditCards { get; set; }

    [XmlElement("FalsePretensesSwindleConfidenceGame")]
    public CriminalSubcategoryFalsePretensesSwindleConfidenceGame FalsePretensesSwindleConfidenceGame { get; set; }

    [XmlElement("FraudulentActivities")]
    public CriminalSubcategoryFraudulentActivities FraudulentActivities { get; set; }

    [XmlElement("Impersonation")]
    public CriminalSubcategoryImpersonation Impersonation { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}