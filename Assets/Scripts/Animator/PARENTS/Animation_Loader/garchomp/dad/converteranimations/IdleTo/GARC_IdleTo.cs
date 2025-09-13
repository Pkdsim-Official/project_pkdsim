using project_pkdsim.ANIMATOR.Parents.Garchomp.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Garchomp.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.converteranimations.IdleTo
{
	public class GARC_IdleTo : MonoBehaviour 
	{
		private GARC_IdleToRun GarchompIdleToRun;
		private GARC_IdleToWalk GarchompIdleToWalk;
		public void GARC_IdleToController()
		{
			Load_GARC_IdleToRun();
			Load_GARC_IdleToWalk();
		}
		private void Load_GARC_IdleToRun()
		{
			GarchompIdleToRun.GARC_IdleToRunController();
		}
		private void Load_GARC_IdleToWalk()
		{
			GarchompIdleToWalk.GARC_IdleToWalkController();
		}
	}
}