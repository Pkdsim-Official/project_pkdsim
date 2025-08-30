using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations
{
	public class HattereneCoverterAnimatorController : MonoBehaviour 
	{
		private HATSittingTo Hatterenesittingto;
		
		private HATWalkingTo Hatterenewalkingto;
		
		private HATIdleTo Hattereneidleto;

		public void HATCoverterToAnimatorController()
		{
			Hatterenewalkingto.HATWalkingToController();

			Hattereneidleto.HATIdleToController();
			
			Hatterenesittingto.HATSittingToController();	
		}
	}
}