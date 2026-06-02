using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo
{
		public class VespiquenParentMom_WalkingTo : MonoBehaviour 
	{
		private VEParentMom_WalkingToSitting VespiquenWalkingToSitting;
		private VEParentMom_WalkingToStanding VespiquenWalkingToStanding;
		public void VEParentMom_WalkingToController()
		{
			VEParentMom_WalkingToStartWalking();
			VEParentMom_WalkingToStanding();
		}
		private void VEParentMom_WalkingToStartWalking()
		{
			VespiquenWalkingToSitting.VEParentMom_WalkingToSittingController();
		}
		private void VEParentMom_WalkingToStanding()
		{
			VespiquenWalkingToStanding.VEParentMom_WalkingToStandingController();
		}
	}
}