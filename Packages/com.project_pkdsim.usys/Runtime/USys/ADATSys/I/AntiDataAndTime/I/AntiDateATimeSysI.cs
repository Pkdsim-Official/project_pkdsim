using project_pkdsim.USys.ADATSys.Modules.AntiDateAndTimeSys.Modules.CheckForTimeManipulation;
using project_pkdsim.USys.ADATSys.Modules.AntiDateAndTimeSys.Modules.LoadPlayHistory;
using project_pkdsim.USys.ADATSys.Modules.AntiDateAndTimeSys.Modules.SaveCurrentPlayDate;
using UnityEngine;

namespace project_pkdsim.USys.ADATSys.Modules.AntiDateAndTimeSys
{
	public class AntiDateATimeSysI : MonoBehaviour
	{
		private Load_Play_History LoadPlayHistory;
		private Save_Current_Play_Date SaveCurrentPlayDate;
		private Check_For_Time_Manipulation CheckForTimeManipulation;

		private void AntiDateAndTimeSys_I()
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
