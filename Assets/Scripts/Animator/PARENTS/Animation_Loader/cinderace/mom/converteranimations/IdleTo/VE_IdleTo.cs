using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.IdleTo
{
	public class CParentMom_IdleTo : MonoBehaviour 
	{
		private CParentMom_IdleToRun CinderaceParentMomIdleToRun;
		private CParentMom_IdleToWalk CinderaceParentMomIdleToWalk;

		public void CParentMom_IdleToController()
		{
			Load_CParentMom_idleToRun();
			Load_CParentMom_idleToWalk();
		}
		private void Load_CParentMom_idleToRun()
		{
			CinderaceParentMomIdleToRun.CParentMom_IdleToRunController();
		}
		private void Load_CParentMom_idleToWalk()
		{
			CinderaceParentMomIdleToWalk.CParentMom_IdleToWalkController();
		}
	}
}