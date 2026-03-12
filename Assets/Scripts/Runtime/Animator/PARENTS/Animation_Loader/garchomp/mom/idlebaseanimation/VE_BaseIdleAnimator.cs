using Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation
{
	public class GarchompParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private GARCParentMom_IdleStanding GARCParentMom_IdleStanding;
		
		private GARCParentMom_IdleSitting GARCParentMom_IdleSitting;
		
		public void	GARCParentMom_IdleAnimatorController()
		{
			GARCParentMom_IdleStandingAnimatorController();
			GARCParentMom_IdleSittingAnimatorController();
		}
		private void GARCParentMom_IdleStandingAnimatorController()
		{
			GARCParentMom_IdleStanding.GARCParentMom_IdleStandingController();
        }
        private void GARCParentMom_IdleSittingAnimatorController()
		{
			GARCParentMom_IdleSitting.GARCParentMom_IdleSittingController();
		}
	}
}