using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.converteranimations
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