using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lopunny.idlebaseanimation
{
	public class Lopunny_IdleAnimatorController : MonoBehaviour 
	{
		private LOIdleStanding Lopunnyidlestanding;
		
		private LO_IdleSitting Lopunnyidlesitting;
		
		public void	LO_IdleAnimatorController()
		{
			LOIdleStandingAnimatorController();
			LO_IdleSittingAnimatorController();
		}
		private void LOIdleStandingAnimatorController()
		{
			Lopunnyidlestanding.LOIdleStandingController();
		}
		private void LO_IdleSittingAnimatorController()
		{
			Lopunnyidlesitting.LO_IdleSittingController();
		}
	}
}