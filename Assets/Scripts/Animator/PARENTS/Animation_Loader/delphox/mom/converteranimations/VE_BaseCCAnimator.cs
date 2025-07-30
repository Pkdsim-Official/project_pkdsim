using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class DelphoxParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo DelphoxParentMomSittingto;
		
		private VEParentMom_WalkingTo DelphoxParentMomWalkingto;
		
		private VEParentMom_IdleTo DelphoxParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			DelphoxParentMomWalkingto.VEParentMom_WalkingToController();

			DelphoxParentMomIdleto.VEParentMom_IdleToController();
			
			DelphoxParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}