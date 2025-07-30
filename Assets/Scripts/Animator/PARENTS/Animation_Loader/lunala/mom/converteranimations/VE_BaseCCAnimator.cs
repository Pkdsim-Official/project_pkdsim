using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class LunalaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo LunalaParentMomSittingto;
		
		private VEParentMom_WalkingTo LunalaParentMomWalkingto;
		
		private VEParentMom_IdleTo LunalaParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			LunalaParentMomWalkingto.VEParentMom_WalkingToController();

			LunalaParentMomIdleto.VEParentMom_IdleToController();
			
			LunalaParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}