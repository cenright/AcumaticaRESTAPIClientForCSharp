using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class CustomerPaymentMethodDetail : Entity
	{

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}