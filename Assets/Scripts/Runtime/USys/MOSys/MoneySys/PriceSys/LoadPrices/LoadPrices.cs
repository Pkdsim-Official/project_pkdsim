using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules.LoadPrices.Modules;

namespace Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules.LoadPrices
{
	public class Load_Prices : Load_PricesI
	{
		public void LoadPrices()
		{
			LoadPriceI();
		}

		public void Load_Normal_Prices()
		{
			Load_NormalPrices();
		}
    }
}