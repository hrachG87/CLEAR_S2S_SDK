using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SingleRiskIndicators")]
public class SingleRiskIndicators
{
    [XmlElement("AssociatedWithMarijuanaBiz")]
    public RiskFlagInfo AssociatedWithMarijuanaBiz { get; set; }

    [XmlElement("MultipleDOBs")]
    public RiskFlagInfo MultipleDOBs { get; set; }

    [XmlElement("MultipleSSNs")]
    public RiskFlagInfo MultipleSSNs { get; set; }

    [XmlElement("MultipleAliases")]
    public RiskFlagInfo MultipleAliases { get; set; }

    [XmlElement("PepUSACrimeFinancial")]
    public RiskFlagInfo PepUSACrimeFinancial { get; set; }

    [XmlElement("PepUSACrimeNarcotics")]
    public RiskFlagInfo PepUSACrimeNarcotics { get; set; }

    [XmlElement("PepUSACrimeOrganized")]
    public RiskFlagInfo PepUSACrimeOrganized { get; set; }

    [XmlElement("PepUSACrimeOther")]
    public RiskFlagInfo PepUSACrimeOther { get; set; }

    [XmlElement("PepUSACrimeWar")]
    public RiskFlagInfo PepUSACrimeWar { get; set; }

    [XmlElement("PepUSADiplomat")]
    public RiskFlagInfo PepUSADiplomat { get; set; }

    [XmlElement("PepUSAIndividual")]
    public RiskFlagInfo PepUSAIndividual { get; set; }

    [XmlElement("PepUSALegal")]
    public RiskFlagInfo PepUSALegal { get; set; }

    [XmlElement("PepUSAMilitary")]
    public RiskFlagInfo PepUSAMilitary { get; set; }

    [XmlElement("PepUSAPoliticalIndividual")]
    public RiskFlagInfo PepUSAPoliticalIndividual { get; set; }

    [XmlElement("PepUSAReligion")]
    public RiskFlagInfo PepUSAReligion { get; set; }

    [XmlElement("PepUSACrimeTerror")]
    public RiskFlagInfo PepUSACrimeTerror { get; set; }

    [XmlElement("PepUSANonConvictionTerror")]
    public RiskFlagInfo PepUSANonConvictionTerror { get; set; }

    [XmlElement("PepIntlCrimeFinancial")]
    public RiskFlagInfo PepIntlCrimeFinancial { get; set; }

    [XmlElement("PepIntlCrimeNarcotics")]
    public RiskFlagInfo PepIntlCrimeNarcotics { get; set; }

    [XmlElement("PepIntlCrimeOrganized")]
    public RiskFlagInfo PepIntlCrimeOrganized { get; set; }

    [XmlElement("PepIntlCrimeOther")]
    public RiskFlagInfo PepIntlCrimeOther { get; set; }

    [XmlElement("PepIntlCrimeWar")]
    public RiskFlagInfo PepIntlCrimeWar { get; set; }

    [XmlElement("PepIntlDiplomat")]
    public RiskFlagInfo PepIntlDiplomat { get; set; }

    [XmlElement("PepIntlIndividual")]
    public RiskFlagInfo PepIntlIndividual { get; set; }

    [XmlElement("PepIntlLegal")]
    public RiskFlagInfo PepIntlLegal { get; set; }

    [XmlElement("PepIntlMilitary")]
    public RiskFlagInfo PepIntlMilitary { get; set; }

    [XmlElement("PepIntlPoliticalIndividual")]
    public RiskFlagInfo PepIntlPoliticalIndividual { get; set; }

    [XmlElement("PepIntlReligion")]
    public RiskFlagInfo PepIntlReligion { get; set; }

    [XmlElement("PepIntlCrimeTerror")]
    public RiskFlagInfo PepIntlCrimeTerror { get; set; }

    [XmlElement("PepIntlNonconvictionTerror")]
    public RiskFlagInfo PepIntlNonconvictionTerror { get; set; }

    [XmlElement("IsSOR")]
    public RiskFlagInfo IsSOR { get; set; }

    [XmlElement("RelativeWithSOR")]
    public RiskFlagInfo RelativeWithSOR { get; set; }

