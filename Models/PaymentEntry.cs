using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PaymentEntry")]
public class PaymentEntry
{
    [XmlElement("PaymentAmount")]
    public ValueAndLabelSet PaymentAmount { get; set; }

    [XmlElement("PaymentDate")]
    public string PaymentDate { get; set; }

    [XmlElement("PaymentDescription")]
    public string PaymentDescription { get; set; }

    [XmlElement("PaymentNote")]
    public ValueAndLabelSet PaymentNote { get; set; }

    [XmlElement("TypeOfPayment")]
    public ValueAndLabelSet TypeOfPayment { get; set; }

    [XmlElement("ItemReceiptID")]
    public string ItemReceiptID { get; set; }

}