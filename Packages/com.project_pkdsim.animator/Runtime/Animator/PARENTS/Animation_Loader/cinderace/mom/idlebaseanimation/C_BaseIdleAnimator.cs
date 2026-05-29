using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation
{
	public class CinderaceParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private C_IdleStanding C_Idlestanding;
		
		private C_IdleSitting C_Idlesitting;
		
		public void	C_IdleAnimatorController()
		{
			C_IdleStandingAnimatorController();
			C_IdleSittingAnimatorController();
		}
		private void C_IdleStandingAnimatorController()
		{
			C_Idlestanding.C_IdleStandingController();
		}
		private void C_IdleSittingAnimatorController()
		{
			C_Idlesitting.C_IdleSittingController();
		}
	}
}