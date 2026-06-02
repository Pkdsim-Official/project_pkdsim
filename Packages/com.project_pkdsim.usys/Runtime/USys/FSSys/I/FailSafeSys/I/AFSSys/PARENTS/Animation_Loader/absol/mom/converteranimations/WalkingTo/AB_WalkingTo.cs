using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo
{
	public class ABParentMom_WalkingTo : MonoBehaviour 
	{
		private ABParentMom_WalkingToSitting AbsolWalkingToSitting;
		private ABParentMom_WalkingToStanding AbsolWalkingToStanding;
		public void ABParentMom_WalkingToController()
		{
			ABParentMom_WalkingToStartWalking();
			ABParentMom_WalkingToStanding();
		}
		public void ABParentMom_WalkingToStartWalking()
		{
			AbsolWalkingToSitting.ABParentMom_WalkingToSittingController();
		}
		public void ABParentMom_WalkingToStanding()
		{
			AbsolWalkingToStanding.ABParentMom_WalkingToStandingController();
		}
	}
}