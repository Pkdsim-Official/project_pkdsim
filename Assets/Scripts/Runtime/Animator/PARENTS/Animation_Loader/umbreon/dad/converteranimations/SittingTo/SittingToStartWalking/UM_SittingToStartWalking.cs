using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo.SittingToStartWalking
{
	public class UMParentDad_SittingToStartWalking : MonoBehaviour
	{
		private Animator UmbreonParentDad_Animator;
		public void UMParentDad_SittingToStartWalkingController()
		{
			UmbreonParentDad_Animator.SetFloat("Speed", 0f);
			UmbreonParentDad_Animator.Play("SittingTo_StartWalking");
        }
	}
}