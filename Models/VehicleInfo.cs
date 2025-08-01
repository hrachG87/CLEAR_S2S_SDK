using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("VehicleInfo")]
public class VehicleInfo
{
    [XmlElement("BodyStyle")]
    public string BodyStyle { get; set; }

    [XmlElement("BodyType")]
    public string BodyType { get; set; }

    [XmlElement("DecalNumber")]
    public string DecalNumber { get; set; }

    [XmlElement("Make")]
    public string Make { get; set; }

    [XmlElement("MakeModelSeries")]
    public string MakeModelSeries { get; set; }

    [XmlElement("Model")]
    public string Model { get; set; }

    [XmlElement("PlateExpirationDate")]
    public string PlateExpirationDate { get; set; }

    [XmlElement("PlateNumber")]
    public string PlateNumber { get; set; }

    [XmlElement("PlateRegistrationDate")]
    public string PlateRegistrationDate { get; set; }

    [XmlElement("PlateRenewalDate")]
    public string PlateRenewalDate { get; set; }

    [XmlElement("PlateState")]
    public string PlateState { get; set; }

    [XmlElement("PlateType")]
    public string PlateType { get; set; }

    [XmlElement("PreviousPlateNumber")]
    public string PreviousPlateNumber { get; set; }

    [XmlElement("PreviousPlateState")]
    public string PreviousPlateState { get; set; }

    [XmlElement("Series")]
    public string Series { get; set; }

    [XmlElement("VehicleColor")]
    public string VehicleColor { get; set; }

    [XmlElement("VehiclePrimaryColor")]
    public string VehiclePrimaryColor { get; set; }

    [XmlElement("LengthMeasure")]
    public string LengthMeasure { get; set; }

    [XmlElement("ModelYear")]
    public string ModelYear { get; set; }

    [XmlElement("WeightMeasure")]
    public string WeightMeasure { get; set; }

    [XmlElement("AxleQuantity")]
    public string AxleQuantity { get; set; }

    [XmlElement("VehicleID")]
    public string VehicleID { get; set; }

    [XmlElement("AnyVehicleCylinders")]
    public string AnyVehicleCylinders { get; set; }

    [XmlElement("BasePrice")]
    public string BasePrice { get; set; }

    [XmlElement("Carburetion")]
    public string Carburetion { get; set; }

    [XmlElement("CountryOfOrigin")]
    public string CountryOfOrigin { get; set; }

    [XmlElement("CubicInchDisplacement")]
    public string CubicInchDisplacement { get; set; }

    [XmlElement("DriveTrain")]
    public string DriveTrain { get; set; }

    [XmlElement("FuelType")]
    public string FuelType { get; set; }

    [XmlElement("LeasedVehicleIndicator")]
    public string LeasedVehicleIndicator { get; set; }

    [XmlElement("PassengerTruckCylinders")]
    public string PassengerTruckCylinders { get; set; }

    [XmlElement("SafetyFeatures")]
    public string SafetyFeatures { get; set; }

    [XmlElement("ShippingWeight")]
    public string ShippingWeight { get; set; }

    [XmlElement("TireSize")]
    public string TireSize { get; set; }

    [XmlElement("TonRating")]
    public string TonRating { get; set; }

    [XmlElement("ValidVINIndicator")]
    public string ValidVINIndicator { get; set; }

    [XmlElement("WheelBase")]
    public string WheelBase { get; set; }

    [XmlElement("BrandTitleIndicator")]
    public string BrandTitleIndicator { get; set; }

}
}