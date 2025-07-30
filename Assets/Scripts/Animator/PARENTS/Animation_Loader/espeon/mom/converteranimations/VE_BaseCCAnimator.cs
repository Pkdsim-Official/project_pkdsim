using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class EspeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo EspeonParentMomSittingto;
		
		private VEParentMom_WalkingTo EspeonParentMomWalkingto;
		
		private VEParentMom_IdleTo EspeonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			EspeonParentMomWalkingto.VEParentMom_WalkingToController();

			EspeonParentMomIdleto.VEParentMom_IdleToController();
			
			EspeonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}