using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations
{
	public class HattereneParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private HATParentDad_SittingTo HattereneSittingto;
		
		private HATParentDad_WalkingTo HattereneWalkingto;
		
		private HATParentDad_IdleTo HattereneIdleto;

		public void HATParentDad_ConverterAnimatorController()
		{
			HattereneWalkingto.HATParentDad_WalkingToController();

			HattereneIdleto.HATParentDad_IdleToController();
			
			HattereneSittingto.HATParentDad_SittingToController();	
		}
	}
}