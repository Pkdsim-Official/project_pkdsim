using project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations
{
	public class Jolteon_ConverterAnimatorController : MonoBehaviour 
	{
		private JT_SittingTo JolteonSittingto;
		
		private JT_WalkingTo JolteonWalkingto;
		
		private JT_IdleTo JolteonIdleto;

		private void JT_Base_IdleAnimatorController()
		{
			JolteonWalkingto.JT_WalkingToController();

			JolteonIdleto.JT_IdleToController();
			
			JolteonSittingto.JT_SittingToController();	
		}
	}
}