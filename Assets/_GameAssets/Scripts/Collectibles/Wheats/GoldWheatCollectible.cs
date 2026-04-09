using System;
using UnityEngine;
using UnityEngine.UI;

public class GoldWheatCollectible : MonoBehaviour, ICollectible
{
   [SerializeField] private WheatDesignSO _wheatDesignSO;
   [SerializeField] private PlayerController _playerController;
   [SerializeField] private PlayerStateUI _PlayerStateUI;
   
   private RectTransform _playerBoosterTransform;
   private Image _playerBoosterImage;
   private void Awake()
   {
      _playerBoosterTransform = _PlayerStateUI.GetPlayerSpeedTransform;
      _playerBoosterImage = _playerBoosterTransform.GetComponent<Image>();
   }

   public void Collect()
   {
      _playerController.SetMovementSpeed(_wheatDesignSO.IncreaseDecreaseMultiplier, _wheatDesignSO.ResetBoostDuration);
      
      _PlayerStateUI.PlayBoosterUIAnimations(_playerBoosterTransform, _playerBoosterImage, _PlayerStateUI.GetGoldBoosterWheatImage, _wheatDesignSO.ActiveSprite, 
         _wheatDesignSO.PassiveSprite, _wheatDesignSO.ActiveWheatSprite, _wheatDesignSO.PassiveWheatSprite, _wheatDesignSO.ResetBoostDuration);

      Destroy(gameObject);
   }
}
