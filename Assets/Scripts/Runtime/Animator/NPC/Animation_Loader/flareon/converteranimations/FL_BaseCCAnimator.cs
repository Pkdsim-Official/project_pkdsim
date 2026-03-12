using Project_Pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.IdleTo;

using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Flareon.converteranimations
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