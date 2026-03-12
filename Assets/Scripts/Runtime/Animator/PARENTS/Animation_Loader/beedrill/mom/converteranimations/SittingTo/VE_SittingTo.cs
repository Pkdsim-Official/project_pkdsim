using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.SittingTo
{
	public class BEParentMom_SittingTo : MonoBehaviour 
	{
		private BEParentMom_SittingToStartWalking BeedrillParentMomSittingToStartWalking;
		private BEParentMom_SittingToStanding BeedrillParentMomSittingToStanding;
		public void BEParentMom_SittingToController()
		{
			BEParentMom_SittingToStartWalking();
			BEParentMom_SittingToStanding();
		}
		private void BEParentMom_SittingToStartWalking()
		{
			BeedrillParentMomSittingToStartWalking.BEParentMom_SittingToStartWalkingController();
		}
		private void BEParentMom_SittingToStanding()
		{
			BeedrillParentMomSittingToStanding.BEParentMom_SittingToStandingController();
		}

	}
}