using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class SylveonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo SylveonParentMomSittingto;
		
		private VEParentMom_WalkingTo SylveonParentMomWalkingto;
		
		private VEParentMom_IdleTo SylveonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			SylveonParentMomWalkingto.VEParentMom_WalkingToController();

			SylveonParentMomIdleto.VEParentMom_IdleToController();
			
			SylveonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}