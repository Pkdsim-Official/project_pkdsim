using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo
{
	public class HATParentDad_SittingTo : MonoBehaviour 
	{
		private HATParentDad_SittingToStartWalking HatterenesittingToStartWalking;
		private HATParentDad_SittingToStanding HatterenesittingToStanding;
		public void HATParentDad_SittingToController()
		{
			HATParentDad_SittingToStartWalking();
			HATParentDad_SittingToStanding();
		}
		private void HATParentDad_SittingToStartWalking()
		{
			HatterenesittingToStartWalking.HATParentDad_SittingToStartWalkingController();
		}
		private void HATParentDad_SittingToStanding()
		{
			HatterenesittingToStanding.HATParentDad_SittingToStandingController();
		}
	}
}