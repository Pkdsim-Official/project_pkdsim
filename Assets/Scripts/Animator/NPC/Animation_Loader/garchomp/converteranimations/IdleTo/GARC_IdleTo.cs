using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo
{
	public class GARCIdleTo : MonoBehaviour 
	{
		private GARCIdleToRun GarchompIdleToRun;
		private GARCIdleToWalk GarchompIdleToWalk;
		public void GARCIdleToController()
		{
			Load_GARCIdleToRun();
			Load_GARCIdleToWalk();
		}
		private void Load_GARCIdleToRun()
		{
			GarchompIdleToRun.GARCIdleToRunController();
		}
		private void Load_GARCIdleToWalk()
		{
			GarchompIdleToWalk.GARCIdleToWalkController();
		}
	}
}