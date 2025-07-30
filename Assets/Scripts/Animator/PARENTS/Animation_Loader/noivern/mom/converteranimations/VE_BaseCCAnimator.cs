using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class NoivernParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo NoivernParentMomSittingto;
		
		private VEParentMom_WalkingTo NoivernParentMomWalkingto;
		
		private VEParentMom_IdleTo NoivernParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			NoivernParentMomWalkingto.VEParentMom_WalkingToController();

			NoivernParentMomIdleto.VEParentMom_IdleToController();
			
			NoivernParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}