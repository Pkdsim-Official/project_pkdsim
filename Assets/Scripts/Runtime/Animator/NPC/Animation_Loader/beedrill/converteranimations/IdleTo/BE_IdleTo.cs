using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Beedrill.converteranimations.IdleTo
{
	public class BE_IdleTo : MonoBehaviour 
	{
		private BE_IdleToRun Beedrill_IdleToRun;
		private BE_IdleToWalk Beedrill_IdleToWalk;

		public void BE_IdleToController()
		{
			Load_BE_idleToRun();
			Load_BE_idleToWalk();
		}
		private void Load_BE_idleToRun()
		{
			Beedrill_IdleToRun.BE_IdleToRunController();
		}
		private void Load_BE_idleToWalk()
		{
			Beedrill_IdleToWalk.BE_IdleToWalkController();
		}
	}
}