using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.WalkingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.converteranimations
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