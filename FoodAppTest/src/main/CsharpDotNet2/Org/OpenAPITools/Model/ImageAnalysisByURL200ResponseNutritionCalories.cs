using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ImageAnalysisByURL200ResponseNutritionCalories {
    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public decimal? Value { get; set; }

    /// <summary>
    /// Gets or Sets Unit
    /// </summary>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public string Unit { get; set; }

    /// <summary>
    /// Gets or Sets ConfidenceRange95Percent
    /// </summary>
    [DataMember(Name="confidenceRange95Percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidenceRange95Percent")]
    public ImageAnalysisByURL200ResponseNutritionCaloriesConfidenceRange95Percent ConfidenceRange95Percent { get; set; }

    /// <summary>
    /// Gets or Sets StandardDeviation
    /// </summary>
    [DataMember(Name="standardDeviation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standardDeviation")]
    public decimal? StandardDeviation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImageAnalysisByURL200ResponseNutritionCalories {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  ConfidenceRange95Percent: ").Append(ConfidenceRange95Percent).Append("\n");
      sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
