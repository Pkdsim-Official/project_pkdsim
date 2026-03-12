using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations
{
	public class Leafeon_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private LE_LFS_IdleTo Leafeon_LFS_idleTo;
		
		private LE_LFS_WalkingTo Leafeon_LFS_WalkingTo;

		private LE_LFS_SittingTo Leafeon_LFS_SittingTo;
		public void LE_LFS_ConverterAnimatorController()
		{
			Leafeon_LFS_idleTo.LE_LFS_IdleToController();
			
			Leafeon_LFS_WalkingTo.LE_LFS_WalkingToController();
			
			Leafeon_LFS_SittingTo.LE_LFS_SittingToController();
		}
	}
}