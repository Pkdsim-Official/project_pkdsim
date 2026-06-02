using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Dad.converteranimations.WalkingTo
{
	public class FR_WalkingTo : MonoBehaviour 
	{
		
		private FR_WalkingToStanding FrostlassWalkingToStanding;
		private FR_WalkingToSitting FrostlassWalkingToSitting;
		public void FR_WalkingToController()
		{
			Load_FR_WalkingToStanding();
			Load_FR_WalkingToWSitting();
		}
		private void Load_FR_WalkingToStanding()
		{
			FrostlassWalkingToStanding.FR_WalkingToStandingController();
		}
		private void Load_FR_WalkingToWSitting()
		{
			FrostlassWalkingToSitting.FR_WalkingToSittingController();
		}
	}
}