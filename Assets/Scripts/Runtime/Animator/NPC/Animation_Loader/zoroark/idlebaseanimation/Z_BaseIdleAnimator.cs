using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Zoroark.idlebaseanimation
{
	public class Zoroark_IdleAnimatorController : MonoBehaviour 
	{
		private Z_IdleStanding Zoroarkidlestanding;
		
		private Z_IdleSitting Zoroarkidlesitting;
		
		public void	Z_IdleAnimatorController()
		{
			Z_IdleStandingAnimatorController();
			Z_IdleSittingAnimatorController();
		}
		private void Z_IdleStandingAnimatorController()
		{
			Zoroarkidlestanding.Z_IdleStandingController();
		}
		private void Z_IdleSittingAnimatorController()
		{
			Zoroarkidlesitting.Z_IdleSittingController();
		}
	}
}