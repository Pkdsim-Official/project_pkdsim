using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation
{
	public class SalazzleParentMom_IdleAnimatorController : MonoBehaviour 
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