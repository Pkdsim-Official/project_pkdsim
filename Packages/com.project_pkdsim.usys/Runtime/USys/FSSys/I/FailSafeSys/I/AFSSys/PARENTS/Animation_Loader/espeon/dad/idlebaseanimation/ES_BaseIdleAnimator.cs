using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.idlebaseanimation
{
	public class EspeonParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private ES_IdleStanding ES_idlestanding;
		
		private ES_IdleSitting ES_idlesitting;
		

		public void ESParentDad_IdleAnimatorController()
		{
			ES_idlestanding.ES_IdleStandingController();
			ES_idlesitting.ES_IdleSittingController();	
		}
	}
}