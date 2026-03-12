using Project_Pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation
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