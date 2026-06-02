using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation
{
	public class EspeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private ES_IdleTo EspeonParentMom_idleto;
		
		private ES_WalkingTo EspeonParentMom_walkingto;

		private ES_SittingTo EspeonParentMom_sittingto;
		public void ESParentMom_ConverterAnimatorController()
		{
			EspeonParentMom_walkingto.ES_WalkingToController();

			EspeonParentMom_idleto.ES_IdleToController();
			
			EspeonParentMom_sittingto.ES_SittingToController();
		}
	}
}