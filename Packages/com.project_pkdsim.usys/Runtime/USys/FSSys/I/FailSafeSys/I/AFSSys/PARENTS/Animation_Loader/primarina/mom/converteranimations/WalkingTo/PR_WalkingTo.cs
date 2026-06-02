using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo
{
	public class PRWalkingTo : MonoBehaviour 
	{
		private PRWalkingToStanding PrimarinaWalkingToStanding;
		private PRWalkingToSitting PrimarinaWalkingToSitting;
		public void PRWalkingToController()
		{
			Load_PRWalkingToStanding();
			Load_PRWalkingToWSitting();
		}
		private void Load_PRWalkingToStanding()
		{
			PrimarinaWalkingToStanding.PRWalkingToStandingController();
		}
		private void Load_PRWalkingToWSitting()
		{
			PrimarinaWalkingToSitting.PRWalkingToSittingController();
		}
	}
}