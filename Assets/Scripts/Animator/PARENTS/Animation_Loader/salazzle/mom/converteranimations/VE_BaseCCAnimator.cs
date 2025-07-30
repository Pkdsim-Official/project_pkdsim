using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class SalazzleParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo SalazzleParentMomSittingto;
		
		private VEParentMom_WalkingTo SalazzleParentMomWalkingto;
		
		private VEParentMom_IdleTo SalazzleParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			SalazzleParentMomWalkingto.VEParentMom_WalkingToController();

			SalazzleParentMomIdleto.VEParentMom_IdleToController();
			
			SalazzleParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}