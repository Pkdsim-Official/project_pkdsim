using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class GarchompParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo GarchompParentMomSittingto;
		
		private VEParentMom_WalkingTo GarchompParentMomWalkingto;
		
		private VEParentMom_IdleTo GarchompParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			GarchompParentMomWalkingto.VEParentMom_WalkingToController();

			GarchompParentMomIdleto.VEParentMom_IdleToController();
			
			GarchompParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}