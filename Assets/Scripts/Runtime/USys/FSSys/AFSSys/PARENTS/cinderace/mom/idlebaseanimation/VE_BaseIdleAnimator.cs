using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation
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