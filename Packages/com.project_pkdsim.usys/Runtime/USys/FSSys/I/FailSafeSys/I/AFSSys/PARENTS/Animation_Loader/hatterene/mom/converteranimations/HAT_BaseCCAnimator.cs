using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.converteranimations
{
	public class HattereneParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private HATParentMom_SittingTo HattereneSittingto;
		
		private HATParentMom_WalkingTo HattereneWalkingto;
		
		private HATParentMom_IdleTo HattereneIdleto;

		public void HATParentMom_ConverterAnimatorController()
		{
			HattereneWalkingto.HATParentMom_WalkingToController();

			HattereneIdleto.HATParentMom_IdleToController();
			
			HattereneSittingto.HATParentMom_SittingToController();	
		}
	}
}