using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo
{
	public class NOIWalkingTo : MonoBehaviour 
	{
		private NOIWalkingToSitting NoivernWalkingToSitting;
		private NOIWalkingToStanding NoivernWalkingToStanding;
		public void NOIWalkingToController()
		{
			NOIWalkingToSitting();
			NOIWalkingToStanding();
		}
		private void NOIWalkingToSitting()
		{
			NoivernWalkingToSitting.NOIWalkingToSittingController();
		}
		private void NOIWalkingToStanding()
		{
			NoivernWalkingToStanding.NOIWalkingToStandingController();
		}
	}
}