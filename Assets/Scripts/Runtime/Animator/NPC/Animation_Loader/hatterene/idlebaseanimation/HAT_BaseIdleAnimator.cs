using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Hatterene.idlebaseanimation
{
	public class Hatterene_IdleAnimatorController : MonoBehaviour 
	{
		private HATIdleStanding HATidlestanding;
		
		private HAT_IdleSitting HATidlesitting;
		
		public void	HAT_IdleAnimatorController()
		{
			HATIdleStandingAnimatorController();
			HAT_IdleSittingAnimatorController();
		}
		private void HATIdleStandingAnimatorController()
		{
			HATidlestanding.HATIdleStandingController();
		}
		private void HAT_IdleSittingAnimatorController()
		{
			HATidlesitting.HAT_IdleSittingController();
		}
	}
}