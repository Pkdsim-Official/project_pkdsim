using project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Garchomp.converteranimations.IdleTo
{
	public class GARC_IdleTo : MonoBehaviour 
	{
		private GARC_IdleToRun Garchomp_IdleToRun;
		private GARC_IdleToWalk Garchomp_IdleToWalk;
		public void GARC_IdleToController()
		{
			Load_GARC_IdleToRun();
			Load_GARC_IdleToWalk();
		}
		private void Load_GARC_IdleToRun()
		{
			Garchomp_IdleToRun.GARC_IdleToRunController();
		}
		private void Load_GARC_IdleToWalk()
		{
			Garchomp_IdleToWalk.GARC_IdleToWalkController();
		}
	}
}