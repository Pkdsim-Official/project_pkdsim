using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo
{
		public class VEParentDad_WalkingTo : MonoBehaviour 
	{
		private VEParentDad_WalkingToSitting VespiquenWalkingToSitting;
		private VEParentDad_WalkingToStanding VespiquenWalkingToStanding;
		public void VEParentDad_WalkingToController()
		{
			VEParentDad_WalkingToStartWalking();
			VEParentDad_WalkingToStanding();
		}
		private void VEParentDad_WalkingToStartWalking()
		{
			VespiquenWalkingToSitting.VEParentDad_WalkingToSittingController();
		}
		private void VEParentDad_WalkingToStanding()
		{
			VespiquenWalkingToStanding.VEParentDad_WalkingToStandingController();
		}
	}
}