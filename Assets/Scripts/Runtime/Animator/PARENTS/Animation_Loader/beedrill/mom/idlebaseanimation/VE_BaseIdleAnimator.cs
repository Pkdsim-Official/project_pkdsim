using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation
{
	public class BeedrillParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private BEParentMom_IdleStanding BEParentMom_Idlestanding;
		
		private BEParentMom_IdleSitting BEParentMom_Idlesitting;
		
		public void	BEParentMom_IdleAnimatorController()
		{
			BEParentMom_IdleStandingAnimatorController();
			BEParentMom_IdleSittingAnimatorController();
		}
		private void BEParentMom_IdleStandingAnimatorController()
		{
			BEParentMom_Idlestanding.BEParentMom_IdleStandingController();
		}
		private void BEParentMom_IdleSittingAnimatorController()
		{
			BEParentMom_Idlesitting.BEParentMom_IdleSittingController();
		}
	}
}