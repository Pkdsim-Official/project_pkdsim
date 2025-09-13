using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations
{
	public class PheromosaCoverterAnimatorController : MonoBehaviour 
	{
		private PH_SittingTo Pheromosasittingto;
		
		private PH_WalkingTo Pheromosawalkingto;
		
		private PH_IdleTo Pheromosaidleto;

		public void PHCoverterToAnimatorController()
		{
			Pheromosawalkingto.PH_WalkingToController();

			Pheromosaidleto.PH_IdleToController();
			
			Pheromosasittingto.PH_SittingToController();	
		}
	}
}