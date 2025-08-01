using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleVesselInfo")]
public class VehicleVesselInfo
{
    [XmlElement("BoatLength")]
    public string BoatLength { get; set; }

    [XmlElement("FuelType")]
    public string FuelType { get; set; }

    [XmlElement("CallSign")]
    public string CallSign { get; set; }

    [XmlElement("CertificateofDocStatus")]
    public string CertificateofDocStatus { get; set; }

    [XmlElement("CertofDocExpirationDate")]
    public string CertofDocExpirationDate { get; set; }

    [XmlElement("CertofDocIssueDate")]
    public string CertofDocIssueDate { get; set; }

    [XmlElement("HullConfiguration")]
    public string HullConfiguration { get; set; }

    [XmlElement("HullNumber")]
    public string HullNumber { get; set; }

    [XmlElement("ItemMakeName")]
    public string ItemMakeName { get; set; }

    [XmlElement("MainHorsepowerAhead")]
    public string MainHorsepowerAhead { get; set; }

    [XmlElement("MainHorsepowerAstern")]
    public string MainHorsepowerAstern { get; set; }

    [XmlElement("OwnershipType")]
    public string OwnershipType { get; set; }

    [XmlElement("RegistrationEffectiveDate")]
    public string RegistrationEffectiveDate { get; set; }

    [XmlElement("RegistrationJurisdictionName")]
    public string RegistrationJurisdictionName { get; set; }

    [XmlElement("SelfPropelled")]
    public string SelfPropelled { get; set; }

    [XmlElement("ShipBuilder")]
    public string ShipBuilder { get; set; }

    [XmlElement("ShipYardBuilt")]
    public string ShipYardBuilt { get; set; }

    [XmlElement("TradeIndCoastwiseFisheriesProductsOnly")]
    public string TradeIndCoastwiseFisheriesProductsOnly { get; set; }

    [XmlElement("TradeIndCoastwiseUnrestricted")]
    public string TradeIndCoastwiseUnrestricted { get; set; }

    [XmlElement("TradeIndFishery")]
    public string TradeIndFishery { get; set; }

    [XmlElement("TradeIndGreatLakes")]
    public string TradeIndGreatLakes { get; set; }

    [XmlElement("TradeIndLimitedBowatersOnly")]
    public string TradeIndLimitedBowatersOnly { get; set; }

    [XmlElement("TradeIndLimitedCoastwiseOilSpillResponseOnly")]
    public string TradeIndLimitedCoastwiseOilSpillResponseOnly { get; set; }

    [XmlElement("TradeIndLimitedCoastwiseRestricedMARADWavier")]
    public string TradeIndLimitedCoastwiseRestricedMARADWavier { get; set; }

    [XmlElement("TradeIndLimitedCoastwiseUnderCharterToCitizen")]
    public string TradeIndLimitedCoastwiseUnderCharterToCitizen { get; set; }

    [XmlElement("TradeIndLimitedFisheryOnly")]
    public string TradeIndLimitedFisheryOnly { get; set; }

    [XmlElement("TradeIndLimitedGreatLakes")]
    public string TradeIndLimitedGreatLakes { get; set; }

    [XmlElement("TradeIndLimitedRegistryCrossBorderFinancing")]
    public string TradeIndLimitedRegistryCrossBorderFinancing { get; set; }

    [XmlElement("TradeIndLimitedRegistryNoForeignVoyage")]
    public string TradeIndLimitedRegistryNoForeignVoyage { get; set; }

    [XmlElement("TradeIndLimitedRegistryTradeWithCanadaOnly")]
    public string TradeIndLimitedRegistryTradeWithCanadaOnly { get; set; }

    [XmlElement("TradeIndRecreation")]
    public string TradeIndRecreation { get; set; }

    [XmlElement("TradeIndRegistry")]
    public string TradeIndRegistry { get; set; }

    [XmlElement("VesselBuildYear")]
    public string VesselBuildYear { get; set; }

    [XmlElement("VesselMeasureOrganizationName")]
    public string VesselMeasureOrganizationName { get; set; }

    [XmlElement("VesselName")]
    public string VesselName { get; set; }

    [XmlElement("VesselServiceType")]
    public string VesselServiceType { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("VesselHullIdentification")]
    public string VesselHullIdentification { get; set; }

    [XmlElement("VesselHullMaterial")]
    public string VesselHullMaterial { get; set; }

    [XmlElement("VesselPropulsion")]
    public string VesselPropulsion { get; set; }

    [XmlElement("VesselHullShape")]
    public string VesselHullShape { get; set; }

    [XmlElement("VesselRegistrationNum")]
    public string VesselRegistrationNum { get; set; }

    [XmlElement("IMOVesselNumber")]
    public string IMOVesselNumber { get; set; }
}
