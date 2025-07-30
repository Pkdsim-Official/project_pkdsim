using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class BlazikenParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo BlazikenParentMomSittingto;
		
		private VEParentMom_WalkingTo BlazikenParentMomWalkingto;
		
		private VEParentMom_IdleTo BlazikenParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			BlazikenParentMomWalkingto.VEParentMom_WalkingToController();

			BlazikenParentMomIdleto.VEParentMom_IdleToController();
			
			BlazikenParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}