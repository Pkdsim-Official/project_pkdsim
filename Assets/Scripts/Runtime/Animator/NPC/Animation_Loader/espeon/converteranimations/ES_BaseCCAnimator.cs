using Project_Pkdsim.ANIMATOR.Npcs.Espeon.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Espeon.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Espeon.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Espeon.idlebaseanimation
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