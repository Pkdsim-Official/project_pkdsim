using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations
{
	public class Lopunny_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private LO_LFS_SittingTo Lopunny_LFS_sittingto;
		
		private LO_LFS_WalkingTo Lopunny_LFS_walkingto;
		
		private LO_LFS_IdleTo Lopunny_LFS_idleto;

		public void LO_LFS_CoverterToAnimatorController()
		{
			Lopunny_LFS_walkingto.LO_LFS_WalkingToController();

			Lopunny_LFS_idleto.LO_LFS_IdleToController();
			
			Lopunny_LFS_sittingto.LO_LFS_SittingToController();	
		}
	}
}