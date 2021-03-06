using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CopyFromCompany : EntityAction<Contact>
	{
		public CopyFromCompany(Contact entity) : base(entity)
		{ }
		public CopyFromCompany() : base()
		{ }
	}
}
