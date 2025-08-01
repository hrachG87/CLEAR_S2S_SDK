using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TopResultAlertSubjects")]
public class TopResultAlertSubjects
{
    [XmlElement("TopResultAlertSubject")]
    public List<TopResultAlertSubject> TopResultAlertSubject { get; set; }

}
}