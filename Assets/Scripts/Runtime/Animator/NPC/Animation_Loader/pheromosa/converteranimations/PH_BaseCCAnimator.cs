using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations
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