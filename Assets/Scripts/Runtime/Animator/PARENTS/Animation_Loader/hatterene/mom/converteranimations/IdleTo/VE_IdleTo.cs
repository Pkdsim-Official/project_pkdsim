using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo
{
	public class HATParentMom_IdleTo : MonoBehaviour 
	{
		private HATParentMom_IdleToRun HattereneParentMomIdleToRun;
		private HATParentMom_IdleToWalk HattereneParentMomIdleToWalk;

		public void HATParentMom_IdleToController()
		{
			Load_HATParentMom_idleToRun();
			Load_HATParentMom_idleToWalk();
		}
		private void Load_HATParentMom_idleToRun()
		{
			HattereneParentMomIdleToRun.HATParentMom_IdleToRunController();
		}
		private void Load_HATParentMom_idleToWalk()
		{
			HattereneParentMomIdleToWalk.HATParentMom_IdleToWalkController();
		}
	}
}