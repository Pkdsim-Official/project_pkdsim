using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.converteranimations
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