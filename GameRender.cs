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
    public class GameRender
    {
        TinerasNES tinerasNES;
        SpriteBatch spriteBatch;
        Texture2D textureScreenBuffer;
        public PresentationParameters pp;

        // Setup background color to use with Alpha
        Microsoft.Xna.Framework.Graphics.Color colorBG;

        // Setup the Graphics device
        public Microsoft.Xna.Framework.Graphics.GraphicsDevice device;
        
        public void InitializeGame()
        {
            // Create Panel So the Game can be rendered on it.
            createGamePanel();

            // Set the presentation parameters of the graphics device
            setPresentationParameters();
            
            // Create the new graphics device
            device = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, DeviceType.Hardware, tinerasNES.pnlGame.Handle, pp);

            // Create new spritebatch to handle the texture2d
            spriteBatch = new SpriteBatch(device);

            // Create new screen buffer texture
            textureScreenBuffer = new Texture2D(device, 256, 240);

            // Set the initial background color
            colorBG = Microsoft.Xna.Framework.Graphics.Color.DarkMagenta;
        }

        public void createGamePanel()
        { 
            // Create Panel So the Game can be rendered on it.
            tinerasNES.pnlGame = new Panel();
            
            tinerasNES.pnlGame.Location = new System.Drawing.Point(0, tinerasNES.MainMenuStrip.Height);
            tinerasNES.pnlGame.Size = new Size(256 * 2, 240 * 2);
            tinerasNES.pnlGame.BackColor = System.Drawing.Color.SteelBlue;
            tinerasNES.Controls.Add(tinerasNES.pnlGame);
        }

        public void setPresentationParameters()
        {
            pp = new PresentationParameters();
            pp.BackBufferCount = 1;
            pp.BackBufferFormat = SurfaceFormat.Unknown;
            pp.BackBufferHeight = tinerasNES.pnlGame.Height;
            pp.BackBufferWidth = tinerasNES.pnlGame.Width;
            pp.DeviceWindowHandle = tinerasNES.pnlGame.Handle;
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
            // ***
            spriteBatch.Begin(SpriteBlendMode.AlphaBlend, SpriteSortMode.Immediate, SaveStateMode.None);
            device.SamplerStates[0].MagFilter = TextureFilter.Point;
            // ***

            // FOR ANTI-ALIASED PIXELS, USE THIS CODE
            // ***
            //spriteBatch.Begin();
            // ***

            spriteBatch.Draw(textureScreenBuffer, new Microsoft.Xna.Framework.Rectangle(0, 0, tinerasNES.pnlGame.Width, tinerasNES.pnlGame.Height), Microsoft.Xna.Framework.Graphics.Color.White);
            spriteBatch.End();
            device.Present();
        }

        public void WriteBitmap(byte[] byteToWrite, Microsoft.Xna.Framework.Graphics.Color XColor)
        {
            device.Textures[0] = null;
            textureScreenBuffer.SetData<byte>(byteToWrite);
            Render(XColor);
        }

        public GameRender(TinerasNES formObject)
        {
            tinerasNES = formObject;
            InitializeGame();
        }
    }
}
