using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules.ChangePrices;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules.ChangePrices
{
	public class ChangePrice : MonoBehaviour
	{
		// Use this for initialization
		private ChangePricesI ChangePrices;
		public void ChangePricesI() 
		{
			ChangePrices.LoadPrice();
		}
	}
}