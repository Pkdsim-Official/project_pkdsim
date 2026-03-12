using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Cinderace.idlebaseanimation
{
	public class Cinderace_IdleAnimatorController : MonoBehaviour 
	{
		private C_IdleStanding C_Idlestanding;
		
		private C_IdleSitting C_Idlesitting;
		
		public void	C_IdleAnimatorController()
		{
			C_IdleStandingAnimatorController();
			C_IdleSittingAnimatorController();
		}
		private void C_IdleStandingAnimatorController()
		{
			C_Idlestanding.C_IdleStandingController();
		}
		private void C_IdleSittingAnimatorController()
		{
			C_Idlesitting.C_IdleSittingController();
		}
	}
}