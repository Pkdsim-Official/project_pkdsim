using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Jolteon.converteranimations
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