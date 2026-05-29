using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.PRICESys.ChangePrices.Modules.LoadPrices.Modules;

namespace project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.PRICESys.ChangePrices.Modules.LoadPrices
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