using project_pkdsim.ANIMATOR.Parents.Jolteon.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Jolteon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Jolteon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.converteranimations
{
	public class Jolteon_ConverterAnimatorController : MonoBehaviour 
	{
		private JT_SittingTo Jolteon_sittingto;
		
		private JT_WalkingTo Jolteon_walkingto;
		
		private JT_IdleTo Jolteon_idleto;

		private void JT_Base_IdleAnimatorController()
		{
			Jolteon_walkingto.JT_WalkingToController();

			Jolteon_idleto.JT_IdleToController();
			
			Jolteon_sittingto.JT_SittingToController();	
		}
	}
}