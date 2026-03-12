using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Sylveon.converteranimations
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