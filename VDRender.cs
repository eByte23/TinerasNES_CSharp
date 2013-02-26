using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TinerasNES
{
    public class VDRender
    {
        TinerasNES tinerasNES;
        VisualDebugger vdb;
        SpriteBatch spriteBatch;
        
        Texture2D textureScreenBuffer0;
        Texture2D textureScreenBuffer1;
        Texture2D textureScreenBuffer2;
        Texture2D textureScreenBuffer3;

        public PresentationParameters pp;

        // Setup background color to use with Alpha
        Microsoft.Xna.Framework.Graphics.Color colorBG;

        // Setup the Graphics device
        public Microsoft.Xna.Framework.Graphics.GraphicsDevice device;

        public void InitializeGame()
        {
            // Create Panel So the Game can be rendered on it.
            createGamePanel();

            setPresentationParameters();

            // Create the new graphics device
            device = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, DeviceType.Hardware, vdb.Handle, pp);

            // Create new spritebatch to handle the texture2d
            spriteBatch = new SpriteBatch(device);

            // Create new screen buffer texture
            textureScreenBuffer0 = new Texture2D(device, 256, 240);
            textureScreenBuffer1 = new Texture2D(device, 256, 240);
            textureScreenBuffer2 = new Texture2D(device, 256, 240);
            textureScreenBuffer3 = new Texture2D(device, 256, 240);

            // Set the initial background color
            colorBG = Microsoft.Xna.Framework.Graphics.Color.DarkMagenta;
        }

        public void createGamePanel()
        {
            // Create Panel So the Game can be rendered on it.
            vdb.pnlNT2000 = new Panel();
            vdb.pnlNT2000.Location = new System.Drawing.Point(0, 0);
            vdb.pnlNT2000.Size = new Size(256 * 2, 240 * 2);
            vdb.pnlNT2000.BackColor = System.Drawing.Color.SteelBlue;
            vdb.Controls.Add(vdb.pnlNT2000);

            // Create Panel So the Game can be rendered on it.
            vdb.pnlNT2400 = new Panel();
            vdb.pnlNT2400.Location = new System.Drawing.Point(256, 0);
            vdb.pnlNT2400.Size = new Size(256, 240);
            vdb.pnlNT2400.BackColor = System.Drawing.Color.SlateGray;
            vdb.Controls.Add(vdb.pnlNT2400);

            // Create Panel So the Game can be rendered on it.
            vdb.pnlNT2800 = new Panel();
            vdb.pnlNT2800.Location = new System.Drawing.Point(0, 240);
            vdb.pnlNT2800.Size = new Size(256, 240);
            vdb.pnlNT2800.BackColor = System.Drawing.Color.SlateGray;
            vdb.Controls.Add(vdb.pnlNT2800);

            // Create Panel So the Game can be rendered on it.
            vdb.pnlNT2C00 = new Panel();
            vdb.pnlNT2C00.Location = new System.Drawing.Point(256, 240);
            vdb.pnlNT2C00.Size = new Size(256, 240);
            vdb.pnlNT2C00.BackColor = System.Drawing.Color.SteelBlue;
            vdb.Controls.Add(vdb.pnlNT2C00);
        }

        public void setPresentationParameters()
        {
            pp = new PresentationParameters();
            pp.BackBufferCount = 1;
            pp.BackBufferFormat = SurfaceFormat.Unknown;
            pp.BackBufferHeight = vdb.pnlNT2000.Height * 2;
            pp.BackBufferWidth = vdb.pnlNT2000.Width * 2;
            pp.DeviceWindowHandle = vdb.pnlNT2000.Handle;
            // pp.IsFullScreen = false;  // This is broken
            pp.SwapEffect = SwapEffect.Discard;
            pp.PresentationInterval = PresentInterval.Default;
        }

        public void Render(Microsoft.Xna.Framework.Graphics.Color XColor)
        {
            //myTexture = Texture2D.FromFile(device, fullPath);
            //textureScreenBuffer.GenerateMipMaps(TextureFilter.Point);

            //device.Clear(Microsoft.Xna.Framework.Graphics.Color.CornflowerBlue);
            device.Clear(XColor);

            // FOR BLOCKY PIXELS, USE THIS CODE
            spriteBatch.Begin(SpriteBlendMode.AlphaBlend, SpriteSortMode.Immediate, SaveStateMode.None);
            device.SamplerStates[0].MagFilter = TextureFilter.Point;

            // FOR ANTI-ALIASED PIXELS, USE THIS CODE
            //spriteBatch.Begin();

            spriteBatch.Draw(textureScreenBuffer0, new Microsoft.Xna.Framework.Rectangle(0, 0, vdb.pnlNT2000.Width, vdb.pnlNT2000.Height), Microsoft.Xna.Framework.Graphics.Color.White);
            spriteBatch.Draw(textureScreenBuffer1, new Microsoft.Xna.Framework.Rectangle(512, 0, vdb.pnlNT2000.Width, vdb.pnlNT2000.Height), Microsoft.Xna.Framework.Graphics.Color.White);
            spriteBatch.Draw(textureScreenBuffer2, new Microsoft.Xna.Framework.Rectangle(0, 480, vdb.pnlNT2000.Width, vdb.pnlNT2000.Height), Microsoft.Xna.Framework.Graphics.Color.White);
            spriteBatch.Draw(textureScreenBuffer3, new Microsoft.Xna.Framework.Rectangle(512, 480, vdb.pnlNT2000.Width, vdb.pnlNT2000.Height), Microsoft.Xna.Framework.Graphics.Color.White);

            spriteBatch.End();

            //base.Update();
            device.Present();
        }

        //public void 

        public void WriteBitmap(byte[] byteToWrite0, byte[] byteToWrite1, byte[] byteToWrite2, byte[] byteToWrite3, Microsoft.Xna.Framework.Graphics.Color XColor)
        {
            device.Textures[0] = null;
            textureScreenBuffer0.SetData<byte>(byteToWrite0);
            textureScreenBuffer1.SetData<byte>(byteToWrite1);
            textureScreenBuffer2.SetData<byte>(byteToWrite2);
            textureScreenBuffer3.SetData<byte>(byteToWrite3);
            Render(XColor);
        }

        public VDRender(TinerasNES tinerasNESRef, VisualDebugger vdRef)
        {
            tinerasNES = tinerasNESRef;
            vdb = vdRef;
            InitializeGame();
        }
    }
}
