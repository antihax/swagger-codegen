/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Definition 2
    /// </summary>
    [DataContract]
    public partial class Definition2 :  IEquatable<Definition2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Definition2" /> class.
        /// </summary>
        /// <param name="Definition1">nested Definition1 array.</param>
        /// <param name="Id">Content Id for lookup.</param>
        public Definition2(List<Definition1> Definition1 = default(List<Definition1>), string Id = default(string))
        {
            this.Definition1 = Definition1;
            this.Id = Id;
        }
        
        /// <summary>
        /// nested Definition1 array
        /// </summary>
        /// <value>nested Definition1 array</value>
        [DataMember(Name="Definition1", EmitDefaultValue=false)]
        public List<Definition1> Definition1 { get; set; }
        /// <summary>
        /// Content Id for lookup
        /// </summary>
        /// <value>Content Id for lookup</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Definition2 {\n");
            sb.Append("  Definition1: ").Append(Definition1).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Definition2);
        }

        /// <summary>
        /// Returns true if Definition2 instances are equal
        /// </summary>
        /// <param name="other">Instance of Definition2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Definition2 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Definition1 == other.Definition1 ||
                    this.Definition1 != null &&
                    this.Definition1.SequenceEqual(other.Definition1)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Definition1 != null)
                    hash = hash * 59 + this.Definition1.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
