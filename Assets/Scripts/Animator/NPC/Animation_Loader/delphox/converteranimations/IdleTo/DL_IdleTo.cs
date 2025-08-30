using project_pkdsim.Models.ANIMATOR.NPC.Delphox.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Delphox.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Delphox.converteranimations.IdleTo
{
	public class DLIdleTo : MonoBehaviour 
	{
		private DLIdleToRun DelphoxIdleToRun;
		private DLIdleToWalk DelphoxIdleToWalk;
		public void DLIdleToController()
		{
			Load_DLidleToRun();
			Load_DLidleToWalk();
		}
		private void Load_DLidleToRun()
		{
			DelphoxIdleToRun.DLIdleToRunController();
		}
		private void Load_DLidleToWalk()
		{
			DelphoxIdleToWalk.DLIdleToWalkController();
		}
	}
}