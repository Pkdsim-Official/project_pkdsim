using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class JolteonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo JolteonParentMomSittingto;
		
		private VEParentMom_WalkingTo JolteonParentMomWalkingto;
		
		private VEParentMom_IdleTo JolteonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			JolteonParentMomWalkingto.VEParentMom_WalkingToController();

			JolteonParentMomIdleto.VEParentMom_IdleToController();
			
			JolteonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}