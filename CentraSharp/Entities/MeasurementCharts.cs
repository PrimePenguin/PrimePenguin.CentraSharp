using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class MeasurementCharts
    {
        /// <summary>
        /// Measurement
        /// </summary>
        [JsonProperty("measurement")]
        public Dictionary<int, Measurement> Measurement { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        [JsonProperty("errors")]
        public MeasurementErrors Errors { get; set; }
    }

    public class MeasurementErrors
    {
        /// <summary>
        /// measurementChart
        /// </summary>
        [JsonProperty("measurementChart")]
        public string MeasurementChart { get; set; }
    }

    public class Length
    {
        public string L { get; set; }
        public string M { get; set; }
        public string S { get; set; }
    }

    public class Rows
    {
        /// <summary>
        /// Length
        /// </summary>
        [JsonProperty("Length")]
        public Length Length { get; set; }
    }

    public class Measurement
    {
        /// <summary>
        /// name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// rows
        /// </summary>
        [JsonProperty("rows")]
        public Rows Rows { get; set; }

        /// <summary>
        /// ColumnNames
        /// </summary>
        [JsonProperty("columnNames")]
        public List<string> ColumnNames { get; set; }

        /// <summary>
        /// unit
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// RowNames
        /// </summary>
        [JsonProperty("rowNames")]
        public List<string> RowNames { get; set; }

        /// <summary>
        /// Measurement
        /// </summary>
        [JsonProperty("measurementChart")]
        public string MeasurementChart { get; set; }
    }
}