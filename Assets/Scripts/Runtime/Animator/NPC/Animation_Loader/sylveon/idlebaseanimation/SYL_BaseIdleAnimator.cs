using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Sylveon.idlebaseanimation
{
	public class Sylveon_IdleAnimatorController : MonoBehaviour 
	{
		private SYL_IdleStanding SYL_idlestanding;
		
		private SYL_IdleSitting SYL_idlesitting;

		private void SYL_Base_IdleAnimatorController()
		{
			SYL_idlestanding.SYL_IdleStandingController();
			SYL_idlesitting.SYL_IdleSittingController();	
		}
	}
}