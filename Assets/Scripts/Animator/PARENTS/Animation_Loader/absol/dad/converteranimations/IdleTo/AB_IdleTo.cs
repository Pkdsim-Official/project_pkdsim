using project_pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Dad.converteranimations.IdleTo
{
	public class AB_IdleTo : MonoBehaviour 
	{

		private AB_IdleToRun AbsolIdleToRun;
		private AB_IdleToWalk AbsolIdleToWalk;
		public void AB_IdleToController()
		{
			Load_AB_idleToRun();
			Load_AB_idleToWalk();
		}
		private void Load_AB_idleToRun()
		{
			AbsolIdleToRun.AB_IdleToRunController();
		}
		private void Load_AB_idleToWalk()
		{
			AbsolIdleToWalk.AB_IdleToWalkController();
		}
	}
}