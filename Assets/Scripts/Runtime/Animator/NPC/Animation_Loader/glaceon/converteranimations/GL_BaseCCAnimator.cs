using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations
{
	public class Glaceon_AnimatorControllerCoverterAnimator : MonoBehaviour 
	{
		private GL_IdleTo GlaceonIdleto;
		
		private GL_WalkingTo GlaceonWalkingto;

		private GL_SittingTo GlaceonSittingto;
		private void Glaceon_Base_IdleAnimatorController()
		{
			GlaceonWalkingto.GL_WalkingToController();

			GlaceonIdleto.GL_IdleToController();
			
			GlaceonSittingto.GL_SittingToController();	
		}
	}
}