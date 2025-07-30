using project_pkdsim.USys.AntiDateAndTimeSys.Modules.CheckForTimeManipulation;
using project_pkdsim.USys.AntiDateAndTimeSys.Modules.LoadPlayHistory;
using project_pkdsim.USys.AntiDateAndTimeSys.Modules.SaveCurrentPlayDate;
using UnityEngine;

namespace project_pkdsim.USys.AntiDateAndTimeSys.Modules
{
	public class ADATSysI : MonoBehaviour
	{
		private Load_Play_History LoadPlayHistory;
		private Save_Current_Play_Date SaveCurrentPlayDate;
		private Check_For_Time_Manipulation CheckForTimeManipulation;
		public void ADATSys_I() 
		{
			AntiDateAndTimeSysI();
		}
		private void AntiDateAndTimeSysI()
		{
			AntiDATSysI();
		}
		private void AntiDATSysI()
		{
			LoadPlayHistory.LoadPlayHistory();
			CheckForTimeManipulation.CheckForTimeManipulation();
			SaveCurrentPlayDate.SaveCurrentPlayDate();
		}
	}
}
