using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class UmbreonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo UmbreonParentMomSittingto;
		
		private VEParentMom_WalkingTo UmbreonParentMomWalkingto;
		
		private VEParentMom_IdleTo UmbreonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			UmbreonParentMomWalkingto.VEParentMom_WalkingToController();

			UmbreonParentMomIdleto.VEParentMom_IdleToController();
			
			UmbreonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}