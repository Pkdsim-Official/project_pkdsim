using project_pkdsim.ANIMATOR.NPC.Delphox.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Delphox.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Delphox.converteranimations.IdleTo
{
	public class DL_IdleTo : MonoBehaviour 
	{
		private DL_IdleToRun DelphoxIdleToRun;
		private DL_IdleToWalk DelphoxIdleToWalk;
		public void DL_IdleToController()
		{
			Load_DL_IdleToRun();
			Load_DL_IdleToWalk();
		}
		private void Load_DL_IdleToRun()
		{
			DelphoxIdleToRun.DL_IdleToRunController();
		}
		private void Load_DL_IdleToWalk()
		{
			DelphoxIdleToWalk.DL_IdleToWalkController();
		}
	}
}