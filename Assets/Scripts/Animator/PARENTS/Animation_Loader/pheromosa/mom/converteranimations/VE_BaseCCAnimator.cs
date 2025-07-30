using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class PheromosaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo PheromosaParentMomSittingto;
		
		private VEParentMom_WalkingTo PheromosaParentMomWalkingto;
		
		private VEParentMom_IdleTo PheromosaParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			PheromosaParentMomWalkingto.VEParentMom_WalkingToController();

			PheromosaParentMomIdleto.VEParentMom_IdleToController();
			
			PheromosaParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}