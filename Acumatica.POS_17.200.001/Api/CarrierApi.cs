using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public class CarrierApi : EntityAPI<Carrier>
	{
		public CarrierApi(Configuration configuration) : base(configuration)
		{ }
	}
}