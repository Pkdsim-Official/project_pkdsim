using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations
{
	public class Frostlass_LFS_ConverterToAnimatorController : MonoBehaviour 
	{
		private FR_LFS_SittingTo Frostlass_LFS_sittingto;
		
		private FR_LFS_WalkingTo Frostlass_LFS_walkingto;
		
		private FR_LFS_IdleTo Frostlass_LFS_idleto;

		public void FR_LFS_ConverterToAnimatorController()
		{
			Frostlass_LFS_walkingto.FR_LFS_WalkingToController();

			Frostlass_LFS_idleto.FR_LFS_IdleToController();
			
			Frostlass_LFS_sittingto.FR_LFS_SittingToController();	
		}
	}
}