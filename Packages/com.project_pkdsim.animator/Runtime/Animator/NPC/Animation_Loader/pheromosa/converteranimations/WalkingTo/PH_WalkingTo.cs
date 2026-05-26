using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo
{
	public class PH_WalkingTo : MonoBehaviour 
	{
		private PH_WalkingToSitting Pheromosa_WalkingToSitting;
		private PH_WalkingToStanding Pheromosa_WalkingToStanding;
		public void PH_WalkingToController() 
		{
			Load_PH_WalkingToSitting();
			Load_PH_WalkingToStanding();
		}
		private void Load_PH_WalkingToStanding()
		{
			Pheromosa_WalkingToStanding.PH_WalkingToStandingController();
		}
		private void Load_PH_WalkingToSitting()
		{
			Pheromosa_WalkingToSitting.PH_WalkingToSittingController();
		}
	}
}