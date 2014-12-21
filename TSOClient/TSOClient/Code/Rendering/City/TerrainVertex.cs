﻿/*This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
If a copy of the MPL was not distributed with this file, You can obtain one at
http://mozilla.org/MPL/2.0/.

The Original Code is the TSOClient.

The Initial Developer of the Original Code is
ddfczm. All Rights Reserved.

Contributor(s): ______________________________________.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TSOClient.Code.Rendering.City
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TerrainVertex
    {
        public Vector3 Position;
        public Color Color;
        public Vector2 TextureCoordinate;
        public Vector2 BlendCoordinate;
        public Vector2 BackTextureCoordinate;


        public static int SizeInBytes = (sizeof(float) * (3 + 2 + 2 + 2)) + 4;
        public static VertexElement[] VertexElements = new VertexElement[]
        {
             new VertexElement( 0, 0, VertexElementFormat.Vector3, VertexElementMethod.Default, VertexElementUsage.Position, 0 ),
             new VertexElement( 0, sizeof(float) * 3, VertexElementFormat.Color, VertexElementMethod.Default, VertexElementUsage.Color, 0 ),
             new VertexElement( 0, (sizeof(float) * 3) + 4, VertexElementFormat.Vector2, VertexElementMethod.Default, VertexElementUsage.TextureCoordinate, 0 ),
             new VertexElement( 0, (sizeof(float) * (3 + 2)) + 4, VertexElementFormat.Vector2, VertexElementMethod.Default, VertexElementUsage.TextureCoordinate, 1 ),
             new VertexElement( 0, (sizeof(float) * (3 + 2 + 2)) + 4, VertexElementFormat.Vector2, VertexElementMethod.Default, VertexElementUsage.TextureCoordinate, 2 )
        };


        public TerrainVertex(Vector3 position, Vector2 textureCoords, Color color, Vector2 blendCoords, Vector2 backTextureCoords)
        {
            this.Position = position;
            this.Color = color;
            this.TextureCoordinate = textureCoords;
            this.BlendCoordinate = blendCoords;
            this.BackTextureCoordinate = backTextureCoords;
        }
    }
}
