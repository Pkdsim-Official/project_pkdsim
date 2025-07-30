using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class PrimarinaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo PrimarinaParentMomSittingto;
		
		private VEParentMom_WalkingTo PrimarinaParentMomWalkingto;
		
		private VEParentMom_IdleTo PrimarinaParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			PrimarinaParentMomWalkingto.VEParentMom_WalkingToController();

			PrimarinaParentMomIdleto.VEParentMom_IdleToController();
			
			PrimarinaParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}