using Project_Pkdsim.ANIMATOR.Npcs.Braixen.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Braixen.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Braixen.converteranimations.IdleTo
{
	public class BR_IdleTo : MonoBehaviour 
	{
		private BR_IdleToRun Braixen_IdleToRun;
		private BR_IdleToWalk Braixen_IdleToWalk;
		public void BR_IdleToController()
		{
			Load_BR_IdleToRun();
			Load_BR_IdleToWalk();
		}
		private void Load_BR_IdleToRun()
		{
			Braixen_IdleToRun.BR_IdleToRunController();
		}
		private void Load_BR_IdleToWalk()
		{
			Braixen_IdleToWalk.BR_IdleToWalkController();
		}
	}
}