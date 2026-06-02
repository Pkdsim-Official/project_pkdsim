using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo
{
	public class VespiquenParentMom_SittingTo : MonoBehaviour 
	{
		private VEParentMom_SittingToStartWalking VespiquensittingToStartWalking;
		private VEParentMom_SittingToStanding VespiquensittingToStanding;
		public void VEParentMom_SittingToController()
		{
			VEParentMom_SittingToStartWalking();
			VEParentMom_SittingToStanding();
		}
		private void VEParentMom_SittingToStartWalking()
		{
			VespiquensittingToStartWalking.VEParentMom_SittingToStartWalkingController();
		}
		private void VEParentMom_SittingToStanding()
		{
			VespiquensittingToStanding.VEParentMom_SittingToStandingController();
		}

	}
}