using Project_Pkdsim.USys.SkyboxSys.Modules.Day;
using Project_Pkdsim.USys.SkyboxSys.Modules.Night;
using UnityEngine;

namespace Project_Pkdsim.USys.SkyboxSys.Modules
{
	public class UnitySkyBoxSysI : MonoBehaviour 
	{
		private Skybox_Day Skybox_Day;
		private Skybox_Night Skybox_Night;
		public void SkyBox_LoadDay() 
		{
			Skybox_Day.Skybox_DayI();
		}
		
		public void SkyBox_LoadNight() 
		{
			Skybox_Night.Skybox_NightI();
		}
		public void SkyBoxSys_I() 
		{
			SkyBox_LoadDay();
			SkyBox_LoadNight();	
		}
	}
}