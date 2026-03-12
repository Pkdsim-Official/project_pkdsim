using Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo
{
	public class VEParentMom_SittingTo : MonoBehaviour 
	{
		private VEParentMom_SittingToStartWalking VespiquenParentMomSittingToStartWalking;
		private VEParentMom_SittingToStanding VespiquenParentMomSittingToStanding;
		public void VEParentMom_SittingToController()
		{
			VEParentMom_SittingToStartWalking();
			VEParentMom_SittingToStanding();
		}
		private void VEParentMom_SittingToStartWalking()
		{
			VespiquenParentMomSittingToStartWalking.VEParentMom_SittingToStartWalkingController();
		}
		private void VEParentMom_SittingToStanding()
		{
			VespiquenParentMomSittingToStanding.VEParentMom_SittingToStandingController();
		}

	}
}