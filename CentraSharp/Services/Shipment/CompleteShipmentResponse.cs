using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class CompleteShipmentResponse
    {
        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("msg")] public string Msg { get; set; }

        [JsonProperty("order")] public int Order { get; set; }

        [JsonProperty("shipment")] public string Shipment { get; set; }
    }
}