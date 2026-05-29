using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations
{
	public class Hatterene_ConverterToAnimatorController : MonoBehaviour 
	{
		private HATSittingTo HattereneSittingto;
		
		private HATWalkingTo HattereneWalkingto;
		
		private HATIdleTo HattereneIdleto;

		public void HAT_ConverterToAnimatorController()
		{
			HattereneWalkingto.HATWalkingToController();

			HattereneIdleto.HAT_IdleToController();
			
			HattereneSittingto.HATSittingToController();	
		}
	}
}