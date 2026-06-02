using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.converteranimations.SittingTo
{
	public class AB_SittingTo : MonoBehaviour 
	{
		private AB_SittingToStartWalking AbsolSittingToStartWalking;
		private AB_SittingToStanding AbsolSittingToStanding;
		public void AB_SittingToController()
		{
			AB_SittingToStartWalking();
			AB_SittingToStanding();
		}
		public void AB_SittingToStartWalking()
		{
			AbsolSittingToStartWalking.AB_SittingToStartWalkingController();
		}
		public void AB_SittingToStanding()
		{
			AbsolSittingToStanding.AB_SittingToStandingController();
		}

	}
}