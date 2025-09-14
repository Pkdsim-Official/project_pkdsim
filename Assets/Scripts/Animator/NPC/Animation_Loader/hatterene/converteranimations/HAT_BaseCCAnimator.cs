using project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations
{
	public class HattereneCoverterAnimatorController : MonoBehaviour 
	{
		private HAT_SittingTo HattereneSittingto;
		
		private HAT_WalkingTo HattereneWalkingto;
		
		private HAT_IdleTo HattereneIdleto;

		public void HATCoverterToAnimatorController()
		{
			HattereneWalkingto.HAT_WalkingToController();

			HattereneIdleto.HAT_IdleToController();
			
			HattereneSittingto.HAT_SittingToController();	
		}
	}
}