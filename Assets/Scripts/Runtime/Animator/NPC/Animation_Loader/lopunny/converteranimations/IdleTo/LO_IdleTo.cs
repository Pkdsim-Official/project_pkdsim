using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo
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