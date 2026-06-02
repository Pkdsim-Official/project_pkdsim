using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations
{
	public class Hatterene_ConverterAnimatorController : MonoBehaviour 
	{
		private HAT_SittingTo HattereneSittingto;
		
		private HAT_WalkingTo HattereneWalkingto;
		
		private HAT_IdleTo HattereneIdleto;

		public void HAT_ConverterAnimatorController()
		{
			HattereneWalkingto.HAT_WalkingToController();

			HattereneIdleto.HAT_IdleToController();
			
			HattereneSittingto.HAT_SittingToController();	
		}
	}
}