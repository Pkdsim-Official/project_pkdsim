using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.idlebaseanimation
{
	public class CinderaceParentDad_IdleAnimatorController : MonoBehaviour
	{
		private CParentDad_IdleStanding CParentDad_Idlestanding;

		private CParentDad_IdleSitting CParentDad_Idlesitting;

		public void CParentDad_IdleAnimatorController()
		{
			CParentDad_IdleStandingAnimatorController();
			CParentDad_IdleSittingAnimatorController();
		}
		private void CParentDad_IdleStandingAnimatorController()
		{
			CParentDad_Idlestanding.CParentDad_IdleStandingController();
		}
		private void CParentDad_IdleSittingAnimatorController()
		{
			CParentDad_Idlesitting.CParentDad_IdleSittingController();
		}
	}
}