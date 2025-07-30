using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class VaporeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo VaporeonParentMomSittingto;
		
		private VEParentMom_WalkingTo VaporeonParentMomWalkingto;
		
		private VEParentMom_IdleTo VaporeonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			VaporeonParentMomWalkingto.VEParentMom_WalkingToController();

			VaporeonParentMomIdleto.VEParentMom_IdleToController();
			
			VaporeonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}