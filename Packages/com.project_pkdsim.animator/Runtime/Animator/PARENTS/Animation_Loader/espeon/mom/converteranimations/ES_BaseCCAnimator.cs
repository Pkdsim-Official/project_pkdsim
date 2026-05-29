using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation
{
	public class Espeon_AnimatorConverterController : MonoBehaviour 
	{
		private ES_IdleTo Espeon_idleto;
		
		private ES_WalkingTo Espeon_walkingto;

		private ES_SittingTo Espeon_sittingto;
		private void Espeon_Base_IdleAnimatorController()
		{
			Espeon_walkingto.ES_WalkingToController();

			Espeon_idleto.ES_IdleToController();
			
			Espeon_sittingto.ES_SittingToController();
		}
	}
}