    [XmlElement("AssociateWithSOR")]
    public RiskFlagInfo AssociateWithSOR { get; set; }

    [XmlElement("CashPayHouse")]
    public RiskFlagInfo CashPayHouse { get; set; }

    [XmlElement("LienOnCar")]
    public RiskFlagInfo LienOnCar { get; set; }

    [XmlElement("AccessToFirearms")]
    public RiskFlagInfo AccessToFirearms { get; set; }

    [XmlElement("AccessToExplosives")]
    public RiskFlagInfo AccessToExplosives { get; set; }

    [XmlElement("AccessToWeapons")]
    public RiskFlagInfo AccessToWeapons { get; set; }

    [XmlElement("MultipleFailedBusinesses")]
    public RiskFlagInfo MultipleFailedBusinesses { get; set; }

    [XmlElement("ProfessionalLicense")]
    public RiskFlagInfo ProfessionalLicense { get; set; }

    [XmlElement("LicenseDiscipline")]
    public RiskFlagInfo LicenseDiscipline { get; set; }

    [XmlElement("MultipleCompanyAssets")]
    public RiskFlagInfo MultipleCompanyAssets { get; set; }

    [XmlElement("MultipleFEINs")]
    public BusinessRiskFlagInfo MultipleFEINs { get; set; }

    [XmlElement("CompanyIsInactive")]
    public BusinessRiskFlagInfo CompanyIsInactive { get; set; }

    [XmlElement("SuspectedOutOfBusiness")]
    public BusinessRiskFlagInfo SuspectedOutOfBusiness { get; set; }

    [XmlElement("WorldCheckBank")]
    public RiskFlagInfo WorldCheckBank { get; set; }

    [XmlElement("WorldCheckCorporate")]
    public RiskFlagInfo WorldCheckCorporate { get; set; }

    [XmlElement("WorldCheckCountry")]
    public RiskFlagInfo WorldCheckCountry { get; set; }

    [XmlElement("WorldCheckCrimeNarcotics")]
    public RiskFlagInfo WorldCheckCrimeNarcotics { get; set; }

    [XmlElement("WorldCheckCrimeOrganized")]
    public RiskFlagInfo WorldCheckCrimeOrganized { get; set; }

    [XmlElement("WorldCheckEmbargo")]
    public RiskFlagInfo WorldCheckEmbargo { get; set; }

    [XmlElement("WorldCheckEmbargoVessel")]
    public RiskFlagInfo WorldCheckEmbargoVessel { get; set; }

    [XmlElement("WorldCheckMilitary")]
    public RiskFlagInfo WorldCheckMilitary { get; set; }

    [XmlElement("WorldCheckOrganization")]
    public RiskFlagInfo WorldCheckOrganization { get; set; }

    [XmlElement("WorldCheckPoliticalParty")]
    public RiskFlagInfo WorldCheckPoliticalParty { get; set; }

    [XmlElement("WorldCheckPort")]
    public RiskFlagInfo WorldCheckPort { get; set; }

    [XmlElement("WorldCheckReligion")]
    public RiskFlagInfo WorldCheckReligion { get; set; }

    [XmlElement("WorldCheckNonconvictionTerror")]
    public RiskFlagInfo WorldCheckNonconvictionTerror { get; set; }

    [XmlElement("WorldCheckTradeUnion")]
    public RiskFlagInfo WorldCheckTradeUnion { get; set; }

    [XmlElement("WorldCheckVessel")]
    public RiskFlagInfo WorldCheckVessel { get; set; }

    [XmlElement("PepUSABank")]
    public RiskFlagInfo PepUSABank { get; set; }

    [XmlElement("PepUSACorporate")]
    public RiskFlagInfo PepUSACorporate { get; set; }

    [XmlElement("PepUSAOrganization")]
    public RiskFlagInfo PepUSAOrganization { get; set; }

    [XmlElement("PepUSAPoliticalParty")]
    public RiskFlagInfo PepUSAPoliticalParty { get; set; }

    [XmlElement("PepUSATradeUnion")]
    public RiskFlagInfo PepUSATradeUnion { get; set; }

    [XmlElement("PepIntlBank")]
    public RiskFlagInfo PepIntlBank { get; set; }

