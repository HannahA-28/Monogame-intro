using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_intro
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D tigerTexture, elephantTexture, monkeyTexture, pigTexture, turtleTexture, cowTexture, natureTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

            this.Window.Title = "Graphics Demo";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            tigerTexture = Content.Load<Texture2D>("tiger");
            elephantTexture = Content.Load<Texture2D>("elephant");
            monkeyTexture = Content.Load<Texture2D>("monkey");
            pigTexture = Content.Load<Texture2D>("pig");
            turtleTexture = Content.Load<Texture2D>("turtle");
            cowTexture = Content.Load<Texture2D>("cow");
            natureTexture = Content.Load<Texture2D>("nature");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightPink);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(natureTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(tigerTexture, new Vector2(400, 300), Color.White);
            _spriteBatch.Draw(elephantTexture, new Vector2(600, 150), Color.White);
            _spriteBatch.Draw(monkeyTexture, new Vector2(175, 50), Color.White);
            _spriteBatch.Draw(pigTexture, new Vector2(150, 500), Color.White);
            _spriteBatch.Draw(turtleTexture, new Vector2(500, 500), Color.White);
            _spriteBatch.Draw(cowTexture, new Vector2(125, 360), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
