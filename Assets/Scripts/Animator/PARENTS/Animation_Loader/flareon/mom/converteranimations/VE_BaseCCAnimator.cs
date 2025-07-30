using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class FlareonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo FlareonParentMomSittingto;
		
		private VEParentMom_WalkingTo FlareonParentMomWalkingto;
		
		private VEParentMom_IdleTo FlareonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			FlareonParentMomWalkingto.VEParentMom_WalkingToController();

			FlareonParentMomIdleto.VEParentMom_IdleToController();
			
			FlareonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}