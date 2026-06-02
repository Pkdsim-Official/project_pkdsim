using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Dad.idlebaseanimation
{
	public class EspeonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private ES_IdleTo EspeonParentDad_idleto;
		
		private ES_WalkingTo EspeonParentDad_walkingto;

		private ES_SittingTo EspeonParentDad_sittingto;
		public void ESParentDad_ConverterAnimatorController()
		{
			EspeonParentDad_walkingto.ES_WalkingToController();

			EspeonParentDad_idleto.ES_IdleToController();
			
			EspeonParentDad_sittingto.ES_SittingToController();
		}
	}
}