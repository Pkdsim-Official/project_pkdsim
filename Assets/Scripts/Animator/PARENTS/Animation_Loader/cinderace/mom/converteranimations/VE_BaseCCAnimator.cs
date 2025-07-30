using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class CinderaceParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo CinderaceParentMomSittingto;
		
		private VEParentMom_WalkingTo CinderaceParentMomWalkingto;
		
		private VEParentMom_IdleTo CinderaceParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			CinderaceParentMomWalkingto.VEParentMom_WalkingToController();

			CinderaceParentMomIdleto.VEParentMom_IdleToController();
			
			CinderaceParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}