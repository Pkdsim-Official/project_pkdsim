using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.WalkingTo
{
	public class DR_LFS_WalkingTo : MonoBehaviour 
	{
		private DR_LFS_WalkingToSitting Dragapult_LFS_WalkingToSitting;
		private DR_LFS_WalkingToStanding Dragapult_LFS_WalkingToStanding;
		public void DR_LFS_WalkingToController()
		{
			DR_LFS_WalkingToStartWalking();
			DR_LFS_WalkingToStanding();
		}
		private void DR_LFS_WalkingToStartWalking()
		{
			Dragapult_LFS_WalkingToSitting.DR_LFS_WalkingToSittingController();
		}
		private void DR_LFS_WalkingToStanding()
		{
			Dragapult_LFS_WalkingToStanding.DR_LFS_WalkingToStandingController();
		}
	}
}
