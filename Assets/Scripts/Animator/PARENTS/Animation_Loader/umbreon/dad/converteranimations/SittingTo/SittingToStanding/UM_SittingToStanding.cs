using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo.SittingToStanding
{
	public class UMParentDad_SittingToStanding : MonoBehaviour
	{
		private Animator UmbreonParentDad_Animator;
		public void UMParentDad_SittingToStandingController() 
		{
			UmbreonParentDad_Animator.SetFloat("Speed", 0f);
			UmbreonParentDad_Animator.Play("SittingTo_StartWalking");
		}
	}
}