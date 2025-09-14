using project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.IdleTo
{
	public class HAT_IdleTo : MonoBehaviour 
	{
		
		private HAT_IdleToRun Hatterene_IdleToRun;
		private HAT_IdleToWalk Hatterene_IdleToWalk;
		public void HAT_IdleToController()
		{
			Load_HATidleToRun();
			Load_HATidleToWalk();
		}
		private void Load_HATidleToRun()
		{
			Hatterene_IdleToRun.HAT_IdleToRunController();
		}
		private void Load_HATidleToWalk()
		{
			Hatterene_IdleToWalk.HAT_IdleToWalkController();
		}
	}
}