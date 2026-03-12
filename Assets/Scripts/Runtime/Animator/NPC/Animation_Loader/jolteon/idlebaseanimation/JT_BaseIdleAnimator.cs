using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Jolteon.idlebaseanimation
{
	public class Jolteon_AnimatorIdleController : MonoBehaviour 
	{
		private JT_IdleStanding JT_idlestanding;
		
		private JT_IdleSitting JT_idlesitting;

		private void JT_Base_IdleAnimatorController()
		{
			JT_idlestanding.JT_IdleStandingController();
			JT_idlesitting.JT_IdleSittingController();	
		}
	}
}