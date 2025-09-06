using project_pkdsim.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo
{
	public class C_IdleTo : MonoBehaviour 
	{
		private C_IdleToRun CinderaceIdleToRun;
		private C_IdleToWalk CinderaceIdleToWalk;
		public void C_IdleToController()
		{
			Load_C_idleToRun();
			Load_C_idleToWalk();
		}
		private void Load_C_idleToRun()
		{
			CinderaceIdleToRun.C_IdleToRunController();
		}
		private void Load_C_idleToWalk()
		{
			CinderaceIdleToWalk.C_IdleToWalkController();
		}
	}
}