using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation
{
	public class VaporeonParentDad_IdleAnimatorController : MonoBehaviour
	{
		private VPParentDad_IdleStanding VPParentDad_idlestanding;

		private VPParentDad_IdleSitting VPParentDad_idlesitting;
		
		public void	VPParentDad_IdleAnimatorController()
		{
			VPParentDad_IdleStandingAnimatorController();
			VPParentDad_IdleSittingAnimatorController();
		}
		private void VPParentDad_IdleStandingAnimatorController()
		{
			VPParentDad_idlestanding.VPParentDad_IdleStandingController();
		}
		private void VPParentDad_IdleSittingAnimatorController()
		{
			VPParentDad_idlesitting.VPParentDad_IdleSittingController();
		}
	}
}