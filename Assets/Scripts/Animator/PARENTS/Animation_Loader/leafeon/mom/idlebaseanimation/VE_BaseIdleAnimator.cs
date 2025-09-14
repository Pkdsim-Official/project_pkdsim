using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation
{
	public class LeafeonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LEParentMom_IdleStanding LEParentMom_Idlestanding;
		
		private LEParentMom_IdleSitting LEParentMom_Idlesitting;
		
		public void	LEParentMom_IdleAnimatorController()
		{
			LEParentMom_IdleStandingAnimatorController();
			LEParentMom_IdleSittingAnimatorController();
		}
		private void LEParentMom_IdleStandingAnimatorController()
		{
			LEParentMom_Idlestanding.LEParentMom_IdleStandingController();
		}
		private void LEParentMom_IdleSittingAnimatorController()
		{
			LEParentMom_Idlesitting.LEParentMom_IdleSittingController();
		}
	}
}