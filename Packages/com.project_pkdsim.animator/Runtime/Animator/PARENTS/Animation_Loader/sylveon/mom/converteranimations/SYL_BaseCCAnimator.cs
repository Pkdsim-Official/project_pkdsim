using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations
{
	public class Sylveon_ConverterToAnimatorController : MonoBehaviour 
	{
		private SYL_SittingTo Sylveon_sittingto;
		
		private SYL_WalkingTo Sylveon_walkingto;
		
		private SYL_IdleTo Sylveon_idleto;

		public void SYL_ConverterToAnimatorController()
		{
			Sylveon_walkingto.SYL_WalkingToController();

			Sylveon_idleto.SYL_IdleToController();
			
			Sylveon_sittingto.SYL_SittingToController();	
		}
	}
}