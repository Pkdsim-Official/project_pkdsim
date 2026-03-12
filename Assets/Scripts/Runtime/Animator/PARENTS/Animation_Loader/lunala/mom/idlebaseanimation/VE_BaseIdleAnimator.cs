using Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation
{
	public class LunalaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LUNAParentMom_IdleStanding LUNAParentMom_Idlestanding;
		
		private LUNAParentMom_IdleSitting LUNAParentMom_Idlesitting;
		
		public void	LUNAParentMom_IdleAnimatorController()
		{
			LUNAParentMom_IdleStandingAnimatorController();
			LUNAParentMom_IdleSittingAnimatorController();
		}
		private void LUNAParentMom_IdleStandingAnimatorController()
		{
			LUNAParentMom_Idlestanding.LUNAParentMom_IdleStandingController();
		}
		private void LUNAParentMom_IdleSittingAnimatorController()
		{
			LUNAParentMom_Idlesitting.LUNAParentMom_IdleSittingController();
		}
	}
}