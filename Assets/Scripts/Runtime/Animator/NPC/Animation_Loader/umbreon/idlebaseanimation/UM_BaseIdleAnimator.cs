using Project_Pkdsim.ANIMATOR.Npcs.Umbreon.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Umbreon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Umbreon.idlebaseanimation
{
	public class Umbreon_AnimatorIdleController : MonoBehaviour 
	{
		private UM_IdleStanding UM_idlestanding;
		
		private UM_IdleSitting UM_idlesitting;
		private void UM_Base_IdleAnimatorController()
		{
			UM_idlestanding.UM_IdleStandingController();
			UM_idlesitting.UM_IdleSittingController();	
		}
	}
}