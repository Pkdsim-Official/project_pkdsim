using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.IdleTo
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