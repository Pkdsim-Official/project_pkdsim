using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo
{
	public class HATParentDad_IdleTo : MonoBehaviour 
	{
		
		private HATParentDad_IdleToRun HattereneIdleToRun;
		private HATParentDad_IdleToWalk HattereneIdleToWalk;
		public void HATParentDad_IdleToController()
		{
			Load_HATParentDad_idleToRun();
			Load_HATParentDad_idleToWalk();
		}
		private void Load_HATParentDad_idleToRun()
		{
			HattereneIdleToRun.HATParentDad_IdleToRunController();
		}
		private void Load_HATParentDad_idleToWalk()
		{
			HattereneIdleToWalk.HATParentDad_IdleToWalkController();
		}
	}
}