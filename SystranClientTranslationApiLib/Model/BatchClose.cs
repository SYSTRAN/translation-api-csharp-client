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
  public class BatchClose {
    
    /* Result of the request */
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /* Error of the request */
    [DataMember(Name="error", EmitDefaultValue=false)]
    public string Error { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BatchClose {\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
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