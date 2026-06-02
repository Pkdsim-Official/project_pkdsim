using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo
{
	public class PHWalkingTo : MonoBehaviour 
	{
		private PHWalkingToSitting PheromosaWalkingToSitting;
		private PHWalkingToStanding PheromosaWalkingToStanding;
		public void PHWalkingToController() 
		{
			Load_PHWalkingToSitting();
			Load_PHWalkingToStanding();
		}
		private void Load_PHWalkingToStanding()
		{
			PheromosaWalkingToStanding.PHWalkingToStandingController();
		}
		private void Load_PHWalkingToSitting()
		{
			PheromosaWalkingToSitting.PHWalkingToSittingController();
		}
	}
}