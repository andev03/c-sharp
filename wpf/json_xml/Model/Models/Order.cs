using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Model.Models;

public partial class Order
{
    public Order() {
    }

    public int OrderId {
        get; set;
    }

    [XmlElement("OrderDate")]
    public DateOnly? OrderDate {
        get; set;
    }

    [XmlElement("CompleDate")]
    public DateOnly? CompleDate {
        get; set;
    }

    public int? TotalDiscount {
        get; set;
    }

    public int? TotalOrderQuatity {
        get; set;
    }

    public string Description {
        get; set;
    }

    public decimal TotalPrice {
        get; set;
    }

    public string Note {
        get; set;
    }

    public bool? UserHaveStatus {
        get; set;
    }

    public bool? UserWantStatus { get; set; }
    [JsonIgnore]
    [XmlIgnore]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}