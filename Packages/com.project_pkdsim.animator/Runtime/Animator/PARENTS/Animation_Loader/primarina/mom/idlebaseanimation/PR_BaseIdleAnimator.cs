using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation
{
	public class PrimarinaParentMom_IdleAnimatorController : MonoBehaviour 
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