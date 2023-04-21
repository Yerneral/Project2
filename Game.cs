using проект2.Scenes;

namespace проект2
{
    class Game
    {
        //January February March April May June July August September October November December
        public JanuarScene MyJanuaryScene;
        public ExitScene Scene;
        public TitleScene MyTitleScene;
        public NavigationScene MyNavigationScene;
        public FebruaryScene MyFebruaryScene;
        public MarchScene MyMarchScene;
        public AprilScene MyAprilScene;
        public MayScene MyMayScene;
        public JuneScene MyJuneScene;
        public JuleScene MyJuleScene;
        public AugustScene MyAugustScene;
        public SeptemberScene MySeptemberScene;
        public OctoberScene MyOctoberScene;
        public NovemberScene MyNovemberScene;
        public DecemberScene MyDecemberScene;

        public ExitScene MyExitScene { get; }

        public Game()
        {
            MyJanuaryScene = new JanuarScene(this);
            MyFebruaryScene = new FebruaryScene(this);
            MyMarchScene = new MarchScene(this);
            MyAprilScene = new AprilScene(this);
            MyMayScene = new MayScene(this);
            MyJuneScene = new JuneScene(this);
            MyJuleScene = new JuleScene(this);
            MyAugustScene = new AugustScene(this);
            MySeptemberScene = new SeptemberScene(this);
            MyOctoberScene = new OctoberScene(this);
            MyNovemberScene = new NovemberScene(this);
            MyDecemberScene = new DecemberScene(this);





            MyTitleScene = new TitleScene(this);

            MyNavigationScene = new NavigationScene(this);
            MyExitScene = new ExitScene(this);

        }
        public void Start()
        {
            MyTitleScene.Run();

            // ConsoleUtils.WaitForKeyPress();
        }
    }
}
