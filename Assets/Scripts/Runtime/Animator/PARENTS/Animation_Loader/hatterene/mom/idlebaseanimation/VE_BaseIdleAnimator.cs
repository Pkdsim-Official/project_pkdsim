using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.idlebaseanimation
{
	public class HattereneParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private HATParentMom_IdleStanding HATParentMom_Idlestanding;
		
		private HATParentMom_IdleSitting HATParentMom_Idlesitting;
		
		public void	HATParentMom_IdleAnimatorController()
		{
			HATParentMom_IdleStandingAnimatorController();
			HATParentMom_IdleSittingAnimatorController();
		}
		private void HATParentMom_IdleStandingAnimatorController()
		{
			HATParentMom_Idlestanding.HATParentMom_IdleStandingController();
		}
		private void HATParentMom_IdleSittingAnimatorController()
		{
			HATParentMom_Idlesitting.HATParentMom_IdleSittingController();
		}
	}
}