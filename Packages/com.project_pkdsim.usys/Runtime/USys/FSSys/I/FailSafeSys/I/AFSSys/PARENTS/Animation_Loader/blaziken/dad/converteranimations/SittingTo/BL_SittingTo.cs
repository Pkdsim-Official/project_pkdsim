using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.converteranimations.SittingTo
{
	public class BL_SittingTo : MonoBehaviour 
	{
		private BL_SittingToStartWalking BlazikenSittingToStartWalking;
		private BL_SittingToStanding BlazikenSittingToStanding;
		public void BL_SittingToController()
		{
			BL_SittingToStartWalking();
			BL_SittingToStanding();
		}
		private void BL_SittingToStartWalking()
		{
			BlazikenSittingToStartWalking.BL_SittingToStartWalkingController();
		}
		private void BL_SittingToStanding()
		{
			BlazikenSittingToStanding.BL_SittingToStandingController();
		}

	}
}