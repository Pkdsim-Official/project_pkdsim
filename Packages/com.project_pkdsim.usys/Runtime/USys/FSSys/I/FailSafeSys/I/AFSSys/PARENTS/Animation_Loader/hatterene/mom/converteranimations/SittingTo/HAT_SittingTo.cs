using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.SittingTo
{
	public class HATParentMom_SittingTo : MonoBehaviour 
	{
		private HATParentMom_SittingToStartWalking HatterenesittingToStartWalking;
		private HATParentMom_SittingToStanding HatterenesittingToStanding;
		public void HATParentMom_SittingToController()
		{
			HATParentMom_SittingToStartWalking();
			HATParentMom_SittingToStanding();
		}
		private void HATParentMom_SittingToStartWalking()
		{
			HatterenesittingToStartWalking.HATParentMom_SittingToStartWalkingController();
		}
		private void HATParentMom_SittingToStanding()
		{
			HatterenesittingToStanding.HATParentMom_SittingToStandingController();
		}
	}
}