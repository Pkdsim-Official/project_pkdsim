using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations
{
	public class Blaziken_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private BL_LFS_SittingTo Blaziken_LFS_sittingto;
		
		private BL_LFS_WalkingTo Blaziken_LFS_walkingto;
		
		private BL_LFS_IdleTo Blaziken_LFS_idleto;

		public void BL_LFS_ConverterAnimatorController()
		{
			Blaziken_LFS_walkingto.BL_LFS_WalkingToController();

			Blaziken_LFS_idleto.BL_LFS_IdleToController();
			
			Blaziken_LFS_sittingto.BL_LFS_SittingToController();	
		}
	}
}