using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation
{
	public class LeafeonParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private LEParentDad_IdleStanding LEParentDad_idlestanding;
		
		private LEParentDad_IdleSitting LEParentDad_idlesitting;

		public void LEParentDad_IdleAnimatorController()
		{
			LEParentDad_idlestanding.LEParentDad_IdleStandingController();
			LEParentDad_idlesitting.LEParentDad_IdleSittingController();	
		}
	}
}