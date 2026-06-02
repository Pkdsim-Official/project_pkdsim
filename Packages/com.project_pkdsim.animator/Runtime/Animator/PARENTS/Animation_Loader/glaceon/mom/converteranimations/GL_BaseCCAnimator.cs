using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.converteranimations
{
	public class Glaceon_ConverterAnimatorController : MonoBehaviour 
	{
		private GL_IdleTo Glaceon_idleto;
		
		private GL_WalkingTo Glaceon_walkingto;

		private GL_SittingTo Glaceon_sittingto;
		private void GlaceonParent_IdleAnimatorController()
		{
			Glaceon_walkingto.GL_WalkingToController();

			Glaceon_idleto.GL_IdleToController();
			
			Glaceon_sittingto.GL_SittingToController();	
		}
	}
}