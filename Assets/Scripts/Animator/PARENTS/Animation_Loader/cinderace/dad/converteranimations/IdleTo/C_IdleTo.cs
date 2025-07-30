using project_pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations.IdleTo
{
	public class CParentDad_IdleTo : MonoBehaviour 
	{
		private CParentDad_IdleToRun CinderaceIdleToRun;
		private CParentDad_IdleToWalk CinderaceIdleToWalk;
		public void CParentDad_IdleToController()
		{
			Load_CParentDad_idleToRun();
			Load_CParentDad_idleToWalk();
		}
		private void Load_CParentDad_idleToRun()
		{
			CinderaceIdleToRun.CParentDad_IdleToRunController();
		}
		private void Load_CParentDad_idleToWalk()
		{
			CinderaceIdleToWalk.CParentDad_IdleToWalkController();
		}
	}
}