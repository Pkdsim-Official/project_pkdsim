using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Salazzle.idlebaseanimation
{
	public class Salazzle_IdleAnimatorController : MonoBehaviour 
	{
		private SA_IdleStanding SA_idlestanding;
		
		private SA_IdleSitting SA_idlesitting;
		
		public void	SA_IdleAnimatorController()
		{
			SA_IdleStandingAnimatorController();
			SA_IdleSittingAnimatorController();
		}
		private void SA_IdleStandingAnimatorController()
		{
			SA_idlestanding.SA_IdleStandingController();
		}
		private void SA_IdleSittingAnimatorController()
		{
			SA_idlesitting.SA_IdleSittingController();
		}
	}
}