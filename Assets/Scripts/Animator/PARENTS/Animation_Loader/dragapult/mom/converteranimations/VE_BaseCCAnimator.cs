using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class DragapultParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo DragapultParentMomSittingto;
		
		private VEParentMom_WalkingTo DragapultParentMomWalkingto;
		
		private VEParentMom_IdleTo DragapultParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			DragapultParentMomWalkingto.VEParentMom_WalkingToController();

			DragapultParentMomIdleto.VEParentMom_IdleToController();
			
			DragapultParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}