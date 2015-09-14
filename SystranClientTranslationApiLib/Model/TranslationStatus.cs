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
  public class TranslationStatus {
    
    /* Error of the request */
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    
    /* Batch Identifier */
    [DataMember(Name="batchId", EmitDefaultValue=false)]
    public string BatchId { get; set; }

    
    /* Is the request cancelled */
    [DataMember(Name="cancelled", EmitDefaultValue=false)]
    public bool? Cancelled { get; set; }

    
    /* Creation time of the request (ms since the Epoch) */
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    public double? CreatedAt { get; set; }

    
    /* Description */
    [DataMember(Name="description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    /* Expiration time of the request (ms since the Epoch) */
    [DataMember(Name="expireAt", EmitDefaultValue=false)]
    public double? ExpireAt { get; set; }

    
    /* Completion time of the request (ms since the Epoch) */
    [DataMember(Name="finishedAt", EmitDefaultValue=false)]
    public double? FinishedAt { get; set; }

    
    /* Number of finished steps */
    [DataMember(Name="finishedSteps", EmitDefaultValue=false)]
    public int? FinishedSteps { get; set; }

    
    /* Status of the request */
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /* Number of steps to complete */
    [DataMember(Name="totalSteps", EmitDefaultValue=false)]
    public int? TotalSteps { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TranslationStatus {\n");
      
      sb.Append("  Error: ").Append(Error).Append("\n");
      
      sb.Append("  BatchId: ").Append(BatchId).Append("\n");
      
      sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
      
      sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
      
      sb.Append("  FinishedSteps: ").Append(FinishedSteps).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  TotalSteps: ").Append(TotalSteps).Append("\n");
      
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