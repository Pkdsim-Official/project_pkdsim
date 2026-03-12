using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations
{
	public class Espeon_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private ES_LFS_SittingTo Espeon_LFS_sittingto;
		
		private ES_LFS_WalkingTo Espeon_LFS_walkingto;
		
		private ES_LFS_IdleTo Espeon_LFS_idleto;

		public void ES_LFS_CoverterToAnimatorController()
		{
			Espeon_LFS_walkingto.ES_LFS_WalkingToController();

			Espeon_LFS_idleto.ES_LFS_IdleToController();
			
			Espeon_LFS_sittingto.ES_LFS_SittingToController();	
		}
	}
}