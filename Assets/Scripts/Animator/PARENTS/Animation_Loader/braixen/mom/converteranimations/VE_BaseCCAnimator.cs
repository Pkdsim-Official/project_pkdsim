using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class BraixenParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo BraixenParentMomSittingto;
		
		private VEParentMom_WalkingTo BraixenParentMomWalkingto;
		
		private VEParentMom_IdleTo BraixenParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			BraixenParentMomWalkingto.VEParentMom_WalkingToController();

			BraixenParentMomIdleto.VEParentMom_IdleToController();
			
			BraixenParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}