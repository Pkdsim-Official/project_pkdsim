using project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations
{
	public class Sylveon_CoverterAnimatorController : MonoBehaviour 
	{
		private SYL_SittingTo Sylveon_sittingto;
		
		private SYL_WalkingTo Sylveon_walkingto;
		
		private SYL_IdleTo Sylveon_idleto;

		public void SYL_CoverterToAnimatorController()
		{
			Sylveon_walkingto.SYL_WalkingToController();

			Sylveon_idleto.SYL_IdleToController();
			
			Sylveon_sittingto.SYL_SittingToController();	
		}
	}
}