using project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations
{
	public class PheromosaParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private PHSittingTo Pheromosasittingto;
		
		private PHWalkingTo Pheromosawalkingto;
		
		private PHIdleTo Pheromosaidleto;

		public void PH_ConverterAnimatorController()
		{
			Pheromosawalkingto.PHWalkingToController();

			Pheromosaidleto.PH_IdleToController();
			
			Pheromosasittingto.PHSittingToController();	
		}
	}
}