using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Primarina.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Dad.idlebaseanimation
{
	public class PrimarinaParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private PRIdleStanding Primarinaidlestanding;
		
		private PRIdleSitting Primarinaidlesitting;
		
		public void	PR_IdleAnimatorController()
		{
			PRIdleStandingAnimatorController();
			PRIdleSittingAnimatorController();
		}
		private void PRIdleStandingAnimatorController()
		{
			Primarinaidlestanding.PRIdleStandingController();
		}
		private void PRIdleSittingAnimatorController()
		{
			Primarinaidlesitting.PRIdleSittingController();
		}
	}
}