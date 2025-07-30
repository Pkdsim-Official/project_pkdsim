using project_pkdsim.Models.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Glaceon.idlebaseanimation
{
	public class Glaceon_AnimatorIdleController : MonoBehaviour 
	{
		private GL_IdleStanding Glaceon_idlestanding;
		
		private GL_IdleSitting Glaceon_idlesitting;
			

		private void GL_BaseIdleAnimatorController()
		{
			Glaceon_idlestanding.GL_IdleStandingController();
			Glaceon_idlesitting.GL_IdleSittingController();	
		}
	}
}