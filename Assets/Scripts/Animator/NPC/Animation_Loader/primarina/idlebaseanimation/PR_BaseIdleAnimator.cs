using project_pkdsim.ANIMATOR.Npcs.Primarina.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Npcs.Primarina.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Primarina.idlebaseanimation
{
	public class Primarina_IdleAnimatorController : MonoBehaviour 
	{
		private PRIdleStanding Primarinaidlestanding;
		
		private PR_IdleSitting Primarinaidlesitting;
		
		public void	PR_IdleAnimatorController()
		{
			PRIdleStandingAnimatorController();
			PR_IdleSittingAnimatorController();
		}
		private void PRIdleStandingAnimatorController()
		{
			Primarinaidlestanding.PRIdleStandingController();
		}
		private void PR_IdleSittingAnimatorController()
		{
			Primarinaidlesitting.PR_IdleSittingController();
		}
	}
}