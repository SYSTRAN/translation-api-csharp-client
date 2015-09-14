using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.TranslationClientLib.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BatchStatus {
    
    /* Is the batch cancelled */
    [DataMember(Name="cancelled", EmitDefaultValue=false)]
    public bool? Cancelled { get; set; }

    
    /* Is the batch closed */
    [DataMember(Name="closed", EmitDefaultValue=false)]
    public bool? Closed { get; set; }

    
    /* Creation time of the batch (ms since the Epoch) */
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    public double? CreatedAt { get; set; }

    
    /* Expiration time of the batch (ms since the Epoch). Is null while there are pending requests */
    [DataMember(Name="expireAt", EmitDefaultValue=false)]
    public double? ExpireAt { get; set; }

    
    /* Completion time of the batch (ms since the Epoch) */
    [DataMember(Name="finishedAt", EmitDefaultValue=false)]
    public double? FinishedAt { get; set; }

    
    /* Array of requests */
    [DataMember(Name="requests", EmitDefaultValue=false)]
    public List<BatchRequest> Requests { get; set; }

    
    /* Error of the request */
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BatchStatus {\n");
      
      sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
      
      sb.Append("  Closed: ").Append(Closed).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
      
      sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
      
      sb.Append("  Requests: ").Append(Requests).Append("\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}