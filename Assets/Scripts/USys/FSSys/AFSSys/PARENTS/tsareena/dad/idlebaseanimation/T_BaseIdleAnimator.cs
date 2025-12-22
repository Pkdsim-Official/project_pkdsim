using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation
{
	public class TsareenaParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private TParentDad_IdleStanding TParentDad_idlestanding;
		
		private TParentDad_IdleSitting TParentDad_idlesitting;
		
		public void	TParentDad_IdleAnimatorController()
		{
			TParentDad_IdleStandingAnimatorController();
			TParentDad_IdleSittingAnimatorController();
		}
		private void TParentDad_IdleStandingAnimatorController()
		{
			TParentDad_idlestanding.TParentDad_IdleStandingController();
		}
		private void TParentDad_IdleSittingAnimatorController()
		{
			TParentDad_idlesitting.TParentDad_IdleSittingController();
		}
	}
}