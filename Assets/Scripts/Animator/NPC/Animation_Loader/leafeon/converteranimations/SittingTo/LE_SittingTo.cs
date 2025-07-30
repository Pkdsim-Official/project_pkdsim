using project_pkdsim.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo
{
	public class LE_SittingTo : MonoBehaviour 
	{
		private LE_SittingToStartWalking LE_sittingToStartWalking;
		private LE_SittingToStanding LE_sittingToStanding;
		
		public void LE_SittingToController()
		{
			Load_LE_SittingToStanding();
			Load_LE_SittingToStartWalking();
		}
		private void Load_LE_SittingToStanding()
		{
			LE_sittingToStanding.LE_SittingToStandingController();
		}
		private void Load_LE_SittingToStartWalking()
		{
			LE_sittingToStartWalking.LE_SittingToStartWalkingController();
		}
	}
}