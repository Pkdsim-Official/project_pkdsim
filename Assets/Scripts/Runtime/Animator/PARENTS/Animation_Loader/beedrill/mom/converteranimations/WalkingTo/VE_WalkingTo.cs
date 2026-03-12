using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.WalkingTo
{
		public class BEParentMom_WalkingTo : MonoBehaviour 
	{
		private BEParentMom_WalkingToSitting BeedrillParentMomWalkingToSitting;
		private BEParentMom_WalkingToStanding BeedrillParentMomWalkingToStanding;
		public void BEParentMom_WalkingToController()
		{
			BEParentMom_WalkingToStartWalking();
			BEParentMom_WalkingToStanding();
		}
		private void BEParentMom_WalkingToStartWalking()
		{
			BeedrillParentMomWalkingToSitting.BEParentMom_WalkingToSittingController();
		}
		private void BEParentMom_WalkingToStanding()
		{
			BeedrillParentMomWalkingToStanding.BEParentMom_WalkingToStandingController();
		}
	}
}