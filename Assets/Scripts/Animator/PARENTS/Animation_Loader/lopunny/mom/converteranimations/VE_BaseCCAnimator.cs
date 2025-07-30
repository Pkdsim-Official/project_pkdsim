using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class LopunnyParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo LopunnyParentMomSittingto;
		
		private VEParentMom_WalkingTo LopunnyParentMomWalkingto;
		
		private VEParentMom_IdleTo LopunnyParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			LopunnyParentMomWalkingto.VEParentMom_WalkingToController();

			LopunnyParentMomIdleto.VEParentMom_IdleToController();
			
			LopunnyParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}