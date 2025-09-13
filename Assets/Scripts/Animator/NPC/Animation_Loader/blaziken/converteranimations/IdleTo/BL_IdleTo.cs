using project_pkdsim.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo
{
	public class BL_IdleTo : MonoBehaviour 
	{
		private BL_IdleToRun Blaziken_IdleToRun;
		private BL_IdleToWalk Blaziken_IdleToWalk;
		public void BL_IdleToController()
		{
			Load_BL_IdleToRun();
			Load_BL_IdleToWalk();
		}
		private void Load_BL_IdleToRun()
		{
			Blaziken_IdleToRun.BL_IdleToRunController();
		}
		private void Load_BL_IdleToWalk()
		{
			Blaziken_IdleToWalk.BL_IdleToWalkController();
		}
	}
}