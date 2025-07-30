using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class TSareenaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo TSareenaParentMomSittingto;
		
		private VEParentMom_WalkingTo TSareenaParentMomWalkingto;
		
		private VEParentMom_IdleTo TSareenaParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			TSareenaParentMomWalkingto.VEParentMom_WalkingToController();

			TSareenaParentMomIdleto.VEParentMom_IdleToController();
			
			TSareenaParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}