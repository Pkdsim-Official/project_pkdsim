using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class BeedrillParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo BeedrillParentMomSittingto;
		
		private VEParentMom_WalkingTo BeedrillParentMomWalkingto;
		
		private VEParentMom_IdleTo BeedrillParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			BeedrillParentMomWalkingto.VEParentMom_WalkingToController();

			BeedrillParentMomIdleto.VEParentMom_IdleToController();
			
			BeedrillParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}