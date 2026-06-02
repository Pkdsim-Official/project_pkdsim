using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo
{
	public class HAT_IdleTo : MonoBehaviour 
	{
		
		private HAT_IdleToRun Hatterene_IdleToRun;
		private HAT_IdleToWalk Hatterene_IdleToWalk;
		public void HAT_IdleToController()
		{
			Load_HAT_idleToRun();
			Load_HAT_idleToWalk();
		}
		private void Load_HAT_idleToRun()
		{
			Hatterene_IdleToRun.HAT_IdleToRunController();
		}
		private void Load_HAT_idleToWalk()
		{
			Hatterene_IdleToWalk.HAT_IdleToWalkController();
		}
	}
}