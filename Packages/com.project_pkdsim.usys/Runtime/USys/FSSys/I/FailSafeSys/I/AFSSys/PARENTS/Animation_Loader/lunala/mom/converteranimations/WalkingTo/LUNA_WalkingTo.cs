using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo
{
	public class LUNAParentMom_WalkingTo : MonoBehaviour 
	{
		private LUNAParentMom_WalkingToSitting LunalaWalkingToSitting;
		private LUNAParentMom_WalkingToStanding LunalaWalkingToStanding;
		public void LUNAParentMom_WalkingToController()
		{
			LUNAParentMom_WalkingToSitting();
			LUNAParentMom_WalkingToStanding();
		}
		private void LUNAParentMom_WalkingToSitting()
		{
			LunalaWalkingToSitting.LUNAParentMom_WalkingToSittingController();
		}
		private void LUNAParentMom_WalkingToStanding()
		{
			LunalaWalkingToStanding.LUNAParentMom_WalkingToStandingController();
		}
	}
}