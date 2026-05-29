using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.WalkingTo
{
		public class VEWalkingTo : MonoBehaviour 
	{
		private VEWalkingToSitting VespiquenWalkingToSitting;
		private VEWalkingToStanding VespiquenWalkingToStanding;
		public void VEWalkingToController()
		{
			VEWalkingToStartWalking();
			VEWalkingToStanding();
		}
		private void VEWalkingToStartWalking()
		{
			VespiquenWalkingToSitting.VEWalkingToSittingController();
		}
		private void VEWalkingToStanding()
		{
			VespiquenWalkingToStanding.VEWalkingToStandingController();
		}
	}
}