﻿//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using osu.Framework.Input;

namespace osu.Framework.Graphics.Containers
{
    public class ClickableContainer : Container
    {
        public event Action Click;

        protected override bool OnClick(InputState state)
        {
            Click?.Invoke();
            return true;
        }
    }
}
