using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations
{
	public class ZoroarkParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private ZParentDad_SittingTo ZoroarkSittingto;
		
		private ZParentDad_WalkingTo ZoroarkWalkingto;
		
		private ZParentDad_IdleTo ZoroarkIdleto;

		public void ZParentDad_ConverterAnimatorController()
		{
			ZoroarkWalkingto.ZParentDad_WalkingToController();

			ZoroarkIdleto.ZParentDad_IdleToController();
			
			ZoroarkSittingto.ZParentDad_SittingToController();	
		}
	}
}