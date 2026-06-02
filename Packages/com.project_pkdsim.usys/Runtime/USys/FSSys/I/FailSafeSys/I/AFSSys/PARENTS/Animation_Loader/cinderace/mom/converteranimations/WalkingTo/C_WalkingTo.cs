using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo
{
	public class C_WalkingTo : MonoBehaviour 
	{
		private C_WalkingToSitting CinderaceWalkingToSitting;
		private C_WalkingToStanding CinderaceWalkingToStanding;
		public void C_WalkingToController()
		{
			C_WalkingToStartWalking();
			C_WalkingToStanding();
		}
		private void C_WalkingToStartWalking()
		{
			CinderaceWalkingToSitting.C_WalkingToSittingController();
		}
		private void C_WalkingToStanding()
		{
			CinderaceWalkingToStanding.C_WalkingToStandingController();
		}
	}
}