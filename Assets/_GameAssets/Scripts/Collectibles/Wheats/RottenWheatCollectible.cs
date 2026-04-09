using UnityEngine;
using UnityEngine.UI;

public class RottenWheatCollectible : MonoBehaviour, ICollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private PlayerStateUI _PlayerStateUI;
    
    private RectTransform _playerBoosterTransform;
    private Image _playerBoosterImage;
    
    private void Awake()
    {
        _playerBoosterTransform = _PlayerStateUI.GetBoosterSlowTransform;
        _playerBoosterImage = _playerBoosterTransform.GetComponent<Image>();
    }
    

    public void Collect()
    {
        _playerController.SetJumpForce(_wheatDesignSO.IncreaseDecreaseMultiplier, _wheatDesignSO.ResetBoostDuration);
        
        _PlayerStateUI.PlayBoosterUIAnimations(_playerBoosterTransform, _playerBoosterImage, _PlayerStateUI.GetRottenBoosterWheatImage, _wheatDesignSO.ActiveSprite, 
            _wheatDesignSO.PassiveSprite, _wheatDesignSO.ActiveWheatSprite, _wheatDesignSO.PassiveWheatSprite, _wheatDesignSO.ResetBoostDuration);

        
        Destroy(gameObject);
    }
}