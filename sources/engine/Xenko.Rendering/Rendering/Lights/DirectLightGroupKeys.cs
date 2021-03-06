// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System;

namespace Xenko.Rendering.Lights
{
    public static partial class DirectLightGroupKeys
    {
        public static ParameterKey<T> GetParameterKey<T>(ParameterKey<T> key, int lightGroupIndex)
        {
            if (key == null) throw new ArgumentNullException("key");
            return key.ComposeIndexer("directLightGroups", lightGroupIndex);
        }
    }
}
