using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation
{
	public class BlazikenParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private BLParentMom_IdleStanding BLParentMom_Idlestanding;
		
		private BLParentMom_IdleSitting BLParentMom_Idlesitting;
		
		public void	BLParentMom_IdleAnimatorController()
		{
			BLParentMom_IdleStandingAnimatorController();
			BLParentMom_IdleSittingAnimatorController();
		}
		private void BLParentMom_IdleStandingAnimatorController()
		{
			BLParentMom_Idlestanding.BLParentMom_IdleStandingController();
		}
		private void BLParentMom_IdleSittingAnimatorController()
		{
			BLParentMom_Idlesitting.BLParentMom_IdleSittingController();
		}
	}
}