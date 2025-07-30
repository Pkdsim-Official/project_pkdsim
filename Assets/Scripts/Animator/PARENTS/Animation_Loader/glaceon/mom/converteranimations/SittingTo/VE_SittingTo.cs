using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo
{
	public class VEParentMom_SittingTo : MonoBehaviour 
	{
		private VEParentMom_SittingToStartWalking GlaceonParentMomSittingToStartWalking;
		private VEParentMom_SittingToStanding GlaceonParentMomSittingToStanding;
		public void VEParentMom_SittingToController()
		{
			VEParentMom_SittingToStartWalking();
			VEParentMom_SittingToStanding();
		}
		private void VEParentMom_SittingToStartWalking()
		{
			GlaceonParentMomSittingToStartWalking.VEParentMom_SittingToStartWalkingController();
		}
		private void VEParentMom_SittingToStanding()
		{
			GlaceonParentMomSittingToStanding.VEParentMom_SittingToStandingController();
		}

	}
}