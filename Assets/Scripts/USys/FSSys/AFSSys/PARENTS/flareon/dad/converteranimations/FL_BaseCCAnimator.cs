using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.WalkingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations
{
	public class FlareonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private FLParentDadDad_IdleTo FlareonParentDadIdleto;
		
		private FLParentDadDad_WalkingTo FlareonParentDadWalkingto;

		private FLParentDadDad_SittingTo FlareonParentDadSittingto;
		public void FLParentDadDad_ConverterAnimatorController()
		{
			FlareonParentDadWalkingto.FLParentDadDad_WalkingToController();

			FlareonParentDadIdleto.FLParentDadDad_IdleToController();
			
			FlareonParentDadSittingto.FLParentDadDad_SittingToController();
		}
	}
}