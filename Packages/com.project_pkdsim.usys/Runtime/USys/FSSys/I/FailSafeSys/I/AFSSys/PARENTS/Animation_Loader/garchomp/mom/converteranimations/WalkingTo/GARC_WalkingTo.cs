using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo
{
	public class GARCParentMom_WalkingTo : MonoBehaviour 
	{
		private GARCParentMom_WalkingToStanding GarchompWalkingToStanding;
		private GARCParentMom_WalkingToSitting GarchompWalkingToSitting;
		public void GARCParentMom_WalkingToController()
		{
			Load_GARCParentMom_WalkingToStanding();
			Load_GARCParentMom_WalkingToWSitting();
		}
		private void Load_GARCParentMom_WalkingToStanding()
		{
			GarchompWalkingToStanding.GARCParentMom_WalkingToStandingController();
		}
		private void Load_GARCParentMom_WalkingToWSitting()
		{
			GarchompWalkingToSitting.GARCParentMom_WalkingToSittingController();
		}
	}
}