using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation
{
	public class PheromosaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private PHParentMom_IdleStanding PHParentMom_Idlestanding;
		
		private PHParentMom_IdleSitting PHParentMom_Idlesitting;
		
		public void	PHParentMom_IdleAnimatorController()
		{
			PHParentMom_IdleStandingAnimatorController();
			PHParentMom_IdleSittingAnimatorController();
		}
		private void PHParentMom_IdleStandingAnimatorController()
		{
			PHParentMom_Idlestanding.PHParentMom_IdleStandingController();
		}
		private void PHParentMom_IdleSittingAnimatorController()
		{
			PHParentMom_Idlesitting.PHParentMom_IdleSittingController();
		}
	}
}