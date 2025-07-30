using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations
{
	public class MeowscaradaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private VEParentMom_SittingTo MeowscaradaParentMomSittingto;
		
		private VEParentMom_WalkingTo MeowscaradaParentMomWalkingto;
		
		private VEParentMom_IdleTo MeowscaradaParentMomIdleto;

		public void VEParentMom_ConverterToAnimatorController()
		{
			MeowscaradaParentMomWalkingto.VEParentMom_WalkingToController();

			MeowscaradaParentMomIdleto.VEParentMom_IdleToController();
			
			MeowscaradaParentMomSittingto.VEParentMom_SittingToController();	
		}
	}
}