using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.idlebaseanimation
{
	public class Salazzle_IdleAnimatorController : MonoBehaviour 
	{
		private SA_IdleStanding SA_idlestanding;
		
		private SA_IdleSitting SA_idlesitting;
		
		public void	SA_IdleAnimatorController()
		{
			SA_IdleStandingAnimatorController();
			SA_IdleSittingAnimatorController();
		}
		private void SA_IdleStandingAnimatorController()
		{
			SA_idlestanding.SA_IdleStandingController();
		}
		private void SA_IdleSittingAnimatorController()
		{
			SA_idlesitting.SA_IdleSittingController();
		}
	}
}