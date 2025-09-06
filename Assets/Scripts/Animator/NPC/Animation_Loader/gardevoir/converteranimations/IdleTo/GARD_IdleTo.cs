using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo
{
	public class GARD_IdleTo : MonoBehaviour 
	{
		private GARD_IdleToWalk GardevoirIdleToWalk;
		private GARD_IdleToRun GardevoirIdleToRun;
		public void GARD_IdleToController()
		{
			Load_GARD_idleToRun();
			Load_GARD_idleToWalk();
		}
		private void Load_GARD_idleToRun()
		{
			GardevoirIdleToRun.GARD_IdleToRunController();
		}
		private void Load_GARD_idleToWalk()
		{
			GardevoirIdleToWalk.GARD_IdleToWalkController();
		}
	}
}