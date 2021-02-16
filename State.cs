using System;
using UnityEngine;

namespace app.state
{
    public class State : IDisposable
    {
        public virtual void Start()
        {
        }

        public virtual void Dispose()
        {
        }
    }
}