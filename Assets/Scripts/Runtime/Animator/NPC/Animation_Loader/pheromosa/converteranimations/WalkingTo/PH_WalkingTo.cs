using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.WalkingTo
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