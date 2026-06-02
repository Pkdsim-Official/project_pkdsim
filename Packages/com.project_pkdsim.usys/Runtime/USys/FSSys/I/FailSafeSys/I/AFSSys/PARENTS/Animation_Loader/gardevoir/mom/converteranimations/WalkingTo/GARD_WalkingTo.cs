using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo
{
	public class GARD_WalkingTo : MonoBehaviour 
	{
		private GARD_WalkingToSitting GardevoirWalkingToSitting;
		private GARD_WalkingToStanding GardevoirWalkingToStanding;
		public void GARD_WalkingToController()
		{
			GARD_WalkingToStartWalking();
			GARD_WalkingToStanding();
		}
		private void GARD_WalkingToStartWalking()
		{
			GardevoirWalkingToSitting.GARD_WalkingToSittingController();
		}
		private void GARD_WalkingToStanding()
		{
			GardevoirWalkingToStanding.GARD_WalkingToStandingController();
		}
	}
}