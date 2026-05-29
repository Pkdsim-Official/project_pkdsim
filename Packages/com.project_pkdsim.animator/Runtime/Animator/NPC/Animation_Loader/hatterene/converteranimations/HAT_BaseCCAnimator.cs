using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations
{
	public class Hatterene_ConverterToAnimatorController : MonoBehaviour 
	{
		private HAT_SittingTo HattereneSittingto;
		
		private HAT_WalkingTo HattereneWalkingto;
		
		private HAT_IdleTo HattereneIdleto;

		public void HAT_ConverterToAnimatorController()
		{
			HattereneWalkingto.HAT_WalkingToController();

			HattereneIdleto.HAT_IdleToController();
			
			HattereneSittingto.HAT_SittingToController();	
		}
	}
}