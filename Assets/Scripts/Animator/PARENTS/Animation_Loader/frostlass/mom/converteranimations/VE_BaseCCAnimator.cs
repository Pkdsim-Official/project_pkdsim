using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class FrostlassParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo FrostlassParentMomSittingto;
		
		private VEParentMom_WalkingTo FrostlassParentMomWalkingto;
		
		private VEParentMom_IdleTo FrostlassParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			FrostlassParentMomWalkingto.VEParentMom_WalkingToController();

			FrostlassParentMomIdleto.VEParentMom_IdleToController();
			
			FrostlassParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}