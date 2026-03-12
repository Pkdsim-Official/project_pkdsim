using Project_Pkdsim.ANIMATOR.Npcs.Noivern.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Noivern.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Noivern.idlebaseanimation
{
	public class Noivern_IdleAnimatorController : MonoBehaviour 
	{
		private NOIIdleStanding Noivernidlestanding;
		
		private NOI_IdleSitting Noivernidlesitting;
		
		public void	NOI_IdleAnimatorController()
		{
			NOIIdleStandingAnimatorController();
			NOI_IdleSittingAnimatorController();
		}
		private void NOIIdleStandingAnimatorController()
		{
			Noivernidlestanding.NOIIdleStandingController();
		}
		private void NOI_IdleSittingAnimatorController()
		{
			Noivernidlesitting.NOI_IdleSittingController();
		}
	}
}