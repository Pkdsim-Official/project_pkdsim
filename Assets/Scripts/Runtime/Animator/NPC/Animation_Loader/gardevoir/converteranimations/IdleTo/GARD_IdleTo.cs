using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.IdleTo
{
	public class GARD_IdleTo : MonoBehaviour 
	{
		private GARD_IdleToWalk Gardevoir_IdleToWalk;
		private GARD_IdleToRun Gardevoir_IdleToRun;
		public void GARD_IdleToController()
		{
			Load_GARD_idleToRun();
			Load_GARD_idleToWalk();
		}
		private void Load_GARD_idleToRun()
		{
			Gardevoir_IdleToRun.GARD_IdleToRunController();
		}
		private void Load_GARD_idleToWalk()
		{
			Gardevoir_IdleToWalk.GARD_IdleToWalkController();
		}
	}
}