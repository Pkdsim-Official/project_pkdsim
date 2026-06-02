using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo
{
	public class BRSittingTo : MonoBehaviour 
	{
		private BRSittingToStartWalking BraixensittingToStartWalking;
		private BRSittingToStanding BraixensittingToStanding;
		public void BRSittingToController()
		{
			BRSittingToStartWalking();
			BRSittingToStanding();
		}
		private void BRSittingToStartWalking()
		{
			BraixensittingToStartWalking.BRSittingToStartWalkingController();
		}
		private void BRSittingToStanding()
		{
			BraixensittingToStanding.BRSittingToStandingController();
		}

	}
}