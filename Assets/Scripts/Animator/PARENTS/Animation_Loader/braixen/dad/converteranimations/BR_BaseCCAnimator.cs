using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations
{
	public class BraixenParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private BRParentDad_SittingTo BraixenParentDadSittingto;
		
		private BRParentDad_WalkingTo BraixenParentDadWalkingto;
		
		private BRParentDad_IdleTo BraixenParentDadIdleto;

		public void BRConverterAnimatorController()
		{
			BraixenParentDadWalkingto.BRParentDad_WalkingToController();

			BraixenParentDadIdleto.BRParentDad_IdleToController();
			
			BraixenParentDadSittingto.BRParentDad_SittingToController();	
		}
	}
}