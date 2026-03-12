using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Glaceon.idlebaseanimation
{
	public class Glaceon_AnimatorIdleController : MonoBehaviour 
	{
		private GL_IdleStanding Glaceon_idlestanding;
		
		private GL_IdleSitting Glaceon_idlesitting;
			

		private void GL_Base_IdleAnimatorController()
		{
			Glaceon_idlestanding.GL_IdleStandingController();
			Glaceon_idlesitting.GL_IdleSittingController();	
		}
	}
}