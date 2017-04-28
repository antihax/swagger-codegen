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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// EnumTest
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class EnumTest :  IEquatable<EnumTest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnumStringEnum
        {
            
            /// <summary>
            /// Enum UPPER for "UPPER"
            /// </summary>
            [EnumMember(Value = "UPPER")]
            UPPER,
            
            /// <summary>
            /// Enum Lower for "lower"
            /// </summary>
            [EnumMember(Value = "lower")]
            Lower
        }

        /// <summary>
        /// Gets or Sets EnumInteger
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnumIntegerEnum
        {
            
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1,
            
            /// <summary>
            /// Enum NUMBER_MINUS_1 for -1
            /// </summary>
            [EnumMember(Value = "-1")]
            NUMBER_MINUS_1 = -1
        }

        /// <summary>
        /// Gets or Sets EnumNumber
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnumNumberEnum
        {
            
            /// <summary>
            /// Enum NUMBER_1_DOT_1 for 1.1
            /// </summary>
            [EnumMember(Value = "1.1")]
            NUMBER_1_DOT_1,
            
            /// <summary>
            /// Enum NUMBER_MINUS_1_DOT_2 for -1.2
            /// </summary>
            [EnumMember(Value = "-1.2")]
            NUMBER_MINUS_1_DOT_2
        }

        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [DataMember(Name="enum_string", EmitDefaultValue=false)]
        public EnumStringEnum? EnumString { get; set; }
        /// <summary>
        /// Gets or Sets EnumInteger
        /// </summary>
        [DataMember(Name="enum_integer", EmitDefaultValue=false)]
        public EnumIntegerEnum? EnumInteger { get; set; }
        /// <summary>
        /// Gets or Sets EnumNumber
        /// </summary>
        [DataMember(Name="enum_number", EmitDefaultValue=false)]
        public EnumNumberEnum? EnumNumber { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTest" /> class.
        /// </summary>
        /// <param name="EnumString">EnumString.</param>
        /// <param name="EnumInteger">EnumInteger.</param>
        /// <param name="EnumNumber">EnumNumber.</param>
        /// <param name="OuterEnum">OuterEnum.</param>
        public EnumTest(EnumStringEnum? EnumString = default(EnumStringEnum?), EnumIntegerEnum? EnumInteger = default(EnumIntegerEnum?), EnumNumberEnum? EnumNumber = default(EnumNumberEnum?), OuterEnum OuterEnum = default(OuterEnum))
        {
            this.EnumString = EnumString;
            this.EnumInteger = EnumInteger;
            this.EnumNumber = EnumNumber;
            this.OuterEnum = OuterEnum;
        }
        
        /// <summary>
        /// Gets or Sets OuterEnum
        /// </summary>
        [DataMember(Name="outerEnum", EmitDefaultValue=false)]
        public OuterEnum OuterEnum { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumTest {\n");
            sb.Append("  EnumString: ").Append(EnumString).Append("\n");
            sb.Append("  EnumInteger: ").Append(EnumInteger).Append("\n");
            sb.Append("  EnumNumber: ").Append(EnumNumber).Append("\n");
            sb.Append("  OuterEnum: ").Append(OuterEnum).Append("\n");
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
            return this.Equals(obj as EnumTest);
        }

        /// <summary>
        /// Returns true if EnumTest instances are equal
        /// </summary>
        /// <param name="other">Instance of EnumTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumTest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnumString == other.EnumString ||
                    this.EnumString != null &&
                    this.EnumString.Equals(other.EnumString)
                ) && 
                (
                    this.EnumInteger == other.EnumInteger ||
                    this.EnumInteger != null &&
                    this.EnumInteger.Equals(other.EnumInteger)
                ) && 
                (
                    this.EnumNumber == other.EnumNumber ||
                    this.EnumNumber != null &&
                    this.EnumNumber.Equals(other.EnumNumber)
                ) && 
                (
                    this.OuterEnum == other.OuterEnum ||
                    this.OuterEnum != null &&
                    this.OuterEnum.Equals(other.OuterEnum)
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
                if (this.EnumString != null)
                    hash = hash * 59 + this.EnumString.GetHashCode();
                if (this.EnumInteger != null)
                    hash = hash * 59 + this.EnumInteger.GetHashCode();
                if (this.EnumNumber != null)
                    hash = hash * 59 + this.EnumNumber.GetHashCode();
                if (this.OuterEnum != null)
                    hash = hash * 59 + this.OuterEnum.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
