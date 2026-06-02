using project_pkdsim.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Glaceon.idlebaseanimation
{
	public class Glaceon_IdleAnimatorController : MonoBehaviour 
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