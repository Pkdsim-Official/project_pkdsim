using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations
{
	public class Absol_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private AB_LFS_SittingTo Absol_LFS_sittingto;
		
		private AB_LFS_WalkingTo Absol_LFS_walkingto;
		
		private AB_LFS_IdleTo Absol_LFS_idleto;

		public void AB_LFS_ConverterAnimatorController()
		{
			Absol_LFS_walkingto.AB_LFS_WalkingToController();

			Absol_LFS_idleto.AB_LFS_IdleToController();
			
			Absol_LFS_sittingto.AB_LFS_SittingToController();	
		}
	}
}