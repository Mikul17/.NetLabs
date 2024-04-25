namespace Lab4GUI
{
    public partial class Form1 : Form
    {
        private ImageManager ImageManager;
        private Bitmap? img;

        public Form1()
        {
            this.ImageManager = new ImageManager();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imageLoader.ShowDialog();
            string file = "";
            file = imageLoader.FileName;
  
            
            if (file != "")
            {
                img = new Bitmap(file);
                origial.Image = Image.FromFile(file);
                transformImagesButton.Enabled = true;
            }
            else
            {
                Console.WriteLine("No file chosen");
            }
        }
        
        
        private void transformImagesButton_Click(object sender, EventArgs e)
        {
            var negativeImage = new Bitmap(img);
            var mirrorImage = new Bitmap(img);
            var grayscaleImage = new Bitmap(img);
            var redToBlueImage = new Bitmap(img);
            
            Parallel.Invoke(
                () => 
                {
                    negativeImage = ImageManager.Negative(negativeImage);
                    Console.WriteLine($"Thread {Task.CurrentId} | Finished processing image negative");
                },
                () => 
                {
                    mirrorImage = ImageManager.Mirror(mirrorImage);
                    Console.WriteLine($"Thread {Task.CurrentId} | Finished processing image mirror");
                },
                () => 
                {
                    grayscaleImage = ImageManager.GrayScale(grayscaleImage);
                    Console.WriteLine($"Thread {Task.CurrentId} | Finished processing image grayscale");
                },
                () => 
                {
                    redToBlueImage = ImageManager.RedToBlue(redToBlueImage);
                    Console.WriteLine($"Thread {Task.CurrentId} | Finished processing image redToBlue");
                }
            );

            Invoke(() =>
            {
                negativeBox.Image = negativeImage;
                mirrorBox.Image = mirrorImage;
                grayScaleBox.Image = grayscaleImage;
                redToBlueBox.Image = redToBlueImage;
            });
        }
    }
}
