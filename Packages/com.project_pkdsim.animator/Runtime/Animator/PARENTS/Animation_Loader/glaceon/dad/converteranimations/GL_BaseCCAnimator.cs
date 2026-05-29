using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.converteranimations
{
	public class Glaceon_AnimatorControllerCoverterAnimator : MonoBehaviour 
	{
		private GL_IdleTo Glaceon_idleto;
		
		private GL_WalkingTo Glaceon_walkingto;

		private GL_SittingTo Glaceon_sittingto;
		private void Glaceon_Base_IdleAnimatorController()
		{
			Glaceon_walkingto.GL_WalkingToController();

			Glaceon_idleto.GL_IdleToController();
			
			Glaceon_sittingto.GL_SittingToController();	
		}
	}
}