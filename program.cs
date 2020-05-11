using System;

namespace Program
{
    abstract class Painting
    {
        public void mySecretMessage()
        {
            Console.WriteLine("This is my secret message!");
        }
        public virtual void options()
        {
            Console.WriteLine("[Insert Painting options]");
        }
        public string groupName = "Painting";

    }

    class Name : Painting
    {
        private string PaintName;
        public string MyPaintName
        {
            get
            {
                return PaintName;
            }
            set
            {
                PaintName = value;
            }
        }
        public override void options()
        {
            Console.WriteLine("Mona Lisa");
        }
    }
    class Artist : Painting
    {


        private string PaintArtist;
        public string MyPaintArtist
        {
            get
            {
                return PaintArtist;
            }
            set
            {
                PaintArtist = value;
            }
        }
        public void myPublicMessage()
        {
            Console.WriteLine("Everyone can see this message!");
        }
        public override void options()
        {
            Console.WriteLine("Leonardo da Vinci");
        }
    }
    class Medium : Painting
    {
        private string PaintMedium;
        public string MyPaintMedium
        {
            get
            {
                return PaintMedium;
            }
            set
            {
                PaintMedium = value;
            }
        }
        public override void options()
        {
            Console.WriteLine("Medium");
        }
    }
    class Year : Painting
    {
        private string PaintYear;
        public string MyPaintYear
        {
            get
            {
                return PaintYear;
            }
            set
            {
                PaintYear = value;
            }
        }
        public override void options()
        {
            Console.WriteLine("1517");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Name Name = new Name();
            Artist Artist = new Artist();
            Medium Medium = new Medium();
            Year Year = new Year();

            Painting Yearoptions= new Year();
           Painting Mediumoptions= new Medium();
           Painting Artistoptions= new Artist();
           Painting Nameoptions= new Name();
           

            Artist.myPublicMessage();
            Artist.mySecretMessage();


            Nameoptions.options();
            Artistoptions.options();
            Mediumoptions.options();
            Yearoptions.options();
            
            Name.MyPaintName = "jsmith";
            Artist.MyPaintArtist = "painter";
            Medium.MyPaintMedium = "anything";
            Year.MyPaintYear = "32";
            Console.WriteLine(Name.MyPaintName + " is a member of " + Name.groupName);
            Console.WriteLine(Artist.MyPaintArtist + " is my Artist in " + Name.groupName);

        }
    }
}



