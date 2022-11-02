using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Resources.Scripts
{
    internal class CompositionRoot : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private int _speed;
        private void Awake()
        {
            _player.Init(100, _speed);
        }
    }
}
