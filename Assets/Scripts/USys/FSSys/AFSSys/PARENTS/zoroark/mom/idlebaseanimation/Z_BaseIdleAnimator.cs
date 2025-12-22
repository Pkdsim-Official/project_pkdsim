using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.idlebaseanimation
{
	public class ZoroarkParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private ZParentMom_IdleStanding ZoroarkParentMomIdlestanding;
		
		private ZParentMom_IdleSitting ZoroarkParentMomIdlesitting;
		
		public void	ZParentMom_IdleAnimatorController()
		{
			ZParentMom_IdleStandingAnimatorController();
			ZParentMom_IdleSittingAnimatorController();
		}
		private void ZParentMom_IdleStandingAnimatorController()
		{
			ZoroarkParentMomIdlestanding.ZParentMom_IdleStandingController();
		}
		private void ZParentMom_IdleSittingAnimatorController()
		{
			ZoroarkParentMomIdlesitting.ZParentMom_IdleSittingController();
		}
	}
}