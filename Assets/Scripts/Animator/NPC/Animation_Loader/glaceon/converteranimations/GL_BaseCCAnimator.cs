using project_pkdsim.ANIMATOR.NPC.Glaceon.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.NPC.Glaceon.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.NPC.Glaceon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Glaceon.converteranimations
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