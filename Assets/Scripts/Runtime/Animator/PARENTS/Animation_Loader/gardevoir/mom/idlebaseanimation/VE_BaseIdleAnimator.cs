using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation
{
	public class GardevoirParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private GARDParentMom_IdleStanding GARDParentMom_Idlestanding;
		
		private GARDParentMom_IdleSitting GARDParentMom_Idlesitting;
		
		public void	GARDParentMom_IdleAnimatorController()
		{
			GARDParentMom_IdleStandingAnimatorController();
			GARDParentMom_IdleSittingAnimatorController();
		}
		private void GARDParentMom_IdleStandingAnimatorController()
		{
			GARDParentMom_Idlestanding.GARDParentMom_IdleStandingController();
		}
		private void GARDParentMom_IdleSittingAnimatorController()
		{
			GARDParentMom_Idlesitting.GARDParentMom_IdleSittingController();
		}
	}
}