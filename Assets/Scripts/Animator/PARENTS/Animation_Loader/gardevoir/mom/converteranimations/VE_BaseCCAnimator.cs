using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class GardevoirParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo GardevoirParentMomSittingto;
		
		private VEParentMom_WalkingTo GardevoirParentMomWalkingto;
		
		private VEParentMom_IdleTo GardevoirParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			GardevoirParentMomWalkingto.VEParentMom_WalkingToController();

			GardevoirParentMomIdleto.VEParentMom_IdleToController();
			
			GardevoirParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}