using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations
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