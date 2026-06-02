using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.idlebaseanimation
{
	public class HattereneParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private HATParentMom_IdleStanding HATParentMom_idlestanding;
		
		private HATParentMom_IdleSitting HATParentMom_idlesitting;
		
		public void	HATParentMom_IdleAnimatorController()
		{
			HATParentMom_IdleStandingAnimatorController();
			HATParentMom_IdleSittingAnimatorController();
		}
		private void HATParentMom_IdleStandingAnimatorController()
		{
			HATParentMom_idlestanding.HATParentMom_IdleStandingController();
		}
		private void HATParentMom_IdleSittingAnimatorController()
		{
			HATParentMom_idlesitting.HATParentMom_IdleSittingController();
		}
	}
}