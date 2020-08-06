using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_20_200_001.Model;

namespace Acumatica.Default_20_200_001.Api
{
	public class InvoiceApi : EntityAPI<Invoice>
	{
		public InvoiceApi(Configuration configuration) : base(configuration)
		{ }
	}
}