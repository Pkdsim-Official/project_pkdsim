using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo
{
	public class SA_LFS_WalkingTo : MonoBehaviour 
	{
		private SA_LFS_WalkingToSitting Salazzle_LFS_WalkingToSitting;
		private SA_LFS_WalkingToStanding Salazzle_LFS_WalkingToStanding;
		public void SA_LFS_WalkingToController()
		{
			SA_LFS_WalkingToSitting();
			SA_LFS_WalkingToStanding();
		}
		private void SA_LFS_WalkingToSitting()
		{
			Salazzle_LFS_WalkingToSitting.SA_LFS_WalkingToSittingController();
		}
		private void SA_LFS_WalkingToStanding()
		{
			Salazzle_LFS_WalkingToStanding.SA_LFS_WalkingToStandingController();
		}
	}
}