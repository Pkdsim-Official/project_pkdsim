using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation
{
	public class DelphoxParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private DLParentMom_IdleStanding DLParentMom_Idlestanding;
		private DLParentMom_IdleSitting DLParentMom_Idlesitting;
		
		public void	DLParentMom_IdleAnimatorController()
		{
			DLParentMom_IdleStandingAnimatorController();
			DLParentMom_IdleSittingAnimatorController();
		}
		private void DLParentMom_IdleStandingAnimatorController()
		{
			DLParentMom_Idlestanding.DLParentMom_IdleStandingController();
		}
		private void DLParentMom_IdleSittingAnimatorController()
		{
			DLParentMom_Idlesitting.DLParentMom_IdleSittingController();
		}
	}
}