using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation
{
	public class EspeonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private ESParentMom_IdleStanding ESParentMom_Idlestanding;
		
		private ESParentMom_IdleSitting ESParentMom_Idlesitting;
		
		public void	ESParentMom_IdleAnimatorController()
		{
			ESParentMom_IdleStandingAnimatorController();
			ESParentMom_IdleSittingAnimatorController();
		}
		private void ESParentMom_IdleStandingAnimatorController()
		{
			ESParentMom_Idlestanding.ESParentMom_IdleStandingController();
		}
		private void ESParentMom_IdleSittingAnimatorController()
		{
			ESParentMom_Idlesitting.ESParentMom_IdleSittingController();
		}
	}
}