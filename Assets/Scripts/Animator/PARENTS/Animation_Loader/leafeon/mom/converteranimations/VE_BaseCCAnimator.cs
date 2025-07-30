using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class LeafeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo LeafeonParentMomSittingto;
		
		private VEParentMom_WalkingTo LeafeonParentMomWalkingto;
		
		private VEParentMom_IdleTo LeafeonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			LeafeonParentMomWalkingto.VEParentMom_WalkingToController();

			LeafeonParentMomIdleto.VEParentMom_IdleToController();
			
			LeafeonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}