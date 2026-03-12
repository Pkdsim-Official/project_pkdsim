using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations
{
	public class Meowscarada_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private MEOW_LFS_SittingTo Meowscarada_LFS_sittingto;
		
		private MEOW_LFS_WalkingTo Meowscarada_LFS_walkingto;
		
		private MEOW_LFS_IdleTo Meowscarada_LFS_idleto;

		public void MEOW_LFS_CoverterToAnimatorController()
		{
			Meowscarada_LFS_walkingto.MEOW_LFS_WalkingToController();

			Meowscarada_LFS_idleto.MEOW_LFS_IdleToController();
			
			Meowscarada_LFS_sittingto.MEOW_LFS_SittingToController();	
		}
	}
}