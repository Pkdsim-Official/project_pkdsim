using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class GlaceonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo GlaceonParentMomSittingto;
		
		private VEParentMom_WalkingTo GlaceonParentMomWalkingto;
		
		private VEParentMom_IdleTo GlaceonParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			GlaceonParentMomWalkingto.VEParentMom_WalkingToController();

			GlaceonParentMomIdleto.VEParentMom_IdleToController();
			
			GlaceonParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}