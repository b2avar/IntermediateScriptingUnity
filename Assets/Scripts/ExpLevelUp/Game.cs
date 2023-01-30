using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace IntermediateScripting
{
    public class Game : MonoBehaviour
    {
        public Button expButton;
        public TextMeshProUGUI levelText;
        public Slider expSlider;
        Player _player = new Player();

        private int _level;
        private void Start()
        {
            _level = 0;
            levelText.text = "Level : " + _level;
        }

        private void Update()
        {
            UpdateLevel();
        }

        public void UpdateLevel()
        {
            levelText.text = "Level : " + _level.ToString();
        }

        public void SliderUpdate()
        {
            expSlider.value = _player.Experience;
            if (_player.Experience >= 1000)
            {
                _level += _player.Level;
                _player.Experience -= 1000;
                expSlider.value = _player.Experience;
            }
        }

        public void InceaseExp()
        {
            _player.Experience += Random.Range(0, 101);
            Debug.Log("Experience :" + _player.Experience);
            UpdateLevel();
            SliderUpdate();
        }
    }
}
