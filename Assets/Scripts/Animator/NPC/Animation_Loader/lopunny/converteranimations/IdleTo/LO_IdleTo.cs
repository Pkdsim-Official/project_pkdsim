using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo
{
	public class LO_IdleTo : MonoBehaviour 
	{
		private LO_IdleToRun Lopunny_IdleToRun;
		private LO_IdleToWalk Lopunny_IdleToWalk;
		public void LO_IdleToController()
		{
			Load_LOidleToRun();
			Load_LOidleToWalk();
		}
		private void Load_LOidleToRun()
		{
			Lopunny_IdleToRun.LO_IdleToRunController();
		}
		private void Load_LOidleToWalk()
		{
			Lopunny_IdleToWalk.LO_IdleToWalkController();
		}
	}
}