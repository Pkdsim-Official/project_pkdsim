using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations
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