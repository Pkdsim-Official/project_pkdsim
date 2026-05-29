using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation
{
	public class Tsareena_IdleAnimatorController : MonoBehaviour 
	{
		private TIdleStanding Tidlestanding;
		
		private TIdleSitting Tidlesitting;
		
		public void	T_IdleAnimatorController()
		{
			TIdleStandingAnimatorController();
			TIdleSittingAnimatorController();
		}
		private void TIdleStandingAnimatorController()
		{
			Tidlestanding.TIdleStandingController();
		}
		private void TIdleSittingAnimatorController()
		{
			Tidlesitting.TIdleSittingController();
		}
	}
}