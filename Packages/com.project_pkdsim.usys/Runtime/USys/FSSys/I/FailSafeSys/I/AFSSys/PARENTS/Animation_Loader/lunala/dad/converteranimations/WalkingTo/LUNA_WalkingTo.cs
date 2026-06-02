using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.WalkingTo
{
	public class LUNAParentDad_WalkingTo : MonoBehaviour 
	{
		private LUNAParentDad_WalkingToSitting LunalaWalkingToSitting;
		private LUNAParentDad_WalkingToStanding LunalaWalkingToStanding;
		public void LUNAParentDad_WalkingToController()
		{
			LUNAParentDad_WalkingToSitting();
			LUNAParentDad_WalkingToStanding();
		}
		private void LUNAParentDad_WalkingToSitting()
		{
			LunalaWalkingToSitting.LUNAParentDad_WalkingToSittingController();
		}
		private void LUNAParentDad_WalkingToStanding()
		{
			LunalaWalkingToStanding.LUNAParentDad_WalkingToStandingController();
		}
	}
}