using project_pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations.IdleTo
{
	public class T_IdleTo : MonoBehaviour 
	{
		private T_IdleToRun Tsareena_IdleToRun;
		private T_IdleToWalk Tsareena_IdleToWalk;
		public void T_IdleToController()
		{
			Load_T_idleToRun();
			Load_T_idleToWalk();
		}
		private void Load_T_idleToRun()
		{
			Tsareena_IdleToRun.T_IdleToRunController();
		}
		private void Load_T_idleToWalk()
		{
			Tsareena_IdleToWalk.T_IdleToWalkController();
		}
	}
}