using project_pkdsim.ANIMATOR.NPC.Espeon.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Espeon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.NPC.Espeon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Espeon.idlebaseanimation
{
	public class Espeon_AnimatorConverterController : MonoBehaviour 
	{
		private ES_IdleTo EspeonIdleto;
		
		private ES_WalkingTo EspeonWalkingto;

		private ES_SittingTo EspeonSittingto;
		private void Espeon_Base_IdleAnimatorController()
		{
			EspeonWalkingto.ES_WalkingToController();

			EspeonIdleto.ES_IdleToController();
			
			EspeonSittingto.ES_SittingToController();
		}
	}
}