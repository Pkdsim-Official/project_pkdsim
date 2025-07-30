using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class HattereneParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo HattereneParentMomSittingto;
		
		private VEParentMom_WalkingTo HattereneParentMomWalkingto;
		
		private VEParentMom_IdleTo HattereneParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			HattereneParentMomWalkingto.VEParentMom_WalkingToController();

			HattereneParentMomIdleto.VEParentMom_IdleToController();
			
			HattereneParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}