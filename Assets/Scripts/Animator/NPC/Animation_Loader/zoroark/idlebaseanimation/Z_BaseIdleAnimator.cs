using project_pkdsim.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.idlebaseanimation
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