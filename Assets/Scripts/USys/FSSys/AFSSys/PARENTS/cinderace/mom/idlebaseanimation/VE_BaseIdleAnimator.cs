using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation
{
	public class CinderaceParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private CParentMom_IdleStanding CParentMom_Idlestanding;
		
		private CParentMom_IdleSitting CParentMom_Idlesitting;
		
		public void	CParentMom_IdleAnimatorController()
		{
			CParentMom_IdleStandingAnimatorController();
			CParentMom_IdleSittingAnimatorController();
		}
		private void CParentMom_IdleStandingAnimatorController()
		{
			CParentMom_Idlestanding.CParentMom_IdleStandingController();
		}
		private void CParentMom_IdleSittingAnimatorController()
		{
			CParentMom_Idlesitting.CParentMom_IdleSittingController();
		}
	}
}