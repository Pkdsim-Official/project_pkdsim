using project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Pheromosa.converteranimations
{
	public class PheromosaCoverterAnimatorController : MonoBehaviour 
	{
		private PHSittingTo Pheromosasittingto;
		
		private PHWalkingTo Pheromosawalkingto;
		
		private PHIdleTo Pheromosaidleto;

		public void PHCoverterToAnimatorController()
		{
			Pheromosawalkingto.PHWalkingToController();

			Pheromosaidleto.PH_IdleToController();
			
			Pheromosasittingto.PHSittingToController();	
		}
	}
}