using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;

namespace SimpleTerrarium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        //World GameWorld = new World();
        //Random rnd = new Random(DateTime.Now.Millisecond);
        //event EventHandler tick;

        public MainWindow()
        {
            InitializeComponent();
            SortedDictionary<int, string> a = new SortedDictionary<int, string>();
            Dictionary<int, string> b = new Dictionary<int, string>();
            a.Add(50, "Survival");
            a.Add(35, "Reproduce");
            a.Add(15, "Feed");
            a.Reverse();

            


            //a.
            //Game.World.Dimensions WorldArea = new Game.World.Dimensions(150);
            //Game.LoopWait interval = new Game.LoopWait(1000);
            //Game game = new Game(WorldArea, interval);
            //game.GameWorld.Canvas = this.WorldCanvas;
            //game.Start();

        }
    }
}


    //        //LifeDataStructure lds = new LifeDataStructure();
    //        //LifeDataStructure.AgeDataStructure AgeDataStructure = new LifeDataStructure.AgeDataStructure();
    //        //AgeDataStructure.



    //        ////testRectIntersect();
    //        //this.tick += new EventHandler(MainWindow_tick);
    //        //StartGameLoop();

    //        //PlantSpecies ps = new PlantSpecies();
            
    //    }

    ////    //private void testRectIntersect()
    ////    //{
    ////    //    Rect r1 = new Rect() { Size = new Size(10, 10), Location=new Point(0,0) };
    ////    //    Rect r2 = new Rect() { Size = new Size(10, 10), Location = new Point(5, 5) };
            
    ////    //}

    ////    void MainWindow_tick(object sender, EventArgs e)
    ////    {
    ////        Debug.WriteLine(DateTime.Now.ToShortTimeString());
    ////        Age();
    ////        Eat();
    ////        this.Dispatcher.Invoke(new Action(Reproduce));
    ////        //Reproduce();
    ////        Idle();
    ////    }

    ////    private void Idle()
    ////    {

    ////    }
        
    ////    private void IntroduceLife()
    ////    {
    ////    }
    ////    private void Eat()
    ////    {
    ////        (from World.Creature creature in GameWorld.BioSphere select creature).ToList<World.Creature>().ForEach(o => o.Life.Feed());
    ////    }

    ////    private void Age()
    ////    {
    ////        (from World.Creature creature in GameWorld.BioSphere select creature).ToList<World.Creature>().ForEach(o => o.Life.Tick());
    ////    }
    ////    private void SeedBioSphere()
    ////    {
            
    ////        //PlantSpecies_001 p001 = new PlantSpecies_001();
    ////        GameWorld.BioSphere.Add(new World.Creature(new PlantSpecies_001()));
    ////        //GameWorld.BioSphere.Add(new World.Creature(new PlantSpecies_001()));
    ////        foreach (World.Creature item in GameWorld.BioSphere)
    ////        {
    ////            this.WorldCanvas.Children.Add(item.UIRepresentation);
    ////            int x = rnd.Next();
    ////            int y = rnd.Next();
    ////            Canvas.SetTop(item.UIRepresentation, y % 300);
    ////            Canvas.SetLeft(item.UIRepresentation, x % 300);

    ////        }
    ////        //Label P = new Label() { Content = "P", FontSize = 16, Padding = new Thickness(0), Margin = new Thickness(0) };
            
            
    ////        //Label P = new Label() { Content = "P",FontSize= 16, Padding = new Thickness(0), Margin = new Thickness(0) };
    ////        //Label C = new Label() { Content = "C", FontSize = 16, Padding = new Thickness(0), Margin = new Thickness(0) };
    ////        //Label H = new Label() { Content = "H", FontSize = 16, Padding = new Thickness(0), Margin = new Thickness(0) };
    ////        ////P.Tag = Guid.NewGuid();

    ////        //Border b = new Border();
    ////        //b.Child = P;
    ////        //b.BorderBrush = new SolidColorBrush(Colors.Black);
    ////        //b.BorderThickness = new Thickness(1);
    ////        //b.Tag = Guid.NewGuid();
    ////        //b.Padding = new Thickness(0);
    ////        //b.Margin = new Thickness(0);
    ////        //this.World.Children.Add(b);

    ////    }
    ////    private void Reproduce()
    ////    {
    ////        foreach (World.Creature item in GetMatureCreatures())
    ////        {
    ////            Debug.WriteLine(item.Life.Age.Current, ToString());
    ////            int BroodCount = item.Life.Spawn((int)this.rnd.Next(item.Life.Reproduction.BroodCountMin, item.Life.Reproduction.BroodCountMax);
    ////            foreach (object o in item.Life.Spawn)
    ////            {

    ////            }

    ////            //blist.Add
    ////            //    (
    ////            //        new Border() 
    ////            //            {
    ////            //                Child = new Label() 
    ////            //                { 
    ////            //                    Content = "P", 
    ////            //                    Padding = new Thickness(0), 
    ////            //                    Margin = new Thickness(0),
    ////            //                    FontSize = 16
    ////            //                },
    ////            //                BorderThickness=new Thickness(1), 
    ////            //                BorderBrush=new SolidColorBrush(Colors.Black),
    ////            //                Padding = new Thickness(0), 
    ////            //                Margin = new Thickness(0),
    ////            //                Tag=Guid.NewGuid()

    ////            //            }
    ////            //    );
    ////        }
    ////        //foreach (Border item in blist)
    ////        //{
    ////        //    this.World.Children.Add(item);
    ////        //    int x = rnd.Next();
    ////        //    int y = rnd.Next();
    ////        //    Canvas.SetTop(item, y % 300);
    ////        //    Canvas.SetLeft(item, x % 300);

    ////        //}
    ////        //foreach (Border border in this.World.Children)
    ////        //{
    ////        //    Rect leftSidePositionRect = new Rect();
    ////        //    leftSidePositionRect.Location = new Point(Canvas.GetLeft(border), Canvas.GetTop(border));
    ////        //    leftSidePositionRect.Height = border.ActualHeight;
    ////        //    leftSidePositionRect.Width = border.ActualWidth;
    ////        //    foreach (Border otherBorder in this.World.Children)
    ////        //    {
    ////        //        if (border.Tag != otherBorder.Tag)
    ////        //        {
    ////        //            Rect rightSidePositionRect = new Rect();
    ////        //            rightSidePositionRect.Location = new Point(Canvas.GetLeft(otherBorder), Canvas.GetTop(otherBorder));
    ////        //            rightSidePositionRect.Height = otherBorder.ActualHeight;
    ////        //            rightSidePositionRect.Width = otherBorder.ActualWidth;
                        
    ////        //            if (rightSidePositionRect.IntersectsWith(leftSidePositionRect))
    ////        //            {
    ////        //                otherBorder.BorderBrush = new SolidColorBrush(Colors.Red);
    ////        //            }
    ////        //        }
    ////        //    }
    ////        //}
    ////        ////foreach (Label label in this.World.Children)
    ////        ////{
    ////        ////    //label.Foreground = new SolidColorBrush(Colors.Red);
                
    ////        ////    Rect position1 = new Rect();
    ////        ////    //Point p = new Point();

    ////        ////    position1.Location = new Point(Canvas.GetLeft(label), Canvas.GetTop(label));//label.PointToScreen(new Point(0, 0));
    ////        ////    position1.Height = label.ActualHeight;
    ////        ////    position1.Width = label.ActualWidth;
                
    ////        ////    foreach (Label labelc in this.World.Children)
    ////        ////    {
                    
    ////        ////        //labelc.Foreground = new SolidColorBrush(Colors.Red);
    ////        ////        //Thread.Sleep(1000);
    ////        ////        if (label.Tag != labelc.Tag)
    ////        ////        {
    ////        ////            Rect position2 = new Rect();
    ////        ////            position2.Location = new Point(Canvas.GetLeft(labelc),Canvas.GetTop(labelc));// .PointToScreen(new Point(0, 0));
    ////        ////            position1.Height = labelc.ActualHeight;
    ////        ////            position1.Width = labelc.ActualWidth;
    ////        ////            if (position2.IntersectsWith(position1))
    ////        ////            {
    ////        ////                labelc.Foreground = new SolidColorBrush(Colors.Red);
    ////        ////            }
    ////        ////        }
    ////        ////        //    //position2.Location = labelc.PointToScreen(new Point(0, 0));
    ////        ////        //    position2.Height = labelc.ActualHeight;
    ////        ////        //    position2.Width = labelc.ActualWidth;
    ////        ////        //    if (position1.IntersectsWith(position2))
    ////        ////        //    {
    ////        ////        //        label.Foreground = new SolidColorBrush(Colors.Red);
    ////        ////        //        //labelc.Foreground = new SolidColorBrush(Colors.Purple);
    ////        ////        //        continue;
    ////        ////        //    }
    ////        ////        //    else
    ////        ////        //    {
    ////        ////        //        label.Foreground = new SolidColorBrush(Colors.Green);
    ////        ////        //    }
    ////        ////        //}
    ////        ////        //label.Foreground = new SolidColorBrush(Colors.Black);
    ////        ////        //labelc.Foreground = new SolidColorBrush(Colors.Black);
    ////        ////    }
                


                
    ////        ////}

            
    ////    }

    ////    private List<World.Creature> GetMatureCreatures()
    ////    {
    ////        return (from World.Creature creature in GameWorld.BioSphere where creature.Life.Age.Current == creature.Life.Age.Maturity select creature).ToList<World.Creature>();
    ////    }



    ////    private void StartGameLoop()
    ////    {
    ////        SeedBioSphere();
    ////        StartClock();


    ////    }



    ////    private void StartClock()
    ////    {
    ////        Thread t = new Thread(new ThreadStart(timmer));
    ////        t.Start();
    ////    }
    ////    private void timmer()
    ////    {
    ////        for(int x = 0; x<600;x++)
    ////        {
    ////            Thread.Sleep(1000);
    ////            if (x % 5 == 0)
    ////            {
    ////                tick(null, null);
    ////            }
    ////            //Console.WriteLine(this.World.Children.Count.ToString());
    ////        }
            
    ////    }

////    }
////}
