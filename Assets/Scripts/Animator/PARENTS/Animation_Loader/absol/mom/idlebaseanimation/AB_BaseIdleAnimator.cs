using project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation
{
	public class AbsolParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private ABParentMom_IdleStanding ABParentMom_Idlestanding;
		
		private ABParentMom_IdleSitting ABParentMom_Idlesitting;
		
		public void	ABParentMom_IdleAnimatorController()
		{
			ABParentMom_IdleStandingAnimatorController();
			ABParentMom_IdleSittingAnimatorController();
		}
		private void ABParentMom_IdleStandingAnimatorController()
		{
			ABParentMom_Idlestanding.ABParentMom_IdleStandingController();
		}
		private void ABParentMom_IdleSittingAnimatorController()
		{
			ABParentMom_Idlesitting.ABParentMom_IdleSittingController();
		}
	}
}