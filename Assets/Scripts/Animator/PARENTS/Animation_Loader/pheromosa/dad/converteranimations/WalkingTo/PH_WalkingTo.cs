using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.WalkingTo
{
	public class PHParentDad_WalkingTo : MonoBehaviour 
	{
		private PHParentDad_WalkingToSitting PheromosaWalkingToSitting;
		private PHParentDad_WalkingToStanding PheromosaWalkingToStanding;
		public void PHParentDad_WalkingToController() 
		{
			Load_PHParentDad_WalkingToSitting();
			Load_PHParentDad_WalkingToStanding();
		}
		private void Load_PHParentDad_WalkingToStanding()
		{
			PheromosaWalkingToStanding.PHParentDad_WalkingToStandingController();
		}
		private void Load_PHParentDad_WalkingToSitting()
		{
			PheromosaWalkingToSitting.PHParentDad_WalkingToSittingController();
		}
	}
}