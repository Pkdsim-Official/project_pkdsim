using Project_Pkdsim.ANIMATOR.Parents.Primarina.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Primarina.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Primarina.idlebaseanimation
{
	public class Primarina_IdleAnimatorController : MonoBehaviour 
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