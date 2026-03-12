using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.converteranimations.SittingTo.SittingToStanding;
using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Sylveon.converteranimations.SittingTo
{
	public class SYL_SittingTo : MonoBehaviour 
	{
		private SYL_SittingToStartWalking Sylveon_SittingToStartWalking;
		private SYL_SittingToStanding Sylveon_SittingToStanding;
		public void SYL_SittingToController()
		{
			Load_SYL_SittingToStartWalking();
			Load_SYL_SittingToStanding();
		}
		private void Load_SYL_SittingToStartWalking()
		{
			Sylveon_SittingToStartWalking.SYL_SittingToStartWalkingController();
		}
		private void Load_SYL_SittingToStanding()
		{
			Sylveon_SittingToStanding.SYL_SittingToStandingController();
		}
	}
}