using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations
{
	public class Gardevoir_LFS_ConverterToAnimatorController : MonoBehaviour 
	{
		private GARD_LFS_SittingTo Gardevoir_LFS_sittingto;
		
		private GARD_LFS_WalkingTo Gardevoir_LFS_walkingto;
		
		private GARD_LFS_IdleTo Gardevoir_LFS_idleto;

		public void GARD_LFS_ConverterToAnimatorController()
		{
			Gardevoir_LFS_walkingto.GARD_LFS_WalkingToController();

			Gardevoir_LFS_idleto.GARD_LFS_IdleToController();
			
			Gardevoir_LFS_sittingto.GARD_LFS_SittingToController();	
		}
	}
}