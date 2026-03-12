using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Beedrill.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Beedrill.idlebaseanimation
{
	public class Beedrill_IdleAnimatorController : MonoBehaviour 
	{
		private BE_IdleStanding BeedrillIdlestanding;
		
		private BE_IdleSitting BeedrillIdlesitting;
		
		public void	BE_IdleAnimatorController()
		{
			BE_IdleStandingAnimatorController();
			BE_IdleSittingAnimatorController();
		}
		private void BE_IdleStandingAnimatorController()
		{
			BeedrillIdlestanding.BE_IdleStandingController();
		}
		private void BE_IdleSittingAnimatorController()
		{
			BeedrillIdlesitting.BE_IdleSittingController();
		}
	}
}