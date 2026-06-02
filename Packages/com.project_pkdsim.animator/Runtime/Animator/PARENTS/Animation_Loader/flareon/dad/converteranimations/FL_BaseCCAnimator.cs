using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations.IdleTo;

using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations
{
	public class FlareonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private FLParentDad_IdleTo FlareonParentDad_idleto;
		
		private FLParentDad_WalkingTo FlareonParentDad_walkingto;

		private FLParentDad_SittingTo FlareonParentDad_sittingto;
		public void FLParentDad_ConverterAnimatorController()
		{
			FlareonParentDad_walkingto.FLParentDad_WalkingToController();

			FlareonParentDad_idleto.FLParentDad_IdleToController();
			
			FlareonParentDad_sittingto.FLParentDad_SittingToController();
		}
	}
}