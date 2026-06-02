using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.converteranimations.WalkingTo
{
	public class AB_WalkingTo : MonoBehaviour 
	{
		private AB_WalkingToSitting AbsolWalkingToSitting;
		private AB_WalkingToStanding AbsolWalkingToStanding;
		public void AB_WalkingToController()
		{
			AB_WalkingToStartWalking();
			AB_WalkingToStanding();
		}
		public void AB_WalkingToStartWalking()
		{
			AbsolWalkingToSitting.AB_WalkingToSittingController();
		}
		public void AB_WalkingToStanding()
		{
			AbsolWalkingToStanding.AB_WalkingToStandingController();
		}
	}
}