using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class CreateTaskFromEmail : EntityAction<Email>
	{
		public CreateTaskFromEmail(Email entity) : base(entity)
		{ }
		public CreateTaskFromEmail() : base()
		{ }
	}
}