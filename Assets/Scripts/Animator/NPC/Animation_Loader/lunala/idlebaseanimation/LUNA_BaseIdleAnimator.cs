using project_pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation
{
	public class Lunala_IdleAnimatorController : MonoBehaviour 
	{
		private LUNAIdleStanding Lunalaidlestanding;
		
		private LUNA_IdleSitting Lunalaidlesitting;
		
		public void	LUNA_IdleAnimatorController()
		{
			LUNAIdleStandingAnimatorController();
			LUNA_IdleSittingAnimatorController();
		}
		private void LUNAIdleStandingAnimatorController()
		{
			Lunalaidlestanding.LUNAIdleStandingController();
		}
		private void LUNA_IdleSittingAnimatorController()
		{
			Lunalaidlesitting.LUNA_IdleSittingController();
		}
	}
}