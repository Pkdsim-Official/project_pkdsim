using Project_Pkdsim.ANIMATOR.Parents.Blaziken.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.idlebaseanimation
{
	public class Blaziken_IdleAnimatorController : MonoBehaviour 
	{
		private BL_IdleStanding BL_Idlestanding;
		
		private BL_IdleSitting BL_Idlesitting;
		
		public void	BL_IdleAnimatorController()
		{
			BL_IdleStandingAnimatorController();
			BL_IdleSittingAnimatorController();
		}
		private void BL_IdleStandingAnimatorController()
		{
			BL_Idlestanding.BL_IdleStandingController();
		}
		private void BL_IdleSittingAnimatorController()
		{
			BL_Idlesitting.BL_IdleSittingController();
		}
	}
}