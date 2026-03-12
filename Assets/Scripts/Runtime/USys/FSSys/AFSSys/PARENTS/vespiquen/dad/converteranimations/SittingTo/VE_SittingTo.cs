using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.SittingTo
{
	public class VEParentDad_SittingTo : MonoBehaviour 
	{
		private VEParentDad_SittingToStartWalking VEParentDadsittingToStartWalking;
		private VEParentDad_SittingToStanding VEParentDadsittingToStanding;
		public void VEParentDad_SittingToController()
		{
			VEParentDad_SittingToStartWalking();
			VEParentDad_SittingToStanding();
		}
		private void VEParentDad_SittingToStartWalking()
		{
			VEParentDadsittingToStartWalking.VEParentDad_SittingToStartWalkingController();
		}
		private void VEParentDad_SittingToStanding()
		{
			VEParentDadsittingToStanding.VEParentDad_SittingToStandingController();
		}

	}
}