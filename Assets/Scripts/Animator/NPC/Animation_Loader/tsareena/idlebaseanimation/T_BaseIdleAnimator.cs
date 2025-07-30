using project_pkdsim.ANIMATOR.Npcs.Tsareena.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Tsareena.idlebaseanimation
{
	public class Tsareena_IdleAnimatorController : MonoBehaviour 
	{
		private T_IdleStanding T_idlestanding;
		
		private T_IdleSitting T_idlesitting;
		
		public void	T_IdleAnimatorController()
		{
			T_IdleStandingAnimatorController();
			T_IdleSittingAnimatorController();
		}
		private void T_IdleStandingAnimatorController()
		{
			T_idlestanding.T_IdleStandingController();
		}
		private void T_IdleSittingAnimatorController()
		{
			T_idlesitting.T_IdleSittingController();
		}
	}
}