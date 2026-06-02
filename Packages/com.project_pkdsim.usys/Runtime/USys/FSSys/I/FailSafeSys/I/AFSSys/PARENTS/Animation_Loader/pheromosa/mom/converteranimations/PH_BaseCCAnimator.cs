using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations
{
	public class PheromosaParentMom_ConverterAnimatorController : MonoBehaviour 
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