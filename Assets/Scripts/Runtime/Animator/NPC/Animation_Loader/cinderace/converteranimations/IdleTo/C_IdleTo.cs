using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations.IdleTo
{
	public class C_IdleTo : MonoBehaviour 
	{
		private C_IdleToRun Cinderace_IdleToRun;
		private C_IdleToWalk Cinderace_IdleToWalk;
		public void C_IdleToController()
		{
			Load_C_idleToRun();
			Load_C_idleToWalk();
		}
		private void Load_C_idleToRun()
		{
			Cinderace_IdleToRun.C_IdleToRunController();
		}
		private void Load_C_idleToWalk()
		{
			Cinderace_IdleToWalk.C_IdleToWalkController();
		}
	}
}