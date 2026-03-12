using Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.IdleTo
{
	public class AB_IdleTo : MonoBehaviour 
	{

		private AB_IdleToRun Absol_IdleToRun;
		private AB_IdleToWalk Absol_IdleToWalk;
		public void AB_IdleToController()
		{
			Load_AB_idleToRun();
			Load_AB_idleToWalk();
		}
		private void Load_AB_idleToRun()
		{
			Absol_IdleToRun.AB_IdleToRunController();
		}
		private void Load_AB_idleToWalk()
		{
			Absol_IdleToWalk.AB_IdleToWalkController();
		}
	}
}