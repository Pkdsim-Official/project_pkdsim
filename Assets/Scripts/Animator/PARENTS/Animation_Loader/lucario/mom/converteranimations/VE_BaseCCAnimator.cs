using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class LucarioParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo LucarioParentMomSittingto;
		
		private VEParentMom_WalkingTo LucarioParentMomWalkingto;
		
		private VEParentMom_IdleTo LucarioParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			LucarioParentMomWalkingto.VEParentMom_WalkingToController();

			LucarioParentMomIdleto.VEParentMom_IdleToController();
			
			LucarioParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}