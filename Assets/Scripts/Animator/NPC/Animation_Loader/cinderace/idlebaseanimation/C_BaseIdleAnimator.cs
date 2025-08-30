using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.idlebaseanimation
{
	public class CinderaceIdleAnimatorController : MonoBehaviour 
	{
		private CIdleStanding Cidlestanding;
		
		private CIdleSitting Cidlesitting;
		
		public void	CIdleAnimatorController()
		{
			CIdleStandingAnimatorController();
			CIdleSittingAnimatorController();
		}
		private void CIdleStandingAnimatorController()
		{
			Cidlestanding.CIdleStandingController();
		}
		private void CIdleSittingAnimatorController()
		{
			Cidlesitting.CIdleSittingController();
		}
	}
}