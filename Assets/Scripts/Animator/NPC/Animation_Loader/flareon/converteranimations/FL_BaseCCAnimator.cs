using project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.IdleTo;

using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Flareon.converteranimations
{
	public class Flareon_AnimatorConverterController : MonoBehaviour 
	{
		private FL_IdleTo FlareonIdleto;
		
		private FL_WalkingTo FlareonWalkingto;

		private FL_SittingTo FlareonSittingto;
		private void Flareon_Base_IdleAnimatorController()
		{
			FlareonWalkingto.FL_WalkingToController();

			FlareonIdleto.FL_IdleToController();
			
			FlareonSittingto.FL_SittingToController();
		}
	}
}