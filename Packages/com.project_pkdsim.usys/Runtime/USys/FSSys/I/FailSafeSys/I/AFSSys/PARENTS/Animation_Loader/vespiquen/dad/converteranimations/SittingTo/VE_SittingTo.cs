using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo
{
	public class VEParentDad_SittingTo : MonoBehaviour 
	{
		private VEParentDad_SittingToStartWalking VespiquensittingToStartWalking;
		private VEParentDad_SittingToStanding VespiquensittingToStanding;
		public void VEParentDad_SittingToController()
		{
			VEParentDad_SittingToStartWalking();
			VEParentDad_SittingToStanding();
		}
		private void VEParentDad_SittingToStartWalking()
		{
			VespiquensittingToStartWalking.VEParentDad_SittingToStartWalkingController();
		}
		private void VEParentDad_SittingToStanding()
		{
			VespiquensittingToStanding.VEParentDad_SittingToStandingController();
		}

	}
}