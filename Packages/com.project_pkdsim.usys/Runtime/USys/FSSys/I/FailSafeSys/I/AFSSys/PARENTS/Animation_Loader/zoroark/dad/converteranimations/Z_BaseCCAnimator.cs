using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations
{
	public class ZoroarkParentDad_ConverterToAnimatorController : MonoBehaviour 
	{
		private ZParentDad_SittingTo ZoroarkSittingto;
		
		private ZParentDad_WalkingTo ZoroarkWalkingto;
		
		private ZParentDad_IdleTo ZoroarkIdleto;

		public void ZParentDad_ConverterToAnimatorController()
		{
			ZoroarkWalkingto.ZParentDad_WalkingToController();

			ZoroarkIdleto.ZParentDad_IdleToController();
			
			ZoroarkSittingto.ZParentDad_SittingToController();	
		}
	}
}