    [XmlElement("PepIntlCorporate")]
    public RiskFlagInfo PepIntlCorporate { get; set; }

    [XmlElement("PepIntlEmbargo")]
    public RiskFlagInfo PepIntlEmbargo { get; set; }

    [XmlElement("PepIntlOrganization")]
    public RiskFlagInfo PepIntlOrganization { get; set; }

    [XmlElement("PepIntlPoliticalParty")]
    public RiskFlagInfo PepIntlPoliticalParty { get; set; }

    [XmlElement("PepIntlPort")]
    public RiskFlagInfo PepIntlPort { get; set; }

    [XmlElement("PepIntlTradeUnion")]
    public RiskFlagInfo PepIntlTradeUnion { get; set; }

    [XmlElement("PepIntlVessel")]
    public RiskFlagInfo PepIntlVessel { get; set; }

    [XmlElement("GlobalSanctions")]
    public RiskFlagInfo GlobalSanctions { get; set; }

    [XmlElement("MilitaryID")]
    public MilitaryIdRiskFlagInfo MilitaryID { get; set; }

    [XmlElement("MoneyServiceBusiness")]
    public BusinessRiskFlagInfo MoneyServiceBusiness { get; set; }

    [XmlElement("MultipleForeclosuresAtCompanyAddress")]
    public BusinessRiskFlagInfo MultipleForeclosuresAtCompanyAddress { get; set; }

    [XmlElement("ImprovementValueOfProperty")]
    public BusinessRiskFlagInfo ImprovementValueOfProperty { get; set; }

    [XmlElement("OtherBusinessesLinkedToBusinessPhoneNumber")]
    public BusinessRiskFlagInfo OtherBusinessesLinkedToBusinessPhoneNumber { get; set; }

    [XmlElement("KeyNatureOfSuit")]
    public BusinessRiskFlagInfo KeyNatureOfSuit { get; set; }

    [XmlElement("PendingClassAction")]
    public BusinessRiskFlagInfo PendingClassAction { get; set; }

    [XmlElement("GoingConcern")]
    public BusinessRiskFlagInfo GoingConcern { get; set; }

    [XmlElement("EPLS")]
    public BusinessRiskFlagInfo EPLS { get; set; }

    [XmlElement("UnlawfulDetainerCivil")]
    public BusinessRiskFlagInfo UnlawfulDetainerCivil { get; set; }

    [XmlElement("UnlawfulDetainerJudge")]
    public BusinessRiskFlagInfo UnlawfulDetainerJudge { get; set; }

    [XmlElement("CashPaymentForBusinessProperty")]
    public BusinessRiskFlagInfo CashPaymentForBusinessProperty { get; set; }

    [XmlElement("BusinessOrLicenseDiscipline")]
    public BusinessRiskFlagInfo BusinessOrLicenseDiscipline { get; set; }

    [XmlElement("BusinessLessThanOneYear")]
    public BusinessRiskFlagInfo BusinessLessThanOneYear { get; set; }

    [XmlElement("CompnayNetWorth")]
    public BusinessRiskFlagInfo CompnayNetWorth { get; set; }

    [XmlElement("MarijuanaRelatedBusiness")]
    public BusinessRiskFlagInfo MarijuanaRelatedBusiness { get; set; }

    [XmlElement("BusinessLessThanXDays")]
    public BusinessRiskFlagInfo BusinessLessThanXDays { get; set; }

    [XmlElement("CompanyHasOverXEmployees")]
    public BusinessRiskFlagInfo CompanyHasOverXEmployees { get; set; }

    [XmlElement("CompanyIsInactiveHistorical")]
    public BusinessRiskFlagInfo CompanyIsInactiveHistorical { get; set; }

    [XmlElement("IndividualBusNotInPR")]
    public RiskFlagInfo IndividualBusNotInPR { get; set; }

    [XmlElement("AKAInput")]
    public RiskFlagInfo AKAInput { get; set; }

    [XmlElement("OFACRecord")]
    public RiskFlagInfo OFACRecord { get; set; }

    [XmlElement("SSNIsITIN")]
    public RiskFlagInfo SSNIsITIN { get; set; }

}