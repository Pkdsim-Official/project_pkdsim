using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleSitting;
using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation
{
	public class LeafeonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LE_IdleStanding LE_idlestanding;
		
		private LE_IdleSitting LE_idlesitting;

		private void LEParent_IdleAnimatorController()
		{
			LE_idlestanding.LE_IdleStandingController();
			LE_idlesitting.LE_IdleSittingController();	
		}
	}
}