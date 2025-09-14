using project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo
{
	public class VEParentDad_WalkingTo : MonoBehaviour 
	{
		private VEParentDad_WalkingToSitting VespiquenParentDadWalkingToSitting;
		private VEParentDad_WalkingToStanding VespiquenParentDadWalkingToStanding;
		public void VEParentDad_WalkingToController()
		{
			VEParentDad_WalkingToStartWalking();
			VEParentDad_WalkingToStanding();
		}
		private void VEParentDad_WalkingToStartWalking()
		{
			VespiquenParentDadWalkingToSitting.VEParentDad_WalkingToSittingController();
		}
		private void VEParentDad_WalkingToStanding()
		{
			VespiquenParentDadWalkingToStanding.VEParentDad_WalkingToStandingController();
		}
	}
}