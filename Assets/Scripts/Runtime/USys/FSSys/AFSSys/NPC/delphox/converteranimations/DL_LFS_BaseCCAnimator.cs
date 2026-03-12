using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations
{
	public class Delphox_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private DL_LFS_SittingTo Delphox_LFS_sittingto;
		
		private DL_LFS_WalkingTo Delphox_LFS_walkingto;
		
		private DL_LFS_IdleTo Delphox_LFS_idleto;

		public void DL_LFS_CoverterToAnimatorController()
		{
			Delphox_LFS_walkingto.DL_LFS_WalkingToController();

			Delphox_LFS_idleto.DL_LFS_IdleToController();
			
			Delphox_LFS_sittingto.DL_LFS_SittingToController();	
		}
	}
}