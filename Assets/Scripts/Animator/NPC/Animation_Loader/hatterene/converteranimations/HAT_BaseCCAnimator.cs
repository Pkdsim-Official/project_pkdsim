using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations
{
	public class HattereneCoverterAnimatorController : MonoBehaviour 
	{
		private HATSittingTo HattereneSittingto;
		
		private HATWalkingTo HattereneWalkingto;
		
		private HATIdleTo HattereneIdleto;

		public void HATCoverterToAnimatorController()
		{
			HattereneWalkingto.HATWalkingToController();

			HattereneIdleto.HAT_IdleToController();
			
			HattereneSittingto.HATSittingToController();	
		}
	}
}